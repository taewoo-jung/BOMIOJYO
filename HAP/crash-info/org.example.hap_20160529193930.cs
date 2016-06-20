S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.5
Build-Number: R732XXU2CPC5
Build-Date: 2016.03.21 17:05:24

Crash Information
Process Name: hap
PID: 11399
Date: 2016-05-29 19:39:30+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x41dc8504, r1   = 0xffffffff
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xbe93fef8, r5   = 0x00000068
r6   = 0x41ef7c00, r7   = 0xbe93fecc
r8   = 0x41fee6e0, r9   = 0x417c5861
r10  = 0x4059a4b8, fp   = 0x00000000
ip   = 0x4142deb0, sp   = 0xbe93fcc0
lr   = 0x404ac070, pc   = 0x404ac090
cpsr = 0x40000010

Memory Information
MemTotal:   489992 KB
MemFree:     16536 KB
Buffers:     19180 KB
Cached:     116380 KB
VmPeak:      62076 KB
VmSize:      61564 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16740 KB
VmRSS:       16740 KB
VmData:      30956 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20056 KB
VmPTE:          44 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 11399 TID = 11399
11399 11466 

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40046000 r-xp /usr/lib/libappcore-efl.so.1.1
40055000 40061000 r-xp /usr/lib/libaul.so.0.1.0
4006b000 4006d000 r-xp /lib/libdl-2.13.so
40076000 40079000 r-xp /usr/lib/libbundle.so.0.1.22
40081000 40083000 r-xp /usr/lib/libdlog.so.0.0.0
4008b000 4009f000 r-xp /lib/libpthread-2.13.so
400aa000 401e4000 r-xp /usr/lib/libelementary.so.1.7.99
401fa000 402c8000 r-xp /usr/lib/libevas.so.1.7.99
402ed000 40304000 r-xp /usr/lib/libecore.so.1.7.99
4031b000 40378000 r-xp /usr/lib/libedje.so.1.7.99
40382000 40452000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40453000 40459000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40461000 40464000 r-xp /usr/lib/libsmack.so.1.0.0
4046c000 40474000 r-xp /lib/libgcc_s-4.6.so.1
40475000 40590000 r-xp /lib/libc-2.13.so
4059e000 405da000 r-xp /usr/lib/libsystemd.so.0.4.0
405e3000 405ee000 r-xp /lib/libunwind.so.8.0.1
4061b000 40632000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4063a000 40664000 r-xp /usr/lib/libdbus-1.so.3.8.12
4066d000 40672000 r-xp /usr/lib/libxdgmime.so.1.1.0
4067a000 4069c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
406a4000 406a7000 r-xp /usr/lib/libproc-stat.so.0.2.86
406af000 406b5000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406be000 40727000 r-xp /lib/libm-2.13.so
40730000 40749000 r-xp /usr/lib/libeet.so.1.7.99
4075a000 4079b000 r-xp /usr/lib/libeina.so.1.7.99
407a4000 407c6000 r-xp /usr/lib/libecore_evas.so.1.7.99
407cf000 407d4000 r-xp /usr/lib/libecore_file.so.1.7.99
407dc000 407ed000 r-xp /usr/lib/libecore_input.so.1.7.99
407f5000 407f9000 r-xp /usr/lib/libvconf.so.0.2.45
40801000 40851000 r-xp /usr/lib/libecore_x.so.1.7.99
40853000 4085c000 r-xp /usr/lib/libedbus.so.1.7.99
40864000 4087e000 r-xp /usr/lib/libecore_con.so.1.7.99
40887000 4089a000 r-xp /usr/lib/libfribidi.so.0.3.1
408a2000 408df000 r-xp /usr/lib/libharfbuzz.so.0.940.0
408e8000 40910000 r-xp /usr/lib/libfontconfig.so.1.8.0
40911000 40967000 r-xp /usr/lib/libfreetype.so.6.11.3
40973000 409c9000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d6000 409dc000 r-xp /lib/librt-2.13.so
409e5000 409ec000 r-xp /usr/lib/libembryo.so.1.7.99
409f4000 40a0b000 r-xp /usr/lib/liblua-5.1.so
40a14000 40a1a000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a22000 40a23000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2b000 40a58000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a60000 40a63000 r-xp /lib/libcap.so.2.21
40a6b000 40a83000 r-xp /usr/lib/liblzma.so.5.0.3
40a8b000 40b07000 r-xp /usr/lib/libgcrypt.so.20.0.3
40b13000 40b23000 r-xp /lib/libresolv-2.13.so
40b27000 40bfa000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40c05000 40c39000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40c42000 40c58000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40c60000 40cd5000 r-xp /usr/lib/libsqlite3.so.0.8.6
40cdf000 40cf5000 r-xp /lib/libz.so.1.2.5
40cfd000 40d20000 r-xp /usr/lib/libjpeg.so.8.0.2
40d38000 40e19000 r-xp /usr/lib/libX11.so.6.3.0
40e24000 40e29000 r-xp /usr/lib/libecore_fb.so.1.7.99
40e32000 40e36000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40e3f000 40e42000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40e4a000 40e51000 r-xp /usr/lib/libXcursor.so.1.0.2
40e59000 40e5b000 r-xp /usr/lib/libXdamage.so.1.1.0
40e63000 40e65000 r-xp /usr/lib/libXcomposite.so.1.0.0
40e6d000 40e6f000 r-xp /usr/lib/libXgesture.so.7.0.0
40e77000 40e7a000 r-xp /usr/lib/libXfixes.so.3.1.0
40e82000 40e8b000 r-xp /usr/lib/libXi.so.6.1.0
40e93000 40e94000 r-xp /usr/lib/libXinerama.so.1.0.0
40e9d000 40ea3000 r-xp /usr/lib/libXrandr.so.2.2.0
40eab000 40eb1000 r-xp /usr/lib/libXrender.so.1.3.0
40eb9000 40ebd000 r-xp /usr/lib/libXtst.so.6.1.0
40ec5000 40ecf000 r-xp /usr/lib/libXext.so.6.4.0
40ed8000 40f1c000 r-xp /usr/lib/libcurl.so.4.3.0
40f25000 40f3b000 r-xp /lib/libexpat.so.1.5.2
40f45000 40f5d000 r-xp /usr/lib/libpng12.so.0.50.0
40f65000 40f82000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f8b000 4101f000 r-xp /usr/lib/libstdc++.so.6.0.16
41033000 41036000 r-xp /lib/libattr.so.1.1.0
4103e000 41049000 r-xp /usr/lib/libgpg-error.so.0.15.0
41051000 41052000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
4105a000 4105f000 r-xp /usr/lib/libffi.so.5.0.10
41067000 41069000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
41072000 4113e000 r-xp /usr/lib/libxml2.so.2.7.8
4114b000 4114d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
41156000 41158000 r-xp /usr/lib/journal/libjournal.so.0.1.0
41160000 41173000 r-xp /usr/lib/libxcb.so.1.1.0
4117d000 41186000 r-xp /usr/lib/libcares.so.2.1.0
4118f000 411bd000 r-xp /usr/lib/libidn.so.11.5.44
411c5000 41212000 r-xp /usr/lib/libssl.so.1.0.0
4121e000 413c6000 r-xp /usr/lib/libcrypto.so.1.0.0
413df000 413e1000 r-xp /usr/lib/libiri.so
413ea000 413f1000 r-xp /lib/libcrypt-2.13.so
41421000 41423000 r-xp /usr/lib/libXau.so.6.0.0
41430000 41434000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
41445000 4144a000 r-xp /usr/lib/libappcore-common.so.1.1
41452000 41454000 r-xp /usr/lib/libiniparser.so.0
4145d000 41463000 r-xp /opt/usr/apps/org.example.hap/bin/hap
41472000 41476000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4147f000 41481000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4148a000 41490000 r-xp /usr/lib/libappsvc.so.0.1.0
41498000 414bc000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414c5000 41594000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415aa000 415b4000 r-xp /lib/libnss_files-2.13.so
4175c000 41767000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41771000 41776000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4177e000 4179f000 r-xp /usr/lib/libefl-extension.so.0.1.0
417a7000 417b9000 r-xp /usr/lib/libtts.so
417c1000 417ce000 r-xp /usr/lib/libsap-client-stub-api.so.1.0.0
417d6000 4188e000 r-xp /usr/lib/libcairo.so.2.11200.14
41899000 418a1000 r-xp /usr/lib/libsap_client.so.0.0.0
418a9000 418b7000 r-xp /usr/lib/libGLESv2.so.2.0
418c0000 418c1000 r-xp /usr/lib/libxcb-shm.so.0.0.0
418ca000 418d0000 r-xp /usr/lib/libxcb-render.so.0.0.0
418d8000 418db000 r-xp /usr/lib/libEGL.so.1.4
418e3000 419ad000 r-xp /usr/lib/libCOREGL.so.4.0
41bbf000 41bca000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
41bd3000 41bd7000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41be8000 41bf0000 r-xp /usr/lib/libdrm.so.2.4.0
41bf8000 41bff000 r-xp /usr/lib/libtbm.so.1.0.0
41c07000 41c09000 r-xp /usr/lib/libdri2.so.0.0.0
41c11000 41c28000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
41c35000 41c37000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
41c4e000 41c96000 rw-p [heap]
41c96000 41dc8000 rw-p [heap]
43206000 43a05000 rwxp [stack:11466]
be920000 be941000 rwxp [stack]
End of Maps Information

Callstack Information (PID:11399)
Call Stack Count: 1
 0: (0x404ac090) [/lib/libc.so.6] + 0x37090
End of Call Stack

Package Information
Package Name: org.example.hap
Package ID : org.example.hap
Version: 1.0.0
Package Type: rpm
App Name: hap
App ID: org.example.hap
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
ble(1)
05-29 19:39:00.881+0900 W/W_HOME  (  718): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-29 19:39:00.881+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 19:39:00.881+0900 W/W_HOME  (  718): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-29 19:39:00.881+0900 I/APP_CORE(  718): appcore-efl.c: __do_app(429) > [APP 718] Event: PAUSE State: RUNNING
05-29 19:39:00.881+0900 I/CAPI_APPFW_APPLICATION(  718): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 19:39:00.881+0900 W/W_HOME  (  718): main.c: _appcore_pause_cb(690) > appcore pause
05-29 19:39:00.881+0900 W/W_HOME  (  718): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-29 19:39:00.881+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 19:39:00.881+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 19:39:00.881+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 19:39:00.881+0900 W/W_HOME  (  718): rotary.c: rotary_deattach(156) > rotary_deattach:0x46683838
05-29 19:39:00.881+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 19:39:00.881+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46683838, elm_layout, func : 0x4004b469
05-29 19:39:00.881+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-29 19:39:00.881+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-29 19:39:00.881+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 19:39:00.881+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96248, elm_box, _activated_obj : 0x46683838, activated : 1
05-29 19:39:00.881+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 19:39:00.881+0900 E/wnotib  (  718): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 19:39:00.881+0900 I/wnotib  (  718): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-29 19:39:00.921+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(429) > [APP 2594] Event: RESUME State: RUNNING
05-29 19:39:00.941+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 19:39:00.941+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 19:39:00.941+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 19:39:00.941+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-29 19:39:00.941+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-29 19:39:00.941+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 19:39:00.941+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-29 19:39:00.941+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 19:39:00.941+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 19:39:00.941+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 19:39:00.941+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 19:39:00.941+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-29 19:39:00.941+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-29 19:39:00.941+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 19:39:00.941+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-29 19:39:00.941+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-29 19:39:00.941+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-29 19:39:00.941+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 19:39:00.941+0900 E/CAPI_APPFW_APP_CONTROL( 1053): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-29 19:39:00.941+0900 W/MUSIC_CONTROL_SERVICE( 1053): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1053]   [com.samsung.w-home]register msg port [false][0m
05-29 19:39:00.941+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 19:39:00.941+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 19:39:00.986+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 19:39:00.996+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 19:39:01.011+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 19:39:01.011+0900 E/AUL_AMD (  496): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 19:39:01.011+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 697
05-29 19:39:01.026+0900 E/RESOURCED(  497): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-29 19:39:01.026+0900 E/RESOURCED(  497): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 19:39:01.036+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(2080) > pad pid(-5)
05-29 19:39:01.036+0900 W/AUL_PAD ( 1161): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-29 19:39:01.036+0900 W/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(272) > Check app launching
05-29 19:39:01.036+0900 E/AUL_PAD (11291): launchpad_loader.c: __candidate_process_prepare_exec(259) > fail to set privileges - check your package's credential : -1
05-29 19:39:01.036+0900 E/AUL_PAD (11291): launchpad_loader.c: __candidate_process_launchpad_main_loop(402) > __candidate_process_prepare_exec() failed
05-29 19:39:01.066+0900 I/wnotib  (  718): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-29 19:39:01.066+0900 E/wnotib  (  718): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 19:39:01.081+0900 W/APPS    (  718): apps_main.c: _time_changed_cb(295) >  date : 29->29
05-29 19:39:01.081+0900 W/APPS    (  718): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-29 19:39:01.086+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:01.086+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:01.186+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:01.186+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:01.286+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:01.286+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:01.386+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:01.386+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:01.446+0900 I/APP_CORE(  718): appcore-efl.c: __do_app(429) > [APP 718] Event: MEM_FLUSH State: PAUSED
05-29 19:39:01.486+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:01.486+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:01.586+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:01.586+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:01.686+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:01.686+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:01.786+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:01.786+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:01.891+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:01.891+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:01.991+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:01.991+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:02.091+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:02.091+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:02.191+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:02.191+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:02.291+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:02.291+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:02.391+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:02.391+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:02.491+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:02.491+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:02.596+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:02.596+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:02.711+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:02.711+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:02.816+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:02.816+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:02.921+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:02.921+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:03.026+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:03.026+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:03.131+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:03.131+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:03.136+0900 E/RESOURCED(  497): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 19:39:03.241+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:03.241+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:03.246+0900 E/RESOURCED(  497): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 19:39:03.346+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:03.351+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:03.456+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:03.456+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:03.486+0900 E/RESOURCED(  497): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 19:39:03.556+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:03.556+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:03.661+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:03.661+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:03.766+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:03.766+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:03.876+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:03.876+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:03.981+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:03.981+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:04.086+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:04.086+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:04.196+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:04.196+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:04.216+0900 E/RESOURCED(  497): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 19:39:04.301+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:04.311+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:04.411+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:04.416+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:04.521+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:04.521+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:04.626+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:04.626+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:04.641+0900 E/RESOURCED(  497): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 19:39:04.731+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:04.731+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:04.836+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:04.836+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:04.941+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:04.941+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:05.046+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:05.046+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:05.146+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:05.151+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:05.251+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:05.251+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:05.361+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:05.361+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:05.461+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:05.461+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:05.566+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:05.566+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:05.671+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:05.671+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:05.776+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:05.776+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:05.881+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:05.881+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:05.956+0900 I/APP_CORE(  718): appcore-efl.c: __do_app(429) > [APP 718] Event: MEM_FLUSH State: PAUSED
05-29 19:39:05.986+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:05.986+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:06.091+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:06.096+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:39:06.186+0900 E/AUL     (  697): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
05-29 19:39:06.196+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(312) > process launched, but cmdline not changed
05-29 19:39:06.196+0900 E/AUL_AMD (  496): amd_launch.c: __real_send(824) > send failed due to EPIPE.
05-29 19:39:06.196+0900 E/AUL_AMD (  496): amd_launch.c: __real_send(826) > send fail to client
05-29 19:39:06.251+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:39:06.266+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 19:39:06.266+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 19:39:06.266+0900 I/AUL_AMD (  496): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 11291
05-29 19:39:06.276+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 26
05-29 19:39:06.301+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
05-29 19:39:06.316+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
05-29 19:39:06.316+0900 E/AUL_AMD (  496): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 19:39:06.316+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 493
05-29 19:39:06.341+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(2080) > pad pid(-5)
05-29 19:39:06.351+0900 E/RESOURCED(  497): procfs.c: proc_get_oom_score_adj(124) > [proc_get_oom_score_adj,124] fopen /proc/11291/oom_score_adj failed
05-29 19:39:06.351+0900 E/RESOURCED(  497): proc-main.c: resourced_proc_status_change(860) > [resourced_proc_status_change,860] Empty pid or process not exists. 11291
05-29 19:39:06.366+0900 E/RESOURCED(  497): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-29 19:39:06.371+0900 E/RESOURCED(  497): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 19:39:07.221+0900 W/AUL_PAD ( 1161): launchpad.c: __launchpad_main_loop(607) > Candidate is not prepared, enter legacy logic
05-29 19:39:07.221+0900 W/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(272) > Check app launching
05-29 19:39:07.231+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(2091) > Launch with legacy way : no launchpad
05-29 19:39:07.256+0900 W/AUL_AMD (  496): amd_launch.c: start_process(580) > child process: 11400
05-29 19:39:07.356+0900 W/AUL_AMD (  496): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 11400
05-29 19:39:07.366+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:39:07.366+0900 W/AUL_AMD (  496): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-29 19:39:07.366+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 19:39:07.401+0900 E/RESOURCED( 1094): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:07.406+0900 E/AUL     ( 1094): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-29 19:39:07.416+0900 E/CAPI_APPFW_APP_MANAGER( 1094): app_manager.c: app_manager_error(78) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
05-29 19:39:07.506+0900 I/efl-extension(11400): efl_extension.c: eext_mod_init(40) > Init
05-29 19:39:07.516+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:39:07.531+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11400
05-29 19:39:07.536+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 19:39:07.551+0900 I/CAPI_APPFW_APPLICATION(11400): app_main.c: ui_app_main(704) > app_efl_main
05-29 19:39:07.761+0900 I/AUL_PAD (11399): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 19:39:07.826+0900 I/CAPI_APPFW_APPLICATION(11400): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-29 19:39:07.851+0900 E/EFL     ( 2594): evas_main<2594> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=18853369 button=1 downs=1
05-29 19:39:07.916+0900 E/EFL     ( 2594): evas_main<2594> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=18853434 button=1 downs=0
05-29 19:39:07.926+0900 E/TBM     (11400): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 19:39:08.041+0900 E/EFL     ( 2594): evas_main<2594> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=18853562 button=1 downs=1
05-29 19:39:08.086+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04600003)
05-29 19:39:08.106+0900 E/EFL     (11400): ecore_evas<11400> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-29 19:39:08.131+0900 E/EFL     ( 2594): evas_main<2594> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=18853649 button=1 downs=0
05-29 19:39:08.166+0900 I/efl-extension(11400): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0x4293ed58]'s widget[0x4293cf90] to elm_conformant widget[0x41ce5210]
05-29 19:39:08.261+0900 I/HAP     (11400): SUCCESSFULLY create sap agent
05-29 19:39:08.261+0900 I/HAP     (11400): connectivity type(1): bt
05-29 19:39:08.361+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:39:08.361+0900 W/AUL_AMD (  496): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-29 19:39:08.521+0900 I/HAP     (11400): agent is initialized
05-29 19:39:08.521+0900 I/HAP     (11400): agent initialized callback is over
05-29 19:39:08.521+0900 I/HAP     (11400): SAP >>> getRegisteredServiceAgent() >>> 0
05-29 19:39:08.666+0900 I/APP_CORE(11400): appcore-efl.c: __do_app(429) > [APP 11400] Event: RESET State: CREATED
05-29 19:39:08.666+0900 I/CAPI_APPFW_APPLICATION(11400): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 19:39:08.716+0900 I/APP_CORE(11400): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 19:39:08.716+0900 I/APP_CORE(11400): appcore-efl.c: __do_app(474) > [APP 11400] Initial Launching, call the resume_cb
05-29 19:39:08.716+0900 I/CAPI_APPFW_APPLICATION(11400): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 19:39:08.736+0900 W/APP_CORE(11400): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4600003
05-29 19:39:08.746+0900 I/efl-extension(11400): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x4293ed58 = w: 0 h: 0  obj 0x4293cf90 w: 360 h: 360
05-29 19:39:08.756+0900 I/efl-extension(11400): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 19:39:08.871+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(429) > [APP 2594] Event: PAUSE State: RUNNING
05-29 19:39:08.871+0900 I/CAPI_APPFW_APPLICATION( 2594): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 19:39:08.871+0900 I/APP_CORE(11400): appcore-efl.c: __do_app(429) > [APP 11400] Event: RESUME State: RUNNING
05-29 19:39:08.906+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:39:08.906+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 19:39:09.191+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 19:39:09.246+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 19:39:09.281+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 19:39:09.281+0900 E/AUL_AMD (  496): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 19:39:09.286+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 697
05-29 19:39:09.306+0900 W/AUL_AMD (  496): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 11400
05-29 19:39:09.316+0900 I/MALI    (11400): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x41a26f28] swap changed from async to sync
05-29 19:39:09.321+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(11400), cmd(0)
05-29 19:39:09.321+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 19:39:09.321+0900 I/APP_CORE(11400): appcore-efl.c: __do_app(429) > [APP 11400] Event: RESET State: RUNNING
05-29 19:39:09.321+0900 I/CAPI_APPFW_APPLICATION(11400): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 19:39:09.321+0900 I/APP_CORE(11400): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-29 19:39:09.321+0900 I/APP_CORE(11400): appcore-efl.c: __do_app(481) > [APP 11400] App already running, raise the window
05-29 19:39:09.321+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 19:39:09.341+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04600003)
05-29 19:39:09.586+0900 I/efl-extension( 2686): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:39:09.586+0900 I/efl-extension(10647): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:39:09.586+0900 I/efl-extension( 5514): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:39:09.586+0900 I/efl-extension(  718): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:39:10.076+0900 I/efl-extension(  718): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:39:10.081+0900 I/efl-extension( 2686): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:39:10.081+0900 I/efl-extension(10647): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:39:10.086+0900 I/efl-extension( 5514): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:39:10.316+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:39:10.316+0900 W/AUL_AMD (  496): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-29 19:39:13.901+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(429) > [APP 2594] Event: MEM_FLUSH State: PAUSED
05-29 19:39:14.321+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 19:39:14.321+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 19:39:14.471+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:39:14.541+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11400
05-29 19:39:16.266+0900 I/efl-extension(  718): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:39:16.271+0900 I/efl-extension( 2686): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:39:16.271+0900 I/efl-extension( 5514): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:39:16.271+0900 I/efl-extension(10647): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:39:16.376+0900 E/RESOURCED( 2695): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:39:16.376+0900 E/AUL     ( 2695): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-29 19:39:17.126+0900 I/efl-extension(  718): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:39:17.131+0900 I/efl-extension( 2686): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:39:17.131+0900 I/efl-extension( 5514): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:39:17.131+0900 I/efl-extension(10647): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:39:18.486+0900 W/CRASH_MANAGER(11443): worker.c: worker_job(1199) > 11114006861701464518358
05-29 19:39:18.621+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:39:18.621+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 19:39:18.696+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(429) > [APP 2594] Event: RESUME State: PAUSED
05-29 19:39:18.716+0900 I/CAPI_APPFW_APPLICATION( 2594): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 19:39:19.326+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:39:19.396+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 19:39:19.401+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 4
05-29 19:39:19.411+0900 E/AUL_AMD (  496): amd_request.c: __app_process_by_pid(193) > pid(11400) is dead. cmd(4) is canceled
05-29 19:39:21.671+0900 E/EFL     ( 2594): evas_main<2594> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=18867187 button=1 downs=1
05-29 19:39:21.686+0900 E/EFL     ( 2594): evas_main<2594> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=18867209 button=1 downs=0
05-29 19:39:21.801+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 19:39:21.811+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 19:39:21.826+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 19:39:21.826+0900 E/AUL_AMD (  496): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 19:39:21.826+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 697
05-29 19:39:21.841+0900 E/RESOURCED(  497): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-29 19:39:21.841+0900 E/RESOURCED(  497): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 19:39:21.846+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(2080) > pad pid(-5)
05-29 19:39:21.846+0900 W/AUL_PAD ( 1161): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-29 19:39:21.846+0900 W/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(272) > Check app launching
05-29 19:39:21.896+0900 I/efl-extension(11399): efl_extension.c: eext_mod_init(40) > Init
05-29 19:39:21.901+0900 I/CAPI_APPFW_APPLICATION(11399): app_main.c: ui_app_main(704) > app_efl_main
05-29 19:39:21.906+0900 I/CAPI_APPFW_APPLICATION(11399): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-29 19:39:21.951+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 19:39:21.986+0900 E/TBM     (11399): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 19:39:22.051+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x06200002)
05-29 19:39:22.121+0900 E/EFL     (11399): ecore_evas<11399> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-29 19:39:22.186+0900 I/efl-extension(11399): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0x41ef91d0]'s widget[0x41dbf708] to elm_conformant widget[0x41d90000]
05-29 19:39:22.261+0900 I/HAP     (11399): SUCCESSFULLY create sap agent
05-29 19:39:22.261+0900 I/HAP     (11399): connectivity type(1): bt
05-29 19:39:22.416+0900 I/HAP     (11399): agent is initialized
05-29 19:39:22.416+0900 I/HAP     (11399): agent initialized callback is over
05-29 19:39:22.416+0900 I/HAP     (11399): SAP >>> getRegisteredServiceAgent() >>> 0
05-29 19:39:22.481+0900 I/APP_CORE(11399): appcore-efl.c: __do_app(429) > [APP 11399] Event: RESET State: CREATED
05-29 19:39:22.481+0900 I/CAPI_APPFW_APPLICATION(11399): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 19:39:22.501+0900 I/APP_CORE(11399): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 19:39:22.501+0900 I/APP_CORE(11399): appcore-efl.c: __do_app(474) > [APP 11399] Initial Launching, call the resume_cb
05-29 19:39:22.506+0900 I/CAPI_APPFW_APPLICATION(11399): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 19:39:22.511+0900 W/APP_CORE(11399): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6200002
05-29 19:39:22.516+0900 E/EFL     (11399): evas_main<11399> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=18867982 button=1 downs=1
05-29 19:39:22.516+0900 E/EFL     (11399): evas_main<11399> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=18868026 button=1 downs=0
05-29 19:39:22.516+0900 I/efl-extension(11399): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x41ef91d0 = w: 0 h: 0  obj 0x41dbf708 w: 360 h: 360
05-29 19:39:22.521+0900 I/efl-extension(11399): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 19:39:22.556+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(429) > [APP 2594] Event: PAUSE State: RUNNING
05-29 19:39:22.556+0900 I/CAPI_APPFW_APPLICATION( 2594): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 19:39:22.576+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:39:22.576+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 19:39:22.586+0900 I/APP_CORE(11399): appcore-efl.c: __do_app(429) > [APP 11399] Event: RESUME State: RUNNING
05-29 19:39:22.961+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 19:39:22.996+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:39:23.006+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11399
05-29 19:39:23.021+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 19:39:23.301+0900 I/AUL_PAD (11467): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 19:39:26.151+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 19:39:26.151+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 19:39:26.151+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(134920432)
05-29 19:39:26.151+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 19:39:26.151+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 19:39:26.151+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 19:39:26.151+0900 E/ALARM_MANAGER(  492): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[134920432] is removed.
05-29 19:39:26.166+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 19:39:26.166+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 19:39:26.186+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:39:26.201+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:39:26.211+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:39:26.226+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:39:26.226+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-29 19:39:26.226+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-29 19:39:26.236+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:39:26.251+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:39:26.251+0900 E/ALARM_MANAGER(  492): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464518370, Sun May 29 19:39:30 2016
05-29 19:39:26.251+0900 E/ALARM_MANAGER(  492): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 125969613, next duetime: 1464518370
05-29 19:39:26.251+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(125969613)
05-29 19:39:26.251+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464518370)
05-29 19:39:26.251+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 19:39:26.251+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 10:39:30 (UTC).
05-29 19:39:26.251+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 19:39:26.261+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 19:39:26.261+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 19:39:26.266+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(125969613)
05-29 19:39:26.266+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 19:39:26.266+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 19:39:26.266+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 19:39:26.266+0900 E/ALARM_MANAGER(  492): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[125969613] is removed.
05-29 19:39:26.276+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 19:39:26.276+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 19:39:26.291+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:39:26.306+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:39:26.321+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:39:26.336+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:39:26.336+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-29 19:39:26.336+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-29 19:39:26.346+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:39:26.356+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:39:26.356+0900 E/ALARM_MANAGER(  492): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464561566, Mon May 30 07:39:26 2016
05-29 19:39:26.356+0900 E/ALARM_MANAGER(  492): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 125969613, next duetime: 1464561566
05-29 19:39:26.356+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(125969613)
05-29 19:39:26.356+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464561566)
05-29 19:39:26.356+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 19:39:26.356+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 19:39:26.356+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 19:39:26.956+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:39:26.966+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11399
05-29 19:39:27.581+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(429) > [APP 2594] Event: MEM_FLUSH State: PAUSED
05-29 19:39:30.786+0900 W/CRASH_MANAGER(11443): worker.c: worker_job(1199) > 1111399686170146451837
