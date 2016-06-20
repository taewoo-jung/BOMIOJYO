#include <glib.h>
#include <sap.h>
#include "helloaccessory.h"
#include "ftw.h"
#include "app_main.h"
#include "tts_app.h"
#include "g_inc_uib.h"
#include "uib_views.h"
#include "uib_view1_view.h"
#include "finder.h"

#define HELLO_ACC_ASPID "/sample/hello"
#define HELLO_ACC_CHANNELID 104
route_info ri[200];
unsigned int num_routes;
unsigned int cnt_index = 0;

struct priv {
	sap_agent_h agent;
	sap_socket_h socket;
	sap_peer_agent_h peer_agent;
};

static gboolean agent_created = FALSE;

static struct priv priv_data = { 0 };

static void on_service_connection_terminated(sap_peer_agent_h peer_agent,
		sap_socket_h socket, sap_service_connection_terminated_reason_e result,
		void *user_data) {
	switch (result) {
	case SAP_CONNECTION_TERMINATED_REASON_PEER_DISCONNECTED:
		dlog_print(DLOG_INFO, TAG, "disconnected because peer lost");
		break;

	case SAP_CONNECTION_TERMINATED_REASON_DEVICE_DETACHED:
		dlog_print(DLOG_INFO, TAG, "disconnected because device is detached");
		break;

	case SAP_CONNECTION_TERMINATED_REASON_UNKNOWN:
		dlog_print(DLOG_INFO, TAG, "disconnected because of unknown reason");
		break;
	}

	update_ui("Connection terminated");

	sap_socket_destroy(priv_data.socket);
	priv_data.socket = NULL;

	dlog_print(DLOG_INFO, TAG, "status:%d", result);
}

static void on_data_recieved(sap_socket_h socket, unsigned short int channel_id,
		unsigned int payload_length, void *buffer, void *user_data) {
	char send[255];
	char left_dist[32];
	double togo;
	if (eina_str_has_prefix(buffer, "GPS")) {
		route_info* tr;
		tr = calloc(sizeof(route_info), 1);
		get_cnt_gps(buffer, tr);
		togo = calDistance(ri[cnt_index + 1], *tr);
		if ((cnt_index < num_routes) && togo < 10) {
			cnt_index++;
			if(!strcmp(ri[cnt_index].route_desc,"도착"))
			{
				ri[cnt_index].route_desc = "목적지에 도착했습니다";
			}
			alarm_route_desc(ri[cnt_index].route_desc);
			if (cnt_index == num_routes - 2)
				strcpy(send, "finish");
			else {
				strcpy(send, "point");
				togo = calDistance(ri[cnt_index + 1], *tr);
				sprintf(left_dist, "남은 거리: %0.2f m", togo);
				elm_object_text_set(view1->label1, left_dist);
			}
			sap_socket_send_data(priv_data.socket, HELLO_ACC_CHANNELID,
					strlen(send), send);
			dlog_print(DLOG_INFO, TAG, "SENT MSG: %s", send);
		} else {
			sprintf(send, "distance between current loc and r%d distance: %f m",
					cnt_index + 1, togo);
			sap_socket_send_data(priv_data.socket, HELLO_ACC_CHANNELID,
					strlen(send), send);
			dlog_print(DLOG_INFO, TAG, "SENT MSG: %s", send);

			sprintf(left_dist, "남은 거리: %0.2f m", togo);
			elm_object_text_set(view1->label1, left_dist);
		}

		free(tr);
	} else if (eina_str_has_prefix(buffer, "accident")) {
		char** recieved;
		recieved = eina_str_split(buffer, "/", -1);
		alter_danger_area(recieved[1]);
		return;
	} else {
		cnt_index = 0;
		saveRoutes(buffer, ri, &num_routes);
		alarm_route_desc(ri[0].route_desc);
		togo = calDistance(ri[cnt_index], ri[cnt_index + 1]);
		sprintf(send, "distance between current r%d and r%d distance: %f m",
				cnt_index, cnt_index + 1, togo);
		sap_socket_send_data(priv_data.socket, HELLO_ACC_CHANNELID,
				strlen(send), send);
		dlog_print(DLOG_INFO, TAG, "SENT MSG: %s", send);
		sprintf(left_dist, "남은 거리: %0.2f m", togo);
		elm_object_text_set(view1->label1, left_dist);
	}
}

static void on_service_connection_requested(sap_peer_agent_h peer_agent,
		sap_socket_h socket, sap_service_connection_result_e result,
		void *user_data) {
	priv_data.socket = socket;
	priv_data.peer_agent = peer_agent;

	sap_peer_agent_set_service_connection_terminated_cb(priv_data.peer_agent,
			on_service_connection_terminated, user_data);

	sap_socket_set_data_received_cb(socket, on_data_recieved, peer_agent);

	sap_peer_agent_accept_service_connection(peer_agent);

	update_ui("Connection Established");
}

static void on_agent_initialized(sap_agent_h agent,
		sap_agent_initialized_result_e result, void *user_data) {
	switch (result) {
	case SAP_AGENT_INITIALIZED_RESULT_SUCCESS:
		dlog_print(DLOG_INFO, TAG, "agent is initialized");

		sap_agent_set_service_connection_requested_cb(agent,
				on_service_connection_requested,
				NULL);

		priv_data.agent = agent;
		agent_created = TRUE;
		break;

	case SAP_AGENT_INITIALIZED_RESULT_DUPLICATED:
		dlog_print(DLOG_INFO, TAG, "duplicate registration");
		break;

	case SAP_AGENT_INITIALIZED_RESULT_INVALID_ARGUMENTS:
		dlog_print(DLOG_INFO, TAG, "invalid arguments");
		break;

	case SAP_AGENT_INITIALIZED_RESULT_INTERNAL_ERROR:
		dlog_print(DLOG_INFO, TAG, "internal sap error");
		break;

	default:
		dlog_print(DLOG_INFO, TAG, "unknown status (%d)", result);
		break;
	}

	dlog_print(DLOG_INFO, TAG, "agent initialized callback is over");

}

static void on_device_status_changed(sap_device_status_e status,
		sap_transport_type_e transport_type, void *user_data) {
	switch (transport_type) {
	case SAP_TRANSPORT_TYPE_BT:
		dlog_print(DLOG_INFO, TAG, "connectivity type(%d): bt", transport_type);
		break;

	case SAP_TRANSPORT_TYPE_BLE:
		dlog_print(DLOG_INFO, TAG, "connectivity type(%d): ble",
				transport_type);
		break;

	case SAP_TRANSPORT_TYPE_TCP:
		dlog_print(DLOG_INFO, TAG, "connectivity type(%d): tcp/ip",
				transport_type);
		break;

	case SAP_TRANSPORT_TYPE_USB:
		dlog_print(DLOG_INFO, TAG, "connectivity type(%d): usb",
				transport_type);
		break;

	case SAP_TRANSPORT_TYPE_MOBILE:
		dlog_print(DLOG_INFO, TAG, "connectivity type(%d): mobile",
				transport_type);
		break;

	default:
		dlog_print(DLOG_INFO, TAG, "unknown connectivity type (%d)",
				transport_type);
		break;
	}

	switch (status) {
	case SAP_DEVICE_STATUS_DETACHED:

		if (priv_data.peer_agent) {
			sap_socket_destroy(priv_data.socket);
			priv_data.socket = NULL;
			sap_peer_agent_destroy(priv_data.peer_agent);
			priv_data.peer_agent = NULL;

		}

		break;

	case SAP_DEVICE_STATUS_ATTACHED:
		break;

	default:
		dlog_print(DLOG_INFO, TAG, "unknown status (%d)", status);
		break;
	}
}

gboolean agent_initialize() {
	int result = 0;

	do {
		result = sap_agent_initialize(priv_data.agent, HELLO_ACC_ASPID,
				SAP_AGENT_ROLE_PROVIDER, on_agent_initialized, NULL);

		dlog_print(DLOG_INFO, TAG, "SAP >>> getRegisteredServiceAgent() >>> %d",
				result);
	} while (result != SAP_RESULT_SUCCESS);

	return TRUE;
}

void initialize_sap() {
	sap_agent_h agent = NULL;

	sap_agent_create(&agent);

	if (agent == NULL)
		dlog_print(DLOG_ERROR, TAG, "ERROR in creating agent");
	else
		dlog_print(DLOG_INFO, TAG, "SUCCESSFULLY create sap agent");

	priv_data.agent = agent;

	sap_set_device_status_changed_cb(on_device_status_changed, NULL);

	agent_initialize();
}

