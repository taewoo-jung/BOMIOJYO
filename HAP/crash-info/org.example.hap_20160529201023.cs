S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.5
Build-Number: R732XXU2CPC5
Build-Date: 2016.03.21 17:05:24

Crash Information
Process Name: hap
PID: 2556
Date: 2016-05-29 20:10:23+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x41dbf504, r1   = 0xffffffff
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x4156aae0, r5   = 0xbed33ef8
r6   = 0x41eeec00, r7   = 0xbed33ed0
r8   = 0x42854358, r9   = 0x419c5861
r10  = 0x4059a4b8, fp   = 0x00000000
ip   = 0x4142deb0, sp   = 0xbed33cc0
lr   = 0x404ac070, pc   = 0x404ac090
cpsr = 0x40000010

Memory Information
MemTotal:   491012 KB
MemFree:     15488 KB
Buffers:     14652 KB
Cached:     159880 KB
VmPeak:      62400 KB
VmSize:      61888 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16864 KB
VmRSS:       16864 KB
VmData:      31280 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20056 KB
VmPTE:          46 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 2556 TID = 2556
2556 2578 

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
41530000 41534000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
41545000 4154a000 r-xp /usr/lib/libappcore-common.so.1.1
41552000 41554000 r-xp /usr/lib/libiniparser.so.0
4155d000 41563000 r-xp /opt/usr/apps/org.example.hap/bin/hap
41572000 41576000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4157f000 41581000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4158a000 41590000 r-xp /usr/lib/libappsvc.so.0.1.0
41598000 415bc000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415c5000 41694000 r-xp /usr/lib/libscim-1.0.so.8.2.3
416aa000 416b4000 r-xp /lib/libnss_files-2.13.so
4195c000 41967000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41971000 41976000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4197e000 4199f000 r-xp /usr/lib/libefl-extension.so.0.1.0
419a7000 419b9000 r-xp /usr/lib/libtts.so
419c1000 419ce000 r-xp /usr/lib/libsap-client-stub-api.so.1.0.0
419d6000 41a8e000 r-xp /usr/lib/libcairo.so.2.11200.14
41a99000 41aa1000 r-xp /usr/lib/libsap_client.so.0.0.0
41aa9000 41ab7000 r-xp /usr/lib/libGLESv2.so.2.0
41ac0000 41ac1000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41aca000 41ad0000 r-xp /usr/lib/libxcb-render.so.0.0.0
41ad8000 41adb000 r-xp /usr/lib/libEGL.so.1.4
41ae3000 41bad000 r-xp /usr/lib/libCOREGL.so.4.0
41ef0000 41efb000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
41f04000 41f08000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41f19000 41f21000 r-xp /usr/lib/libdrm.so.2.4.0
41f29000 41f30000 r-xp /usr/lib/libtbm.so.1.0.0
41f38000 41f3a000 r-xp /usr/lib/libdri2.so.0.0.0
41f42000 41f59000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
41f66000 41f68000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
4330d000 43b0c000 rwxp [stack:2578]
bed14000 bed35000 rwxp [stack]
End of Maps Information

Callstack Information (PID:2556)
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
w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 20:09:29.135+0900 I/wnotib  (  725): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 85, 218.
05-29 20:09:29.135+0900 I/wnotib  (  725): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-29 20:09:29.155+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 20:09:29.155+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 20:09:29.155+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 20:09:29.155+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-29 20:09:29.155+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-29 20:09:29.155+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 20:09:29.155+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-29 20:09:29.155+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 20:09:29.155+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 20:09:29.155+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 20:09:29.155+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 20:09:29.155+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-29 20:09:29.155+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-29 20:09:29.155+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 20:09:29.155+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-29 20:09:29.155+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-29 20:09:29.160+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-29 20:09:29.160+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 20:09:29.160+0900 E/CAPI_APPFW_APP_CONTROL( 1034): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-29 20:09:29.160+0900 W/MUSIC_CONTROL_SERVICE( 1034): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1034]   [com.samsung.w-home]register msg port [false][0m
05-29 20:09:29.160+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: RESUME State: RUNNING
05-29 20:09:29.165+0900 W/GESTURE (  135): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 20:09:29.165+0900 W/GESTURE (  135): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 20:09:29.250+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 20:09:29.260+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 20:09:29.270+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 20:09:29.270+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 20:09:29.270+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1702) > caller pid : 700
05-29 20:09:29.285+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-29 20:09:29.285+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 20:09:29.290+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2080) > pad pid(-5)
05-29 20:09:29.290+0900 W/AUL_PAD ( 1191): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-29 20:09:29.290+0900 W/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(272) > Check app launching
05-29 20:09:29.300+0900 E/AUL_PAD ( 2464): launchpad_loader.c: __candidate_process_prepare_exec(259) > fail to set privileges - check your package's credential : -1
05-29 20:09:29.300+0900 E/AUL_PAD ( 2464): launchpad_loader.c: __candidate_process_launchpad_main_loop(402) > __candidate_process_prepare_exec() failed
05-29 20:09:29.315+0900 I/wnotib  (  725): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-29 20:09:29.315+0900 E/wnotib  (  725): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 20:09:29.330+0900 W/APPS    (  725): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-29 20:09:29.360+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:29.360+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:29.460+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:29.460+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:29.560+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:29.560+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:29.660+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:29.660+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:29.660+0900 I/APP_CORE(  725): appcore-efl.c: __do_app(429) > [APP 725] Event: MEM_FLUSH State: PAUSED
05-29 20:09:29.760+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:29.760+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:29.860+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:29.860+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:29.960+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:29.960+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:30.060+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:30.060+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:30.165+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:30.165+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:30.265+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:30.265+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:30.365+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:30.365+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:30.465+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:30.465+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:30.565+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:30.565+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:30.665+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:30.665+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:30.765+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:30.765+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:30.870+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:30.870+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:30.975+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:30.980+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:31.080+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:31.080+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:31.185+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:31.185+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:31.295+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:31.295+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:31.400+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:31.400+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:31.510+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:31.510+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:31.615+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:31.615+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:31.615+0900 E/RESOURCED(  498): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 20:09:31.720+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:31.720+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:31.825+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:31.825+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:31.930+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:31.930+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:32.035+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:32.035+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:32.145+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:32.145+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:32.250+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:32.250+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:32.355+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:32.355+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:32.460+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:32.460+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:32.570+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:32.570+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:32.675+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:32.675+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:32.780+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:32.780+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:32.890+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:32.890+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:32.995+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:32.995+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:33.100+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:33.100+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:33.210+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:33.210+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:33.315+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:33.315+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:33.420+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:33.420+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:33.525+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:33.525+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:33.630+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:33.630+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:33.735+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:33.735+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:33.840+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:33.840+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:33.950+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:33.950+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:34.055+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:34.055+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:34.160+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:34.160+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:34.175+0900 I/APP_CORE(  725): appcore-efl.c: __do_app(429) > [APP 725] Event: MEM_FLUSH State: PAUSED
05-29 20:09:34.265+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:34.265+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:34.375+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:34.375+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:09:34.380+0900 E/RESOURCED(  498): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 20:09:34.480+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(312) > process launched, but cmdline not changed
05-29 20:09:34.525+0900 E/RESOURCED(  498): procfs.c: proc_get_oom_score_adj(124) > [proc_get_oom_score_adj,124] fopen /proc/2464/oom_score_adj failed
05-29 20:09:34.525+0900 E/RESOURCED(  498): proc-main.c: resourced_proc_status_change(860) > [resourced_proc_status_change,860] Empty pid or process not exists. 2464
05-29 20:09:34.600+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:09:34.600+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2464
05-29 20:09:34.625+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:09:35.490+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:09:35.495+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-29 20:09:35.575+0900 E/RESOURCED( 1097): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:09:35.575+0900 E/AUL     ( 1097): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-29 20:09:35.580+0900 E/CAPI_APPFW_APP_MANAGER( 1097): app_manager.c: app_manager_error(78) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
05-29 20:09:35.945+0900 I/AUL_PAD ( 2556): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 20:09:38.485+0900 I/efl-extension(  725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:09:38.485+0900 I/efl-extension( 1196): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:09:38.485+0900 I/efl-extension( 1366): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:09:39.510+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:09:39.590+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 20:09:39.595+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 4
05-29 20:09:39.610+0900 E/AUL_AMD (  495): amd_request.c: __app_process_by_pid(193) > pid(2464) is dead. cmd(4) is canceled
05-29 20:09:42.760+0900 E/EFL     ( 1921): evas_main<1921> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=613391 button=1 downs=1
05-29 20:09:42.805+0900 E/EFL     ( 1921): evas_main<1921> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=613438 button=1 downs=0
05-29 20:09:42.900+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 20:09:42.915+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 20:09:42.930+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 20:09:42.930+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 20:09:42.930+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1702) > caller pid : 700
05-29 20:09:42.940+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-29 20:09:42.940+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 20:09:42.945+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2080) > pad pid(-5)
05-29 20:09:42.945+0900 W/AUL_PAD ( 1191): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-29 20:09:42.945+0900 W/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(272) > Check app launching
05-29 20:09:42.970+0900 I/efl-extension( 2556): efl_extension.c: eext_mod_init(40) > Init
05-29 20:09:42.970+0900 I/CAPI_APPFW_APPLICATION( 2556): app_main.c: ui_app_main(704) > app_efl_main
05-29 20:09:42.975+0900 I/CAPI_APPFW_APPLICATION( 2556): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-29 20:09:43.040+0900 E/TBM     ( 2556): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 20:09:43.050+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:09:43.080+0900 E/E17     (  379): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04600002)
05-29 20:09:43.115+0900 E/EFL     ( 2556): ecore_evas<2556> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-29 20:09:43.165+0900 I/efl-extension( 2556): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0x428080b0]'s widget[0x418856b0] to elm_conformant widget[0x414ea850]
05-29 20:09:43.245+0900 I/HAP     ( 2556): SUCCESSFULLY create sap agent
05-29 20:09:43.250+0900 I/HAP     ( 2556): connectivity type(1): bt
05-29 20:09:43.410+0900 I/HAP     ( 2556): agent is initialized
05-29 20:09:43.410+0900 I/HAP     ( 2556): agent initialized callback is over
05-29 20:09:43.410+0900 I/HAP     ( 2556): SAP >>> getRegisteredServiceAgent() >>> 0
05-29 20:09:43.465+0900 I/APP_CORE( 2556): appcore-efl.c: __do_app(429) > [APP 2556] Event: RESET State: CREATED
05-29 20:09:43.465+0900 I/CAPI_APPFW_APPLICATION( 2556): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 20:09:43.480+0900 I/APP_CORE( 2556): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 20:09:43.480+0900 I/APP_CORE( 2556): appcore-efl.c: __do_app(474) > [APP 2556] Initial Launching, call the resume_cb
05-29 20:09:43.480+0900 I/CAPI_APPFW_APPLICATION( 2556): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 20:09:43.485+0900 W/APP_CORE( 2556): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4600002
05-29 20:09:43.485+0900 I/efl-extension( 2556): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x428080b0 = w: 0 h: 0  obj 0x418856b0 w: 360 h: 360
05-29 20:09:43.485+0900 I/efl-extension( 2556): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 20:09:43.545+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: PAUSE State: RUNNING
05-29 20:09:43.545+0900 I/CAPI_APPFW_APPLICATION( 1921): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 20:09:43.550+0900 I/APP_CORE( 2556): appcore-efl.c: __do_app(429) > [APP 2556] Event: RESUME State: RUNNING
05-29 20:09:43.560+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:09:43.565+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 20:09:43.950+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:09:44.095+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:09:44.115+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2556
05-29 20:09:44.120+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 20:09:44.380+0900 I/AUL_PAD ( 2579): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 20:09:44.715+0900 I/efl-extension(  725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:09:44.715+0900 I/efl-extension( 1366): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:09:44.715+0900 I/efl-extension( 1196): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:09:44.870+0900 I/efl-extension(  725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:09:44.870+0900 I/efl-extension( 1196): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:09:44.870+0900 I/efl-extension( 1366): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:09:48.060+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:09:48.165+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2556
05-29 20:09:48.570+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: MEM_FLUSH State: PAUSED
05-29 20:09:50.275+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 20:09:50.275+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 20:09:53.175+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:09:53.245+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2556
05-29 20:09:58.140+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:09:58.205+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2556
05-29 20:09:59.320+0900 W/WATCH_CORE(  749): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-29 20:09:59.325+0900 W/W_HOME  (  725): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-29 20:09:59.325+0900 W/W_HOME  (  725): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 20:09:59.325+0900 W/W_HOME  (  725): gesture.c: _manual_render_enable(133) > 1
05-29 20:09:59.325+0900 W/W_HOME  (  725): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-29 20:09:59.325+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 20:09:59.350+0900 I/watchface-viewer(  749): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
05-29 20:09:59.350+0900 W/STARTER (  692): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
05-29 20:09:59.350+0900 W/STARTER (  692): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-29 20:09:59.355+0900 E/STARTER (  692): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-29 20:09:59.355+0900 W/STARTER (  692): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-29 20:09:59.355+0900 W/STARTER (  692): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-29 20:09:59.395+0900 W/STARTER (  692): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
05-29 20:09:59.395+0900 W/STARTER (  692): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-29 20:09:59.400+0900 W/STARTER (  692): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-29 20:09:59.400+0900 W/STARTER (  692): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-29 20:09:59.420+0900 I/watchface-viewer(  749): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
05-29 20:09:59.435+0900 I/APP_CORE( 2556): appcore-efl.c: __do_app(429) > [APP 2556] Event: PAUSE State: RUNNING
05-29 20:09:59.435+0900 I/CAPI_APPFW_APPLICATION( 2556): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 20:09:59.470+0900 W/wnotibp ( 1366): wnotiboard-popup-view.c: _wnotibp_event_lcd_on_cb(1419) > ::APP:: view state=0, 2, 0
05-29 20:09:59.470+0900 W/MUSIC_CONTROL_SERVICE( 1034): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1034]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
05-29 20:09:59.480+0900 W/WATCH_CORE(  749): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
05-29 20:09:59.480+0900 I/WATCH_CORE(  749): appcore-watch.c: __signal_lcd_status_handler(1149) > Call the time_tick_cb
05-29 20:09:59.480+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:09:59.480+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:09:59.480+0900 I/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 20:09:59.485+0900 W/W_HOME  (  725): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-29 20:09:59.485+0900 W/W_HOME  (  725): gesture.c: _manual_render_disable_timer_set(161) > timer set
05-29 20:09:59.485+0900 W/W_HOME  (  725): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 20:09:59.485+0900 W/W_HOME  (  725): gesture.c: _apps_status_get(123) > apps status:0
05-29 20:09:59.485+0900 W/W_HOME  (  725): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:0 info->offtime:264
05-29 20:09:59.485+0900 W/W_HOME  (  725): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-29 20:09:59.485+0900 W/W_HOME  (  725): event_manager.c: _lcd_on_cb(691) > lcd state: 1
05-29 20:09:59.485+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 20:09:59.500+0900 I/efl-extension( 1366): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:09:59.500+0900 I/efl-extension(  725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:09:59.505+0900 I/APP_CORE( 2556): appcore-efl.c: __do_app(429) > [APP 2556] Event: RESUME State: PAUSED
05-29 20:09:59.505+0900 I/CAPI_APPFW_APPLICATION( 2556): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 20:09:59.510+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-29 20:09:59.510+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-29 20:09:59.510+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-29 20:09:59.510+0900 I/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-29 20:09:59.515+0900 E/ALARM_MANAGER(  692): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(29-5-2016, 20:10:20), repeat(1), interval(20), type(-1073741822)
05-29 20:09:59.515+0900 I/efl-extension( 1196): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:09:59.520+0900 I/SHealth_Common( 1097): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
05-29 20:09:59.585+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:09:59.585+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:09:59.610+0900 I/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-29 20:09:59.615+0900 W/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-29 20:09:59.620+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-29 20:09:59.620+0900 I/HIGEAR  ( 1081): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-29 20:09:59.620+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : 1075153676[0;m
05-29 20:09:59.620+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
05-29 20:09:59.620+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-29 20:09:59.620+0900 I/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_product.c: sound_manager_svoice_set_param(1248) > [SVOICE] set param [keyword length] : 0
05-29 20:09:59.625+0900 W/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-29 20:09:59.625+0900 I/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Enable start
05-29 20:09:59.665+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-29 20:09:59.665+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 2088320060, next duetime: 1464520220
05-29 20:09:59.665+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(2088320060)
05-29 20:09:59.665+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464520220)
05-29 20:09:59.670+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:09:59.670+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 11:10:20 (UTC).
05-29 20:09:59.670+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:09:59.675+0900 W/STARTER (  692): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [unknown] after screen off time [264]ms
05-29 20:09:59.675+0900 W/STARTER (  692): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
05-29 20:09:59.680+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-29 20:09:59.680+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: preference_get_double(1214) > preference_get_double(1097) : pedometer_inactive_period error
05-29 20:09:59.680+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 20:09:59.680+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 20:09:59.680+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: preference_get_double(1214) > preference_get_double(1097) : inactive_10min_precaution_millisec error
05-29 20:09:59.680+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 20:09:59.680+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 20:09:59.680+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: preference_get_double(1214) > preference_get_double(1097) : inactive_before_10min_precaution_millisec error
05-29 20:09:59.680+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:09:59.680+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:09:59.680+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(2088320060)
05-29 20:09:59.680+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:09:59.680+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 20:09:59.685+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:09:59.685+0900 E/ALARM_MANAGER(  487): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[2088320060] is removed.
05-29 20:09:59.685+0900 W/W_HOME  (  725): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
05-29 20:09:59.685+0900 W/W_HOME  (  725): gesture.c: _manual_render_enable(133) > 0
05-29 20:09:59.685+0900 W/STARTER (  692): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [unknown]
05-29 20:09:59.685+0900 W/STARTER (  692): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
05-29 20:09:59.715+0900 I/efl-extension(  725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:09:59.715+0900 I/efl-extension( 1196): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:09:59.715+0900 I/efl-extension( 1366): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:09:59.840+0900 I/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-29 20:09:59.840+0900 W/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-29 20:09:59.840+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
05-29 20:09:59.840+0900 I/HIGEAR  ( 1081): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
05-29 20:10:00.430+0900 I/efl-extension(  725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:10:00.430+0900 I/efl-extension( 1196): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:10:00.430+0900 I/efl-extension( 1366): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:10:00.855+0900 W/APPS    (  725): apps_main.c: _time_changed_cb(295) >  date : 29->29
05-29 20:10:01.335+0900 I/efl-extension(  725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:10:01.335+0900 I/efl-extension( 1196): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:10:01.340+0900 I/efl-extension( 1366): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:10:01.350+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-29 20:10:01.350+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-29 20:10:01.350+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: preference_get_double(1214) > preference_get_double(1097) : pedometer_inactive_period error
05-29 20:10:01.350+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 20:10:01.350+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 20:10:01.350+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: preference_get_double(1214) > preference_get_double(1097) : inactive_10min_precaution_millisec error
05-29 20:10:01.350+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 20:10:01.350+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 20:10:01.355+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: preference_get_double(1214) > preference_get_double(1097) : inactive_before_10min_precaution_millisec error
05-29 20:10:01.545+0900 I/efl-extension(  725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:10:01.545+0900 I/efl-extension( 1366): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:10:01.545+0900 I/efl-extension( 1196): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:10:03.060+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:10:03.130+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2556
05-29 20:10:07.855+0900 E/SHealth_Common( 1097): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-29 20:10:08.140+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:10:08.210+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2556
05-29 20:10:13.130+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:10:13.140+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2556
05-29 20:10:13.195+0900 I/efl-extension(  725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:10:13.195+0900 I/efl-extension( 1196): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:10:13.195+0900 I/efl-extension( 1366): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:10:13.295+0900 I/efl-extension(  725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:10:13.295+0900 I/efl-extension( 1196): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:10:13.295+0900 I/efl-extension( 1366): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:10:18.075+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:10:18.140+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2556
05-29 20:10:23.130+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:10:23.155+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2556
05-29 20:10:23.610+0900 I/HAP     ( 2556): routes length: 21
05-29 20:10:23.610+0900 I/HAP     ( 2556): lat: 37.277
05-29 20:10:23.610+0900 I/HAP     ( 2556): lat: 37.278
05-29 20:10:23.610+0900 I/HAP     ( 2556): lat: 37.278
05-29 20:10:23.610+0900 I/HAP     ( 2556): lat: 37.278
05-29 20:10:23.610+0900 I/HAP     ( 2556): lat: 37.278
05-29 20:10:23.610+0900 I/HAP     ( 2556): lat: 37.277
05-29 20:10:23.610+0900 I/HAP     ( 2556): lat: 37.277
05-29 20:10:23.610+0900 I/HAP     ( 2556): lat: 37.277
05-29 20:10:23.610+0900 I/HAP     ( 2556): lat: 37.277
05-29 20:10:23.610+0900 I/HAP     ( 2556): lat: 37.277
05-29 20:10:23.610+0900 I/HAP     ( 2556): lat: 37.277
05-29 20:10:23.610+0900 I/HAP     ( 2556): lat: 37.277
05-29 20:10:23.610+0900 I/HAP     ( 2556): lat: 37.277
05-29 20:10:23.610+0900 I/HAP     ( 2556): lat: 37.277
05-29 20:10:23.610+0900 I/HAP     ( 2556): lat: 37.277
05-29 20:10:23.610+0900 I/HAP     ( 2556): lat: 37.277
05-29 20:10:23.610+0900 I/HAP     ( 2556): lat: 37.277
05-29 20:10:23.610+0900 I/HAP     ( 2556): lat: 37.278
05-29 20:10:23.610+0900 I/HAP     ( 2556): lat: 37.279
05-29 20:10:23.610+0900 I/HAP     ( 2556): lat: 37.279
05-29 20:10:23.980+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:10:23.980+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 20:10:24.145+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: RESUME State: PAUSED
05-29 20:10:24.145+0900 I/CAPI_APPFW_APPLICATION( 1921): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 20:10:24.220+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2556
05-29 20:10:24.280+0900 W/CRASH_MANAGER( 2722): worker.c: worker_job(1199) > 1102556686170146452022
