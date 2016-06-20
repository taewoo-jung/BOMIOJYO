/*
 * finder.h
 *
 *  Created on: May 29, 2016
 *      Author: wonhyuk
 */

#ifndef FINDER_H_
#define FINDER_H_

#include <math.h>
#include "ftw.h"
double calDistance(route_info r1, route_info r2);
void saveRoutes(void *buffer,route_info ri[], unsigned int* num_routes);
void get_cnt_gps(void* buffer, route_info* tr);
void alarm_route_desc(char* desc);
void alter_danger_area(char* type);
#endif /* FINDER_H_ */
