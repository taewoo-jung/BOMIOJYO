S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.5
Build-Number: R732XXU2CPC5
Build-Date: 2016.03.21 17:05:24

Crash Information
Process Name: hap
PID: 3122
Date: 2016-05-29 20:11:51+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x41dbf504, r1   = 0xffffffff
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x4156aaa4, r5   = 0xbee71ef8
r6   = 0x41eeec00, r7   = 0xbee71ed0
r8   = 0x42865e40, r9   = 0x419c5861
r10  = 0x4059a4b8, fp   = 0x00000000
ip   = 0x4142deb0, sp   = 0xbee71cc8
lr   = 0x404ac070, pc   = 0x404ac090
cpsr = 0x40000010

Memory Information
MemTotal:   491012 KB
MemFree:     14064 KB
Buffers:     15204 KB
Cached:     161516 KB
VmPeak:      62376 KB
VmSize:      61864 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16868 KB
VmRSS:       16868 KB
VmData:      31256 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20056 KB
VmPTE:          46 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3122 TID = 3122
3122 3128 

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
4330d000 43b0c000 rwxp [stack:3128]
bee52000 bee73000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3122)
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
9 20:11:38.510+0900 W/WATCH_CORE(  749): appcore-watch.c: __widget_resume(1012) > widget_resume
05-29 20:11:38.510+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppResume(721) > 
05-29 20:11:38.510+0900 I/watchface-viewer(  749): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [37]
05-29 20:11:38.510+0900 I/watchface-viewer(  749): viewer-part-resource.cpp: SetUpdateImage(1981) > new mThread[0x476cd698]
05-29 20:11:38.510+0900 I/watchface-viewer(  749): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [39]
05-29 20:11:38.510+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:38.510+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:38.510+0900 W/WATCH_CORE(  749): appcore-watch.c: __widget_pause(1001) > widget_pause
05-29 20:11:38.515+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppPause(713) > 
05-29 20:11:38.515+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:11:38.515+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:11:38.515+0900 I/watchface-viewer(  749): viewer-part-resource.cpp: CancelWorkerThread(2096) > cancel mThread[0x476cd698]
05-29 20:11:38.515+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:11:38.515+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:11:38.515+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:11:38.515+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:11:38.515+0900 I/watchface-viewer(  749): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
05-29 20:11:38.520+0900 W/WATCH_CORE(  749): appcore-watch.c: __widget_resume(1012) > widget_resume
05-29 20:11:38.525+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppResume(721) > 
05-29 20:11:38.525+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:38.525+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:38.530+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:11:38.530+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3001
05-29 20:11:38.535+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:11:38.535+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 20:11:38.535+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:11:38.540+0900 I/watchface-viewer(  749): viewer-part-resource.cpp: ThreadCancelCallback(2194) > thread[0x476cd698]
05-29 20:11:38.550+0900 I/CAPI_WIDGET_APPLICATION(  785): widget_app.c: __provider_resume_cb(314) > widget obj was resumed
05-29 20:11:38.555+0900 I/CAPI_WIDGET_APPLICATION(  785): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
05-29 20:11:38.575+0900 I/CAPI_WIDGET_APPLICATION(  785): widget_app.c: __provider_pause_cb(296) > widget obj was paused
05-29 20:11:38.580+0900 I/CAPI_WIDGET_APPLICATION(  785): widget_app.c: __check_status_for_cgroup(145) > enter background group
05-29 20:11:38.585+0900 W/wnotib  (  725): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-29 20:11:38.585+0900 I/efl-extension(  725): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c93d70 : elm_scroller] CurrentPage(0)
05-29 20:11:38.590+0900 W/MUSIC_CONTROL_SERVICE( 1034): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1034]   [MUSIC_PLAYER_EVENT][0m
05-29 20:11:38.590+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 20:11:38.590+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 20:11:38.590+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 20:11:38.590+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-29 20:11:38.590+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-29 20:11:38.590+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 20:11:38.590+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-29 20:11:38.590+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 20:11:38.595+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 20:11:38.595+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 20:11:38.595+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 20:11:38.595+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-29 20:11:38.595+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-29 20:11:38.595+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 20:11:38.595+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-29 20:11:38.595+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-29 20:11:38.595+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-29 20:11:38.595+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 20:11:38.600+0900 W/MUSIC_CONTROL_SERVICE( 1034): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1034]   [MUSIC_PLAYER_EVENT][0m
05-29 20:11:38.600+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 20:11:38.600+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 20:11:38.600+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 20:11:38.600+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-29 20:11:38.600+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-29 20:11:38.600+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 20:11:38.600+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-29 20:11:38.600+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 20:11:38.605+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 20:11:38.605+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 20:11:38.605+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 20:11:38.605+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-29 20:11:38.605+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-29 20:11:38.605+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 20:11:38.605+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-29 20:11:38.605+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-29 20:11:38.605+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-29 20:11:38.605+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 20:11:38.615+0900 W/WATCH_CORE(  749): appcore-watch.c: __widget_pause(1001) > widget_pause
05-29 20:11:38.615+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppPause(713) > 
05-29 20:11:38.615+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:11:38.615+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:11:38.615+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:11:38.615+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:11:38.615+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:11:38.615+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:11:38.625+0900 W/W_HOME  (  725): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
05-29 20:11:38.625+0900 E/W_HOME  (  725): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-29 20:11:38.625+0900 W/W_HOME  (  725): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
05-29 20:11:38.625+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 20:11:38.625+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 20:11:38.625+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 20:11:38.625+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-29 20:11:38.625+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-29 20:11:38.625+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 20:11:38.625+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-29 20:11:38.625+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 20:11:38.630+0900 E/W_HOME  (  725): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-29 20:11:38.630+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 20:11:38.630+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 20:11:38.630+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 20:11:38.630+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-29 20:11:38.630+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-29 20:11:38.630+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 20:11:38.630+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-29 20:11:38.630+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-29 20:11:38.630+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-29 20:11:38.630+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 20:11:38.710+0900 W/W_HOME  (  725): event_manager.c: _home_scroll_cb(564) > scroll,done
05-29 20:11:39.135+0900 I/efl-extension(  725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:11:39.135+0900 I/efl-extension(  725): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45c962f0, elm_box, time_stamp : 729768
05-29 20:11:39.135+0900 I/wnotib  (  725): w-notification-board-broker-main.c: _wnotib_rotary_cb(568) > Pass rotary event to home.
05-29 20:11:39.135+0900 I/efl-extension( 1366): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:11:39.140+0900 I/efl-extension( 1196): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:11:39.145+0900 W/W_HOME  (  725): home_navigation.c: _is_rightedge(188) > (0 360) not right edge: 0 0 0x49bb29a0 -> 360 0 0x45ce3b20
05-29 20:11:39.150+0900 I/efl-extension(  725): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0x45c93d70 : elm_scroller] rotary callabck is called.
05-29 20:11:39.150+0900 I/efl-extension(  725): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0x45c93d70 : elm_scroller] block(2)
05-29 20:11:39.150+0900 I/efl-extension(  725): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0x45c93d70 : elm_scroller] scroll_locked_x(0), scroll_locked_y(0)
05-29 20:11:39.150+0900 I/efl-extension(  725): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0x45c93d70 : elm_scroller] content size (w, h)(4320, 360)
05-29 20:11:39.150+0900 I/efl-extension(  725): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0x45c93d70 : elm_scroller] viewport size (w, h)(360, 360)
05-29 20:11:39.150+0900 I/efl-extension(  725): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0x45c93d70 : elm_scroller] CurrentPage(0) DetentCount(1)
05-29 20:11:39.150+0900 I/efl-extension(  725): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93d70 : elm_scroller] mx(3960), my(0), minx(0), miny(0), px(0), py(0)
05-29 20:11:39.150+0900 I/efl-extension(  725): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93d70 : elm_scroller] mx(3960), my(0), minx(0), miny(0), px(0), py(0)
05-29 20:11:39.150+0900 I/efl-extension(  725): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93d70 : elm_scroller] mx(3960), my(0), minx(0), miny(0), px(0), py(0)
05-29 20:11:39.150+0900 I/efl-extension(  725): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93d70 : elm_scroller] mx(3960), my(0), minx(0), miny(0), px(0), py(0)
05-29 20:11:39.150+0900 I/efl-extension(  725): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0x45c93d70 : elm_scroller] bring in 1 page
05-29 20:11:39.150+0900 W/W_HOME  (  725): event_manager.c: _home_scroll_cb(564) > scroll,start
05-29 20:11:39.160+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-29 20:11:39.160+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 20:11:39.160+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(581) > 0
05-29 20:11:39.160+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(591) > select index:1
05-29 20:11:39.175+0900 W/WATCH_CORE(  749): appcore-watch.c: __widget_resume(1012) > widget_resume
05-29 20:11:39.175+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-29 20:11:39.175+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 20:11:39.175+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(581) > 0
05-29 20:11:39.175+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(591) > select index:1
05-29 20:11:39.175+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppResume(721) > 
05-29 20:11:39.175+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:39.175+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:39.195+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-29 20:11:39.195+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 20:11:39.195+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(581) > 0
05-29 20:11:39.195+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(591) > select index:1
05-29 20:11:39.200+0900 W/W_HOME  (  725): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
05-29 20:11:39.210+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-29 20:11:39.210+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 20:11:39.210+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(581) > 0
05-29 20:11:39.210+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(591) > select index:1
05-29 20:11:39.225+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-29 20:11:39.225+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 20:11:39.230+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(581) > 0
05-29 20:11:39.230+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(591) > select index:1
05-29 20:11:39.245+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-29 20:11:39.245+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 20:11:39.250+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(581) > 0
05-29 20:11:39.250+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(591) > select index:1
05-29 20:11:39.260+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-29 20:11:39.260+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 20:11:39.260+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(581) > 0
05-29 20:11:39.260+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(591) > select index:1
05-29 20:11:39.275+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-29 20:11:39.275+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 20:11:39.275+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(581) > 0
05-29 20:11:39.280+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(591) > select index:1
05-29 20:11:39.295+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-29 20:11:39.295+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 20:11:39.295+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(581) > 0
05-29 20:11:39.295+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(591) > select index:1
05-29 20:11:39.315+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-29 20:11:39.315+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 20:11:39.315+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(581) > 0
05-29 20:11:39.315+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(591) > select index:1
05-29 20:11:39.330+0900 W/W_HOME  (  725): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
05-29 20:11:39.330+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:11:39.330+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-29 20:11:39.330+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 20:11:39.330+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(581) > 0
05-29 20:11:39.330+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(591) > select index:1
05-29 20:11:39.335+0900 W/GESTURE (  135): gesture.c: BackGestureSetProperty(4469) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
05-29 20:11:39.345+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:39.345+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:39.355+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-29 20:11:39.355+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 20:11:39.355+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(581) > 0
05-29 20:11:39.355+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(591) > select index:1
05-29 20:11:39.370+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-29 20:11:39.370+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 20:11:39.370+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(581) > 0
05-29 20:11:39.370+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(591) > select index:1
05-29 20:11:39.385+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-29 20:11:39.385+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 20:11:39.390+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(581) > 0
05-29 20:11:39.390+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(591) > select index:1
05-29 20:11:39.400+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-29 20:11:39.400+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 20:11:39.400+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(581) > 0
05-29 20:11:39.400+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_select(591) > select index:1
05-29 20:11:39.420+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-29 20:11:39.420+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 20:11:39.425+0900 W/wnotib  (  725): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-29 20:11:39.425+0900 I/efl-extension(  725): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c93d70 : elm_scroller] CurrentPage(1)
05-29 20:11:39.500+0900 E/RESOURCED( 1097): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:11:39.500+0900 E/AUL     ( 1097): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-29 20:11:39.500+0900 E/CAPI_APPFW_APP_MANAGER( 1097): app_manager.c: app_manager_error(78) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
05-29 20:11:39.520+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:39.520+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:39.570+0900 W/W_HOME  (  725): event_manager.c: _home_scroll_cb(564) > scroll,done
05-29 20:11:39.695+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:39.695+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:39.860+0900 I/AUL_PAD ( 3122): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 20:11:39.875+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:39.880+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:39.925+0900 W/W_HOME  (  725): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
05-29 20:11:40.065+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:40.065+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:40.255+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:40.255+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:40.445+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:40.445+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:40.640+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:40.640+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:40.835+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:40.835+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:41.030+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:41.030+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:41.230+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:41.230+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:41.425+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:41.425+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:41.520+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: MEM_FLUSH State: PAUSED
05-29 20:11:41.625+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:41.625+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:41.825+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:41.825+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:42.020+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:42.020+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:42.220+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:42.220+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:42.325+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:11:42.370+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 20:11:42.375+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 26
05-29 20:11:42.410+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
05-29 20:11:42.420+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:42.420+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:42.435+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
05-29 20:11:42.435+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 20:11:42.435+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1702) > caller pid : 488
05-29 20:11:42.450+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2080) > pad pid(-5)
05-29 20:11:42.450+0900 W/AUL_PAD ( 1191): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-29 20:11:42.455+0900 W/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(272) > Check app launching
05-29 20:11:42.460+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-29 20:11:42.460+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 20:11:42.500+0900 I/efl-extension( 3122): efl_extension.c: eext_mod_init(40) > Init
05-29 20:11:42.500+0900 I/CAPI_APPFW_APPLICATION( 3122): app_main.c: ui_app_main(704) > app_efl_main
05-29 20:11:42.515+0900 I/CAPI_APPFW_APPLICATION( 3122): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-29 20:11:42.610+0900 E/TBM     ( 3122): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 20:11:42.615+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:42.615+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:42.665+0900 E/E17     (  379): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04600002)
05-29 20:11:42.685+0900 E/EFL     ( 3122): ecore_evas<3122> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-29 20:11:42.700+0900 W/W_HOME  (  725): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-29 20:11:42.700+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:11:42.700+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:11:42.705+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:11:42.705+0900 W/W_HOME  (  725): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-29 20:11:42.710+0900 W/GESTURE (  135): gesture.c: BackGestureSetProperty(4474) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
05-29 20:11:42.755+0900 I/MALI    (  725): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-29 20:11:42.780+0900 I/efl-extension( 3122): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0x41872b90]'s widget[0x418852b8] to elm_conformant widget[0x414ea868]
05-29 20:11:42.815+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:42.815+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:42.875+0900 I/HAP     ( 3122): SUCCESSFULLY create sap agent
05-29 20:11:42.880+0900 I/HAP     ( 3122): connectivity type(1): bt
05-29 20:11:43.010+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:43.010+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:43.090+0900 I/HAP     ( 3122): agent is initialized
05-29 20:11:43.090+0900 I/HAP     ( 3122): agent initialized callback is over
05-29 20:11:43.090+0900 I/HAP     ( 3122): SAP >>> getRegisteredServiceAgent() >>> 0
05-29 20:11:43.200+0900 I/APP_CORE( 3122): appcore-efl.c: __do_app(429) > [APP 3122] Event: RESET State: CREATED
05-29 20:11:43.200+0900 I/CAPI_APPFW_APPLICATION( 3122): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 20:11:43.210+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:43.210+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:43.225+0900 I/APP_CORE( 3122): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 20:11:43.225+0900 I/APP_CORE( 3122): appcore-efl.c: __do_app(474) > [APP 3122] Initial Launching, call the resume_cb
05-29 20:11:43.230+0900 I/CAPI_APPFW_APPLICATION( 3122): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 20:11:43.240+0900 W/APP_CORE( 3122): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4600002
05-29 20:11:43.250+0900 I/efl-extension( 3122): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x41872b90 = w: 0 h: 0  obj 0x418852b8 w: 360 h: 360
05-29 20:11:43.250+0900 I/efl-extension( 3122): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 20:11:43.355+0900 W/W_HOME  (  725): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-29 20:11:43.355+0900 W/W_HOME  (  725): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-29 20:11:43.355+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:11:43.355+0900 W/W_HOME  (  725): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-29 20:11:43.355+0900 I/APP_CORE(  725): appcore-efl.c: __do_app(429) > [APP 725] Event: PAUSE State: RUNNING
05-29 20:11:43.355+0900 I/CAPI_APPFW_APPLICATION(  725): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 20:11:43.355+0900 W/W_HOME  (  725): main.c: _appcore_pause_cb(690) > appcore pause
05-29 20:11:43.355+0900 W/W_HOME  (  725): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-29 20:11:43.355+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:11:43.355+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:11:43.355+0900 W/W_HOME  (  725): main.c: home_pause(751) > clock/widget paused
05-29 20:11:43.355+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:11:43.355+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 20:11:43.355+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 20:11:43.355+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 20:11:43.355+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-29 20:11:43.355+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-29 20:11:43.355+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 20:11:43.355+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-29 20:11:43.355+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 20:11:43.370+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 20:11:43.370+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 20:11:43.370+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 20:11:43.370+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-29 20:11:43.370+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-29 20:11:43.370+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 20:11:43.370+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-29 20:11:43.370+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-29 20:11:43.370+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-29 20:11:43.370+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 20:11:43.370+0900 E/CAPI_APPFW_APP_CONTROL( 1034): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-29 20:11:43.370+0900 W/MUSIC_CONTROL_SERVICE( 1034): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1034]   [com.samsung.w-home]register msg port [false][0m
05-29 20:11:43.410+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:43.410+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:43.425+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:11:43.425+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 20:11:43.490+0900 I/APP_CORE( 3122): appcore-efl.c: __do_app(429) > [APP 3122] Event: RESUME State: RUNNING
05-29 20:11:43.505+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:11:43.515+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3122
05-29 20:11:43.555+0900 I/wnotib  (  725): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-29 20:11:43.555+0900 E/wnotib  (  725): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 20:11:43.575+0900 W/WATCH_CORE(  749): appcore-watch.c: __widget_pause(1001) > widget_pause
05-29 20:11:43.575+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppPause(713) > 
05-29 20:11:43.575+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:11:43.575+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:11:43.575+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:11:43.575+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:11:43.575+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:11:43.575+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:11:43.610+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:11:43.625+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3122
05-29 20:11:43.625+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 20:11:43.740+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:11:43.855+0900 I/AUL_PAD ( 3129): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 20:11:43.880+0900 I/APP_CORE(  725): appcore-efl.c: __do_app(429) > [APP 725] Event: MEM_FLUSH State: PAUSED
05-29 20:11:48.385+0900 I/APP_CORE(  725): appcore-efl.c: __do_app(429) > [APP 725] Event: MEM_FLUSH State: PAUSED
05-29 20:11:48.520+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:11:48.595+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3122
05-29 20:11:50.280+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 20:11:50.285+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 20:11:50.310+0900 I/RESOURCED(  498): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
05-29 20:11:51.860+0900 I/HAP     ( 3122): routes length: 21
05-29 20:11:52.335+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:11:52.335+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 20:11:52.425+0900 W/PROCESSMGR(  379): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-29 20:11:52.430+0900 W/W_HOME  (  725): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-29 20:11:52.430+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:11:52.430+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:11:52.430+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:11:52.430+0900 W/W_HOME  (  725): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-29 20:11:52.485+0900 W/W_HOME  (  725): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-29 20:11:52.485+0900 W/W_HOME  (  725): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-29 20:11:52.485+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:11:52.485+0900 W/W_HOME  (  725): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-29 20:11:52.505+0900 I/APP_CORE(  725): appcore-efl.c: __do_app(429) > [APP 725] Event: RESUME State: PAUSED
05-29 20:11:52.505+0900 I/CAPI_APPFW_APPLICATION(  725): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-29 20:11:52.505+0900 W/W_HOME  (  725): main.c: _appcore_resume_cb(681) > appcore resume
05-29 20:11:52.505+0900 W/W_HOME  (  725): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-29 20:11:52.505+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:11:52.520+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:11:52.520+0900 W/W_HOME  (  725): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
05-29 20:11:52.520+0900 W/W_HOME  (  725): main.c: home_resume(733) > clock/widget resumed
05-29 20:11:52.520+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:11:52.520+0900 I/wnotib  (  725): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-29 20:11:52.520+0900 E/wnotib  (  725): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 20:11:52.520+0900 W/wnotib  (  725): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-29 20:11:52.525+0900 W/GESTURE (  135): gesture.c: BackGestureSetProperty(4469) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
05-29 20:11:52.535+0900 W/WATCH_CORE(  749): appcore-watch.c: __widget_resume(1012) > widget_resume
05-29 20:11:52.535+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppResume(721) > 
05-29 20:11:52.535+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:52.535+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:52.575+0900 W/WATCH_CORE(  749): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-29 20:11:52.575+0900 I/WATCH_CORE(  749): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-29 20:11:52.575+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:11:52.575+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:11:52.585+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3122
05-29 20:11:52.680+0900 W/CRASH_MANAGER( 3148): worker.c: worker_job(1199) > 1103122686170146452031
