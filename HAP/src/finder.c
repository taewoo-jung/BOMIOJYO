/*
 * finder.c
 *
 *  Created on: May 29, 2016
 *      Author: wonhyuk
 */
#include "finder.h"
#include "app_main.h"
#include "ftw.h"
#include "helloaccessory.h"
#include "math.h"
#include <stdlib.h>
#include "tts_app.h"
void alter_danger_area(char* type) {
	if (!strcmp(type, "oldman")) {
		stop_tts(app);
		play_tts(app, "노인분들의 사고가 많은 지역입니다. 조심하세요");
	} else if (!strcmp(type, "child")) {
		stop_tts(app);
		play_tts(app, "어린이들의 사고가 많은 지역입니다. 조심하세요");
	} else {
		stop_tts(app);
		play_tts(app, " 사고가 많은 지역입니다. 조심하세요");
	}
}
double deg2rad(double deg) {
	return deg * M_PI / 180;
}

double rad2deg(double rad) {
	return rad * 180 / M_PI;
}

double calDistance(route_info r1, route_info r2) {
	double lat1, lon1, lat2, lon2;
	lat1 = r1.lat;
	lon1 = r1.lon;
	lat2 = r2.lat;
	lon2 = r2.lon;
	double theta = lon1 - lon2;
	double dist = sin(deg2rad(lat1)) * sin(deg2rad(lat2))
			+ cos(deg2rad(lat1)) * cos(deg2rad(lat2)) * cos(deg2rad(theta));
	dist = acos(dist);
	dist = rad2deg(dist);
	dist = dist * 60 * 1.1515;
	dist = dist * 1.609344;
	return dist * 1000;
}
void saveRoutes(void *buffer, route_info ri[], unsigned int* num_routes) {
	char** recieved;
	recieved = eina_str_split_full(buffer, ",", -1, num_routes);
	dlog_print(DLOG_INFO, TAG, "routes length: %d", *num_routes);
	for (int rt = 0; rt < *num_routes - 1; rt++) {
		char** splitted;
		dlog_print(DLOG_INFO, TAG, "%s", recieved[rt]);
		splitted = eina_str_split(recieved[rt], "/", -1);
		ri[rt].route_desc = splitted[0];
		ri[rt].lat = atof(splitted[1]);
		ri[rt].lon = atof(splitted[2]);
		dlog_print(DLOG_INFO, TAG, "lat: %0.3f lon: %0.3f num:%d", ri[rt].lat,
				ri[rt].lon, rt);
	}
}
void get_cnt_gps(void* buffer, route_info* tr) {
	char** recieved;
	recieved = eina_str_split(buffer, "/", -1);
	tr->lat = atof(recieved[1]);
	tr->lon = atof(recieved[2]);
}
void alarm_route_desc(char* desc) {
	stop_tts(app);
	play_tts(app, desc);
	update_ui(desc);
}

