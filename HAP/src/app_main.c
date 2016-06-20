#include "app_main.h"
#include "uib_app_manager.h"
#include "uib_view1_view.h"
#include "helloaccessory.h"
#include "tts_app.h"
#include "uib_app_manager.h"
#include "uib_view1_view.h"
#include <stdlib.h>
#include <app_alarm.h>
#include <time.h>
#include <Elementary.h>
#include <pthread.h>
static void _popup_hide_cb(void *data, Evas_Object *obj, void *event_info) {
	if (!obj)
		return;
	elm_popup_dismiss(obj);
}
static void _timeout_cb(void *data, Evas_Object *obj, void *event_info) {
	if (!obj)
		return;
	elm_popup_dismiss(obj);
}
static void _popup_hide_finished_cb(void *data, Evas_Object *obj,
		void *event_info) {
	if (!obj)
		return;
	evas_object_del(obj);
}
static void _block_clicked_cb(void *data, Evas_Object *obj, void *event_info) {
	if (!obj)
		return;
	elm_popup_dismiss(obj);
}
static void _popup_toast_cb(Evas_Object *parent, char *string);

/* app event callbacks */
static bool _on_create_cb(void *user_data);
static void _on_terminate_cb(void *user_data);
static void _on_app_control_cb(app_control_h app_control, void *user_data);
static void _on_resume_cb(void *user_data);
static void _on_pause_cb(void *user_data);
static void _on_low_memory_cb(app_event_info_h event_info, void *user_data);
static void _on_low_battery_cb(app_event_info_h event_info, void *user_data);
static void _on_device_orientation_cb(app_event_info_h event_info,
		void *user_data);
static void _on_language_changed_cb(app_event_info_h event_info,
		void *user_data);
static void _on_region_format_changed_cb(app_event_info_h event_info,
		void *user_data);
static void record_start(void *data, Evas_Object *obj, void *event_info);
static void setting_start(void *data, Evas_Object *obj, void *event_info);
static bool _recorder_is_recording(app_data *ad) {
	recorder_state_e state = RECORDER_STATE_NONE;
	recorder_get_state(ad->recorder, &state);
	return state == RECORDER_STATE_RECORDING;
}
static void _end_func(void *data, Ecore_Thread *thread) {
//	app_data *ad = data;
//	elm_object_text_set(ad->label, "Ticks over");
}
static void _record_stop(void *data, Evas_Object *obj, void *event_info) {
	app_data *ad = data;
	/*
	 if (ad->recorder) {
	 recorder_commit(ad->recorder);

	 // Check is recording
	 if (!_recorder_is_recording(ad)) {
	 recorder_unprepare(ad->recorder);
	 }
	 elm_object_disabled_set(ad->btn_rec, EINA_FALSE);
	 elm_object_disabled_set(ad->btn_recstop, EINA_TRUE);
	 }
	 _end_func(NULL, NULL);
	 */
}
static void _on_recording_limit_reached_cb(recorder_recording_limit_type_e type,
		void *user_data) {
	app_data *ad = user_data;
	if (type == RECORDER_RECORDING_LIMIT_TIME) // Stop recording
		_record_stop(ad, NULL, NULL);
}
static void recorder_create(app_data *ad) {
	if (recorder_create_audiorecorder(&ad->recorder) == RECORDER_ERROR_NONE) {
		recorder_set_recording_limit_reached_cb(ad->recorder,
				_on_recording_limit_reached_cb, ad);
		recorder_attr_set_audio_channel(ad->recorder, 1);
		recorder_attr_set_audio_device(ad->recorder, RECORDER_AUDIO_DEVICE_MIC);
		//recorder_attr_set_time_limit(ad->recorder, 5);
	}
}
static bool _recorder_supported_audio_encoder_cb(recorder_audio_codec_e codec,
		void *user_data) {
	bool result = false;
	supported_encoder_data *data = user_data;
	if (data && codec != RECORDER_AUDIO_CODEC_DISABLE) {
		data->codec_list = realloc(data->codec_list,
				sizeof(supported_encoder_data) * (data->len + 1));
		data->codec_list[data->len] = codec;
		++(data->len);
		result = true;
	}
	return result;
}
static void _set_label_text(void *data, Ecore_Thread *thread, void *msgdata) {

	char buf[64];
	app_data *ad = data;
	snprintf(buf, sizeof(buf), "Tick %d", (int) (uintptr_t) msgdata);
	elm_object_text_set(ad->label, buf);
	//elm_object_text_set(point->label1, buf);
}
static void _Check_DB(void *data, Ecore_Thread *thread) {
	int iteration;
	int res = 0;
	double dB = 0;
	int error;
	app_data *ad = data;
	dlog_print(DLOG_INFO, "aa", "chk = %s", elm_object_text_get(view1->On));
	if (strcmp(elm_object_text_get(view1->On), "Off")==0) {
		for (iteration = 0;; iteration++) {
			sleep(1);
			dlog_print(DLOG_INFO, "aa", "res = %d", res);
			res = recorder_get_audio_level(ad->recorder, &dB);

			dlog_print(DLOG_INFO, "aa", "res = %d", res);

			if (dB > -25 && dB <= 0) {
				dlog_print(DLOG_INFO, "aa", "db hi = %lf", dB);
				error = device_haptic_vibrate(ad->handle, 3000, 100,
						&ad->effect_handle);
				update_ui("주의 하세요!");
				sleep(3);
				if (error == DEVICE_ERROR_NONE)
					dlog_print(DLOG_INFO, "aa", "db hi = %d", error);
				if (error == DEVICE_ERROR_INVALID_PARAMETER)
					dlog_print(DLOG_INFO, "aa", "invalid para", error);
				if (error == DEVICE_ERROR_PERMISSION_DENIED)
					dlog_print(DLOG_INFO, "aa", "permi de", error);
				if (error == DEVICE_ERROR_OPERATION_FAILED)
					dlog_print(DLOG_INFO, "aa", "op fa", error);
				if (error == DEVICE_ERROR_NOT_SUPPORTED)
					dlog_print(DLOG_INFO, "aa", "not support", error);
			} else {
				dlog_print(DLOG_INFO, "aa", "db hi = %d", error);
			}

		}
		ecore_thread_feedback(thread, (void*) (uintptr_t) iteration);
	}
}
recorder_audio_codec_e* audio_recorder_get_supported_encoder(
	recorder_h recorder, int *list_length) {
supported_encoder_data data = { 0 };
data.codec_list = NULL;
data.len = 0;
int res = recorder_foreach_supported_audio_encoder(recorder,
		_recorder_supported_audio_encoder_cb, &data);
if (res && list_length) {
	*list_length = data.len;
}
return data.codec_list;
}
const char* get_file_format_by_codec(app_data* ad) {
switch (ad->codec) {
case RECORDER_AUDIO_CODEC_AMR:
	ad->file_format = RECORDER_FILE_FORMAT_AMR;
	return "AMR";
	break;
case RECORDER_AUDIO_CODEC_AAC:
	ad->file_format = RECORDER_FILE_FORMAT_MP4;
	return "MP4";
	break;
case RECORDER_AUDIO_CODEC_VORBIS:
	ad->file_format = RECORDER_FILE_FORMAT_OGG;
	return "OGG";
	break;
}
ad->file_format = RECORDER_FILE_FORMAT_WAV;
return "WAV";
}

static void _codec_set(app_data *ad) {
char file_name[NAME_MAX] = { '\0' };
const char *file_ext = get_file_format_by_codec(ad);
char *data_path = app_get_data_path();
snprintf(file_name, NAME_MAX, "record.%s", file_ext);
snprintf(ad->file_path, PATH_MAX, "%s%s", data_path, file_name);
free(data_path);
}
static void _recorder_apply_settings(app_data *ad) {
if (ad->recorder) { // Set record file name
	recorder_set_filename(ad->recorder, ad->file_path);
	// Set record file format
	recorder_set_file_format(ad->recorder, ad->file_format);
	// Set record codec
	recorder_set_audio_encoder(ad->recorder, ad->codec);
}
}

static void record_start(void *data, Evas_Object *obj, void *event_info) {
app_data *ad = data;

if (!strcmp(elm_object_text_get(view1->On), "On")) {
	if (ad->recorder) {
		// Apply settings to recorder
		_recorder_apply_settings(ad);
		recorder_prepare(ad->recorder);
		recorder_start(ad->recorder);
		elm_object_disabled_set(ad->btn_recstop, EINA_FALSE);
		elm_object_disabled_set(ad->btn_rec, EINA_TRUE);
	}
	elm_object_text_set(view1->On, "Off");
	ecore_thread_feedback_run(_Check_DB, _set_label_text, _end_func, NULL, ad,
	EINA_FALSE);


} else {
	 if (ad->recorder) {
		 recorder_commit(ad->recorder);

		 // Check is recording
		 if (!_recorder_is_recording(ad)) {
		 recorder_unprepare(ad->recorder);
		 }
	 }
	elm_object_text_set(view1->On, "On");
}
}

void update_ui(char *data) {
dlog_print(DLOG_INFO, TAG, "Updating UI with data %s", data);
_popup_toast_cb(app->naviframe, data);
}
void nf_hw_back_cb(void* param, Evas_Object * evas_obj, void* event_info) {
//TODO : user define code
evas_obj = uib_views_get_instance()->get_window_obj()->app_naviframe;
elm_naviframe_item_pop(evas_obj);
}

void win_del_request_cb(void *data, Evas_Object *obj, void *event_info) {
ui_app_exit();
}

Eina_Bool nf_root_it_pop_cb(void* elm_win, Elm_Object_Item *it) {
elm_win_lower(elm_win);
return EINA_FALSE;
}

app_data *app_create() {
return calloc(1, sizeof(app_data));
}

void app_destroy(app_data *user_data) {
uib_app_manager_get_instance()->free_all_view_context();
free(user_data);
}

int app_run(app_data *user_data, int argc, char **argv) {
ui_app_lifecycle_callback_s cbs = { .create = _on_create_cb, .terminate =
		_on_terminate_cb, .pause = _on_pause_cb, .resume = _on_resume_cb,
		.app_control = _on_app_control_cb, };

app_event_handler_h handlers[5] = { NULL, };

ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY],
		APP_EVENT_LOW_BATTERY, _on_low_battery_cb, user_data);
ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY,
		_on_low_memory_cb, user_data);
ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED],
		APP_EVENT_DEVICE_ORIENTATION_CHANGED, _on_device_orientation_cb,
		user_data);
ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED],
		APP_EVENT_LANGUAGE_CHANGED, _on_language_changed_cb, user_data);
ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED],
		APP_EVENT_REGION_FORMAT_CHANGED, _on_region_format_changed_cb,
		user_data);

return ui_app_main(argc, argv, &cbs, user_data);
}

void app_get_resource(const char *res_file_in, char *res_path_out,
	int res_path_max) {
char *res_path = app_get_resource_path();
if (res_path) {
	snprintf(res_path_out, res_path_max, "%s%s", res_path, res_file_in);
	free(res_path);
}
}

static bool _on_create_cb(void *user_data) {
uib_app_manager_get_instance()->initialize();
initialize_sap();
int chk;
app_data* ad = user_data;
/* Get view1 */
uib_app_manager_st *am = uib_app_manager_get_instance();
view1 = (uib_view1_view_context*) am->find_view_context("view1");
evas_object_smart_callback_add(view1->On, "clicked", record_start, user_data);
ad->naviframe = uib_views_get_instance()->get_window_obj()->app_naviframe;
ad->tts = create_tts_handle(ad);

recorder_create(ad);
ad->codec_list = audio_recorder_get_supported_encoder(ad->recorder,
		&ad->codec_list_len);
ad->codec = ad->codec_list_len ? ad->codec_list[0] : RECORDER_AUDIO_CODEC_PCM;
_codec_set(ad);

chk = device_haptic_open(0, &ad->handle);

return true;
}

static void _on_terminate_cb(void *user_data) {
app_data *ad = user_data;
int chk = 0;
dlog_print(DLOG_INFO, "aa", "where are you = _on_terminate_cb", 0);
chk = device_haptic_close(ad->handle);
uib_views_get_instance()->destroy_window_obj();
}

static void _on_resume_cb(void *user_data) {
/* Take necessary actions when application becomes visible. */
}

static void _on_pause_cb(void *user_data) {
/* Take necessary actions when application becomes invisible. */
}

static void _on_app_control_cb(app_control_h app_control, void *user_data) {
/* Handle the launch request. */
}

static void _on_low_memory_cb(app_event_info_h event_info, void *user_data) {
/* Take necessary actions when the system runs low on memory. */
}

static void _on_low_battery_cb(app_event_info_h event_info, void *user_data) {
/* Take necessary actions when the battery is low. */
}

static void _on_device_orientation_cb(app_event_info_h event_info,
	void *user_data) {
/* deprecated APIs */
}

static void _on_language_changed_cb(app_event_info_h event_info,
	void *user_data) {
/* Take necessary actions is called when language setting changes. */
uib_views_get_instance()->uib_views_current_view_redraw();
}

static void _on_region_format_changed_cb(app_event_info_h event_info,
	void *user_data) {
/* Take necessary actions when region format setting changes. */
}

static void _popup_toast_cb(Evas_Object *parent, char *string) {
Evas_Object *popup;

popup = elm_popup_add(parent);
elm_object_style_set(popup, "toast/circle");
elm_popup_orient_set(popup, ELM_POPUP_ORIENT_BOTTOM);
evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK, _popup_hide_cb,
NULL);
evas_object_smart_callback_add(popup, "dismissed", _popup_hide_finished_cb,
NULL);
elm_object_part_text_set(popup, "elm.text", string);

evas_object_smart_callback_add(popup, "block,clicked", _block_clicked_cb,
NULL);

elm_popup_timeout_set(popup, 2.0);

evas_object_smart_callback_add(popup, "timeout", _timeout_cb, NULL);

evas_object_show(popup);
}
