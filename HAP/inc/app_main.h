#ifndef __APP_MAIN_H__
#define __APP_MAIN_H__

#define ENABLE_UIB_DELOG

#include "g_inc_uib.h"
#include "uib_views.h"
#include "tts.h"
#include "uib_view1_view.h"
#define ENABLE_UIB_DELOG
#include <recorder.h>
#include <player.h>
#include <device/haptic.h>
/**
 * @brief Forward declaration of model
 */
typedef struct {
	tts_h tts;
	Evas_Object * naviframe;
	   Evas_Object *win;
	   Evas_Object *conform;
	   Evas_Object *label;
	   Evas_Object *btn_rec, *btn_recstop, *btn_play, *btn_playstop;
	   player_h player;
	   recorder_h recorder;
	   recorder_audio_codec_e *codec_list;
	   int codec_list_len;
	   char file_path[PATH_MAX];
	   recorder_audio_codec_e codec;
	   recorder_file_format_e file_format;
	   FILE *preproc_file;
	   haptic_device_h handle;
	   haptic_effect_h effect_handle;
	   Ecore_Timer *timer1;
	   Evas_Object *nf;
	   int timer_count;
	   int flag;
	   int timer_id;
	   int date_id;
} app_data;

typedef struct {
   recorder_audio_codec_e *codec_list;
   int len;
} supported_encoder_data;
struct thd
{
   app_data *ad;
   Eina_Bool tick_not_tock;
   int iteration;
};

app_data *app;
uib_view1_view_context* view1;
/**< H/W Back Key Event */
/**
 * @brief Add (register) a callback function for H/W Back Key Event to a given evas object.
 * @param[in]   pv_param     The void pointer to be passed to this func.
 * @param[in]   p_evas_obj    evas object (naviframe)
 */

void
nf_hw_back_cb(void* param, Evas_Object * evas_obj, void* event_info);

void
win_del_request_cb(void *data, Evas_Object *obj, void *event_info);

Eina_Bool
nf_root_it_pop_cb(void* elm_win, Elm_Object_Item *it);

/**
 * @brief Create application instance
 * @return Application instance on success, otherwise NULL
 */
app_data *app_create();

/**
 * @brief Destroy application instance
 * @param[in]   app     Application instance
 */
void app_destroy(app_data *app);

/**
 * @brief Run Tizen application
 * @param[in]   app     Application instance
 * @param[in]   argc    argc paremeter received in main
 * @param[in]   argv    argv parameter received in main
 */
int app_run(app_data *app, int argc, char **argv);

void app_get_resource(const char *edj_file_in, char *edj_path_out, int edj_path_max);

#endif /* __APP_MAIN_H__ */

