S/W Version Information
Model: SM-R735S
Tizen-Version: 2.3.1.2
Build-Number: R735SKSU1AOKE
Build-Date: 2015.11.25 20:46:58

Crash Information
Process Name: hap
PID: 3245
Date: 2016-05-29 14:39:16+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x003183c9, r3   = 0x00000001
r4   = 0xb7d21a30, r5   = 0xb5822b34
r6   = 0xbe9b1e14, r7   = 0x00000000
r8   = 0x00000002, r9   = 0xb57f8861
r10  = 0x00000000, fp   = 0xbe9b1e30
ip   = 0xb5822c4c, sp   = 0xbe9b0e08
lr   = 0xb580e23d, pc   = 0xb6ac1dc4
cpsr = 0x20000010

Memory Information
MemTotal:   407572 KB
MemFree:     13696 KB
Buffers:      6924 KB
Cached:      81048 KB
VmPeak:      62496 KB
VmSize:      61952 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16404 KB
VmRSS:       16404 KB
VmData:      31204 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20036 KB
VmPTE:          48 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3245 TID = 3245
3245 3287 

Maps Information
b356f000 b35f6000 rw-s anon_inode:dmabuf
b3676000 b3e75000 rwxp [stack:3287]
b524e000 b5265000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b5272000 b5274000 r-xp /usr/lib/libgenlock.so
b5286000 b5288000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b5292000 b5294000 r-xp /usr/lib/libdri2.so.0.0.0
b529c000 b52a3000 r-xp /usr/lib/libtbm.so.1.0.0
b52ab000 b52b3000 r-xp /usr/lib/libdrm.so.2.4.0
b52c4000 b52c9000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b52d1000 b52dc000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b5616000 b56e0000 r-xp /usr/lib/libCOREGL.so.4.0
b56f1000 b56f7000 r-xp /usr/lib/libxcb-render.so.0.0.0
b56ff000 b5702000 r-xp /usr/lib/libEGL.so.1.4
b570a000 b5718000 r-xp /usr/lib/libGLESv2.so.2.0
b5721000 b5729000 r-xp /usr/lib/libsap_client.so.0.0.0
b5731000 b57e9000 r-xp /usr/lib/libcairo.so.2.11200.14
b57f4000 b5801000 r-xp /usr/lib/libsap-client-stub-api.so.1.0.0
b5809000 b581b000 r-xp /usr/lib/libtts.so
b5823000 b5844000 r-xp /usr/lib/libefl-extension.so.0.1.0
b584c000 b5851000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b585b000 b5866000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b5a2d000 b5a37000 r-xp /lib/libnss_files-2.13.so
b5a40000 b5b0f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5b25000 b5b49000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5b52000 b5b58000 r-xp /usr/lib/libappsvc.so.0.1.0
b5b60000 b5b62000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5b6b000 b5b70000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5b7f000 b5b85000 r-xp /opt/usr/apps/org.example.hap/bin/hap
b5b8e000 b5b90000 r-xp /usr/lib/libiniparser.so.0
b5b99000 b5b9e000 r-xp /usr/lib/libappcore-common.so.1.1
b5ba6000 b5ba7000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b5bb0000 b5bb4000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5bc1000 b5bc3000 r-xp /usr/lib/libXau.so.6.0.0
b5bcc000 b5bd3000 r-xp /lib/libcrypt-2.13.so
b5c03000 b5c05000 r-xp /usr/lib/libiri.so
b5c0d000 b5db5000 r-xp /usr/lib/libcrypto.so.1.0.0
b5dce000 b5e1b000 r-xp /usr/lib/libssl.so.1.0.0
b5e28000 b5e56000 r-xp /usr/lib/libidn.so.11.5.44
b5e5e000 b5e67000 r-xp /usr/lib/libcares.so.2.1.0
b5e70000 b5e83000 r-xp /usr/lib/libxcb.so.1.1.0
b5e8c000 b5e8e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5e97000 b5e99000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ea2000 b5f6e000 r-xp /usr/lib/libxml2.so.2.7.8
b5f7b000 b5f7d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5f85000 b5f8a000 r-xp /usr/lib/libffi.so.5.0.10
b5f92000 b5f93000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5f9c000 b5fa7000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5faf000 b5fb2000 r-xp /lib/libattr.so.1.1.0
b5fba000 b604e000 r-xp /usr/lib/libstdc++.so.6.0.16
b6061000 b607d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b6086000 b609e000 r-xp /usr/lib/libpng12.so.0.50.0
b60a7000 b60bd000 r-xp /lib/libexpat.so.1.5.2
b60c7000 b610b000 r-xp /usr/lib/libcurl.so.4.3.0
b6114000 b611e000 r-xp /usr/lib/libXext.so.6.4.0
b6127000 b612a000 r-xp /usr/lib/libXtst.so.6.1.0
b6133000 b6139000 r-xp /usr/lib/libXrender.so.1.3.0
b6142000 b6148000 r-xp /usr/lib/libXrandr.so.2.2.0
b6150000 b6151000 r-xp /usr/lib/libXinerama.so.1.0.0
b615a000 b6163000 r-xp /usr/lib/libXi.so.6.1.0
b616b000 b616e000 r-xp /usr/lib/libXfixes.so.3.1.0
b6176000 b6178000 r-xp /usr/lib/libXgesture.so.7.0.0
b6180000 b6182000 r-xp /usr/lib/libXcomposite.so.1.0.0
b618b000 b618d000 r-xp /usr/lib/libXdamage.so.1.1.0
b6195000 b619c000 r-xp /usr/lib/libXcursor.so.1.0.2
b61a4000 b61a7000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b61af000 b61b3000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b61bc000 b61c1000 r-xp /usr/lib/libecore_fb.so.1.7.99
b61cb000 b62ac000 r-xp /usr/lib/libX11.so.6.3.0
b62b7000 b62da000 r-xp /usr/lib/libjpeg.so.8.0.2
b62f2000 b6308000 r-xp /lib/libz.so.1.2.5
b6310000 b6385000 r-xp /usr/lib/libsqlite3.so.0.8.6
b638f000 b63a4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b63ad000 b63e1000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b63ea000 b64bd000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b64c8000 b64d8000 r-xp /lib/libresolv-2.13.so
b64dc000 b6558000 r-xp /usr/lib/libgcrypt.so.20.0.3
b6564000 b657c000 r-xp /usr/lib/liblzma.so.5.0.3
b6585000 b6588000 r-xp /lib/libcap.so.2.21
b6590000 b65b6000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b65bf000 b65c0000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b65c8000 b65ce000 r-xp /usr/lib/libecore_imf.so.1.7.99
b65d6000 b65ed000 r-xp /usr/lib/liblua-5.1.so
b65f7000 b65fe000 r-xp /usr/lib/libembryo.so.1.7.99
b6606000 b660c000 r-xp /lib/librt-2.13.so
b6615000 b666b000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6678000 b66ce000 r-xp /usr/lib/libfreetype.so.6.11.3
b66da000 b6702000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6704000 b6741000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b674a000 b675d000 r-xp /usr/lib/libfribidi.so.0.3.1
b6765000 b677f000 r-xp /usr/lib/libecore_con.so.1.7.99
b6788000 b6791000 r-xp /usr/lib/libedbus.so.1.7.99
b6799000 b67e9000 r-xp /usr/lib/libecore_x.so.1.7.99
b67ec000 b67f0000 r-xp /usr/lib/libvconf.so.0.2.45
b67f8000 b6809000 r-xp /usr/lib/libecore_input.so.1.7.99
b6811000 b6816000 r-xp /usr/lib/libecore_file.so.1.7.99
b681e000 b6840000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6849000 b688a000 r-xp /usr/lib/libeina.so.1.7.99
b6893000 b68ac000 r-xp /usr/lib/libeet.so.1.7.99
b68bd000 b6926000 r-xp /lib/libm-2.13.so
b692f000 b6935000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b693e000 b6941000 r-xp /usr/lib/libproc-stat.so.0.2.86
b6949000 b696b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6973000 b6978000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6980000 b69aa000 r-xp /usr/lib/libdbus-1.so.3.8.12
b69b3000 b69ca000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b69d2000 b69dd000 r-xp /lib/libunwind.so.8.0.1
b6a0a000 b6a46000 r-xp /usr/lib/libsystemd.so.0.4.0
b6a4f000 b6b6a000 r-xp /lib/libc-2.13.so
b6b78000 b6b80000 r-xp /lib/libgcc_s-4.6.so.1
b6b81000 b6b84000 r-xp /usr/lib/libsmack.so.1.0.0
b6b8c000 b6b92000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6b9a000 b6c6a000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c6b000 b6cc8000 r-xp /usr/lib/libedje.so.1.7.99
b6cd2000 b6ce9000 r-xp /usr/lib/libecore.so.1.7.99
b6d00000 b6dcf000 r-xp /usr/lib/libevas.so.1.7.99
b6df3000 b6f2d000 r-xp /usr/lib/libelementary.so.1.7.99
b6f43000 b6f57000 r-xp /lib/libpthread-2.13.so
b6f62000 b6f64000 r-xp /usr/lib/libdlog.so.0.0.0
b6f6c000 b6f6f000 r-xp /usr/lib/libbundle.so.0.1.22
b6f77000 b6f79000 r-xp /lib/libdl-2.13.so
b6f82000 b6f8e000 r-xp /usr/lib/libaul.so.0.1.0
b6fa0000 b6fa5000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fae000 b6fb2000 r-xp /usr/lib/libsys-assert.so
b6fbb000 b6fd8000 r-xp /lib/ld-2.13.so
b6fe1000 b6fe6000 r-xp /usr/bin/launchpad-loader
b7bf1000 b7d54000 rw-p [heap]
be992000 be9b3000 rwxp [stack]
be992000 be9b3000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3245)
Call Stack Count: 1
 0: strlen + 0x4 (0xb6ac1dc4) [/lib/libc.so.6] + 0x72dc4
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
E/CAPI_APPFW_APP_CONTROL( 1442): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-29 14:37:37.829+0900 W/AUL_PAD ( 1763): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
05-29 14:37:37.829+0900 W/AUL_PAD ( 1763): launchpad.c: __send_result_to_caller(265) > Check app launching
05-29 14:37:37.849+0900 W/MUSIC_CONTROL_SERVICE( 1442): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1442]   value = [false][0m
05-29 14:37:37.849+0900 I/wnotib  ( 1194): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-29 14:37:37.849+0900 E/wnotib  ( 1194): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 14:37:37.869+0900 I/efl-extension( 3027): efl_extension.c: eext_mod_init(40) > Init
05-29 14:37:37.869+0900 I/CAPI_APPFW_APPLICATION( 3027): app_main.c: ui_app_main(704) > app_efl_main
05-29 14:37:37.879+0900 I/CAPI_APPFW_APPLICATION( 3027): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-29 14:37:37.979+0900 I/APP_CORE( 1194): appcore-efl.c: __do_app(429) > [APP 1194] Event: MEM_FLUSH State: PAUSED
05-29 14:37:37.999+0900 E/E17     (  727): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05400002)
05-29 14:37:38.019+0900 E/EFL     ( 3027): ecore_evas<3027> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-29 14:37:38.079+0900 I/efl-extension( 3027): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0xb873bc28]'s widget[0xb8737448] to elm_conformant widget[0xb8708198]
05-29 14:37:38.149+0900 I/HAP     ( 3027): SUCCESSFULLY create sap agent
05-29 14:37:38.149+0900 I/HAP     ( 3027): connectivity type(1): bt
05-29 14:37:38.299+0900 I/HAP     ( 3027): agent is initialized
05-29 14:37:38.299+0900 I/HAP     ( 3027): agent initialized callback is over
05-29 14:37:38.299+0900 I/HAP     ( 3027): SAP >>> getRegisteredServiceAgent() >>> 0
05-29 14:37:38.389+0900 I/APP_CORE( 3027): appcore-efl.c: __do_app(429) > [APP 3027] Event: RESET State: CREATED
05-29 14:37:38.389+0900 I/CAPI_APPFW_APPLICATION( 3027): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 14:37:38.409+0900 I/APP_CORE( 3027): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 14:37:38.409+0900 I/APP_CORE( 3027): appcore-efl.c: __do_app(474) > [APP 3027] Initial Launching, call the resume_cb
05-29 14:37:38.409+0900 I/CAPI_APPFW_APPLICATION( 3027): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 14:37:38.419+0900 W/APP_CORE( 3027): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5400002
05-29 14:37:38.419+0900 I/efl-extension( 3027): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0xb873bc28 = w: 0 h: 0  obj 0xb8737448 w: 360 h: 360
05-29 14:37:38.419+0900 I/efl-extension( 3027): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 14:37:38.489+0900 I/APP_CORE( 2074): appcore-efl.c: __do_app(429) > [APP 2074] Event: PAUSE State: RUNNING
05-29 14:37:38.489+0900 I/CAPI_APPFW_APPLICATION( 2074): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 14:37:38.549+0900 W/AUL_AMD (  910): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 14:37:38.549+0900 W/AUL_AMD (  910): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
05-29 14:37:38.559+0900 I/APP_CORE( 3027): appcore-efl.c: __do_app(429) > [APP 3027] Event: RESUME State: RUNNING
05-29 14:37:38.969+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:37:38.979+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3027
05-29 14:37:38.979+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 12
05-29 14:37:39.249+0900 I/AUL_PAD ( 3245): launchpad_loader.c: main(600) > [candidate] elm init, returned: 1
05-29 14:37:40.129+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=990502 button=1 downs=1
05-29 14:37:40.319+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=990687 button=1 downs=0
05-29 14:37:41.079+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=991452 button=1 downs=1
05-29 14:37:41.319+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=991682 button=1 downs=0
05-29 14:37:42.499+0900 I/APP_CORE( 1194): appcore-efl.c: __do_app(429) > [APP 1194] Event: MEM_FLUSH State: PAUSED
05-29 14:37:42.949+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:37:42.969+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3027
05-29 14:37:43.909+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=994276 button=1 downs=1
05-29 14:37:43.979+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=994343 button=1 downs=0
05-29 14:37:43.989+0900 I/APP_CORE( 2074): appcore-efl.c: __do_app(429) > [APP 2074] Event: MEM_FLUSH State: PAUSED
05-29 14:37:44.269+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=994635 button=1 downs=1
05-29 14:37:44.379+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=994751 button=1 downs=0
05-29 14:37:44.599+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=994971 button=1 downs=1
05-29 14:37:44.869+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=995232 button=1 downs=0
05-29 14:37:45.049+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=995420 button=1 downs=1
05-29 14:37:45.189+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=995560 button=1 downs=0
05-29 14:37:45.369+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=995733 button=1 downs=1
05-29 14:37:45.519+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=995886 button=1 downs=0
05-29 14:37:45.689+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=996054 button=1 downs=1
05-29 14:37:45.829+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=996192 button=1 downs=0
05-29 14:37:45.999+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=996371 button=1 downs=1
05-29 14:37:46.099+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=996468 button=1 downs=0
05-29 14:37:46.249+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=996618 button=1 downs=1
05-29 14:37:46.419+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=996790 button=1 downs=0
05-29 14:37:46.549+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=996914 button=1 downs=1
05-29 14:37:46.739+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=997108 button=1 downs=0
05-29 14:37:46.909+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=997277 button=1 downs=1
05-29 14:37:47.019+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=997384 button=1 downs=0
05-29 14:37:47.179+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=997547 button=1 downs=1
05-29 14:37:47.279+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=997643 button=1 downs=0
05-29 14:37:47.979+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:37:47.999+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3027
05-29 14:37:52.979+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:37:52.999+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3027
05-29 14:37:54.339+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1004717 button=1 downs=1
05-29 14:37:54.449+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1004817 button=1 downs=0
05-29 14:37:56.209+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1006582 button=1 downs=1
05-29 14:37:56.359+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1006734 button=1 downs=0
05-29 14:37:57.269+0900 I/WECONN  (  869): esap.c: __sap_service_signal_peeragent_added_cb(1627) > path: /Application/org_2E_example_2E_hap/HelloAccessoryProvider, [sig: PeerAgentUpdated]
05-29 14:37:57.289+0900 I/WECONN  (  869): esap.c: __sap_service_signal_peeragent_added_cb(1627) > path: /Application/org_2E_example_2E_hap/HelloAccessoryProvider, [sig: PeerAgentRemoved]
05-29 14:37:57.979+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:37:57.999+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3027
05-29 14:37:58.039+0900 E/WMS     (  908): wms_event_handler.c: wms_event_handler_routine(20319) > 
05-29 14:37:58.039+0900 E/WMS     (  908): ==========
05-29 14:37:58.039+0900 E/WMS     (  908): ##WMS RECEIVED : mgr_gear_package_status_update_req
05-29 14:37:58.039+0900 E/WMS     (  908): ==========
05-29 14:37:58.039+0900 E/WMS     (  908): wms_event_handler.c: handle_mgr_gear_package_status_update_req(12685) > host_pkgname[ftw.swcapstone.com.bomiojyo], host_pkg_ver[1], minVer[none], status[updated]
05-29 14:37:58.059+0900 E/WMS     (  908): wms_msg_broker.c: wms_msg_broker_send(1700) > 
05-29 14:37:58.059+0900 E/WMS     (  908): ==========
05-29 14:37:58.059+0900 E/WMS     (  908): ##WMS SEND : mgr_gear_package_status_update_res
05-29 14:37:58.059+0900 E/WMS     (  908): ==========
05-29 14:37:58.059+0900 E/WMS     (  908): wms_msg_broker.c: wms_msg_broker_send(1716) > Data size: 86 MAX Buffer Size: 61440
05-29 14:37:58.069+0900 E/WMS     (  908): wms_event_handler.c: wms_event_handler_routine(20335) > [mgr_gear_package_status_update_req] handler success.
05-29 14:38:00.869+0900 W/APPS    ( 1194): apps_main.c: _time_changed_cb(294) >  date : 29->29
05-29 14:38:02.979+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:38:02.999+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3027
05-29 14:38:05.709+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1016075 button=1 downs=1
05-29 14:38:05.779+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1016144 button=1 downs=0
05-29 14:38:06.319+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1016688 button=1 downs=1
05-29 14:38:06.399+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1016765 button=1 downs=0
05-29 14:38:06.929+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1017299 button=1 downs=1
05-29 14:38:07.019+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1017388 button=1 downs=0
05-29 14:38:07.409+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1017775 button=1 downs=1
05-29 14:38:07.479+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1017849 button=1 downs=0
05-29 14:38:07.699+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1018068 button=1 downs=1
05-29 14:38:07.809+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1018187 button=1 downs=0
05-29 14:38:07.979+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:38:07.989+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3027
05-29 14:38:10.529+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1020898 button=1 downs=1
05-29 14:38:10.649+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1021027 button=1 downs=0
05-29 14:38:11.079+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1021451 button=1 downs=1
05-29 14:38:11.159+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1021530 button=1 downs=0
05-29 14:38:12.969+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:38:12.999+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3027
05-29 14:38:14.109+0900 I/WECONN  (  869): esap.c: __sap_service_signal_peeragent_added_cb(1627) > path: /Application/org_2E_example_2E_hap/HelloAccessoryProvider, [sig: PeerAgentAdded]
05-29 14:38:14.129+0900 I/WECONN  (  869): esap.c: __sap_service_signal_peeragent_added_cb(1627) > path: /Application/org_2E_example_2E_hap/HelloAccessoryProvider, [sig: PeerAgentUpdated]
05-29 14:38:14.590+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1024955 button=1 downs=1
05-29 14:38:14.649+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1025018 button=1 downs=0
05-29 14:38:14.949+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1025319 button=1 downs=1
05-29 14:38:14.999+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1025371 button=1 downs=0
05-29 14:38:15.229+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1025596 button=1 downs=1
05-29 14:38:15.279+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1025649 button=1 downs=0
05-29 14:38:15.509+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1025887 button=1 downs=1
05-29 14:38:15.559+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1025931 button=1 downs=0
05-29 14:38:17.989+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:38:18.009+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3027
05-29 14:38:18.149+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1028521 button=1 downs=1
05-29 14:38:18.219+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1028596 button=1 downs=0
05-29 14:38:18.379+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1028746 button=1 downs=1
05-29 14:38:18.459+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1028822 button=1 downs=0
05-29 14:38:20.689+0900 W/ALARM_MANAGER(  906): alarm-manager.c: __alarm_remove_from_list(454) > [alarm-server]:Remove alarm id(1228869026)
05-29 14:38:20.689+0900 W/ALARM_MANAGER(  906): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 14:38:20.689+0900 W/ALARM_MANAGER(  906): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 14:38:20.689+0900 W/ALARM_MANAGER(  906): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 14:38:20.689+0900 W/ALARM_MANAGER(  906): alarm-manager.c: alarm_manager_alarm_delete(2219) > alarm_id[1228869026] is removed.
05-29 14:38:20.759+0900 I/AUL     (  906): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 14:38:20.779+0900 I/AUL     (  906): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 14:38:20.789+0900 I/AUL     (  906): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 14:38:20.799+0900 I/AUL     (  906): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 14:38:20.819+0900 I/AUL     (  906): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 14:38:20.829+0900 I/AUL     (  906): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 14:38:20.829+0900 W/ALARM_MANAGER(  906): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464500304, Sun May 29 14:38:24 2016
05-29 14:38:20.829+0900 W/ALARM_MANAGER(  906): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1243238231, next duetime: 1464500304
05-29 14:38:20.829+0900 W/ALARM_MANAGER(  906): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(1243238231)
05-29 14:38:20.829+0900 W/ALARM_MANAGER(  906): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464500304)
05-29 14:38:20.829+0900 W/ALARM_MANAGER(  906): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 14:38:20.829+0900 W/ALARM_MANAGER(  906): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 29-5-2016, 05:38:24 (UTC).
05-29 14:38:20.829+0900 W/ALARM_MANAGER(  906): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 14:38:20.839+0900 W/ALARM_MANAGER(  906): alarm-manager.c: __alarm_remove_from_list(454) > [alarm-server]:Remove alarm id(1243238231)
05-29 14:38:20.839+0900 W/ALARM_MANAGER(  906): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 14:38:20.839+0900 W/ALARM_MANAGER(  906): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 14:38:20.839+0900 W/ALARM_MANAGER(  906): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 14:38:20.839+0900 W/ALARM_MANAGER(  906): alarm-manager.c: alarm_manager_alarm_delete(2219) > alarm_id[1243238231] is removed.
05-29 14:38:20.859+0900 I/AUL     (  906): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 14:38:20.869+0900 I/AUL     (  906): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 14:38:20.889+0900 I/AUL     (  906): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 14:38:20.899+0900 I/AUL     (  906): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 14:38:20.919+0900 I/AUL     (  906): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 14:38:20.929+0900 I/AUL     (  906): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 14:38:20.929+0900 W/ALARM_MANAGER(  906): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464543500, Mon May 30 02:38:20 2016
05-29 14:38:20.929+0900 W/ALARM_MANAGER(  906): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1243238231, next duetime: 1464543500
05-29 14:38:20.929+0900 W/ALARM_MANAGER(  906): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(1243238231)
05-29 14:38:20.929+0900 W/ALARM_MANAGER(  906): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464543500)
05-29 14:38:20.929+0900 W/ALARM_MANAGER(  906): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 14:38:20.929+0900 W/ALARM_MANAGER(  906): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 14:38:20.929+0900 W/ALARM_MANAGER(  906): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 14:38:21.459+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1031825 button=1 downs=1
05-29 14:38:21.529+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1031901 button=1 downs=0
05-29 14:38:21.659+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1032032 button=1 downs=1
05-29 14:38:21.729+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1032099 button=1 downs=0
05-29 14:38:21.879+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1032247 button=1 downs=1
05-29 14:38:21.919+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1032289 button=1 downs=0
05-29 14:38:22.149+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1032521 button=1 downs=1
05-29 14:38:22.209+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1032574 button=1 downs=0
05-29 14:38:22.489+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1032856 button=1 downs=1
05-29 14:38:22.539+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1032909 button=1 downs=0
05-29 14:38:22.809+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1033182 button=1 downs=1
05-29 14:38:22.869+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1033246 button=1 downs=0
05-29 14:38:22.969+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:38:22.979+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3027
05-29 14:38:23.189+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1033552 button=1 downs=1
05-29 14:38:23.219+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1033582 button=1 downs=0
05-29 14:38:23.559+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1033934 button=1 downs=1
05-29 14:38:23.589+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1033958 button=1 downs=0
05-29 14:38:23.809+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1034180 button=1 downs=1
05-29 14:38:23.829+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1034207 button=1 downs=0
05-29 14:38:24.029+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1034397 button=1 downs=1
05-29 14:38:24.059+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1034429 button=1 downs=0
05-29 14:38:25.769+0900 I/RESOURCED(  911): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 14:38:25.769+0900 I/RESOURCED(  911): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 14:38:27.959+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:38:27.999+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3027
05-29 14:38:28.259+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1038629 button=1 downs=1
05-29 14:38:28.299+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1038672 button=1 downs=0
05-29 14:38:28.439+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1038809 button=1 downs=1
05-29 14:38:28.519+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1038885 button=1 downs=0
05-29 14:38:28.699+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1039065 button=1 downs=1
05-29 14:38:28.759+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1039129 button=1 downs=0
05-29 14:38:28.929+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1039291 button=1 downs=1
05-29 14:38:28.959+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1039331 button=1 downs=0
05-29 14:38:30.769+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1041139 button=1 downs=1
05-29 14:38:30.850+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1041225 button=1 downs=0
05-29 14:38:31.049+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1041423 button=1 downs=1
05-29 14:38:31.109+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1041476 button=1 downs=0
05-29 14:38:31.389+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1041762 button=1 downs=1
05-29 14:38:31.409+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1041781 button=1 downs=0
05-29 14:38:31.699+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1042067 button=1 downs=1
05-29 14:38:31.709+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1042076 button=1 downs=0
05-29 14:38:31.979+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1042347 button=1 downs=1
05-29 14:38:32.029+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1042403 button=1 downs=0
05-29 14:38:32.339+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1042704 button=1 downs=1
05-29 14:38:32.369+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1042736 button=1 downs=0
05-29 14:38:32.599+0900 I/WECONN  (  869): esap.c: __sap_service_signal_peeragent_added_cb(1627) > path: /Application/org_2E_example_2E_hap/HelloAccessoryProvider, [sig: PeerAgentUpdated]
05-29 14:38:32.599+0900 I/WECONN  (  869): esap.c: __sap_service_signal_peeragent_added_cb(1627) > path: /Application/org_2E_example_2E_hap/HelloAccessoryProvider, [sig: PeerAgentRemoved]
05-29 14:38:32.649+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1043013 button=1 downs=1
05-29 14:38:32.669+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1043044 button=1 downs=0
05-29 14:38:32.909+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1043283 button=1 downs=1
05-29 14:38:32.959+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1043325 button=1 downs=0
05-29 14:38:32.989+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:38:33.009+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3027
05-29 14:38:33.349+0900 E/WMS     (  908): wms_event_handler.c: wms_event_handler_routine(20319) > 
05-29 14:38:33.349+0900 E/WMS     (  908): ==========
05-29 14:38:33.349+0900 E/WMS     (  908): ##WMS RECEIVED : mgr_gear_package_status_update_req
05-29 14:38:33.349+0900 E/WMS     (  908): ==========
05-29 14:38:33.359+0900 E/WMS     (  908): wms_event_handler.c: handle_mgr_gear_package_status_update_req(12685) > host_pkgname[ftw.swcapstone.com.bomiojyo], host_pkg_ver[1], minVer[none], status[updated]
05-29 14:38:33.359+0900 E/WMS     (  908): wms_msg_broker.c: wms_msg_broker_send(1700) > 
05-29 14:38:33.359+0900 E/WMS     (  908): ==========
05-29 14:38:33.359+0900 E/WMS     (  908): ##WMS SEND : mgr_gear_package_status_update_res
05-29 14:38:33.359+0900 E/WMS     (  908): ==========
05-29 14:38:33.369+0900 E/WMS     (  908): wms_msg_broker.c: wms_msg_broker_send(1716) > Data size: 86 MAX Buffer Size: 61440
05-29 14:38:33.369+0900 E/WMS     (  908): wms_event_handler.c: wms_event_handler_routine(20335) > [mgr_gear_package_status_update_req] handler success.
05-29 14:38:37.479+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1047851 button=1 downs=1
05-29 14:38:37.759+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1048128 button=1 downs=0
05-29 14:38:37.969+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:38:37.989+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3027
05-29 14:38:38.119+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1048485 button=1 downs=1
05-29 14:38:38.209+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1048581 button=1 downs=0
05-29 14:38:38.339+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1048712 button=1 downs=1
05-29 14:38:38.509+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1048876 button=1 downs=0
05-29 14:38:38.699+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1049076 button=1 downs=1
05-29 14:38:39.209+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1049576 button=1 downs=0
05-29 14:38:42.649+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1053018 button=1 downs=1
05-29 14:38:42.689+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1053064 button=1 downs=0
05-29 14:38:42.969+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:38:43.029+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3027
05-29 14:38:45.029+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1055400 button=1 downs=1
05-29 14:38:45.029+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1055403 button=1 downs=0
05-29 14:38:46.809+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1057176 button=1 downs=1
05-29 14:38:46.830+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1057202 button=1 downs=0
05-29 14:38:48.009+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:38:48.029+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3027
05-29 14:38:48.559+0900 I/WECONN  (  869): esap.c: __sap_service_signal_peeragent_added_cb(1627) > path: /Application/org_2E_example_2E_hap/HelloAccessoryProvider, [sig: PeerAgentAdded]
05-29 14:38:48.579+0900 I/WECONN  (  869): esap.c: __sap_service_signal_peeragent_added_cb(1627) > path: /Application/org_2E_example_2E_hap/HelloAccessoryProvider, [sig: PeerAgentUpdated]
05-29 14:38:50.119+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1060486 button=1 downs=1
05-29 14:38:50.179+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1060550 button=1 downs=0
05-29 14:38:51.439+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1061815 button=1 downs=1
05-29 14:38:51.479+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1061855 button=1 downs=0
05-29 14:38:52.979+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:38:52.999+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3027
05-29 14:38:53.209+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1063577 button=1 downs=1
05-29 14:38:53.299+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1063662 button=1 downs=0
05-29 14:38:54.859+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1065232 button=1 downs=1
05-29 14:38:54.969+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1065332 button=1 downs=0
05-29 14:38:56.049+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1066417 button=1 downs=1
05-29 14:38:56.129+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1066492 button=1 downs=0
05-29 14:38:57.609+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1067974 button=1 downs=1
05-29 14:38:57.639+0900 E/EFL     ( 3027): evas_main<3027> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1068015 button=1 downs=0
05-29 14:38:57.979+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:38:57.989+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3027
05-29 14:38:58.489+0900 I/HAP     ( 3027): routes length: 1
05-29 14:38:58.489+0900 I/HAP     ( 3027): received data: 장다리로 을 따라 162m 이동/37.27655039833677/127.03127993829892
05-29 14:38:58.489+0900 I/HAP     ( 3027): 우측 횡단보도 후 보행자도로 을 따라 26m 이동 /37.27795302297102/127.03180485142347
05-29 14:38:58.489+0900 I/HAP     ( 3027): 직진 후 중부대로 을 따라 68m 이동 /37.27791969851095/127.03208538245273
05-29 14:38:58.489+0900 I/HAP     ( 3027): 횡단보도 후 보행자도로 을 따라 8m 이동 /37.277830832970096/127.03281587420162
05-29 14:38:58.489+0900 I/HAP     ( 3027): 직진 후 중부대로 을 따라 163m 이동 /37.27781416982219/127.03290475549065
05-29 14:38:58.489+0900 I/HAP     ( 3027): 횡단보도 후 보행자도로 을 따라 9m 이동 /37.27737536309203/127.03465738649457
05-29 14:38:58.489+0900 I/HAP     ( 3027): 직진 후 중부대로 을 따라 251m 이동 /37.27734481291254/127.03476015580091
05-29 14:38:58.489+0900 I/HAP     ( 3027): 좌측 횡단보도 후 5m 이동 /37.27659494818776/127.03746826436145
05-29 14:38:58.489+0900 I/HAP     ( 3027): 좌측 횡단보도 후 보행자도로 을 따라 27m 이동 /37.276619946035844/127.03750992654794
05-29 14:38:58.489+0900 I/HAP     ( 3027): 우회전 후 권광로 을 따라 7m 이동 /37.27685047671701/127.03761268854973
05-29 14:38:58.489+0900 I/HAP     ( 3027): 횡단보도 후 9m 이동 /37.27689213964827/127.03767379295
05-29 14:38:58.489+0900 I/HAP     ( 3027): 직진 후 15m 이동 /37.27686436667676/127.03776267455035
05-29 14:38:58.489+0900 I/HAP     ( 3027): 횡단보도 후 7
05-29 14:38:58.489+0900 I/HAP     ( 3027): description: (null), x: (null), y: (null)
05-29 14:38:58.519+0900 I/tag     ( 3027): get_tts_state state = 1
05-29 14:38:58.759+0900 W/AUL_AMD (  910): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 14:38:58.759+0900 W/AUL_AMD (  910): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
05-29 14:38:58.969+0900 I/APP_CORE( 2074): appcore-efl.c: __do_app(429) > [APP 2074] Event: RESUME State: PAUSED
05-29 14:38:58.969+0900 I/CAPI_APPFW_APPLICATION( 2074): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 14:38:59.019+0900 I/AUL_AMD (  910): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3027
05-29 14:38:59.289+0900 E/EFL     ( 2074): evas_main<2074> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1069652 button=1 downs=1
05-29 14:38:59.289+0900 E/WIDGET_VIEWER( 2074): widget.c: widget_viewer_feed_mouse_event(2366) > [SECURE_LOG] Handler is not valid
05-29 14:38:59.289+0900 E/WIDGET_VIEWER( 2074): widget.c: widget_viewer_feed_mouse_event(2366) > [SECURE_LOG] Handler is not valid
05-29 14:38:59.289+0900 E/WIDGET_VIEWER( 2074): widget.c: widget_viewer_feed_mouse_event(2366) > [SECURE_LOG] Handler is not valid
05-29 14:38:59.339+0900 E/EFL     ( 2074): evas_main<2074> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1069706 button=1 downs=0
05-29 14:38:59.339+0900 E/WIDGET_VIEWER( 2074): widget.c: widget_viewer_feed_mouse_event(2366) > [SECURE_LOG] Handler is not valid
05-29 14:38:59.339+0900 E/WIDGET_VIEWER( 2074): widget.c: widget_viewer_feed_mouse_event(2366) > [SECURE_LOG] Handler is not valid
05-29 14:38:59.549+0900 W/CRASH_MANAGER( 3258): worker.c: worker_job(1199) > 11030276861701464500338
05-29 14:39:00.869+0900 W/APPS    ( 1194): apps_main.c: _time_changed_cb(294) >  date : 29->29
05-29 14:39:02.939+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:39:02.949+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 14:39:02.949+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 4
05-29 14:39:02.949+0900 E/AUL_AMD (  910): amd_request.c: __app_process_by_pid(193) > pid(3027) is dead. cmd(4) is canceled
05-29 14:39:03.049+0900 E/WIDGET_SDK( 2074): main.c: update_message(428) > [SECURE_LOG] Create aborted
05-29 14:39:03.559+0900 E/WIDGET_VIEWER( 2074): widget.c: widget_viewer_has_glance_bar(1890) > [SECURE_LOG] Handler is invalid
05-29 14:39:05.259+0900 E/EFL     ( 2074): evas_main<2074> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1075629 button=1 downs=1
05-29 14:39:05.299+0900 E/EFL     ( 2074): evas_main<2074> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1075672 button=1 downs=0
05-29 14:39:05.439+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 0
05-29 14:39:05.469+0900 I/AUL_AMD (  910): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 14:39:05.479+0900 I/AUL_AMD (  910): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 14:39:05.479+0900 E/AUL_AMD (  910): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
05-29 14:39:05.479+0900 W/AUL_AMD (  910): amd_launch.c: _start_app(1659) > caller pid : 1180
05-29 14:39:05.509+0900 E/RESOURCED(  911): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-29 14:39:05.509+0900 E/RESOURCED(  911): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 14:39:05.519+0900 W/AUL_AMD (  910): amd_launch.c: _start_app(2026) > pad pid(-5)
05-29 14:39:05.529+0900 W/AUL_PAD ( 1763): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
05-29 14:39:05.529+0900 W/AUL_PAD ( 1763): launchpad.c: __send_result_to_caller(265) > Check app launching
05-29 14:39:05.549+0900 I/efl-extension( 3245): efl_extension.c: eext_mod_init(40) > Init
05-29 14:39:05.549+0900 I/CAPI_APPFW_APPLICATION( 3245): app_main.c: ui_app_main(704) > app_efl_main
05-29 14:39:05.559+0900 I/CAPI_APPFW_APPLICATION( 3245): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-29 14:39:05.809+0900 E/E17     (  727): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04e00002)
05-29 14:39:05.899+0900 E/EFL     ( 3245): ecore_evas<3245> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-29 14:39:05.959+0900 I/efl-extension( 3245): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0xb4912df0]'s widget[0xb7d1a4a8] to elm_conformant widget[0xb7ceb0f0]
05-29 14:39:06.029+0900 I/HAP     ( 3245): SUCCESSFULLY create sap agent
05-29 14:39:06.029+0900 I/HAP     ( 3245): connectivity type(1): bt
05-29 14:39:06.219+0900 I/HAP     ( 3245): agent is initialized
05-29 14:39:06.219+0900 I/HAP     ( 3245): agent initialized callback is over
05-29 14:39:06.219+0900 I/HAP     ( 3245): SAP >>> getRegisteredServiceAgent() >>> 0
05-29 14:39:06.329+0900 I/APP_CORE( 3245): appcore-efl.c: __do_app(429) > [APP 3245] Event: RESET State: CREATED
05-29 14:39:06.329+0900 I/CAPI_APPFW_APPLICATION( 3245): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 14:39:06.349+0900 I/APP_CORE( 3245): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 14:39:06.349+0900 I/APP_CORE( 3245): appcore-efl.c: __do_app(474) > [APP 3245] Initial Launching, call the resume_cb
05-29 14:39:06.349+0900 I/CAPI_APPFW_APPLICATION( 3245): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 14:39:06.359+0900 W/APP_CORE( 3245): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4e00002
05-29 14:39:06.359+0900 E/EFL     ( 3245): evas_main<3245> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1076456 button=1 downs=1
05-29 14:39:06.359+0900 E/EFL     ( 3245): evas_main<3245> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1076520 button=1 downs=0
05-29 14:39:06.359+0900 I/efl-extension( 3245): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0xb4912df0 = w: 0 h: 0  obj 0xb7d1a4a8 w: 360 h: 360
05-29 14:39:06.359+0900 I/efl-extension( 3245): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 14:39:06.439+0900 I/APP_CORE( 2074): appcore-efl.c: __do_app(429) > [APP 2074] Event: PAUSE State: RUNNING
05-29 14:39:06.439+0900 I/CAPI_APPFW_APPLICATION( 2074): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 14:39:06.459+0900 W/AUL_AMD (  910): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 14:39:06.459+0900 W/AUL_AMD (  910): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
05-29 14:39:06.549+0900 I/APP_CORE( 3245): appcore-efl.c: __do_app(429) > [APP 3245] Event: RESUME State: RUNNING
05-29 14:39:06.699+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:39:06.709+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3245
05-29 14:39:06.709+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 12
05-29 14:39:07.169+0900 I/AUL_PAD ( 3290): launchpad_loader.c: main(600) > [candidate] elm init, returned: 1
05-29 14:39:07.469+0900 E/EFL     ( 3245): evas_main<3245> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1077838 button=1 downs=1
05-29 14:39:07.509+0900 E/EFL     ( 3245): evas_main<3245> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1077880 button=1 downs=0
05-29 14:39:08.049+0900 E/EFL     ( 3245): evas_main<3245> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1078415 button=1 downs=1
05-29 14:39:08.119+0900 E/EFL     ( 3245): evas_main<3245> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1078488 button=1 downs=0
05-29 14:39:10.639+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:39:10.669+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3245
05-29 14:39:11.949+0900 I/APP_CORE( 2074): appcore-efl.c: __do_app(429) > [APP 2074] Event: MEM_FLUSH State: PAUSED
05-29 14:39:14.109+0900 W/W_HOME  ( 1194): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
05-29 14:39:14.109+0900 W/W_HOME  ( 1194): dbox.c: _dbus_rotation_cb(1351) > invalid angle, skipped:0
05-29 14:39:14.269+0900 W/W_HOME  ( 1194): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
05-29 14:39:14.269+0900 W/W_HOME  ( 1194): dbox.c: _dbus_rotation_cb(1348) > angle changed:90
05-29 14:39:15.639+0900 W/AUL_AMD (  910): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 14:39:15.669+0900 W/AUL_AMD (  910): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3245
05-29 14:39:16.479+0900 I/HAP     ( 3245): routes length: 1
05-29 14:39:16.479+0900 I/HAP     ( 3245): received data: 장다리로 을 따라 162m 이동/37.27655039833677/127.03127993829892
05-29 14:39:16.479+0900 I/HAP     ( 3245): 우측 횡단보도 후 보행자도로 을 따라 26m 이동 /37.27795302297102/127.03180485142347
05-29 14:39:16.479+0900 I/HAP     ( 3245): 직진 후 중부대로 을 따라 68m 이동 /37.27791969851095/127.03208538245273
05-29 14:39:16.479+0900 I/HAP     ( 3245): 횡단보도 후 보행자도로 을 따라 8m 이동 /37.277830832970096/127.03281587420162
05-29 14:39:16.479+0900 I/HAP     ( 3245): 직진 후 중부대로 을 따라 163m 이동 /37.27781416982219/127.03290475549065
05-29 14:39:16.479+0900 I/HAP     ( 3245): 횡단보도 후 보행자도로 을 따라 9m 이동 /37.27737536309203/127.03465738649457
05-29 14:39:16.479+0900 I/HAP     ( 3245): 직진 후 중부대로 을 따라 251m 이동 /37.27734481291254/127.03476015580091
05-29 14:39:16.479+0900 I/HAP     ( 3245): 좌측 횡단보도 후 5m 이동 /37.27659494818776/127.03746826436145
05-29 14:39:16.479+0900 I/HAP     ( 3245): 좌측 횡단보도 후 보행자도로 을 따라 27m 이동 /37.276619946035844/127.03750992654794
05-29 14:39:16.479+0900 I/HAP     ( 3245): 우회전 후 권광로 을 따라 7m 이동 /37.27685047671701/127.03761268854973
05-29 14:39:16.479+0900 I/HAP     ( 3245): 횡단보도 후 9m 이동 /37.27689213964827/127.03767379295
05-29 14:39:16.479+0900 I/HAP     ( 3245): 직진 후 15m 이동 /37.27686436667676/127.03776267455035
05-29 14:39:16.479+0900 I/HAP     ( 3245): 횡단보도 후 7
05-29 14:39:16.479+0900 I/HAP     ( 3245): description: (null), x: (null), y: (null)
05-29 14:39:16.509+0900 I/tag     ( 3245): get_tts_state state = 1
05-29 14:39:16.659+0900 W/CRASH_MANAGER( 3258): worker.c: worker_job(1199) > 1103245686170146450035
