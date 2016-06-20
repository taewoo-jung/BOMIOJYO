S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.5
Build-Number: R732XXU2CPC5
Build-Date: 2016.03.21 17:05:24

Crash Information
Process Name: hap
PID: 3524
Date: 2016-05-31 17:40:12+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 3524, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x55e6b200, r3   = 0x44f764f8
r4   = 0x00000000, r5   = 0x00000000
r6   = 0x44f76510, r7   = 0x46ab57f8
r8   = 0x40381540, r9   = 0x40381540
r10  = 0x00000400, fp   = 0x403806a8
ip   = 0x4008aa5c, sp   = 0x4bbdd830
lr   = 0x407704c5, pc   = 0x403610b8
cpsr = 0x60000030

Memory Information
MemTotal:   491012 KB
MemFree:     32796 KB
Buffers:     14420 KB
Cached:     101620 KB
VmPeak:     193600 KB
VmSize:     157776 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26400 KB
VmRSS:       24152 KB
VmData:      92236 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       29300 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 3524 TID = 3713
3524 3652 3654 3655 3694 3713 

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
4143c000 41444000 r-xp /usr/lib/libmdm-common.so.1.0.89
41445000 4144a000 r-xp /usr/lib/libappcore-common.so.1.1
41452000 41454000 r-xp /usr/lib/libiniparser.so.0
4145d000 41465000 r-xp /opt/usr/apps/org.example.hap/bin/hap
41472000 41476000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4147f000 41481000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4148a000 41490000 r-xp /usr/lib/libappsvc.so.0.1.0
41498000 414bc000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414c5000 41594000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415aa000 415b4000 r-xp /lib/libnss_files-2.13.so
4175c000 41767000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41771000 41779000 r-xp /usr/lib/libcapi-media-recorder.so.0.1.27
41781000 41786000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
4178e000 41793000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4179b000 417bc000 r-xp /usr/lib/libefl-extension.so.0.1.0
417c4000 417d6000 r-xp /usr/lib/libtts.so
417de000 417eb000 r-xp /usr/lib/libsap-client-stub-api.so.1.0.0
417f3000 41805000 r-xp /usr/lib/libcapi-media-camera.so.0.1.34
4180d000 41866000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
41874000 4190f000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
4191a000 41920000 rw-p [heap]
41920000 41a52000 rw-p [heap]
41a52000 41b0a000 r-xp /usr/lib/libcairo.so.2.11200.14
41b15000 41b1d000 r-xp /usr/lib/libsap_client.so.0.0.0
41b25000 41b2a000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41b32000 41b39000 r-xp /usr/lib/libtbm.so.1.0.0
41b41000 41b4e000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
41b57000 41b60000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
41b68000 41b89000 r-xp /usr/lib/libexif.so.12.3.3
41b9c000 41bb2000 r-xp /usr/lib/libmmfsound.so.0.1.0
41bc4000 41bc9000 r-xp /usr/lib/libmmfsession.so.0.0.0
41bd1000 41c09000 r-xp /usr/lib/libpulse.so.0.16.2
41c0a000 41c0c000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
41c14000 41c19000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41c21000 41c3a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
41c43000 41c4d000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
41c59000 41c60000 r-xp /usr/lib/libmmfcommon.so.0.0.0
41c68000 41c99000 r-xp /usr/lib/libmdm.so.1.1.85
41ca1000 41caf000 r-xp /usr/lib/libGLESv2.so.2.0
41cb8000 41cb9000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41cc2000 41cc8000 r-xp /usr/lib/libxcb-render.so.0.0.0
41cd0000 41cd3000 r-xp /usr/lib/libEGL.so.1.4
41cdb000 41ce3000 r-xp /usr/lib/libdrm.so.2.4.0
41ceb000 41d2c000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
41d35000 41d39000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
41d42000 41d58000 r-xp /usr/lib/libavsysaudio.so.0.0.1
41d61000 41d66000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
41d6e000 41d71000 r-xp /usr/lib/libpulse-simple.so.0.0.4
41d79000 41dda000 r-xp /usr/lib/libasound.so.2.0.0
41de4000 41de7000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
41def000 41dfc000 r-xp /usr/lib/libail.so.0.1.0
41e05000 41f42000 r-xp /usr/lib/libicui18n.so.51.1
41f52000 42036000 r-xp /usr/lib/libicuuc.so.51.1
435d2000 435e2000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
43603000 4360b000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
4361a000 4361f000 r-xp /usr/lib/libjson.so.0.0.1
43627000 4366f000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
43670000 436b3000 r-xp /usr/lib/libsndfile.so.1.0.25
436c0000 436c6000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
436ce000 436d6000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
436de000 436e3000 r-xp /usr/lib/libcsc-feature.so.0.0.0
436eb000 436ee000 r-xp /usr/lib/libcompress.so.0.2.0
436f6000 43718000 r-xp /usr/lib/libvorbis.so.0.4.3
43720000 43724000 r-xp /usr/lib/libogg.so.0.7.1
4372c000 43748000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43751000 43758000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43761000 43763000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
4376b000 43772000 r-xp /usr/lib/libminizip.so.1.0.0
4377a000 43844000 r-xp /usr/lib/libCOREGL.so.4.0
43c87000 43c92000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c9b000 43c9f000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43cb0000 43cb2000 r-xp /usr/lib/libdri2.so.0.0.0
43cba000 43cd1000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43cde000 43ce0000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
444e9000 44ce8000 rwxp [stack:3694]
44ce8000 44ce9000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44cf1000 44cf2000 r-xp /usr/lib/gstreamer-0.10/libgstapp.so
44cfa000 44cfd000 r-xp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
44d06000 44d0d000 r-xp /usr/lib/libfeedback.so.0.1.4
44d16000 44d17000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44d1f000 44d21000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
44d29000 44d33000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
44dba000 44dc6000 r-xp /usr/lib/gstreamer-0.10/libgstencodebin.so
44dce000 44dd3000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
44e78000 44e79000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
4500d000 4580c000 rwxp [stack:3652]
4580d000 4600c000 rwxp [stack:3654]
4600d000 4680c000 rwxp [stack:3655]
4688b000 468bf000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
468c8000 468e8000 r-xp /usr/lib/gstreamer-0.10/libgstomx.so
468f0000 468f6000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
46bfe000 46d5c000 r-xp /usr/lib/gstreamer-0.10/libgstffmpeg.so
46e44000 46e49000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
46e59000 46e82000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
46e8b000 46ea3000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
46eac000 46ec4000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
46ecc000 46ed1000 r-xp /usr/lib/gstreamer-0.10/libgstsecrecord.so
46ee2000 46f1a000 r-xp /usr/lib/libsaac.so
46f1b000 46f21000 r-xp /usr/lib/libscmn.so
46f29000 46f39000 r-xp /usr/lib/gstreamer-0.10/libgstalsa.so
46f41000 46f4c000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
46f56000 46f8e000 r-xp /usr/lib/libsamrnb.so
46faf000 46fc9000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
46fd2000 46fd5000 r-xp /usr/lib/gstreamer-0.10/libgstwavenc.so
4b3e0000 4bbdf000 rwxp [stack:3713]
be9f8000 bea19000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3524)
Call Stack Count: 4
 0: edje_object_message_signal_process + 0x13b (0x403610b8) [/usr/lib/libedje.so.1] + 0x460b8
 1: (0x400f86ed) [/usr/lib/libelementary.so.1] + 0x4e6ed
 2: elm_widget_theme + 0x90 (0x4019b08d) [/usr/lib/libelementary.so.1] + 0xf108d
 3: _popup_toast_cb + 0x28 (0x4145fca1) [/opt/usr/apps/org.example.hap/bin/hap] + 0x2ca1
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
5.225+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-31 17:39:25.315+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-31 17:39:25.315+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 17:39:25.315+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-31 17:39:25.315+0900 I/HIGEAR  ( 1080): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-31 17:39:25.320+0900 I/watchface-viewer(  752): viewer-data-provider.cpp: AddPendingChanges(1088) > added [37] to pending list
05-31 17:39:25.320+0900 I/watchface-viewer(  752): viewer-data-provider.cpp: AddPendingChanges(1088) > added [39] to pending list
05-31 17:39:25.325+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 48 -> 47 1464683965 60
05-31 17:39:25.325+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 47 683 383 535
05-31 17:39:25.325+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 47 0 0 918
05-31 17:39:25.325+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 47 942 382 738
05-31 17:39:25.325+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 47 186 5 146
05-31 17:39:25.325+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 47 364 30 285
05-31 17:39:25.990+0900 I/aa      ( 3513): db hi = 0
05-31 17:39:26.995+0900 I/aa      ( 3513): res = -26542062
05-31 17:39:26.995+0900 E/TIZEN_N_RECORDER( 3513): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
05-31 17:39:27.000+0900 I/aa      ( 3513): res = -26542062
05-31 17:39:27.005+0900 I/aa      ( 3513): db hi = -16.201134
05-31 17:39:27.045+0900 I/HAP     ( 3513): Updating UI with data 주의 하세요!
05-31 17:39:27.770+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:39:27.840+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3513
05-31 17:39:30.125+0900 I/aa      ( 3513): db hi = 0
05-31 17:39:30.185+0900 I/APP_CORE( 3513): appcore-efl.c: __do_app(429) > [APP 3513] Event: MEM_FLUSH State: PAUSED
05-31 17:39:30.725+0900 E/WMS     (  496): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-31 17:39:30.725+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-31 17:39:30.725+0900 E/WMS     (  496): ==========
05-31 17:39:30.725+0900 E/WMS     (  496): ##WMS SEND : mgr_gear_wear_onoff_req
05-31 17:39:30.725+0900 E/WMS     (  496): ==========
05-31 17:39:30.725+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-31 17:39:31.130+0900 I/aa      ( 3513): res = -26542062
05-31 17:39:31.130+0900 E/TIZEN_N_RECORDER( 3513): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
05-31 17:39:31.140+0900 I/aa      ( 3513): res = -26542062
05-31 17:39:31.145+0900 I/aa      ( 3513): db hi = -16.201134
05-31 17:39:31.200+0900 I/HAP     ( 3513): Updating UI with data 주의 하세요!
05-31 17:39:31.755+0900 W/CRASH_MANAGER( 3626): worker.c: worker_job(1199) > 11035136861701464683971
05-31 17:39:32.005+0900 I/APP_CORE( 2547): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
05-31 17:39:32.020+0900 W/AUL_AMD (  498): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 17:39:32.020+0900 W/AUL_AMD (  498): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-31 17:39:32.845+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:39:32.860+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-31 17:39:32.865+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 4
05-31 17:39:32.865+0900 E/AUL_AMD (  498): amd_request.c: __app_process_by_pid(193) > pid(3513) is dead. cmd(4) is canceled
05-31 17:39:35.175+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-31 17:39:35.175+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-31 17:39:35.175+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:39:35.175+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:39:35.175+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-31 17:39:35.175+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-31 17:39:35.175+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-31 17:39:35.175+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-31 17:39:35.180+0900 W/W_HOME  (  722): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-31 17:39:35.180+0900 W/W_HOME  (  722): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-31 17:39:35.215+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
05-31 17:39:35.215+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1149) > Call the time_tick_cb
05-31 17:39:35.220+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:39:35.220+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:39:35.220+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-31 17:39:35.225+0900 W/W_HOME  (  722): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-31 17:39:35.225+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_set(161) > timer set
05-31 17:39:35.225+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-31 17:39:35.225+0900 W/W_HOME  (  722): gesture.c: _apps_status_get(123) > apps status:0
05-31 17:39:35.225+0900 W/W_HOME  (  722): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:0 info->offtime:10326
05-31 17:39:35.225+0900 W/W_HOME  (  722): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-31 17:39:35.225+0900 W/W_HOME  (  722): event_manager.c: _lcd_on_cb(691) > lcd state: 1
05-31 17:39:35.225+0900 W/W_HOME  (  722): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 17:39:35.230+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [gesture] after screen off time [10326]ms
05-31 17:39:35.230+0900 W/STARTER (  697): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
05-31 17:39:35.255+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:39:35.255+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: RESUME State: PAUSED
05-31 17:39:35.255+0900 I/CAPI_APPFW_APPLICATION( 2547): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 17:39:35.260+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:39:35.260+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(834537451)
05-31 17:39:35.260+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:39:35.260+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 15:00:00 (UTC).
05-31 17:39:35.260+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:39:35.260+0900 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[834537451] is removed.
05-31 17:39:35.285+0900 I/watchface-viewer(  752): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
05-31 17:39:35.315+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [gesture]
05-31 17:39:35.315+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
05-31 17:39:35.335+0900 W/MUSIC_CONTROL_SERVICE( 1056): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1056]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
05-31 17:39:35.350+0900 I/SHealth_Common( 1102): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
05-31 17:39:35.350+0900 I/SHealth_Service( 1102): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-31 17:39:35.355+0900 I/efl-extension(  722): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 17:39:35.355+0900 I/w-magazine-widget(  803): widget.c: widget_resume(1079) > Resumed
05-31 17:39:35.375+0900 W/SHealth_Service( 1102): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
05-31 17:39:35.380+0900 E/SHealth_Service( 1102): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-31 17:39:35.385+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_set_param(1248) > [SVOICE] set param [keyword length] : 0
05-31 17:39:35.385+0900 I/CAPI_WIDGET_APPLICATION(  803): widget_app.c: __provider_resume_cb(314) > widget obj was resumed
05-31 17:39:35.395+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-31 17:39:35.400+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Enable start
05-31 17:39:35.430+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
05-31 17:39:35.430+0900 W/W_HOME  (  722): gesture.c: _manual_render_enable(133) > 0
05-31 17:39:35.475+0900 I/efl-extension( 1724): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 17:39:35.475+0900 I/CAPI_WIDGET_APPLICATION(  803): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
05-31 17:39:35.480+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-31 17:39:35.480+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-31 17:39:35.480+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : pedometer_inactive_period error
05-31 17:39:35.480+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-31 17:39:35.480+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-31 17:39:35.480+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : inactive_10min_precaution_millisec error
05-31 17:39:35.480+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-31 17:39:35.490+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-31 17:39:35.490+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : inactive_before_10min_precaution_millisec error
05-31 17:39:35.570+0900 E/WMS     (  496): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 2 -> 1
05-31 17:39:35.570+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-31 17:39:35.570+0900 E/WMS     (  496): ==========
05-31 17:39:35.570+0900 E/WMS     (  496): ##WMS SEND : mgr_gear_wear_onoff_req
05-31 17:39:35.570+0900 E/WMS     (  496): ==========
05-31 17:39:35.570+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-31 17:39:35.600+0900 W/SHealth_Service( 1102): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1007[0;m
05-31 17:39:35.670+0900 E/SHealth_Service( 1102): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-31 17:39:35.685+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-31 17:39:35.685+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 17:39:35.685+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
05-31 17:39:35.685+0900 I/HIGEAR  ( 1080): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
05-31 17:39:35.685+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : 1075153676[0;m
05-31 17:39:35.690+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
05-31 17:39:35.690+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-31 17:39:35.690+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_set_param(1248) > [SVOICE] set param [keyword length] : 0
05-31 17:39:35.695+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-31 17:39:35.695+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Enable start
05-31 17:39:35.700+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-31 17:39:35.700+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 17:39:35.700+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
05-31 17:39:35.700+0900 I/HIGEAR  ( 1080): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
05-31 17:39:37.090+0900 E/EFL     ( 2547): evas_main<2547> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=40274386 button=1 downs=1
05-31 17:39:37.100+0900 E/EFL     ( 2547): evas_main<2547> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=40274396 button=1 downs=0
05-31 17:39:37.215+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 0
05-31 17:39:37.225+0900 I/AUL_AMD (  498): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-31 17:39:37.235+0900 I/AUL_AMD (  498): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-31 17:39:37.235+0900 E/AUL_AMD (  498): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-31 17:39:37.235+0900 W/AUL_AMD (  498): amd_launch.c: _start_app(1702) > caller pid : 699
05-31 17:39:37.245+0900 E/RESOURCED(  499): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-31 17:39:37.245+0900 E/RESOURCED(  499): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-31 17:39:37.250+0900 W/AUL_AMD (  498): amd_launch.c: _start_app(2080) > pad pid(-5)
05-31 17:39:37.250+0900 W/AUL_PAD ( 1201): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-31 17:39:37.250+0900 W/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(272) > Check app launching
05-31 17:39:37.395+0900 I/efl-extension( 3524): efl_extension.c: eext_mod_init(40) > Init
05-31 17:39:37.415+0900 I/CAPI_APPFW_APPLICATION( 3524): app_main.c: ui_app_main(704) > app_efl_main
05-31 17:39:37.430+0900 I/CAPI_APPFW_APPLICATION( 3524): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-31 17:39:37.460+0900 E/AUL     (  498): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-31 17:39:37.510+0900 E/TBM     ( 3524): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-31 17:39:37.585+0900 E/E17     (  388): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x07800002)
05-31 17:39:37.650+0900 E/EFL     ( 3524): ecore_evas<3524> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-31 17:39:37.685+0900 I/efl-extension( 3524): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0x43b945e0]'s widget[0x43b8e648] to elm_conformant widget[0x41a4d2f8]
05-31 17:39:37.780+0900 I/HAP     ( 3524): SUCCESSFULLY create sap agent
05-31 17:39:37.780+0900 I/HAP     ( 3524): connectivity type(1): bt
05-31 17:39:37.945+0900 I/HAP     ( 3524): agent is initialized
05-31 17:39:37.945+0900 I/HAP     ( 3524): agent initialized callback is over
05-31 17:39:37.945+0900 I/HAP     ( 3524): SAP >>> getRegisteredServiceAgent() >>> 0
05-31 17:39:38.050+0900 E/TIZEN_N_RECORDER( 3524): recorder.c: __convert_recorder_error_code(193) > [audio-channel] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:39:38.050+0900 E/TIZEN_N_RECORDER( 3524): recorder.c: __convert_recorder_error_code(193) > [audio-device] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:39:38.080+0900 I/APP_CORE( 3524): appcore-efl.c: __do_app(429) > [APP 3524] Event: RESET State: CREATED
05-31 17:39:38.080+0900 I/CAPI_APPFW_APPLICATION( 3524): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-31 17:39:38.095+0900 I/APP_CORE( 3524): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-31 17:39:38.100+0900 I/APP_CORE( 3524): appcore-efl.c: __do_app(474) > [APP 3524] Initial Launching, call the resume_cb
05-31 17:39:38.100+0900 I/CAPI_APPFW_APPLICATION( 3524): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 17:39:38.105+0900 W/APP_CORE( 3524): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7800002
05-31 17:39:38.110+0900 I/efl-extension( 3524): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x43b945e0 = w: 0 h: 0  obj 0x43b8e648 w: 360 h: 360
05-31 17:39:38.110+0900 I/efl-extension( 3524): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-31 17:39:38.160+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: PAUSE State: RUNNING
05-31 17:39:38.160+0900 I/CAPI_APPFW_APPLICATION( 2547): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-31 17:39:38.180+0900 W/AUL_AMD (  498): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 17:39:38.180+0900 W/AUL_AMD (  498): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-31 17:39:38.205+0900 I/APP_CORE( 3524): appcore-efl.c: __do_app(429) > [APP 3524] Event: RESUME State: RUNNING
05-31 17:39:38.210+0900 I/w-magazine-widget(  803): widget.c: widget_pause(1057) > Paused
05-31 17:39:38.220+0900 I/CAPI_WIDGET_APPLICATION(  803): widget_app.c: __provider_pause_cb(296) > widget obj was paused
05-31 17:39:38.220+0900 I/CAPI_WIDGET_APPLICATION(  803): widget_app.c: __check_status_for_cgroup(145) > enter background group
05-31 17:39:38.560+0900 E/AUL     (  498): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-31 17:39:38.815+0900 I/AUL_PAD ( 3656): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-31 17:39:38.875+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:39:38.885+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3524
05-31 17:39:38.885+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 12
05-31 17:39:40.715+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:39:40.720+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:39:40.720+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(559910215)
05-31 17:39:40.720+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:39:40.720+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 15:00:00 (UTC).
05-31 17:39:40.720+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:39:40.720+0900 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[559910215] is removed.
05-31 17:39:40.730+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:39:40.735+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:39:40.750+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:39:40.765+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:39:40.780+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:39:40.795+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:39:40.795+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-31 17:39:40.795+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-31 17:39:40.810+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:39:40.825+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:39:40.825+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464683984, Tue May 31 17:39:44 2016
05-31 17:39:40.825+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 567287400, next duetime: 1464683984
05-31 17:39:40.825+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(567287400)
05-31 17:39:40.825+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464706800), due_time(1464683984)
05-31 17:39:40.825+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:39:40.825+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 08:39:44 (UTC).
05-31 17:39:40.825+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:39:40.835+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:39:40.835+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:39:40.835+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(567287400)
05-31 17:39:40.835+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:39:40.835+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 15:00:00 (UTC).
05-31 17:39:40.835+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:39:40.835+0900 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[567287400] is removed.
05-31 17:39:40.845+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:39:40.845+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:39:40.860+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:39:40.875+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:39:40.890+0900 I/efl-extension( 1724): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 17:39:40.890+0900 I/efl-extension(  722): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 17:39:40.890+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:39:40.905+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:39:40.905+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-31 17:39:40.910+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-31 17:39:40.920+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:39:40.930+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:39:40.930+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464727180, Wed Jun  1 05:39:40 2016
05-31 17:39:40.930+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 567287400, next duetime: 1464727180
05-31 17:39:40.930+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(567287400)
05-31 17:39:40.930+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464706800), due_time(1464727180)
05-31 17:39:40.930+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:39:40.930+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 15:00:00 (UTC).
05-31 17:39:40.930+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:39:42.470+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:39:42.545+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3524
05-31 17:39:42.740+0900 I/RESOURCED(  499): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-31 17:39:42.740+0900 I/RESOURCED(  499): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-31 17:39:42.745+0900 I/RESOURCED(  499): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
05-31 17:39:43.190+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: MEM_FLUSH State: PAUSED
05-31 17:39:46.985+0900 E/EFL     ( 3524): evas_main<3524> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=40284279 button=1 downs=1
05-31 17:39:47.115+0900 E/EFL     ( 3524): evas_main<3524> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=40284359 button=1 downs=0
05-31 17:39:47.320+0900 E/TIZEN_N_RECORDER( 3524): recorder.c: __convert_recorder_error_code(193) > [recorder_set_filename] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:39:47.320+0900 E/TIZEN_N_RECORDER( 3524): recorder.c: __convert_recorder_error_code(193) > [file-format] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:39:47.320+0900 E/TIZEN_N_RECORDER( 3524): recorder.c: __convert_recorder_error_code(193) > [audio-encoder] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:39:47.380+0900 I/PRIVACY-MANAGER-CLIENT( 3524): PrivacyChecker.cpp: initialize(168) > Got lock. Starting initialize
05-31 17:39:47.380+0900 I/PRIVACY-MANAGER-CLIENT( 3524): PrivacyChecker.cpp: runSignalListenerThread(194) > Running g main loop for signal
05-31 17:39:47.380+0900 I/PRIVACY-MANAGER-CLIENT( 3524): PrivacyChecker.cpp: initializeDbus(220) > Starting initialize
05-31 17:39:47.430+0900 I/PRIVACY-MANAGER-CLIENT( 3524): PrivacyChecker.cpp: initializeDbus(235) > Initialized
05-31 17:39:47.430+0900 I/PRIVACY-MANAGER-CLIENT( 3524): PrivacyChecker.cpp: initialize(186) > Initialized
05-31 17:39:47.545+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:39:47.555+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3524
05-31 17:39:48.320+0900 E/TIZEN_N_RECORDER( 3524): recorder.c: __convert_recorder_error_code(193) > [recorder_start] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:39:48.320+0900 E/EFL     ( 3524): <3524> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:39:48.325+0900 E/EFL     ( 3524): <3524> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:39:48.350+0900 I/aa      ( 3524): chk = Off
05-31 17:39:49.355+0900 I/aa      ( 3524): res = 0
05-31 17:39:49.355+0900 I/aa      ( 3524): res = 0
05-31 17:39:49.355+0900 I/aa      ( 3524): db hi = 1076939232
05-31 17:39:50.360+0900 I/aa      ( 3524): res = 0
05-31 17:39:50.360+0900 I/aa      ( 3524): res = 0
05-31 17:39:50.360+0900 I/aa      ( 3524): db hi = -10.273180
05-31 17:39:50.445+0900 I/HAP     ( 3524): Updating UI with data 주의 하세요!
05-31 17:39:50.645+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-31 17:39:50.645+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-31 17:39:50.645+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:39:50.645+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:39:50.650+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-31 17:39:50.655+0900 W/W_HOME  (  722): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-31 17:39:50.660+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-31 17:39:50.665+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-31 17:39:50.665+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-31 17:39:50.670+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_set_param(1248) > [SVOICE] set param [keyword length] : 0
05-31 17:39:50.685+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-31 17:39:50.685+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Enable start
05-31 17:39:50.695+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-31 17:39:50.695+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 17:39:50.700+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
05-31 17:39:50.700+0900 I/HIGEAR  ( 1080): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
05-31 17:39:52.475+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:39:52.585+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3524
05-31 17:39:53.645+0900 I/aa      ( 3524): db hi = 0
05-31 17:39:54.650+0900 I/aa      ( 3524): res = 0
05-31 17:39:54.650+0900 I/aa      ( 3524): res = 0
05-31 17:39:54.650+0900 I/aa      ( 3524): db hi = 0
05-31 17:39:55.360+0900 E/EFL     ( 3524): evas_main<3524> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=40292647 button=1 downs=1
05-31 17:39:55.460+0900 E/EFL     ( 3524): evas_main<3524> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=40292742 button=1 downs=0
05-31 17:39:55.655+0900 I/aa      ( 3524): res = 0
05-31 17:39:55.655+0900 I/aa      ( 3524): res = 0
05-31 17:39:55.655+0900 I/aa      ( 3524): db hi = -24.119761
05-31 17:39:55.665+0900 I/HAP     ( 3524): Updating UI with data 주의 하세요!
05-31 17:39:56.210+0900 E/TIZEN_N_RECORDER( 3524): recorder.c: __convert_recorder_error_code(193) > [recorder_commit] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:39:56.215+0900 E/TIZEN_N_RECORDER( 3524): recorder.c: __convert_recorder_error_code(193) > [recorder_unprepare] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:39:57.595+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:39:57.690+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3524
05-31 17:39:58.715+0900 I/aa      ( 3524): db hi = 0
05-31 17:39:59.720+0900 I/aa      ( 3524): res = 0
05-31 17:39:59.720+0900 E/TIZEN_N_RECORDER( 3524): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
05-31 17:39:59.735+0900 I/aa      ( 3524): res = -26542062
05-31 17:39:59.740+0900 I/aa      ( 3524): db hi = -24.119761
05-31 17:39:59.805+0900 I/HAP     ( 3524): Updating UI with data 주의 하세요!
05-31 17:40:00.185+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-31 17:40:00.185+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-31 17:40:00.235+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : pedometer_inactive_period error
05-31 17:40:00.240+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-31 17:40:00.245+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-31 17:40:00.255+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : inactive_10min_precaution_millisec error
05-31 17:40:00.255+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-31 17:40:00.260+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-31 17:40:00.260+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : inactive_before_10min_precaution_millisec error
05-31 17:40:00.395+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-31 17:40:00.395+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-31 17:40:00.450+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:40:00.450+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:40:00.455+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-31 17:40:00.485+0900 W/W_HOME  (  722): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-31 17:40:00.540+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-31 17:40:00.540+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-31 17:40:00.545+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-31 17:40:00.550+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_set_param(1248) > [SVOICE] set param [keyword length] : 0
05-31 17:40:00.565+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-31 17:40:00.575+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Enable start
05-31 17:40:00.585+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-31 17:40:00.585+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 17:40:00.585+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
05-31 17:40:00.590+0900 I/HIGEAR  ( 1080): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
05-31 17:40:02.470+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:40:02.565+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3524
05-31 17:40:02.885+0900 I/aa      ( 3524): db hi = 0
05-31 17:40:03.890+0900 I/aa      ( 3524): res = -26542062
05-31 17:40:03.895+0900 E/TIZEN_N_RECORDER( 3524): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
05-31 17:40:03.905+0900 I/aa      ( 3524): res = -26542062
05-31 17:40:03.930+0900 I/aa      ( 3524): db hi = -24.119761
05-31 17:40:03.975+0900 I/HAP     ( 3524): Updating UI with data 주의 하세요!
05-31 17:40:07.055+0900 I/aa      ( 3524): db hi = 0
05-31 17:40:07.185+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-31 17:40:07.190+0900 W/W_HOME  (  722): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-31 17:40:07.190+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-31 17:40:07.190+0900 W/W_HOME  (  722): gesture.c: _manual_render_enable(133) > 1
05-31 17:40:07.190+0900 W/W_HOME  (  722): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-31 17:40:07.190+0900 W/W_HOME  (  722): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 17:40:07.200+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
05-31 17:40:07.200+0900 W/STARTER (  697): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-31 17:40:07.205+0900 E/STARTER (  697): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-31 17:40:07.205+0900 W/STARTER (  697): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-31 17:40:07.205+0900 W/STARTER (  697): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-31 17:40:07.260+0900 I/watchface-viewer(  752): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
05-31 17:40:07.295+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
05-31 17:40:07.295+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-31 17:40:07.300+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-31 17:40:07.300+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-31 17:40:07.335+0900 I/SHealth_Common( 1102): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-31 17:40:07.335+0900 I/SHealth_Service( 1102): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-31 17:40:07.335+0900 W/MUSIC_CONTROL_SERVICE( 1056): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1056]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-31 17:40:07.345+0900 E/ALARM_MANAGER(  697): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(31-5-2016, 17:40:27), repeat(1), interval(20), type(-1073741822)
05-31 17:40:07.345+0900 I/APP_CORE( 3524): appcore-efl.c: __do_app(429) > [APP 3524] Event: PAUSE State: RUNNING
05-31 17:40:07.345+0900 I/CAPI_APPFW_APPLICATION( 3524): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-31 17:40:07.355+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:40:07.355+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:40:07.360+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-31 17:40:07.360+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-31 17:40:07.360+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-31 17:40:07.365+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-31 17:40:07.460+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:40:07.470+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3524
05-31 17:40:07.470+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-31 17:40:07.470+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 17:40:07.470+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-31 17:40:07.470+0900 I/HIGEAR  ( 1080): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-31 17:40:07.480+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 945529445, next duetime: 1464684027
05-31 17:40:07.480+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(945529445)
05-31 17:40:07.485+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464706800), due_time(1464684027)
05-31 17:40:07.485+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:40:07.485+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 08:40:27 (UTC).
05-31 17:40:07.485+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:40:08.055+0900 I/aa      ( 3524): res = -26542062
05-31 17:40:08.055+0900 E/TIZEN_N_RECORDER( 3524): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
05-31 17:40:08.055+0900 I/aa      ( 3524): res = -26542062
05-31 17:40:08.055+0900 I/aa      ( 3524): db hi = -24.119761
05-31 17:40:08.145+0900 I/HAP     ( 3524): Updating UI with data 주의 하세요!
05-31 17:40:11.245+0900 I/aa      ( 3524): db hi = 0
05-31 17:40:12.250+0900 I/aa      ( 3524): res = -26542062
05-31 17:40:12.250+0900 E/TIZEN_N_RECORDER( 3524): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
05-31 17:40:12.260+0900 I/aa      ( 3524): res = -26542062
05-31 17:40:12.285+0900 I/aa      ( 3524): db hi = -24.119761
05-31 17:40:12.355+0900 I/APP_CORE( 3524): appcore-efl.c: __do_app(429) > [APP 3524] Event: MEM_FLUSH State: PAUSED
05-31 17:40:12.440+0900 I/HAP     ( 3524): Updating UI with data 주의 하세요!
05-31 17:40:12.475+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:40:12.485+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3524
05-31 17:40:12.495+0900 F/EFL     ( 3524): <3524> eina_list.c:730 eina_list_remove_list() *** Eina Magic Check Failed !!!
05-31 17:40:12.495+0900 F/EFL     ( 3524):     Input handle has already been freed!
05-31 17:40:12.495+0900 F/EFL     ( 3524): *** NAUGHTY PROGRAMMER!!!
05-31 17:40:12.495+0900 F/EFL     ( 3524): *** SPANK SPANK SPANK!!!
05-31 17:40:12.495+0900 F/EFL     ( 3524): *** Now go fix your code. Tut tut tut!
05-31 17:40:12.495+0900 F/EFL     ( 3524): 
05-31 17:40:12.780+0900 W/CRASH_MANAGER( 3748): worker.c: worker_job(1199) > 1103524686170146468401
