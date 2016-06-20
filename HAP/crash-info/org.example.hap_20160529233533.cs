S/W Version Information
Model: SM-R735S
Tizen-Version: 2.3.1.2
Build-Number: R735SKSU1AOKE
Build-Date: 2015.11.25 20:46:58

Crash Information
Process Name: hap
PID: 3176
Date: 2016-05-29 23:35:33+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00307641, r3   = 0x00000001
r4   = 0xb7bab300, r5   = 0xb579ab34
r6   = 0xbe8e0dfc, r7   = 0x00000000
r8   = 0x00000002, r9   = 0xb5770861
r10  = 0x00000000, fp   = 0xbe8e0e18
ip   = 0xb579ac4c, sp   = 0xbe8dfdf0
lr   = 0xb578623d, pc   = 0xb6a39dc4
cpsr = 0x20000010

Memory Information
MemTotal:   407572 KB
MemFree:     14172 KB
Buffers:      3348 KB
Cached:      85228 KB
VmPeak:      64508 KB
VmSize:      62344 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17656 KB
VmRSS:       17656 KB
VmData:      31560 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20040 KB
VmPTE:          50 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3176 TID = 3176
3176 3256 

Maps Information
b3488000 b350f000 rw-s anon_inode:dmabuf
b350f000 b3596000 rw-s anon_inode:dmabuf
b3596000 b3597000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b359f000 b3626000 rw-s anon_inode:dmabuf
b3626000 b36ad000 rw-s anon_inode:dmabuf
b372d000 b3f2c000 rwxp [stack:3256]
b51c6000 b51dd000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b51ea000 b51ec000 r-xp /usr/lib/libgenlock.so
b5200000 b5202000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b520a000 b520c000 r-xp /usr/lib/libdri2.so.0.0.0
b5214000 b521b000 r-xp /usr/lib/libtbm.so.1.0.0
b5223000 b522b000 r-xp /usr/lib/libdrm.so.2.4.0
b523c000 b5241000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b5249000 b5254000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b558e000 b5658000 r-xp /usr/lib/libCOREGL.so.4.0
b5669000 b566f000 r-xp /usr/lib/libxcb-render.so.0.0.0
b5677000 b567a000 r-xp /usr/lib/libEGL.so.1.4
b5682000 b5690000 r-xp /usr/lib/libGLESv2.so.2.0
b5699000 b56a1000 r-xp /usr/lib/libsap_client.so.0.0.0
b56a9000 b5761000 r-xp /usr/lib/libcairo.so.2.11200.14
b576c000 b5779000 r-xp /usr/lib/libsap-client-stub-api.so.1.0.0
b5781000 b5793000 r-xp /usr/lib/libtts.so
b579b000 b57bc000 r-xp /usr/lib/libefl-extension.so.0.1.0
b57c4000 b57c9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b57d3000 b57de000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b59a5000 b59af000 r-xp /lib/libnss_files-2.13.so
b59b8000 b5a87000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5a9d000 b5ac1000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5aca000 b5ad0000 r-xp /usr/lib/libappsvc.so.0.1.0
b5ad8000 b5ada000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5ae3000 b5ae8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5af6000 b5afc000 r-xp /opt/usr/apps/org.example.hap/bin/hap
b5b06000 b5b08000 r-xp /usr/lib/libiniparser.so.0
b5b11000 b5b16000 r-xp /usr/lib/libappcore-common.so.1.1
b5b1e000 b5b1f000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b5b28000 b5b2c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5b39000 b5b3b000 r-xp /usr/lib/libXau.so.6.0.0
b5b44000 b5b4b000 r-xp /lib/libcrypt-2.13.so
b5b7b000 b5b7d000 r-xp /usr/lib/libiri.so
b5b85000 b5d2d000 r-xp /usr/lib/libcrypto.so.1.0.0
b5d46000 b5d93000 r-xp /usr/lib/libssl.so.1.0.0
b5da0000 b5dce000 r-xp /usr/lib/libidn.so.11.5.44
b5dd6000 b5ddf000 r-xp /usr/lib/libcares.so.2.1.0
b5de8000 b5dfb000 r-xp /usr/lib/libxcb.so.1.1.0
b5e04000 b5e06000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5e0f000 b5e11000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5e1a000 b5ee6000 r-xp /usr/lib/libxml2.so.2.7.8
b5ef3000 b5ef5000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5efd000 b5f02000 r-xp /usr/lib/libffi.so.5.0.10
b5f0a000 b5f0b000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5f14000 b5f1f000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5f27000 b5f2a000 r-xp /lib/libattr.so.1.1.0
b5f32000 b5fc6000 r-xp /usr/lib/libstdc++.so.6.0.16
b5fd9000 b5ff5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5ffe000 b6016000 r-xp /usr/lib/libpng12.so.0.50.0
b601f000 b6035000 r-xp /lib/libexpat.so.1.5.2
b603f000 b6083000 r-xp /usr/lib/libcurl.so.4.3.0
b608c000 b6096000 r-xp /usr/lib/libXext.so.6.4.0
b609f000 b60a2000 r-xp /usr/lib/libXtst.so.6.1.0
b60ab000 b60b1000 r-xp /usr/lib/libXrender.so.1.3.0
b60ba000 b60c0000 r-xp /usr/lib/libXrandr.so.2.2.0
b60c8000 b60c9000 r-xp /usr/lib/libXinerama.so.1.0.0
b60d2000 b60db000 r-xp /usr/lib/libXi.so.6.1.0
b60e3000 b60e6000 r-xp /usr/lib/libXfixes.so.3.1.0
b60ee000 b60f0000 r-xp /usr/lib/libXgesture.so.7.0.0
b60f8000 b60fa000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6103000 b6105000 r-xp /usr/lib/libXdamage.so.1.1.0
b610d000 b6114000 r-xp /usr/lib/libXcursor.so.1.0.2
b611c000 b611f000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6127000 b612b000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6134000 b6139000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6143000 b6224000 r-xp /usr/lib/libX11.so.6.3.0
b622f000 b6252000 r-xp /usr/lib/libjpeg.so.8.0.2
b626a000 b6280000 r-xp /lib/libz.so.1.2.5
b6288000 b62fd000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6307000 b631c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6325000 b6359000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6362000 b6435000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6440000 b6450000 r-xp /lib/libresolv-2.13.so
b6454000 b64d0000 r-xp /usr/lib/libgcrypt.so.20.0.3
b64dc000 b64f4000 r-xp /usr/lib/liblzma.so.5.0.3
b64fd000 b6500000 r-xp /lib/libcap.so.2.21
b6508000 b652e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6537000 b6538000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b6540000 b6546000 r-xp /usr/lib/libecore_imf.so.1.7.99
b654e000 b6565000 r-xp /usr/lib/liblua-5.1.so
b656f000 b6576000 r-xp /usr/lib/libembryo.so.1.7.99
b657e000 b6584000 r-xp /lib/librt-2.13.so
b658d000 b65e3000 r-xp /usr/lib/libpixman-1.so.0.28.2
b65f0000 b6646000 r-xp /usr/lib/libfreetype.so.6.11.3
b6652000 b667a000 r-xp /usr/lib/libfontconfig.so.1.8.0
b667c000 b66b9000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b66c2000 b66d5000 r-xp /usr/lib/libfribidi.so.0.3.1
b66dd000 b66f7000 r-xp /usr/lib/libecore_con.so.1.7.99
b6700000 b6709000 r-xp /usr/lib/libedbus.so.1.7.99
b6711000 b6761000 r-xp /usr/lib/libecore_x.so.1.7.99
b6764000 b6768000 r-xp /usr/lib/libvconf.so.0.2.45
b6770000 b6781000 r-xp /usr/lib/libecore_input.so.1.7.99
b6789000 b678e000 r-xp /usr/lib/libecore_file.so.1.7.99
b6796000 b67b8000 r-xp /usr/lib/libecore_evas.so.1.7.99
b67c1000 b6802000 r-xp /usr/lib/libeina.so.1.7.99
b680b000 b6824000 r-xp /usr/lib/libeet.so.1.7.99
b6835000 b689e000 r-xp /lib/libm-2.13.so
b68a7000 b68ad000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b68b6000 b68b9000 r-xp /usr/lib/libproc-stat.so.0.2.86
b68c1000 b68e3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b68eb000 b68f0000 r-xp /usr/lib/libxdgmime.so.1.1.0
b68f8000 b6922000 r-xp /usr/lib/libdbus-1.so.3.8.12
b692b000 b6942000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b694a000 b6955000 r-xp /lib/libunwind.so.8.0.1
b6982000 b69be000 r-xp /usr/lib/libsystemd.so.0.4.0
b69c7000 b6ae2000 r-xp /lib/libc-2.13.so
b6af0000 b6af8000 r-xp /lib/libgcc_s-4.6.so.1
b6af9000 b6afc000 r-xp /usr/lib/libsmack.so.1.0.0
b6b04000 b6b0a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6b12000 b6be2000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6be3000 b6c40000 r-xp /usr/lib/libedje.so.1.7.99
b6c4a000 b6c61000 r-xp /usr/lib/libecore.so.1.7.99
b6c78000 b6d47000 r-xp /usr/lib/libevas.so.1.7.99
b6d6b000 b6ea5000 r-xp /usr/lib/libelementary.so.1.7.99
b6ebb000 b6ecf000 r-xp /lib/libpthread-2.13.so
b6eda000 b6edc000 r-xp /usr/lib/libdlog.so.0.0.0
b6ee4000 b6ee7000 r-xp /usr/lib/libbundle.so.0.1.22
b6eef000 b6ef1000 r-xp /lib/libdl-2.13.so
b6efa000 b6f06000 r-xp /usr/lib/libaul.so.0.1.0
b6f18000 b6f1d000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f26000 b6f2a000 r-xp /usr/lib/libsys-assert.so
b6f33000 b6f50000 r-xp /lib/ld-2.13.so
b6f59000 b6f5e000 r-xp /usr/bin/launchpad-loader
b7a0f000 b7c10000 rw-p [heap]
be8c1000 be8e2000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3176)
Call Stack Count: 1
 0: strlen + 0x4 (0xb6a39dc4) [/lib/libc.so.6] + 0x72dc4
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
PortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-29 23:35:21.039+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-29 23:35:21.039+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 23:35:21.039+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-29 23:35:21.039+0900 I/MESSAGE_PORT(  866): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-29 23:35:21.039+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-29 23:35:21.039+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 23:35:21.119+0900 W/MUSIC_TRANSFER( 3198): mt-consumer.c: __mt_consumer_on_data_indication(333) > [36m[TID:3198]   [MUSIC_PLAYER_EVENT]uwServiceHandle : [1], uwChannelId : [1001], uwPayloadLength : [50], pvBuffer : [{"msgId":"musictransfer-setting-ind","auto":"off"}][0m
05-29 23:35:21.119+0900 W/MUSIC_TRANSFER( 3198): mt-controller.c: _process_setting_change(402) > [36m[TID:3198]   [MUSIC_PLAYER_EVENT]AutoTransfer setting[off][0m
05-29 23:35:21.129+0900 W/WG-CONSUMER( 3197): [32m[F:SAPProxy.cpp     L:  780][_WARN][Phone->Gear] Connection Confirmed. wResponseCode : [0], uwLocalAgentId : [6255] uwServiceHandle : [1] PeerAgent(0xb88c0000)[0m
05-29 23:35:21.129+0900 W/WG-CONSUMER( 3197): [34m[F:ConnectionInfo.c L: 1131][_HIGH][TX]connection established. AgentID(6255) ServiceHandle=1 SM_STATE_REQUEST_SERVICE bTryingWFD=0[0m
05-29 23:35:21.129+0900 W/WG-CONSUMER( 3197): [34m[F:ConnectionInfo.c L: 1146][_HIGH][TX]Connection Established. ServiceID=1[0m
05-29 23:35:21.129+0900 W/WG-CONSUMER( 3197): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_REQUEST_SERVICE->SM_STATE_ESTABLISHED[0m
05-29 23:35:21.129+0900 W/WG-CONSUMER( 3197): [34m[F:TransferCtrl.cpp L:  199][_HIGH][TX]CTransferCtrl::OnEstablished[0m
05-29 23:35:21.139+0900 W/WG-CONSUMER( 3197): [32m[F:TransferCtrl.cpp L:  136][_WARN]Queue is empty[0m
05-29 23:35:21.149+0900 W/MUSIC_TRANSFER( 3198): mt-auto-transfer.c: mt_auto_transfer_clear(843) > [36m[TID:3198]   [MUSIC_PLAYER_EVENT][0m
05-29 23:35:21.149+0900 W/MUSIC_TRANSFER( 3198): mt-auto-transfer.c: mt_auto_transfer_clear(846) > [33m[TID:3198]   in progress = 0, success = 0[0m
05-29 23:35:21.189+0900 W/WG-CONSUMER( 3197): [32m[F:SAPProxy.cpp     L:  780][_WARN][Phone->Gear] Connection Confirmed. wResponseCode : [0], uwLocalAgentId : [6256] uwServiceHandle : [2] PeerAgent(0xb8895168)[0m
05-29 23:35:21.189+0900 W/WG-CONSUMER( 3197): [34m[F:ConnectionInfo.c L: 1131][_HIGH][RX]connection established. AgentID(6256) ServiceHandle=2 SM_STATE_REQUEST_SERVICE bTryingWFD=0[0m
05-29 23:35:21.189+0900 W/WG-CONSUMER( 3197): [34m[F:ConnectionInfo.c L: 1146][_HIGH][RX]Connection Established. ServiceID=2[0m
05-29 23:35:21.189+0900 W/WG-CONSUMER( 3197): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_REQUEST_SERVICE->SM_STATE_ESTABLISHED[0m
05-29 23:35:21.189+0900 W/WG-CONSUMER( 3197): [32m[F:ReceiverCtrl.cpp L:  469][_WARN][RX]Connection is established[0m
05-29 23:35:21.189+0900 W/WG-CONSUMER( 3197): [34m[F:AutoTransfer.cpp L:   54][_HIGH]AutoSync : Gear is charging[0m
05-29 23:35:21.189+0900 W/WG-CONSUMER( 3197): [34m[F:consumer-app.cpp L:  274][_HIGH]CGalleryConsumer::ResetTimer[0m
05-29 23:35:21.219+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:21.219+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:21.279+0900 I/TIZEN_N_SOUND_MANAGER( 3190): sound_manager.c: __sound_manager_finalize(831) > <ENTER>
05-29 23:35:21.279+0900 I/TIZEN_N_SOUND_MANAGER( 3190): sound_manager.c: __sound_manager_finalize(837) > <LEAVE>
05-29 23:35:21.419+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:21.419+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:21.609+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:21.609+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:21.809+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:21.809+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:21.849+0900 I/GESTURE (  244): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
05-29 23:35:21.849+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3965 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), block(2)
05-29 23:35:21.849+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), ev->cur.canvas.x(189) ev->cur.canvas.y(221)
05-29 23:35:21.849+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), hold(0) freeze(0)
05-29 23:35:21.849+0900 E/EFL     ( 1177): evas_main<1177> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1066243 button=1 downs=1
05-29 23:35:21.849+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3965 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), block(2)
05-29 23:35:21.849+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), ev->cur.canvas.x(175) ev->cur.canvas.y(221)
05-29 23:35:21.849+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), hold(0) freeze(0)
05-29 23:35:21.859+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3965 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), block(2)
05-29 23:35:21.859+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), ev->cur.canvas.x(154) ev->cur.canvas.y(221)
05-29 23:35:21.859+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), hold(0) freeze(0)
05-29 23:35:21.879+0900 E/watchface-viewer( 1755): viewer-group.cpp: OnGroupTouched(491) > Dali::TouchPoint::State = [0]
05-29 23:35:21.879+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:35:21.879+0900 E/watchface-viewer( 1755): viewer-group.cpp: OnPressed(633) > x y [ 70, 22] trigger[3]
05-29 23:35:21.879+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3965 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), block(2)
05-29 23:35:21.879+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), ev->cur.canvas.x(128) ev->cur.canvas.y(226)
05-29 23:35:21.879+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), hold(0) freeze(0)
05-29 23:35:21.879+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:4249 _elm_scroll_mouse_move_event_cb() [DDO] animator
05-29 23:35:21.879+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] obj(b768b2d8), type(elm_scroller)
05-29 23:35:21.879+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3354 _elm_scroll_post_event_move() [DDO] hold_parent(0)
05-29 23:35:21.879+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3382 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(b768b2d8), type(elm_scroller)
05-29 23:35:21.889+0900 W/W_HOME  ( 1177): home_navigation.c: _is_rightedge(188) > (360 360) not right edge: 0 0 0xacc74a68 -> 360 0 0xaf6e3680
05-29 23:35:21.889+0900 W/W_HOME  ( 1177): event_manager.c: _home_scroll_cb(564) > scroll,start
05-29 23:35:21.899+0900 E/watchface-viewer( 1755): viewer-group.cpp: OnGroupTouched(491) > Dali::TouchPoint::State = [5]
05-29 23:35:21.899+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:35:21.899+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3965 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), block(2)
05-29 23:35:21.899+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), ev->cur.canvas.x(97) ev->cur.canvas.y(229)
05-29 23:35:21.899+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), hold(0) freeze(0)
05-29 23:35:21.899+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3965 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), block(2)
05-29 23:35:21.899+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), ev->cur.canvas.x(64) ev->cur.canvas.y(235)
05-29 23:35:21.899+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), hold(0) freeze(0)
05-29 23:35:21.899+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3617 _elm_scroll_hold_animator() [DDO] obj(b768b2d8), locked_x(0)
05-29 23:35:21.899+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3843 _elm_scroll_hold_animator() [DDO] obj(b768b2d8)
05-29 23:35:21.899+0900 W/W_HOME  ( 1177): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
05-29 23:35:21.899+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:35:21.899+0900 I/ELM_RPANEL( 1177): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
05-29 23:35:21.899+0900 I/ELM_RPANEL( 1177): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
05-29 23:35:21.919+0900 I/GESTURE (  244): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
05-29 23:35:21.939+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3965 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), block(2)
05-29 23:35:21.939+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), ev->cur.canvas.x(49) ev->cur.canvas.y(238)
05-29 23:35:21.939+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), hold(0) freeze(0)
05-29 23:35:21.939+0900 E/EFL     ( 1177): evas_main<1177> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1066319 button=1 downs=0
05-29 23:35:21.939+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:2278 _elm_scroll_post_event_up() [DDO] lock set false. : obj(b768b2d8), type(elm_scroller)
05-29 23:35:21.939+0900 I/ELM_RPANEL( 1177): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
05-29 23:35:21.939+0900 I/ELM_RPANEL( 1177): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
05-29 23:35:21.959+0900 W/W_HOME  ( 1177): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
05-29 23:35:21.959+0900 I/ELM_RPANEL( 1177): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
05-29 23:35:21.959+0900 I/ELM_RPANEL( 1177): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
05-29 23:35:21.989+0900 I/ELM_RPANEL( 1177): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
05-29 23:35:21.989+0900 I/ELM_RPANEL( 1177): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
05-29 23:35:22.009+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:22.009+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:22.019+0900 I/ELM_RPANEL( 1177): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
05-29 23:35:22.019+0900 I/ELM_RPANEL( 1177): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
05-29 23:35:22.039+0900 I/ELM_RPANEL( 1177): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
05-29 23:35:22.039+0900 I/ELM_RPANEL( 1177): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
05-29 23:35:22.069+0900 I/ELM_RPANEL( 1177): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
05-29 23:35:22.069+0900 I/ELM_RPANEL( 1177): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
05-29 23:35:22.069+0900 W/wnotib  ( 1177): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
05-29 23:35:22.069+0900 I/efl-extension( 1177): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xb768b2d8 : elm_scroller] CurrentPage(2)
05-29 23:35:22.089+0900 W/WATCH_CORE( 1755): appcore-watch.c: __widget_pause(1001) > widget_pause
05-29 23:35:22.089+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppPause(717) > 
05-29 23:35:22.089+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:35:22.089+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:35:22.089+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:35:22.089+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:35:22.089+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:35:22.089+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:35:22.209+0900 W/W_HOME  ( 1177): event_manager.c: _home_scroll_cb(564) > scroll,done
05-29 23:35:22.569+0900 W/W_HOME  ( 1177): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
05-29 23:35:23.319+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3965 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), block(2)
05-29 23:35:23.319+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), ev->cur.canvas.x(188) ev->cur.canvas.y(79)
05-29 23:35:23.319+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), hold(0) freeze(0)
05-29 23:35:23.319+0900 E/EFL     ( 1177): evas_main<1177> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1067718 button=1 downs=1
05-29 23:35:23.349+0900 E/EFL     ( 1255): evas_main<1255> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1067718 button=1 downs=1
05-29 23:35:23.349+0900 E/EFL     ( 1255): evas_main<1255> evas_object_main.c:1359 evas_object_color_set() Evas only handles pre multiplied colors!
05-29 23:35:23.349+0900 E/EFL     ( 1255): evas_main<1255> evas_object_main.c:1364 evas_object_color_set() Evas only handles pre multiplied colors!
05-29 23:35:23.349+0900 E/EFL     ( 1255): evas_main<1255> evas_object_main.c:1369 evas_object_color_set() Evas only handles pre multiplied colors!
05-29 23:35:23.369+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3965 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), block(2)
05-29 23:35:23.369+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), ev->cur.canvas.x(187) ev->cur.canvas.y(79)
05-29 23:35:23.369+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), hold(0) freeze(0)
05-29 23:35:23.389+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3965 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), block(2)
05-29 23:35:23.389+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), ev->cur.canvas.x(187) ev->cur.canvas.y(78)
05-29 23:35:23.389+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), hold(0) freeze(0)
05-29 23:35:23.399+0900 E/EFL     ( 1177): evas_main<1177> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1067805 button=1 downs=0
05-29 23:35:23.419+0900 E/EFL     ( 1255): evas_main<1255> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1067807 button=1 downs=0
05-29 23:35:23.419+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 0
05-29 23:35:23.419+0900 W/AUL_AMD (  957): amd_launch.c: _start_app(1659) > caller pid : 1255
05-29 23:35:23.429+0900 W/AUL_AMD (  957): amd_launch.c: __nofork_processing(1138) > __nofork_processing, cmd: 0, pid: 1177
05-29 23:35:23.429+0900 I/APP_CORE( 1177): appcore-efl.c: __do_app(429) > [APP 1177] Event: RESET State: RUNNING
05-29 23:35:23.429+0900 I/CAPI_APPFW_APPLICATION( 1177): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-29 23:35:23.429+0900 W/W_HOME  ( 1177): main.c: _app_control(1737) > Service value : launch_apps
05-29 23:35:23.429+0900 W/W_HOME  ( 1177): move.c: move_move_to_apps(216) > move to apps
05-29 23:35:23.429+0900 W/AUL_AMD (  957): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(1177), cmd(0)
05-29 23:35:23.449+0900 W/W_HOME  ( 1177): rotary.c: rotary_attach(138) > rotary_attach:0xb77910b0
05-29 23:35:23.449+0900 I/efl-extension( 1177): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb77910b0, elm_layout, _activated_obj : 0xb768d858, activated : 1
05-29 23:35:23.449+0900 I/efl-extension( 1177): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 23:35:23.449+0900 W/W_HOME  ( 1177): event_manager.c: _move_module_anim_start_cb(635) > state: 0 -> 1
05-29 23:35:23.459+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:35:23.459+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:35:23.479+0900 I/APP_CORE( 1177): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
05-29 23:35:23.479+0900 W/W_HOME  ( 1177): event_manager.c: _apptray_visibility_cb(578) > apps,show,start
05-29 23:35:23.479+0900 W/W_HOME  ( 1177): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 0
05-29 23:35:23.479+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:35:23.479+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:35:23.479+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:35:23.479+0900 W/W_HOME  ( 1177): noti_broker.c: _apptray_visibility_cb(793) > apps,show,start
05-29 23:35:23.479+0900 W/W_HOME  ( 1177): noti_broker.c: noti_broker_event_fire_to_plugin(1011) > source:1 event:80002
05-29 23:35:23.479+0900 I/wnotib  ( 1177): w-notification-board-broker-main.c: _wnotib_view_event_handler(1182) > Home view event: 0x80002
05-29 23:35:23.479+0900 I/wnotib  ( 1177): w-notification-board-broker-main.c: _wnotib_view_event_handler(1263) > Unhandled type: 0x80002
05-29 23:35:23.799+0900 W/W_HOME  ( 1177): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
05-29 23:35:23.799+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:35:23.809+0900 W/W_HOME  ( 1177): rotary.c: rotary_deattach(156) > rotary_deattach:0xb77910b0
05-29 23:35:23.809+0900 I/efl-extension( 1177): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 23:35:23.809+0900 I/efl-extension( 1177): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xb77910b0, elm_layout, func : 0xb6eaffd1
05-29 23:35:23.809+0900 I/efl-extension( 1177): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-29 23:35:23.809+0900 I/efl-extension( 1177): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-29 23:35:23.809+0900 I/efl-extension( 1177): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 23:35:23.809+0900 I/efl-extension( 1177): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb768d858, elm_box, _activated_obj : 0xb77910b0, activated : 1
05-29 23:35:23.809+0900 I/efl-extension( 1177): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 23:35:23.809+0900 E/wnotib  ( 1177): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 23:35:23.809+0900 I/wnotib  ( 1177): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1108) > No second depth view available.
05-29 23:35:23.809+0900 W/W_HOME  ( 1177): event_manager.c: _apptray_visibility_cb(578) > apps,show
05-29 23:35:23.809+0900 W/W_HOME  ( 1177): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 1
05-29 23:35:23.809+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 23:35:23.809+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 23:35:23.809+0900 W/W_HOME  ( 1177): main.c: home_pause(762) > clock/widget paused
05-29 23:35:23.809+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 23:35:23.819+0900 W/APPS    ( 1177): apps_main.c: _time_changed_cb(294) >  date : 29->29
05-29 23:35:23.829+0900 W/W_HOME  ( 1177): rotary.c: rotary_attach(138) > rotary_attach:0xaf663318
05-29 23:35:23.829+0900 I/efl-extension( 1177): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xaf663318, elm_layout, _activated_obj : 0xb768d858, activated : 1
05-29 23:35:23.829+0900 I/efl-extension( 1177): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 23:35:23.829+0900 W/W_HOME  ( 1177): noti_broker.c: _apptray_visibility_cb(793) > apps,show
05-29 23:35:23.829+0900 W/W_HOME  ( 1177): noti_broker.c: noti_broker_event_fire_to_plugin(1011) > source:1 event:80000
05-29 23:35:23.829+0900 I/wnotib  ( 1177): w-notification-board-broker-main.c: _wnotib_view_event_handler(1182) > Home view event: 0x80000
05-29 23:35:23.829+0900 I/wnotib  ( 1177): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1701) > is_app_tray_displayed: 1
05-29 23:35:23.829+0900 E/APPS    ( 1177): apps_main.c: apps_main_resume(619) >  resumed already
05-29 23:35:23.829+0900 W/MUSIC_TRANSFER( 3198): mt-consumer.c: mt_consumer_send_data(834) > [36m[TID:3198]   [MUSIC_PLAYER_EVENT]pStr : {"msgId":"musictransfer-start-req"}[0m
05-29 23:35:23.829+0900 I/GESTURE (  244): gesture.c: BackGestureSetProperty(4538) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 23:35:23.829+0900 I/GESTURE (  244): gesture.c: BackGestureSetProperty(4533) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 23:35:23.829+0900 I/GESTURE (  244): gesture.c: BackGestureSetProperty(4533) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 23:35:23.829+0900 I/GESTURE (  244): gesture.c: BackGestureSetProperty(4533) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 23:35:23.899+0900 W/W_HOME  ( 1177): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
05-29 23:35:24.429+0900 W/AUL_AMD (  957): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 23:35:24.429+0900 W/AUL_AMD (  957): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
05-29 23:35:25.289+0900 W/WG-CONSUMER( 3197): [34m[F:AutoTransfer.cpp L:   86][_HIGH]Send StartAutoSync message to Peer[0m
05-29 23:35:25.289+0900 W/WG-CONSUMER( 3197): [34m[F:ReceiverCtrl.cpp L:  550][_HIGH]OnAutoTransferSendRequest. bAutoTransfer=0[0m
05-29 23:35:25.289+0900 W/WG-CONSUMER( 3197): [34m[F:ConnectionInfo.c L:  329][_HIGH][RX][Gear->Phone][2] SendData[37] z jreHa 9!d`jidpxqp`mpeco,qs^ps,odo|[0m
05-29 23:35:25.309+0900 W/WG-CONSUMER( 3197): [34m[F:ReceiverCtrl.cpp L:  573][_HIGH]Send CAutoTransferStart MSG[0m
05-29 23:35:25.589+0900 I/GESTURE (  244): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-29 23:35:25.589+0900 E/EFL     ( 1177): evas_main<1177> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1069997 button=1 downs=1
05-29 23:35:25.589+0900 W/APPS    ( 1177): AppsViewNecklace.cpp: touchPressed(1261) >  TOUCH [117, 53]
05-29 23:35:25.689+0900 E/EFL     ( 1177): evas_main<1177> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1070094 button=1 downs=0
05-29 23:35:25.689+0900 W/APPS    ( 1177): AppsViewNecklace.cpp: touchReleased(1579) >  TOUCH [117, 53]->[121, 71]
05-29 23:35:25.689+0900 W/APPS    ( 1177): AppsViewNecklace.cpp: runFocusAni(3000) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[8]
05-29 23:35:25.709+0900 E/APPS    ( 1177): AppsViewNecklace.cpp: runEmptyBoxForwardAnimation(3525) >  (!__pEmptyBox) -> runEmptyBoxForwardAnimation() return
05-29 23:35:25.779+0900 I/APP_CORE( 1139): appcore-efl.c: __do_app(429) > [APP 1139] Event: MEM_FLUSH State: PAUSED
05-29 23:35:25.989+0900 W/APPS    ( 1177): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4390) >  auto launch is disabled
05-29 23:35:26.459+0900 I/GESTURE (  244): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-29 23:35:26.459+0900 E/EFL     ( 1177): evas_main<1177> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1070863 button=1 downs=1
05-29 23:35:26.459+0900 W/APPS    ( 1177): AppsViewNecklace.cpp: touchPressed(1261) >  TOUCH [119, 52]
05-29 23:35:26.579+0900 E/EFL     ( 1177): evas_main<1177> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1070982 button=1 downs=0
05-29 23:35:26.579+0900 W/APPS    ( 1177): AppsViewNecklace.cpp: touchReleased(1579) >  TOUCH [119, 52]->[130, 79]
05-29 23:35:26.579+0900 W/APPS    ( 1177): AppsViewNecklace.cpp: runFocusAni(3000) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[16]
05-29 23:35:26.589+0900 E/APPS    ( 1177): AppsViewNecklace.cpp: runEmptyBoxForwardAnimation(3525) >  (!__pEmptyBox) -> runEmptyBoxForwardAnimation() return
05-29 23:35:26.849+0900 W/APPS    ( 1177): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4390) >  auto launch is disabled
05-29 23:35:27.419+0900 I/GESTURE (  244): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-29 23:35:27.419+0900 E/EFL     ( 1177): evas_main<1177> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1071819 button=1 downs=1
05-29 23:35:27.419+0900 W/APPS    ( 1177): AppsViewNecklace.cpp: touchPressed(1261) >  TOUCH [98, 62]
05-29 23:35:27.469+0900 E/EFL     ( 1177): evas_main<1177> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1071871 button=1 downs=0
05-29 23:35:27.469+0900 W/APPS    ( 1177): AppsViewNecklace.cpp: touchReleased(1579) >  TOUCH [98, 62]->[109, 70]
05-29 23:35:27.469+0900 W/APPS    ( 1177): AppsViewNecklace.cpp: runFocusAni(3000) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[24]
05-29 23:35:27.479+0900 E/APPS    ( 1177): AppsViewNecklace.cpp: runEmptyBoxForwardAnimation(3525) >  (!__pEmptyBox) -> runEmptyBoxForwardAnimation() return
05-29 23:35:27.759+0900 W/APPS    ( 1177): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4390) >  auto launch is disabled
05-29 23:35:28.319+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __alarm_remove_from_list(454) > [alarm-server]:Remove alarm id(620831892)
05-29 23:35:28.319+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 23:35:28.319+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 23:35:28.319+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 23:35:28.319+0900 W/ALARM_MANAGER(  952): alarm-manager.c: alarm_manager_alarm_delete(2219) > alarm_id[620831892] is removed.
05-29 23:35:28.369+0900 I/AUL     (  952): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 23:35:28.389+0900 I/AUL     (  952): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 23:35:28.409+0900 I/AUL     (  952): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 23:35:28.419+0900 I/AUL     (  952): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 23:35:28.439+0900 I/AUL     (  952): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 23:35:28.449+0900 I/AUL     (  952): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 23:35:28.449+0900 W/ALARM_MANAGER(  952): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464532532, Sun May 29 23:35:32 2016
05-29 23:35:28.449+0900 W/ALARM_MANAGER(  952): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 2012029557, next duetime: 1464532532
05-29 23:35:28.449+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(2012029557)
05-29 23:35:28.449+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464532532)
05-29 23:35:28.459+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 23:35:28.459+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 29-5-2016, 14:35:32 (UTC).
05-29 23:35:28.459+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 23:35:28.459+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __alarm_remove_from_list(454) > [alarm-server]:Remove alarm id(2012029557)
05-29 23:35:28.459+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 23:35:28.459+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 23:35:28.459+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 23:35:28.459+0900 W/ALARM_MANAGER(  952): alarm-manager.c: alarm_manager_alarm_delete(2219) > alarm_id[2012029557] is removed.
05-29 23:35:28.479+0900 I/AUL     (  952): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 23:35:28.489+0900 I/AUL     (  952): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 23:35:28.509+0900 I/AUL     (  952): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 23:35:28.519+0900 I/AUL     (  952): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 23:35:28.529+0900 I/AUL     (  952): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 23:35:28.539+0900 I/AUL     (  952): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 23:35:28.539+0900 W/ALARM_MANAGER(  952): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464575728, Mon May 30 11:35:28 2016
05-29 23:35:28.539+0900 W/ALARM_MANAGER(  952): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 2012029557, next duetime: 1464575728
05-29 23:35:28.539+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(2012029557)
05-29 23:35:28.539+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464575728)
05-29 23:35:28.539+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 23:35:28.539+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 23:35:28.539+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 23:35:28.599+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 23:35:28.619+0900 W/AUL_AMD (  957): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 23:35:28.619+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 26
05-29 23:35:28.629+0900 I/AUL_AMD (  957): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
05-29 23:35:28.639+0900 I/AUL_AMD (  957): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
05-29 23:35:28.639+0900 E/AUL_AMD (  957): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
05-29 23:35:28.639+0900 W/AUL_AMD (  957): amd_launch.c: _start_app(1659) > caller pid : 949
05-29 23:35:28.659+0900 E/RESOURCED(  958): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-29 23:35:28.659+0900 E/RESOURCED(  958): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 23:35:28.659+0900 W/AUL_AMD (  957): amd_launch.c: _start_app(2026) > pad pid(-5)
05-29 23:35:28.659+0900 W/AUL_PAD ( 1674): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
05-29 23:35:28.659+0900 W/AUL_PAD ( 1674): launchpad.c: __send_result_to_caller(265) > Check app launching
05-29 23:35:28.719+0900 I/efl-extension( 3176): efl_extension.c: eext_mod_init(40) > Init
05-29 23:35:28.719+0900 I/CAPI_APPFW_APPLICATION( 3176): app_main.c: ui_app_main(704) > app_efl_main
05-29 23:35:28.719+0900 I/CAPI_APPFW_APPLICATION( 3176): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-29 23:35:28.869+0900 E/E17     (  628): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05e00002)
05-29 23:35:28.919+0900 W/W_HOME  ( 1177): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-29 23:35:28.919+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 23:35:28.919+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 23:35:28.919+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 23:35:28.919+0900 W/W_HOME  ( 1177): main.c: _ecore_x_message_cb(1233) > main_info.is_win_on_top: 0
05-29 23:35:28.919+0900 I/GESTURE (  244): gesture.c: BackGestureSetProperty(4533) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 23:35:28.919+0900 I/GESTURE (  244): gesture.c: BackGestureSetProperty(4538) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 23:35:28.959+0900 E/EFL     ( 3176): ecore_evas<3176> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-29 23:35:29.009+0900 I/efl-extension( 3176): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0xb7b3ec58]'s widget[0xb7b380a0] to elm_conformant widget[0xb7b08ff8]
05-29 23:35:29.129+0900 I/HAP     ( 3176): SUCCESSFULLY create sap agent
05-29 23:35:29.139+0900 I/HAP     ( 3176): connectivity type(1): bt
05-29 23:35:29.319+0900 I/HAP     ( 3176): agent is initialized
05-29 23:35:29.319+0900 I/HAP     ( 3176): agent initialized callback is over
05-29 23:35:29.319+0900 I/HAP     ( 3176): SAP >>> getRegisteredServiceAgent() >>> 0
05-29 23:35:29.419+0900 I/APP_CORE( 3176): appcore-efl.c: __do_app(429) > [APP 3176] Event: RESET State: CREATED
05-29 23:35:29.419+0900 I/CAPI_APPFW_APPLICATION( 3176): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 23:35:29.439+0900 I/APP_CORE( 3176): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 23:35:29.439+0900 I/APP_CORE( 3176): appcore-efl.c: __do_app(474) > [APP 3176] Initial Launching, call the resume_cb
05-29 23:35:29.439+0900 I/CAPI_APPFW_APPLICATION( 3176): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 23:35:29.439+0900 W/APP_CORE( 3176): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
05-29 23:35:29.449+0900 I/efl-extension( 3176): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0xb7b3ec58 = w: 0 h: 0  obj 0xb7b380a0 w: 360 h: 360
05-29 23:35:29.449+0900 I/efl-extension( 3176): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 23:35:29.509+0900 W/W_HOME  ( 1177): event_manager.c: _window_visibility_cb(448) > Window [0x2800003] is now visible(1)
05-29 23:35:29.509+0900 W/W_HOME  ( 1177): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-29 23:35:29.509+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 23:35:29.509+0900 W/W_HOME  ( 1177): main.c: _window_visibility_cb(1200) > Window [0x2800003] is now visible(1)
05-29 23:35:29.509+0900 I/APP_CORE( 1177): appcore-efl.c: __do_app(429) > [APP 1177] Event: PAUSE State: RUNNING
05-29 23:35:29.509+0900 I/CAPI_APPFW_APPLICATION( 1177): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 23:35:29.509+0900 W/W_HOME  ( 1177): main.c: _appcore_pause_cb(692) > appcore pause
05-29 23:35:29.509+0900 W/W_HOME  ( 1177): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-29 23:35:29.509+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 23:35:29.509+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 23:35:29.509+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 23:35:29.509+0900 W/W_HOME  ( 1177): rotary.c: rotary_deattach(156) > rotary_deattach:0xaf663318
05-29 23:35:29.509+0900 I/efl-extension( 1177): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 23:35:29.509+0900 I/efl-extension( 1177): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xaf663318, elm_layout, func : 0xb6eaffd1
05-29 23:35:29.509+0900 I/efl-extension( 1177): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-29 23:35:29.509+0900 I/efl-extension( 1177): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-29 23:35:29.509+0900 I/efl-extension( 1177): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 23:35:29.509+0900 I/efl-extension( 1177): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb768d858, elm_box, _activated_obj : 0xaf663318, activated : 1
05-29 23:35:29.509+0900 I/efl-extension( 1177): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 23:35:29.509+0900 E/wnotib  ( 1177): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 23:35:29.509+0900 I/wnotib  ( 1177): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1108) > No second depth view available.
05-29 23:35:29.529+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 23:35:29.529+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 23:35:29.529+0900 I/MESSAGE_PORT(  866): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 23:35:29.529+0900 I/MESSAGE_PORT(  866): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-29 23:35:29.529+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-29 23:35:29.529+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 23:35:29.529+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-29 23:35:29.529+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 23:35:29.539+0900 W/AUL_AMD (  957): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 23:35:29.539+0900 W/AUL_AMD (  957): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
05-29 23:35:29.659+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 23:35:29.659+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 23:35:29.659+0900 I/MESSAGE_PORT(  866): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 23:35:29.659+0900 I/MESSAGE_PORT(  866): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-29 23:35:29.659+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-29 23:35:29.659+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 23:35:29.659+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-29 23:35:29.659+0900 I/MESSAGE_PORT(  866): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-29 23:35:29.659+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-29 23:35:29.659+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 23:35:29.659+0900 I/GESTURE (  244): gesture.c: BackGestureSetProperty(4538) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 23:35:29.659+0900 I/GESTURE (  244): gesture.c: BackGestureSetProperty(4538) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 23:35:29.719+0900 I/APP_CORE( 3176): appcore-efl.c: __do_app(429) > [APP 3176] Event: RESUME State: RUNNING
05-29 23:35:29.909+0900 I/HAP     ( 3176): Updating UI with data Connection Established
05-29 23:35:30.089+0900 I/wnotib  ( 1177): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-29 23:35:30.089+0900 E/wnotib  ( 1177): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 23:35:30.159+0900 I/APP_CORE( 1177): appcore-efl.c: __do_app(429) > [APP 1177] Event: MEM_FLUSH State: PAUSED
05-29 23:35:30.179+0900 E/CAPI_APPFW_APP_CONTROL( 1615): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-29 23:35:30.179+0900 W/MUSIC_CONTROL_SERVICE( 1615): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1615]   value = [false][0m
05-29 23:35:30.549+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 23:35:30.559+0900 W/AUL_AMD (  957): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3176
05-29 23:35:30.569+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 12
05-29 23:35:30.999+0900 I/AUL_PAD ( 3259): launchpad_loader.c: main(600) > [candidate] elm init, returned: 1
05-29 23:35:33.579+0900 I/HAP     ( 3176): routes length: 1
05-29 23:35:33.599+0900 I/tag     ( 3176): get_tts_state state = 1
05-29 23:35:33.609+0900 I/tag     ( 3176): get_tts_state state = 1
05-29 23:35:33.739+0900 W/CRASH_MANAGER( 3209): worker.c: worker_job(1199) > 1103176686170146453253
