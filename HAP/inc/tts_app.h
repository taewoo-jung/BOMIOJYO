/*
 * tts_app.h
 *
 *  Created on: May 11, 2016
 *      Author: wonhyuk
 */
#ifndef __TTS_APP_H__
#define __TTS_APP_H__

#include "app_main.h"


void add_text(tts_h tts, char* text);
int get_tts_state(tts_h* tts);
void ttsstate_changed_cb(tts_h tts, tts_state_e previous, tts_state_e current, void* user_data);
void utterance_completed_cb(tts_h tts, int utt_id, void *user_data);
void utterance_started_cb(tts_h tts, int utt_id, void *user_data);
tts_h create_tts_handle(app_data* ad);
void destroy_tts_handle(tts_h tts);
void play_tts(void *data,char* text);
void stop_tts(void* data);
#endif
