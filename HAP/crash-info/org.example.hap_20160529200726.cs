S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.5
Build-Number: R732XXU2CPC5
Build-Date: 2016.03.21 17:05:24

Crash Information
Process Name: hap
PID: 2008
Date: 2016-05-29 20:07:26+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x10

Register Information
r0   = 0x00000010, r1   = 0x00000010
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0x414624ea
r6   = 0xbea34930, r7   = 0x00000010
r8   = 0x00000020, r9   = 0x4142dec0
r10  = 0x414624cb, fp   = 0xbea34924
ip   = 0x00000000, sp   = 0xbea343c0
lr   = 0x404b45b8, pc   = 0x404e7dc4
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     13156 KB
Buffers:     14024 KB
Cached:     164364 KB
VmPeak:      63116 KB
VmSize:      62604 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16736 KB
VmRSS:       16736 KB
VmData:      31996 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20056 KB
VmPTE:          46 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 2008 TID = 2008
2008 2161 

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
417d6000 417de000 r-xp /usr/lib/libsap_client.so.0.0.0
417e6000 417f4000 r-xp /usr/lib/libGLESv2.so.2.0
417fd000 417fe000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41807000 4180d000 r-xp /usr/lib/libxcb-render.so.0.0.0
41815000 41818000 r-xp /usr/lib/libEGL.so.1.4
41820000 4182b000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
41834000 41838000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41849000 41851000 r-xp /usr/lib/libdrm.so.2.4.0
41859000 41860000 r-xp /usr/lib/libtbm.so.1.0.0
41868000 4186a000 r-xp /usr/lib/libdri2.so.0.0.0
41872000 41889000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
41896000 41898000 rw-p [heap]
41898000 419ca000 rw-p [heap]
419ca000 41a82000 r-xp /usr/lib/libcairo.so.2.11200.14
41a8d000 41b57000 r-xp /usr/lib/libCOREGL.so.4.0
41f9a000 41f9c000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
431c0000 439bf000 rwxp [stack:2161]
bea15000 bea36000 rwxp [stack]
End of Maps Information

Callstack Information (PID:2008)
Call Stack Count: 1
 0: strlen + 0x4 (0x404e7dc4) [/lib/libc.so.6] + 0x72dc4
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
 I/HAP     ( 2009): description: 10시 방향 좌회전 후 권광로348번길 을 따라 79m 이동 , lat: 37.27763096998274,lon: 127.03918752379786
05-29 20:06:09.285+0900 I/HAP     ( 2009): lat: 37.277631
05-29 20:06:09.285+0900 I/HAP     ( 2009): description: UBF수원 에서 좌회전 후 중부대로223번길 을 따라 14m 이동 , lat: 37.27902250807859,lon: 127.04101509678411
05-29 20:06:09.285+0900 I/HAP     ( 2009): lat: 37.279023
05-29 20:06:09.285+0900 I/HAP     ( 2009): description: 도착, lat: 37.279150270457,lon: 127.04098176289973
05-29 20:06:09.285+0900 I/HAP     ( 2009): lat: 37.279150
05-29 20:06:09.670+0900 W/CRASH_MANAGER( 2055): worker.c: worker_job(1199) > 11020096861701464519969
05-29 20:06:09.735+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:06:09.745+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 20:06:09.755+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 4
05-29 20:06:09.760+0900 E/AUL     (  495): app_sock.c: __connect_client_sock(196) > connect error: 111
05-29 20:06:09.760+0900 E/AUL     (  495): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
05-29 20:06:09.790+0900 E/AUL     (  495): app_sock.c: __connect_client_sock(196) > connect error: 111
05-29 20:06:09.790+0900 E/AUL     (  495): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
05-29 20:06:09.885+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: RESUME State: PAUSED
05-29 20:06:09.885+0900 I/CAPI_APPFW_APPLICATION( 1921): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 20:06:10.090+0900 E/AUL     (  495): app_sock.c: __connect_client_sock(196) > connect error: 111
05-29 20:06:10.090+0900 E/AUL     (  495): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
05-29 20:06:10.095+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:06:10.095+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 20:06:10.790+0900 W/WATCH_CORE(  749): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-29 20:06:10.790+0900 W/W_HOME  (  725): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-29 20:06:10.790+0900 W/W_HOME  (  725): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 20:06:10.790+0900 W/W_HOME  (  725): gesture.c: _manual_render_enable(133) > 1
05-29 20:06:10.790+0900 W/W_HOME  (  725): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-29 20:06:10.790+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:06:10.795+0900 W/STARTER (  692): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
05-29 20:06:10.795+0900 W/STARTER (  692): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-29 20:06:10.795+0900 E/STARTER (  692): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-29 20:06:10.795+0900 W/STARTER (  692): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-29 20:06:10.795+0900 W/STARTER (  692): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-29 20:06:10.805+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-29 20:06:10.805+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-29 20:06:10.805+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-29 20:06:10.810+0900 I/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-29 20:06:10.915+0900 I/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-29 20:06:10.915+0900 W/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-29 20:06:10.915+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-29 20:06:10.915+0900 I/HIGEAR  ( 1081): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-29 20:06:10.945+0900 I/watchface-viewer(  749): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
05-29 20:06:10.945+0900 I/SHealth_Common( 1097): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-29 20:06:10.945+0900 I/SHealth_Service( 1097): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-29 20:06:10.945+0900 W/MUSIC_CONTROL_SERVICE( 1034): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1034]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-29 20:06:10.955+0900 W/STARTER (  692): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
05-29 20:06:10.955+0900 W/STARTER (  692): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-29 20:06:10.955+0900 W/STARTER (  692): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-29 20:06:10.955+0900 W/STARTER (  692): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-29 20:06:10.965+0900 E/ALARM_MANAGER(  692): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(29-5-2016, 20:06:31), repeat(1), interval(20), type(-1073741822)
05-29 20:06:10.970+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: PAUSE State: RUNNING
05-29 20:06:10.970+0900 I/CAPI_APPFW_APPLICATION( 1921): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 20:06:10.975+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:06:10.975+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:06:11.020+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1633869501, next duetime: 1464519991
05-29 20:06:11.020+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1633869501)
05-29 20:06:11.020+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464519991)
05-29 20:06:11.020+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:06:11.020+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 11:06:31 (UTC).
05-29 20:06:11.020+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:06:15.980+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: MEM_FLUSH State: PAUSED
05-29 20:06:28.650+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:06:28.655+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:06:28.660+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(620819680)
05-29 20:06:28.660+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:06:28.670+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 11:06:31 (UTC).
05-29 20:06:28.670+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:06:28.670+0900 E/ALARM_MANAGER(  487): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[620819680] is removed.
05-29 20:06:28.700+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:06:28.710+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:06:28.740+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:06:28.760+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:06:28.790+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:06:28.805+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:06:28.805+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-29 20:06:28.805+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-29 20:06:28.825+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:06:28.835+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:06:28.835+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464519992, Sun May 29 20:06:32 2016
05-29 20:06:28.835+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1828802017, next duetime: 1464519992
05-29 20:06:28.835+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1828802017)
05-29 20:06:28.835+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464519991), due_time(1464519992)
05-29 20:06:28.835+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:06:28.835+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 11:06:31 (UTC).
05-29 20:06:28.835+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:06:28.845+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:06:28.845+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:06:28.845+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1828802017)
05-29 20:06:28.845+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:06:28.845+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 11:06:31 (UTC).
05-29 20:06:28.845+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:06:28.845+0900 E/ALARM_MANAGER(  487): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[1828802017] is removed.
05-29 20:06:28.855+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:06:28.855+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:06:28.865+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:06:28.875+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:06:28.890+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:06:28.900+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:06:28.900+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-29 20:06:28.900+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-29 20:06:28.910+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:06:28.920+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:06:28.925+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464563188, Mon May 30 08:06:28 2016
05-29 20:06:28.925+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1828802017, next duetime: 1464563188
05-29 20:06:28.925+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1828802017)
05-29 20:06:28.925+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464519991), due_time(1464563188)
05-29 20:06:28.925+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:06:28.925+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 11:06:31 (UTC).
05-29 20:06:28.925+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:06:30.995+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_handler_idle(1360) > Lock the display not to enter LCD OFF
05-29 20:06:31.055+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __display_lock_state(1692) > Lock LCD OFF is successfully done
05-29 20:06:31.120+0900 E/RESOURCED(  498): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 692
05-29 20:06:31.135+0900 E/ALARM_MANAGER(  692): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [1633869501]
05-29 20:06:31.135+0900 W/STARTER (  692): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(927) > [__starter_clock_mgr_homescreen_alarm_cb:927] homescreen alarm timer expired [1633869501]
05-29 20:06:31.150+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 20:06:31.155+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1702) > caller pid : 692
05-29 20:06:31.165+0900 W/AUL_AMD (  495): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 725
05-29 20:06:31.170+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(916) > listen fd(20) , send fd(13), pid(725), cmd(0)
05-29 20:06:31.170+0900 I/APP_CORE(  725): appcore-efl.c: __do_app(429) > [APP 725] Event: RESET State: PAUSED
05-29 20:06:31.170+0900 I/CAPI_APPFW_APPLICATION(  725): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-29 20:06:31.170+0900 W/W_HOME  (  725): main.c: _app_control(1726) > Service value : show_clock
05-29 20:06:31.170+0900 W/W_HOME  (  725): main.c: _app_control(1762) > Show clock operation
05-29 20:06:31.170+0900 W/W_HOME  (  725): gesture.c: _clock_show(228) > clock show
05-29 20:06:31.205+0900 W/W_HOME  (  725): gesture.c: _clock_show(243) > home raise
05-29 20:06:31.205+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_expired(1322) > alarm_id[1633869501] is expired.
05-29 20:06:31.205+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1633869501, next duetime: 1464520011
05-29 20:06:31.210+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:06:31.210+0900 E/W_HOME  (  725): gesture.c: gesture_win_aux_set(396) > wm.policy.win.do.not.use.deiconify.approve:-1
05-29 20:06:31.210+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 11:06:51 (UTC).
05-29 20:06:31.210+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:06:31.210+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_handler_idle(1386) > Unlock the display from LCD OFF
05-29 20:06:31.215+0900 W/W_HOME  (  725): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
05-29 20:06:31.215+0900 W/W_HOME  (  725): gesture.c: _clock_show(246) > home raise done
05-29 20:06:31.215+0900 W/W_HOME  (  725): gesture.c: _clock_show(253) > show clock
05-29 20:06:31.215+0900 W/W_HOME  (  725): scroller.c: _get_index_in_list(1913) > page:0x45ce3b20 idx:2 total12 exist:1
05-29 20:06:31.225+0900 E/EFL     (  725): elementary<725> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c93d70), origin_x(0), origin_y(0)
05-29 20:06:31.240+0900 W/W_HOME  (  725): gesture.c: _widget_updated_cb(190) > widget updated
05-29 20:06:31.245+0900 W/W_HOME  (  725): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 20:06:31.245+0900 W/W_HOME  (  725): gesture.c: _manual_render(176) > 
05-29 20:06:31.250+0900 I/efl-extension( 1366): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
05-29 20:06:31.250+0900 W/wnotibp ( 1366): wnotiboard-popup-view.c: _wnotibp_event_home_raise_cb(1735) > [0, 2, 1]
05-29 20:06:31.270+0900 E/E17     (  379): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x02600003)
05-29 20:06:31.275+0900 I/MALI    (  725): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-29 20:06:31.280+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:06:31.280+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 20:06:31.280+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __display_unlock_state(1735) > Unlock LCD OFF is successfully done
05-29 20:06:31.280+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:06:31.285+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:06:31.285+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1633869501)
05-29 20:06:31.285+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:06:31.285+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 20:06:31.285+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:06:31.290+0900 E/ALARM_MANAGER(  487): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[1633869501] is removed.
05-29 20:06:31.320+0900 W/W_HOME  (  725): gesture.c: _manual_render(176) > 
05-29 20:06:31.330+0900 W/W_HOME  (  725): gesture.c: _manual_render_enable(133) > 0
05-29 20:06:31.330+0900 W/W_HOME  (  725): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
05-29 20:06:31.330+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:06:31.340+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-29 20:06:31.340+0900 I/ELM_RPANEL(  725): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 20:06:31.340+0900 I/APP_CORE(  725): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
05-29 20:06:31.360+0900 W/W_HOME  (  725): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-29 20:06:31.360+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:06:31.360+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:06:31.365+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:06:31.365+0900 W/W_HOME  (  725): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-29 20:06:31.395+0900 W/W_HOME  (  725): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-29 20:06:31.395+0900 W/W_HOME  (  725): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-29 20:06:31.395+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:06:31.395+0900 W/W_HOME  (  725): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-29 20:06:31.395+0900 I/APP_CORE(  725): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
05-29 20:06:31.395+0900 I/wnotib  (  725): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-29 20:06:31.395+0900 E/wnotib  (  725): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 20:06:31.395+0900 W/wnotib  (  725): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-29 20:06:31.400+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: PAUSE State: PAUSED
05-29 20:06:31.400+0900 I/APP_CORE( 1921): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
05-29 20:06:31.430+0900 I/MALI    (  725): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-29 20:06:40.155+0900 E/wnoti-service(  865): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(850)
05-29 20:06:40.155+0900 E/wnoti-service(  865): wnoti-sap-client.c: _parse_received_noti(2311) > application_id : 207
05-29 20:06:40.165+0900 E/wnoti-service(  865): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
05-29 20:06:40.185+0900 E/wnoti-service(  865): wnoti-db-server.c: insert_panel_asset(3442) > [panel noti, cache image]attr_type : 18, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/118
05-29 20:06:40.190+0900 E/wnoti-service(  865): wnoti-db-server.c: insert_panel_asset(3442) > [panel noti, cache image]attr_type : 19, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/99
05-29 20:06:40.190+0900 E/wnoti-service(  865): wnoti-json-parser.c: wnoti_parse_android_wear_action(536) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/117
05-29 20:06:40.195+0900 E/wnoti-service(  865): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 0
05-29 20:06:40.195+0900 E/wnoti-service(  865): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 142
05-29 20:06:40.210+0900 E/wnoti-service(  865): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/118
05-29 20:06:40.210+0900 E/wnoti-service(  865): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/99
05-29 20:06:40.215+0900 E/wnoti-service(  865): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/117
05-29 20:06:40.215+0900 E/wnoti-service(  865): wnoti-db-server.c: check_asset_images(3976) > summary_bg_image : /opt/usr/data/wnoti/.crop_106.png
05-29 20:06:40.250+0900 E/wnoti-service(  865): wnoti-db-server.c: wnoti_is_check_notification_update(4453) > 5/229505
05-29 20:06:40.250+0900 E/wnoti-service(  865): wnoti-sap-client.c: _add_exception_handling(581) > type : 5, application_id : 207
05-29 20:06:40.255+0900 E/wnoti-service(  865): wnoti-sap-client.c: publish_received_noti(1839) > application status : 0
05-29 20:06:40.255+0900 E/wnoti-service(  865): wnoti-sap-client.c: publish_received_noti(1848) > 5, category : 0, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 207, seq_num : 229510, noti_flag : 280, g_span_version : 1
05-29 20:06:40.255+0900 E/wnoti-service(  865): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
05-29 20:06:40.285+0900 E/wnoti-service(  865): wnoti-db-server.c: set_global_noti_count(1557) > pre_count : 1, count : 2
05-29 20:06:40.305+0900 E/wnoti-service(  865): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 0
05-29 20:06:40.785+0900 I/wnoti-service(  865): wnoti-msg-builder.c: _publish_notification(1394) > operation_type : 0, source : 0, application_id : 0, display_count : 0
05-29 20:06:40.875+0900 E/wnoti-proxy( 1366): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 1366, caller_id : 0, listener_type : 0
05-29 20:06:40.875+0900 I/wnotibp ( 1366): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1502) > Handle this change type in idler.
05-29 20:06:40.875+0900 I/wnotibp ( 1366): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(926) > ::DATA:: remove notification data, 698
05-29 20:06:40.875+0900 I/wnotibp ( 1366): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(956) > ::DATA:: CHECK DATA : 0, 0
05-29 20:06:40.900+0900 E/wnoti-proxy(  725): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 725, caller_id : 0, listener_type : 0
05-29 20:06:40.900+0900 W/wnotib  (  725): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1501) > Change type : 0, op_type: 0, category_id: 0, display count: 0
05-29 20:06:40.900+0900 I/wnotib  (  725): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1556) > Handle this change type in idler.
05-29 20:06:40.900+0900 I/wnotib  (  725): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1580) > App tray not displayed and edit mode is off.
05-29 20:06:40.900+0900 W/wnotib  (  725): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1059) > idler for type: 0
05-29 20:06:40.955+0900 I/wnoti-proxy(  725): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-29 20:06:40.955+0900 I/wnoti-proxy(  725): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-29 20:06:40.960+0900 I/wnotib  (  725): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1106) > unread_count: 1
05-29 20:06:40.965+0900 W/wnotib  (  725): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(626) > category_id: 85, application_id: 218, application_name: 카카오톡, time_stamp: 1464519788, content_id: 0, spannable_string_version: 1
05-29 20:06:40.965+0900 I/wnotib  (  725): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-29 20:06:40.970+0900 I/wnotib  (  725): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-29 20:06:40.970+0900 I/wnotib  (  725): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-29 20:06:40.975+0900 I/wnotib  (  725): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-29 20:06:40.975+0900 I/wnotib  (  725): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-29 20:06:40.975+0900 I/wnotib  (  725): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-29 20:06:40.975+0900 I/wnotib  (  725): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1106) > unread_count: 1
05-29 20:06:40.975+0900 W/wnotib  (  725): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(626) > category_id: 84, application_id: 207, application_name: Google 앱, time_stamp: 1464519951, content_id: 0, spannable_string_version: 1
05-29 20:06:40.980+0900 I/wnotib  (  725): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1343) > New noti is here. Add it on panel  84, Google 앱.
05-29 20:06:40.980+0900 I/wnotib  (  725): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 84, application_id: 207, type: 1
05-29 20:06:41.000+0900 I/wnotib  (  725): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4629) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
05-29 20:06:41.000+0900 I/wnotib  (  725): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 84, application_id: 207, type: 13
05-29 20:06:41.015+0900 I/wnotib  (  725): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 207, thumbnail path: /opt/usr/data/wnoti/.app_icon_207.jpg, width: 58, height: 58
05-29 20:06:41.035+0900 I/wnotib  (  725): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 85, application_id: 218, type: 13
05-29 20:06:41.035+0900 I/wnotib  (  725): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1378) > This noti will be removed from panel: 84, Google 앱.
05-29 20:06:41.035+0900 I/wnotib  (  725): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 84, application_id: 207, type: 2
05-29 20:06:41.035+0900 I/wnotib  (  725): w-notification-board-panel-basic.c: _wnotib_basic_panel_delete_card(2986) > We don't need to delete the item for second_depth_type: 0.
05-29 20:06:41.045+0900 E/EFL     (  725): elementary<725> elm_genlist.c:6080 elm_genlist_items_count() obj ((nil)) is NULL or type is not correct
05-29 20:06:41.045+0900 I/wnotib  (  725): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 84, application_id: 207, type: 12
05-29 20:06:41.045+0900 I/wnotib  (  725): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 207, thumbnail path: /opt/usr/data/wnoti/.app_icon_207.jpg, width: 58, height: 58
05-29 20:06:41.050+0900 I/wnotib  (  725): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 85, application_id: 218, type: 12
05-29 20:06:41.050+0900 W/wnotib  (  725): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1387) > Num categories: 2, num total noti: 2
05-29 20:06:41.050+0900 I/wnotib  (  725): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(871) > Free noti manager data.
05-29 20:06:41.055+0900 I/wnotib  (  725): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(876) > Free previous notifications.
05-29 20:06:41.055+0900 I/wnotib  (  725): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(897) > Free previous categories.
05-29 20:06:41.055+0900 I/wnotib  (  725): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
05-29 20:06:41.055+0900 I/wnotib  (  725): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 2, setting_power_saving_mode: 0, show_summary_board: 0
05-29 20:06:41.055+0900 I/wnotib  (  725): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
05-29 20:06:41.055+0900 I/wnotib  (  725): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1412) > num_total_panel: 2.
05-29 20:06:41.060+0900 W/W_HOME  (  725): noti_broker.c: _handler_indicator_update(562) > 0x2
05-29 20:06:41.105+0900 W/wnotib  (  725): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1416) > unread_count_for_home: 1
05-29 20:06:41.105+0900 W/W_HOME  (  725): noti_broker.c: _handler_noti_indicator_show(478) > 
05-29 20:06:50.280+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 20:06:50.285+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 20:07:07.870+0900 E/SHealth_Common( 1097): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-29 20:07:11.590+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:07:11.640+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 20:07:11.645+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 26
05-29 20:07:11.685+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
05-29 20:07:11.705+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
05-29 20:07:11.705+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 20:07:11.705+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1702) > caller pid : 488
05-29 20:07:11.735+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-29 20:07:11.735+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 20:07:11.740+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2080) > pad pid(-5)
05-29 20:07:11.745+0900 W/AUL_PAD ( 1191): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-29 20:07:11.745+0900 W/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(272) > Check app launching
05-29 20:07:11.800+0900 I/efl-extension( 2008): efl_extension.c: eext_mod_init(40) > Init
05-29 20:07:11.805+0900 I/CAPI_APPFW_APPLICATION( 2008): app_main.c: ui_app_main(704) > app_efl_main
05-29 20:07:11.815+0900 I/CAPI_APPFW_APPLICATION( 2008): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-29 20:07:11.890+0900 E/TBM     ( 2008): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 20:07:11.925+0900 E/E17     (  379): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05c00002)
05-29 20:07:11.935+0900 E/EFL     ( 2008): ecore_evas<2008> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-29 20:07:11.965+0900 W/W_HOME  (  725): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-29 20:07:11.965+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:07:11.965+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:07:11.965+0900 I/efl-extension( 2008): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0x41eaaf00]'s widget[0x419c1268] to elm_conformant widget[0x41992000]
05-29 20:07:11.970+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:07:11.970+0900 W/W_HOME  (  725): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-29 20:07:12.050+0900 I/HAP     ( 2008): SUCCESSFULLY create sap agent
05-29 20:07:12.050+0900 I/HAP     ( 2008): connectivity type(1): bt
05-29 20:07:12.220+0900 I/HAP     ( 2008): agent is initialized
05-29 20:07:12.220+0900 I/HAP     ( 2008): agent initialized callback is over
05-29 20:07:12.220+0900 I/HAP     ( 2008): SAP >>> getRegisteredServiceAgent() >>> 0
05-29 20:07:12.305+0900 I/APP_CORE( 2008): appcore-efl.c: __do_app(429) > [APP 2008] Event: RESET State: CREATED
05-29 20:07:12.305+0900 I/CAPI_APPFW_APPLICATION( 2008): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 20:07:12.325+0900 I/APP_CORE( 2008): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 20:07:12.325+0900 I/APP_CORE( 2008): appcore-efl.c: __do_app(474) > [APP 2008] Initial Launching, call the resume_cb
05-29 20:07:12.325+0900 I/CAPI_APPFW_APPLICATION( 2008): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 20:07:12.330+0900 W/APP_CORE( 2008): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5c00002
05-29 20:07:12.340+0900 I/efl-extension( 2008): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x41eaaf00 = w: 0 h: 0  obj 0x419c1268 w: 360 h: 360
05-29 20:07:12.340+0900 I/efl-extension( 2008): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 20:07:12.415+0900 W/W_HOME  (  725): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-29 20:07:12.415+0900 W/W_HOME  (  725): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-29 20:07:12.415+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:07:12.415+0900 W/W_HOME  (  725): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-29 20:07:12.420+0900 I/APP_CORE(  725): appcore-efl.c: __do_app(429) > [APP 725] Event: PAUSE State: RUNNING
05-29 20:07:12.420+0900 I/CAPI_APPFW_APPLICATION(  725): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 20:07:12.420+0900 W/W_HOME  (  725): main.c: _appcore_pause_cb(690) > appcore pause
05-29 20:07:12.420+0900 E/W_HOME  (  725): main.c: _pause_cb(668) > paused already
05-29 20:07:12.420+0900 I/APP_CORE(  725): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
05-29 20:07:12.420+0900 I/wnotib  (  725): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-29 20:07:12.420+0900 E/wnotib  (  725): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 20:07:12.440+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:07:12.440+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 20:07:12.445+0900 I/APP_CORE( 2008): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
05-29 20:07:12.935+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:07:12.995+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:07:13.015+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2008
05-29 20:07:13.020+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 20:07:13.285+0900 I/AUL_PAD ( 2162): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 20:07:17.425+0900 I/APP_CORE(  725): appcore-efl.c: __do_app(429) > [APP 725] Event: MEM_FLUSH State: PAUSED
05-29 20:07:26.460+0900 I/HAP     ( 2008): routes length: 21
05-29 20:07:26.460+0900 I/HAP     ( 2008): description: 장다리로 을 따라 162m 이동, lat: 37.27655039833677,lon: 127.03127993829892
05-29 20:07:26.465+0900 I/HAP     ( 2008): lat: 37.276550
05-29 20:07:26.465+0900 I/HAP     ( 2008): description: 우측 횡단보도 후 보행자도로 을 따라 26m 이동 , lat: 37.27795302297102,lon: 127.03180485142347
05-29 20:07:26.465+0900 I/HAP     ( 2008): lat: 37.277953
05-29 20:07:26.470+0900 I/HAP     ( 2008): description: 직진 후 중부대로 을 따라 68m 이동 , lat: 37.27791969851095,lon: 127.03208538245273
05-29 20:07:26.470+0900 I/HAP     ( 2008): lat: 37.277920
05-29 20:07:26.470+0900 I/HAP     ( 2008): description: 횡단보도 후 보행자도로 을 따라 8m 이동 , lat: 37.277830832970096,lon: 127.03281587420162
05-29 20:07:26.470+0900 I/HAP     ( 2008): lat: 37.277831
05-29 20:07:26.470+0900 I/HAP     ( 2008): description: 직진 후 중부대로 을 따라 163m 이동 , lat: 37.27781416982219,lon: 127.03290475549065
05-29 20:07:26.470+0900 I/HAP     ( 2008): lat: 37.277814
05-29 20:07:26.470+0900 I/HAP     ( 2008): description: 횡단보도 후 보행자도로 을 따라 9m 이동 , lat: 37.27737536309203,lon: 127.03465738649457
05-29 20:07:26.470+0900 I/HAP     ( 2008): lat: 37.277375
05-29 20:07:26.470+0900 I/HAP     ( 2008): description: 직진 후 중부대로 을 따라 251m 이동 , lat: 37.27734481291254,lon: 127.03476015580091
05-29 20:07:26.470+0900 I/HAP     ( 2008): lat: 37.277345
05-29 20:07:26.470+0900 I/HAP     ( 2008): description: 좌측 횡단보도 후 5m 이동 , lat: 37.27659494818776,lon: 127.03746826436145
05-29 20:07:26.470+0900 I/HAP     ( 2008): lat: 37.276595
05-29 20:07:26.470+0900 I/HAP     ( 2008): description: 좌측 횡단보도 후 보행자도로 을 따라 27m 이동 , lat: 37.276619946035844,lon: 127.03750992654794
05-29 20:07:26.470+0900 I/HAP     ( 2008): lat: 37.276620
05-29 20:07:26.470+0900 I/HAP     ( 2008): description: 우회전 후 권광로 을 따라 7m 이동 , lat: 37.27685047671701,lon: 127.03761268854973
05-29 20:07:26.470+0900 I/HAP     ( 2008): lat: 37.276850
05-29 20:07:26.470+0900 I/HAP     ( 2008): description: 횡단보도 후 9m 이동 , lat: 37.27689213964827,lon: 127.03767379295
05-29 20:07:26.470+0900 I/HAP     ( 2008): lat: 37.276892
05-29 20:07:26.470+0900 I/HAP     ( 2008): description: 직진 후 15m 이동 , lat: 37.27686436667676,lon: 127.03776267455035
05-29 20:07:26.470+0900 I/HAP     ( 2008): lat: 37.276864
05-29 20:07:26.470+0900 I/HAP     ( 2008): description: 횡단보도 후 7m 이동 , lat: 37.27681437539752,lon: 127.03792654996703
05-29 20:07:26.470+0900 I/HAP     ( 2008): lat: 37.276814
05-29 20:07:26.470+0900 I/HAP     ( 2008): description: 좌측 횡단보도 후 보행자도로 을 따라 10m 이동 , lat: 37.27678660202898,lon: 127.03799321136158
05-29 20:07:26.470+0900 I/HAP     ( 2008): lat: 37.276787
05-29 20:07:26.470+0900 I/HAP     ( 2008): description: 좌회전 후 53m 이동 , lat: 37.27683937533004,lon: 127.038084868234
05-29 20:07:26.470+0900 I/HAP     ( 2008): lat: 37.276839
05-29 20:07:26.470+0900 I/HAP     ( 2008): description: 우회전 후 권광로 을 따라 6m 이동 , lat: 37.27730598956949,lon: 127.03817651352684
05-29 20:07:26.470+0900 I/HAP     ( 2008): lat: 37.277306
05-29 20:07:26.470+0900 I/HAP     ( 2008): description: 좌회전 후 권광로340번길 을 따라 93m 이동 , lat: 37.27733098801315,lon: 127.03825150602198
05-29 20:07:26.470+0900 I/HAP     ( 2008): lat: 37.277331
05-29 20:07:26.470+0900 I/HAP     ( 2008): description: 10시 방향 좌회전 후 권광로348번길 을 따라 79m 이동 , lat: 37.27763096998274,lon: 127.03918752379786
05-29 20:07:26.470+0900 I/HAP     ( 2008): lat: 37.277631
05-29 20:07:26.470+0900 I/HAP     ( 2008): description: UBF수원 에서 좌회전 후 중부대로223번길 을 따라 14m 이동 , lat: 37.27902250807859,lon: 127.04101509678411
05-29 20:07:26.470+0900 I/HAP     ( 2008): lat: 37.279023
05-29 20:07:26.470+0900 I/HAP     ( 2008): description: 도착, lat: 37.279150270457,lon: 127.04098176289973
05-29 20:07:26.470+0900 I/HAP     ( 2008): lat: 37.279150
05-29 20:07:26.870+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:07:26.870+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 20:07:26.890+0900 W/W_HOME  (  725): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-29 20:07:26.890+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:07:26.890+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:07:26.890+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:07:26.890+0900 W/W_HOME  (  725): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-29 20:07:26.935+0900 W/W_HOME  (  725): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-29 20:07:26.935+0900 W/W_HOME  (  725): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-29 20:07:26.935+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:07:26.935+0900 W/W_HOME  (  725): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-29 20:07:26.935+0900 I/APP_CORE(  725): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
05-29 20:07:26.935+0900 I/wnotib  (  725): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-29 20:07:26.935+0900 E/wnotib  (  725): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 20:07:26.935+0900 W/wnotib  (  725): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-29 20:07:27.045+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2008
05-29 20:07:27.110+0900 W/CRASH_MANAGER( 2179): worker.c: worker_job(1199) > 1102008686170146452004
