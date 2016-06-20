#include "tts_app.h"
 void
play_tts(void *data,char* text)
{
	app_data *ad = data;
	int state = get_tts_state(&ad->tts);
	if ((tts_state_e) state == TTS_STATE_READY || (tts_state_e) state ==
			TTS_STATE_PAUSED)
	{
		add_text(ad->tts, text);
		int ret = tts_play(ad->tts);
		if (TTS_ERROR_NONE != ret)
		{
			dlog_print(DLOG_INFO, "tag", "%s err = %d", __func__, ret);
		}
	}

}

 void stop_tts(void* data)
 {
	app_data *ad = data;
	int state = get_tts_state(&ad->tts);
	if ((tts_state_e) state == TTS_STATE_PLAYING)
	{
		int ret = tts_stop(ad->tts);
		if (TTS_ERROR_NONE != ret)
		{
			dlog_print(DLOG_INFO, "tag", "%s err = %d", __func__, ret);
		}
	}

 }

void add_text(tts_h tts, char* text) {
	const char* language = "ko_KR"; // Language
	int voice_type = TTS_VOICE_TYPE_FEMALE; // Voice type
	int speed = TTS_SPEED_AUTO;
	int utt_id; // Utterance ID for the requested text
//	text = elm_object_text_get(ad->entry);
	int ret = tts_add_text(tts, text, language, voice_type, speed, &utt_id);
	if (TTS_ERROR_NONE != ret) {
		dlog_print(DLOG_INFO, "tag", "%s err = %x", __func__, ret);
	}
}

int get_tts_state(tts_h* tts) {
	tts_state_e current_state;
	int ret;
	ret = tts_get_state(*tts, &current_state);
	if (TTS_ERROR_NONE != ret) {
		dlog_print(DLOG_INFO, "tag", "%s state = %x", __func__, ret);
		return -1;
	} else {
		dlog_print(DLOG_INFO, "tag", "%s state = %x", __func__, current_state);
		return (int) current_state;
	}
}

void ttsstate_changed_cb(tts_h tts, tts_state_e previous,
		tts_state_e current, void* user_data) {
//	app_data *ad = user_data;
	switch (current) {
	case TTS_STATE_PLAYING:
//		elm_object_text_set(view->button, "Stop");
		break;
	case TTS_STATE_READY:
	default:
//		elm_object_text_set(ad->button, "Play");
		break;
	}
}
void utterance_completed_cb(tts_h tts, int utt_id, void *user_data) {
//	app_data *ad = user_data;
	dlog_print(DLOG_INFO, LOG_TAG, "Utterance completed: %d", utt_id);
//	elm_object_text_set(ad->button, "Stop (idle)");
}
void utterance_started_cb(tts_h tts, int utt_id, void *user_data) {
//	app_data *ad = user_data;
	dlog_print(DLOG_INFO, LOG_TAG, "Utterance started: %d", utt_id);
//	elm_object_text_set(ad->button, "Stop (speaking)");
}
tts_h create_tts_handle(app_data *ad) {
	tts_h tts;
	int ret = tts_create(&tts);
	if (TTS_ERROR_NONE != ret) {
		dlog_print(DLOG_INFO, "tag", "%s err = %x", __func__, ret);
	} else {
		tts_set_utterance_started_cb(tts, utterance_started_cb, ad);
		tts_set_utterance_completed_cb(tts, utterance_completed_cb, ad);
		tts_set_state_changed_cb(tts, ttsstate_changed_cb, ad);
		tts_prepare(tts);
	}
	return tts;
}
void destroy_tts_handle(tts_h tts) {
	int ret = tts_destroy(tts); // tts is the TTS handle
	if (TTS_ERROR_NONE != ret) {
		dlog_print(DLOG_INFO, "tag", "%s err = %x", __func__, ret);
	}
}
