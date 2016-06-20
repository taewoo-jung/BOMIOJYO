S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.5
Build-Number: R732XXU2CPC5
Build-Date: 2016.03.21 17:05:24

Crash Information
Process Name: hap
PID: 3656
Date: 2016-05-31 17:41:17+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 3656, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x41953cd8
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x41953d40, r5   = 0x4194998c
r6   = 0x41953cd8, r7   = 0x41929a00
r8   = 0x00000000, r9   = 0x00000000
r10  = 0x4194973c, fp   = 0x00000003
ip   = 0x00000000, sp   = 0xbedbce28
lr   = 0x40333861, pc   = 0x4033111c
cpsr = 0x80000030

Memory Information
MemTotal:   491012 KB
MemFree:     27252 KB
Buffers:     14748 KB
Cached:     101988 KB
VmPeak:     196680 KB
VmSize:     194644 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28920 KB
VmRSS:       28916 KB
VmData:     120904 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       29300 KB
VmPTE:          94 KB
VmSwap:          0 KB

Threads Information
Threads: 13
PID = 3656 TID = 3656
3656 3778 3779 3780 3833 3834 3845 3846 3847 3848 3849 3850 3852 

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
4153c000 41544000 r-xp /usr/lib/libmdm-common.so.1.0.89
41545000 4154a000 r-xp /usr/lib/libappcore-common.so.1.1
41552000 41554000 r-xp /usr/lib/libiniparser.so.0
4155d000 41565000 r-xp /opt/usr/apps/org.example.hap/bin/hap
41572000 41576000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4157f000 41581000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4158a000 41590000 r-xp /usr/lib/libappsvc.so.0.1.0
41598000 415bc000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415c5000 41694000 r-xp /usr/lib/libscim-1.0.so.8.2.3
416aa000 416b4000 r-xp /lib/libnss_files-2.13.so
4195c000 41967000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41971000 41979000 r-xp /usr/lib/libcapi-media-recorder.so.0.1.27
41981000 41986000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
4198e000 41993000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4199b000 419bc000 r-xp /usr/lib/libefl-extension.so.0.1.0
419c4000 419d6000 r-xp /usr/lib/libtts.so
419de000 419eb000 r-xp /usr/lib/libsap-client-stub-api.so.1.0.0
419f3000 41a05000 r-xp /usr/lib/libcapi-media-camera.so.0.1.34
41a0d000 41a66000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
41a74000 41b0f000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
41b1b000 41bd3000 r-xp /usr/lib/libcairo.so.2.11200.14
41bde000 41be6000 r-xp /usr/lib/libsap_client.so.0.0.0
41bee000 41bf3000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41bfb000 41c02000 r-xp /usr/lib/libtbm.so.1.0.0
41c0a000 41c17000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
41c20000 41c29000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
41c31000 41c52000 r-xp /usr/lib/libexif.so.12.3.3
41c65000 41c7b000 r-xp /usr/lib/libmmfsound.so.0.1.0
41c8d000 41c92000 r-xp /usr/lib/libmmfsession.so.0.0.0
41c9a000 41cd2000 r-xp /usr/lib/libpulse.so.0.16.2
41cd3000 41cd5000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
41cdd000 41ce2000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41cea000 41d03000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
41d0c000 41d16000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
41d22000 41d29000 r-xp /usr/lib/libmmfcommon.so.0.0.0
41d31000 41d62000 r-xp /usr/lib/libmdm.so.1.1.85
41d6a000 41d78000 r-xp /usr/lib/libGLESv2.so.2.0
41d81000 41d82000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41d8b000 41d91000 r-xp /usr/lib/libxcb-render.so.0.0.0
41d99000 41d9c000 r-xp /usr/lib/libEGL.so.1.4
41da4000 41dac000 r-xp /usr/lib/libdrm.so.2.4.0
41db4000 41df5000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
41dfe000 41e02000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
41e0b000 41e21000 r-xp /usr/lib/libavsysaudio.so.0.0.1
41e2a000 41e2f000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
41e37000 41e3a000 r-xp /usr/lib/libpulse-simple.so.0.0.4
41e42000 41ea3000 r-xp /usr/lib/libasound.so.2.0.0
41ead000 41eb0000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
41eb8000 41ec5000 r-xp /usr/lib/libail.so.0.1.0
41ece000 4200b000 r-xp /usr/lib/libicui18n.so.51.1
4201b000 420ff000 r-xp /usr/lib/libicuuc.so.51.1
4369b000 436ab000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
436cc000 436d4000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
436e3000 436e8000 r-xp /usr/lib/libjson.so.0.0.1
436f0000 43738000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
43739000 4377c000 r-xp /usr/lib/libsndfile.so.1.0.25
43789000 4378f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43797000 4379f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
437a7000 437ac000 r-xp /usr/lib/libcsc-feature.so.0.0.0
437b4000 437b7000 r-xp /usr/lib/libcompress.so.0.2.0
437bf000 437e1000 r-xp /usr/lib/libvorbis.so.0.4.3
437e9000 437ed000 r-xp /usr/lib/libogg.so.0.7.1
437f5000 43811000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4381a000 43821000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4382a000 4382c000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43834000 4383b000 r-xp /usr/lib/libminizip.so.1.0.0
43843000 4390d000 r-xp /usr/lib/libCOREGL.so.4.0
43c50000 43c5b000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c64000 43c68000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c79000 43c7b000 r-xp /usr/lib/libdri2.so.0.0.0
43c83000 43c9a000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43ca7000 43ca9000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43cb2000 444b1000 rwxp [stack:3834]
444c0000 444c1000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
444c9000 444ca000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
444d2000 444d3000 r-xp /usr/lib/gstreamer-0.10/libgstapp.so
444db000 444de000 r-xp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
444e7000 444ee000 r-xp /usr/lib/libfeedback.so.0.1.4
444f7000 444f8000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44601000 44e00000 rwxp [stack:3833]
44e7f000 44e81000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
44e89000 44e93000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
44e9b000 44ecf000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
44ed8000 44ee4000 r-xp /usr/lib/gstreamer-0.10/libgstencodebin.so
4500d000 4580c000 rwxp [stack:3778]
4590d000 4610c000 rwxp [stack:3779]
4610d000 4690c000 rwxp [stack:3780]
46b7e000 46b9e000 r-xp /usr/lib/gstreamer-0.10/libgstomx.so
46ba6000 46d04000 r-xp /usr/lib/gstreamer-0.10/libgstffmpeg.so
46dec000 46df1000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
46e01000 46e2a000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
46e33000 46e4b000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
46e54000 46e5a000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
46e69000 46e81000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
46e89000 46e8e000 r-xp /usr/lib/gstreamer-0.10/libgstsecrecord.so
46e9f000 46ea4000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
46eb4000 46eec000 r-xp /usr/lib/libsaac.so
46eed000 46ef3000 r-xp /usr/lib/libscmn.so
46efb000 46f0b000 r-xp /usr/lib/gstreamer-0.10/libgstalsa.so
46f13000 46f1e000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
46f28000 46f60000 r-xp /usr/lib/libsamrnb.so
46f81000 46f9b000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
46fa4000 46fa7000 r-xp /usr/lib/gstreamer-0.10/libgstwavenc.so
46fb0000 477af000 rwxp [stack:3845]
477b0000 47faf000 rwxp [stack:3846]
487b2000 48fb1000 rwxp [stack:3847]
48fb2000 497b1000 rwxp [stack:3848]
49bb2000 4a3b1000 rwxp [stack:3849]
4a3b2000 4abb1000 rwxp [stack:3850]
4b3b2000 4bbb1000 rwxp [stack:3852]
bed9d000 bedbe000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3656)
Call Stack Count: 13
 0: (0x4033111c) [/usr/lib/libedje.so.1] + 0x1611c
 1: (0x40333861) [/usr/lib/libedje.so.1] + 0x18861
 2: (0x40335a37) [/usr/lib/libedje.so.1] + 0x1aa37
 3: (0x4022fb2f) [/usr/lib/libevas.so.1] + 0x35b2f
 4: (0x402552e3) [/usr/lib/libevas.so.1] + 0x5b2e3
 5: (0x407b6071) [/usr/lib/libecore_evas.so.1] + 0x12071
 6: (0x407b36ed) [/usr/lib/libecore_evas.so.1] + 0xf6ed
 7: (0x402f7f25) [/usr/lib/libecore.so.1] + 0xaf25
 8: (0x402f9509) [/usr/lib/libecore.so.1] + 0xc509
 9: ecore_main_loop_begin + 0x30 (0x402f98b9) [/usr/lib/libecore.so.1] + 0xc8b9
10: appcore_efl_main + 0x20e (0x40044503) [/usr/lib/libappcore-efl.so.1] + 0x3503
11: ui_app_main + 0xb0 (0x41532421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
12: app_run + 0xea (0x4155fef7) [/opt/usr/apps/org.example.hap/bin/hap] + 0x2ef7
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
 _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:40:22.195+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:40:22.195+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-31 17:40:22.195+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-31 17:40:22.195+0900 W/W_HOME  (  722): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-31 17:40:22.205+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_set_param(1248) > [SVOICE] set param [keyword length] : 0
05-31 17:40:22.210+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-31 17:40:22.210+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Enable start
05-31 17:40:22.225+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-31 17:40:22.225+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 17:40:22.225+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
05-31 17:40:22.225+0900 I/HIGEAR  ( 1080): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
05-31 17:40:22.415+0900 I/AUL_PAD ( 3782): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-31 17:40:23.415+0900 W/CALL_CONSUMER( 1209): CallSAPInterface.c: call_sap_provider_data_available_on_channel_cb(2050) > response ID: 0x1007
05-31 17:40:23.415+0900 W/CALL_CONSUMER( 1209): CallSAPInterface.c: _call_sap_receive_provider_events_general_cmd(1772) > general_cmd : MUTE_BUTTON_STATUS
05-31 17:40:23.415+0900 W/CALL_CONSUMER( 1209): CallSAPInterface.c: _call_sap_receive_provider_events_general_cmd(1773) > general_cmd_extra : false
05-31 17:40:23.415+0900 I/CALL_CONSUMER( 1209): CallSAPInterface.c: _call_sap_receive_provider_events_general_cmd(1788) > id: 1, value: false
05-31 17:40:26.085+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:40:26.125+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3656
05-31 17:40:26.830+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: MEM_FLUSH State: PAUSED
05-31 17:40:28.835+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-31 17:40:28.840+0900 W/W_HOME  (  722): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-31 17:40:28.840+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-31 17:40:28.840+0900 W/W_HOME  (  722): gesture.c: _manual_render_enable(133) > 1
05-31 17:40:28.840+0900 W/W_HOME  (  722): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-31 17:40:28.840+0900 W/W_HOME  (  722): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 17:40:28.850+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
05-31 17:40:28.850+0900 W/STARTER (  697): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-31 17:40:28.860+0900 E/STARTER (  697): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-31 17:40:28.865+0900 W/STARTER (  697): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-31 17:40:28.865+0900 W/STARTER (  697): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-31 17:40:28.915+0900 I/watchface-viewer(  752): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
05-31 17:40:28.945+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
05-31 17:40:28.945+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-31 17:40:28.945+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-31 17:40:28.945+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-31 17:40:28.965+0900 I/APP_CORE( 3656): appcore-efl.c: __do_app(429) > [APP 3656] Event: PAUSE State: RUNNING
05-31 17:40:28.965+0900 I/CAPI_APPFW_APPLICATION( 3656): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-31 17:40:28.985+0900 I/SHealth_Common( 1102): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-31 17:40:28.985+0900 I/SHealth_Service( 1102): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-31 17:40:28.990+0900 W/MUSIC_CONTROL_SERVICE( 1056): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1056]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-31 17:40:28.995+0900 E/ALARM_MANAGER(  697): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(31-5-2016, 17:40:49), repeat(1), interval(20), type(-1073741822)
05-31 17:40:29.000+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-31 17:40:29.000+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-31 17:40:29.000+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-31 17:40:29.000+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:40:29.005+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:40:29.005+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-31 17:40:29.085+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 699396938, next duetime: 1464684049
05-31 17:40:29.085+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(699396938)
05-31 17:40:29.090+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464706800), due_time(1464684049)
05-31 17:40:29.090+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:40:29.090+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 08:40:49 (UTC).
05-31 17:40:29.090+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:40:29.095+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-31 17:40:29.095+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 17:40:29.095+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-31 17:40:29.095+0900 I/HIGEAR  ( 1080): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-31 17:40:31.090+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:40:31.165+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3656
05-31 17:40:33.975+0900 I/APP_CORE( 3656): appcore-efl.c: __do_app(429) > [APP 3656] Event: MEM_FLUSH State: PAUSED
05-31 17:40:34.545+0900 W/MUSIC_CONTROL_SERVICE( 1056): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1056]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
05-31 17:40:34.545+0900 I/watchface-viewer(  752): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
05-31 17:40:34.600+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
05-31 17:40:34.600+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1149) > Call the time_tick_cb
05-31 17:40:34.600+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:40:34.600+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:40:34.600+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-31 17:40:34.605+0900 W/W_HOME  (  722): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-31 17:40:34.605+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_set(161) > timer set
05-31 17:40:34.605+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-31 17:40:34.610+0900 W/W_HOME  (  722): gesture.c: _apps_status_get(123) > apps status:0
05-31 17:40:34.610+0900 W/W_HOME  (  722): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:0 info->offtime:5830
05-31 17:40:34.610+0900 W/W_HOME  (  722): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-31 17:40:34.610+0900 W/W_HOME  (  722): event_manager.c: _lcd_on_cb(691) > lcd state: 1
05-31 17:40:34.610+0900 W/W_HOME  (  722): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 17:40:34.620+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [unknown] after screen off time [5830]ms
05-31 17:40:34.620+0900 W/STARTER (  697): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
05-31 17:40:34.665+0900 I/APP_CORE( 3656): appcore-efl.c: __do_app(429) > [APP 3656] Event: RESUME State: PAUSED
05-31 17:40:34.665+0900 I/CAPI_APPFW_APPLICATION( 3656): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 17:40:34.705+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : 1075153676[0;m
05-31 17:40:34.705+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
05-31 17:40:34.705+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-31 17:40:34.705+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_set_param(1248) > [SVOICE] set param [keyword length] : 0
05-31 17:40:34.710+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-31 17:40:34.715+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Enable start
05-31 17:40:34.765+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:40:34.765+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:40:34.765+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(699396938)
05-31 17:40:34.765+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:40:34.765+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 15:00:00 (UTC).
05-31 17:40:34.765+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:40:34.765+0900 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[699396938] is removed.
05-31 17:40:34.780+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [unknown]
05-31 17:40:34.780+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
05-31 17:40:34.780+0900 I/SHealth_Common( 1102): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
05-31 17:40:34.780+0900 I/SHealth_Service( 1102): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-31 17:40:34.795+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-31 17:40:34.795+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-31 17:40:34.795+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : pedometer_inactive_period error
05-31 17:40:34.795+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-31 17:40:34.795+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-31 17:40:34.795+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : inactive_10min_precaution_millisec error
05-31 17:40:34.795+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-31 17:40:34.795+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-31 17:40:34.795+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : inactive_before_10min_precaution_millisec error
05-31 17:40:34.810+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
05-31 17:40:34.810+0900 W/W_HOME  (  722): gesture.c: _manual_render_enable(133) > 0
05-31 17:40:34.930+0900 E/WMS     (  496): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 2 -> 1
05-31 17:40:34.930+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-31 17:40:34.930+0900 E/WMS     (  496): ==========
05-31 17:40:34.930+0900 E/WMS     (  496): ##WMS SEND : mgr_gear_wear_onoff_req
05-31 17:40:34.930+0900 E/WMS     (  496): ==========
05-31 17:40:34.930+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-31 17:40:34.950+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-31 17:40:34.950+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 17:40:34.950+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
05-31 17:40:34.950+0900 I/HIGEAR  ( 1080): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
05-31 17:40:34.970+0900 W/SHealth_Service( 1102): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1007[0;m
05-31 17:40:34.970+0900 E/SHealth_Service( 1102): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-31 17:40:36.085+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:40:36.185+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3656
05-31 17:40:36.440+0900 E/EFL     ( 3656): evas_main<3656> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=40333729 button=1 downs=1
05-31 17:40:36.540+0900 E/EFL     ( 3656): evas_main<3656> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=40333786 button=1 downs=0
05-31 17:40:36.755+0900 E/TIZEN_N_RECORDER( 3656): recorder.c: __convert_recorder_error_code(193) > [recorder_set_filename] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:40:36.755+0900 E/TIZEN_N_RECORDER( 3656): recorder.c: __convert_recorder_error_code(193) > [file-format] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:40:36.755+0900 E/TIZEN_N_RECORDER( 3656): recorder.c: __convert_recorder_error_code(193) > [audio-encoder] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:40:36.820+0900 I/PRIVACY-MANAGER-CLIENT( 3656): PrivacyChecker.cpp: initialize(168) > Got lock. Starting initialize
05-31 17:40:36.825+0900 I/PRIVACY-MANAGER-CLIENT( 3656): PrivacyChecker.cpp: runSignalListenerThread(194) > Running g main loop for signal
05-31 17:40:36.825+0900 I/PRIVACY-MANAGER-CLIENT( 3656): PrivacyChecker.cpp: initializeDbus(220) > Starting initialize
05-31 17:40:36.865+0900 I/PRIVACY-MANAGER-CLIENT( 3656): PrivacyChecker.cpp: initializeDbus(235) > Initialized
05-31 17:40:36.865+0900 I/PRIVACY-MANAGER-CLIENT( 3656): PrivacyChecker.cpp: initialize(186) > Initialized
05-31 17:40:37.775+0900 E/TIZEN_N_RECORDER( 3656): recorder.c: __convert_recorder_error_code(193) > [recorder_start] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:40:37.775+0900 E/EFL     ( 3656): <3656> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:40:37.775+0900 E/EFL     ( 3656): <3656> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:40:37.800+0900 I/aa      ( 3656): chk = Off
05-31 17:40:38.800+0900 I/aa      ( 3656): res = 0
05-31 17:40:38.805+0900 I/aa      ( 3656): res = 0
05-31 17:40:38.825+0900 I/aa      ( 3656): db hi = 1076939232
05-31 17:40:39.860+0900 I/aa      ( 3656): res = 0
05-31 17:40:39.865+0900 I/aa      ( 3656): res = 0
05-31 17:40:39.870+0900 I/aa      ( 3656): db hi = 1076939232
05-31 17:40:40.775+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:40:40.775+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:40:40.780+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(567287400)
05-31 17:40:40.785+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:40:40.785+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 15:00:00 (UTC).
05-31 17:40:40.785+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:40:40.785+0900 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[567287400] is removed.
05-31 17:40:40.810+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:40:40.815+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:40:40.850+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:40:40.870+0900 I/aa      ( 3656): res = 0
05-31 17:40:40.870+0900 I/aa      ( 3656): res = 0
05-31 17:40:40.870+0900 I/aa      ( 3656): db hi = 1076939232
05-31 17:40:40.890+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:40:40.925+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:40:40.950+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:40:40.950+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-31 17:40:40.955+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-31 17:40:40.985+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:40:41.005+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:40:41.005+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464684044, Tue May 31 17:40:44 2016
05-31 17:40:41.005+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 567803613, next duetime: 1464684044
05-31 17:40:41.005+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(567803613)
05-31 17:40:41.005+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464706800), due_time(1464684044)
05-31 17:40:41.005+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:40:41.005+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 08:40:44 (UTC).
05-31 17:40:41.005+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:40:41.020+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:40:41.020+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:40:41.025+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(567803613)
05-31 17:40:41.025+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:40:41.025+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 15:00:00 (UTC).
05-31 17:40:41.025+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:40:41.025+0900 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[567803613] is removed.
05-31 17:40:41.040+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:40:41.040+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:40:41.060+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:40:41.075+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:40:41.090+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:40:41.100+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:40:41.100+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-31 17:40:41.105+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-31 17:40:41.115+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:40:41.130+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:40:41.135+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464727241, Wed Jun  1 05:40:41 2016
05-31 17:40:41.135+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1332386777, next duetime: 1464727241
05-31 17:40:41.135+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1332386777)
05-31 17:40:41.135+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464706800), due_time(1464727241)
05-31 17:40:41.135+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:40:41.135+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 15:00:00 (UTC).
05-31 17:40:41.135+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:40:41.195+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:40:41.215+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3656
05-31 17:40:41.870+0900 I/aa      ( 3656): res = 0
05-31 17:40:41.870+0900 I/aa      ( 3656): res = 0
05-31 17:40:41.870+0900 I/aa      ( 3656): db hi = 1076939232
05-31 17:40:42.745+0900 I/RESOURCED(  499): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-31 17:40:42.745+0900 I/RESOURCED(  499): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-31 17:40:42.870+0900 I/aa      ( 3656): res = 0
05-31 17:40:42.875+0900 I/aa      ( 3656): res = 0
05-31 17:40:42.880+0900 I/aa      ( 3656): db hi = 1076939232
05-31 17:40:43.885+0900 I/aa      ( 3656): res = 0
05-31 17:40:43.885+0900 I/aa      ( 3656): res = 0
05-31 17:40:43.885+0900 I/aa      ( 3656): db hi = 1076939232
05-31 17:40:44.890+0900 I/aa      ( 3656): res = 0
05-31 17:40:44.890+0900 I/aa      ( 3656): res = 0
05-31 17:40:44.890+0900 I/aa      ( 3656): db hi = 1076939232
05-31 17:40:45.890+0900 I/aa      ( 3656): res = 0
05-31 17:40:45.890+0900 I/aa      ( 3656): res = 0
05-31 17:40:45.890+0900 I/aa      ( 3656): db hi = 1076939232
05-31 17:40:46.110+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:40:46.190+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3656
05-31 17:40:46.895+0900 I/aa      ( 3656): res = 0
05-31 17:40:46.895+0900 I/aa      ( 3656): res = 0
05-31 17:40:46.905+0900 I/aa      ( 3656): db hi = 1076939232
05-31 17:40:47.905+0900 I/aa      ( 3656): res = 0
05-31 17:40:47.905+0900 I/aa      ( 3656): res = 0
05-31 17:40:47.920+0900 I/aa      ( 3656): db hi = 1076939232
05-31 17:40:48.925+0900 I/aa      ( 3656): res = 0
05-31 17:40:48.925+0900 I/aa      ( 3656): res = 0
05-31 17:40:48.960+0900 I/aa      ( 3656): db hi = 1076939232
05-31 17:40:49.970+0900 I/aa      ( 3656): res = 0
05-31 17:40:49.970+0900 I/aa      ( 3656): res = 0
05-31 17:40:49.980+0900 I/aa      ( 3656): db hi = 1076939232
05-31 17:40:50.985+0900 I/aa      ( 3656): res = 0
05-31 17:40:50.985+0900 I/aa      ( 3656): res = 0
05-31 17:40:50.985+0900 I/aa      ( 3656): db hi = 1076939232
05-31 17:40:51.170+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:40:51.190+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3656
05-31 17:40:51.220+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-31 17:40:51.225+0900 W/W_HOME  (  722): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-31 17:40:51.225+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-31 17:40:51.225+0900 W/W_HOME  (  722): gesture.c: _manual_render_enable(133) > 1
05-31 17:40:51.225+0900 W/W_HOME  (  722): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-31 17:40:51.225+0900 W/W_HOME  (  722): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 17:40:51.245+0900 I/watchface-viewer(  752): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
05-31 17:40:51.255+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
05-31 17:40:51.255+0900 W/STARTER (  697): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-31 17:40:51.255+0900 E/STARTER (  697): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-31 17:40:51.255+0900 W/STARTER (  697): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-31 17:40:51.255+0900 W/STARTER (  697): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-31 17:40:51.295+0900 I/SHealth_Common( 1102): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-31 17:40:51.295+0900 I/SHealth_Service( 1102): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-31 17:40:51.295+0900 W/MUSIC_CONTROL_SERVICE( 1056): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1056]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-31 17:40:51.305+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-31 17:40:51.305+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-31 17:40:51.305+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-31 17:40:51.305+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-31 17:40:51.310+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
05-31 17:40:51.310+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-31 17:40:51.310+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-31 17:40:51.310+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-31 17:40:51.315+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-31 17:40:51.315+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 17:40:51.320+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-31 17:40:51.320+0900 I/HIGEAR  ( 1080): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-31 17:40:51.325+0900 I/APP_CORE( 3656): appcore-efl.c: __do_app(429) > [APP 3656] Event: PAUSE State: RUNNING
05-31 17:40:51.325+0900 I/CAPI_APPFW_APPLICATION( 3656): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-31 17:40:51.335+0900 E/ALARM_MANAGER(  697): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(31-5-2016, 17:41:11), repeat(1), interval(20), type(-1073741822)
05-31 17:40:51.340+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:40:51.345+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:40:51.395+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1526804896, next duetime: 1464684071
05-31 17:40:51.395+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1526804896)
05-31 17:40:51.395+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464706800), due_time(1464684071)
05-31 17:40:51.395+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:40:51.395+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 08:41:11 (UTC).
05-31 17:40:51.395+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:40:51.985+0900 I/aa      ( 3656): res = 0
05-31 17:40:51.985+0900 I/aa      ( 3656): res = 0
05-31 17:40:51.985+0900 I/aa      ( 3656): db hi = 1076939232
05-31 17:40:52.990+0900 I/aa      ( 3656): res = 0
05-31 17:40:52.990+0900 I/aa      ( 3656): res = 0
05-31 17:40:52.990+0900 I/aa      ( 3656): db hi = -21.357861
05-31 17:40:53.095+0900 I/HAP     ( 3656): Updating UI with data 주의 하세요!
05-31 17:40:55.530+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 47 -> 46 1464684055 90
05-31 17:40:55.530+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 682 384 523
05-31 17:40:55.530+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 0 0 894
05-31 17:40:55.530+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 940 383 721
05-31 17:40:55.530+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 156 5 120
05-31 17:40:55.530+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 354 31 271
05-31 17:40:56.090+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:40:56.180+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3656
05-31 17:40:56.215+0900 I/aa      ( 3656): db hi = 0
05-31 17:40:56.330+0900 I/APP_CORE( 3656): appcore-efl.c: __do_app(429) > [APP 3656] Event: MEM_FLUSH State: PAUSED
05-31 17:40:57.225+0900 I/aa      ( 3656): res = 0
05-31 17:40:57.225+0900 I/aa      ( 3656): res = 0
05-31 17:40:57.225+0900 I/aa      ( 3656): db hi = 0
05-31 17:40:58.225+0900 I/aa      ( 3656): res = 0
05-31 17:40:58.225+0900 I/aa      ( 3656): res = 0
05-31 17:40:58.225+0900 I/aa      ( 3656): db hi = 0
05-31 17:40:59.225+0900 I/aa      ( 3656): res = 0
05-31 17:40:59.230+0900 I/aa      ( 3656): res = 0
05-31 17:40:59.230+0900 I/aa      ( 3656): db hi = 0
05-31 17:41:00.230+0900 I/aa      ( 3656): res = 0
05-31 17:41:00.230+0900 I/aa      ( 3656): res = 0
05-31 17:41:00.230+0900 I/aa      ( 3656): db hi = 0
05-31 17:41:01.185+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:41:01.245+0900 I/aa      ( 3656): res = 0
05-31 17:41:01.245+0900 I/aa      ( 3656): res = 0
05-31 17:41:01.245+0900 I/aa      ( 3656): db hi = 0
05-31 17:41:01.255+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3656
05-31 17:41:02.250+0900 I/aa      ( 3656): res = 0
05-31 17:41:02.250+0900 I/aa      ( 3656): res = 0
05-31 17:41:02.250+0900 I/aa      ( 3656): db hi = 0
05-31 17:41:03.250+0900 I/aa      ( 3656): res = 0
05-31 17:41:03.250+0900 I/aa      ( 3656): res = 0
05-31 17:41:03.250+0900 I/aa      ( 3656): db hi = 0
05-31 17:41:04.255+0900 I/aa      ( 3656): res = 0
05-31 17:41:04.255+0900 I/aa      ( 3656): res = 0
05-31 17:41:04.255+0900 I/aa      ( 3656): db hi = 0
05-31 17:41:05.255+0900 I/aa      ( 3656): res = 0
05-31 17:41:05.255+0900 I/aa      ( 3656): res = 0
05-31 17:41:05.255+0900 I/aa      ( 3656): db hi = 0
05-31 17:41:05.790+0900 I/watchface-viewer(  752): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
05-31 17:41:05.850+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
05-31 17:41:05.850+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1149) > Call the time_tick_cb
05-31 17:41:05.850+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:41:05.850+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:41:05.850+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-31 17:41:05.860+0900 W/W_HOME  (  722): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-31 17:41:05.860+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_set(161) > timer set
05-31 17:41:05.860+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-31 17:41:05.860+0900 W/W_HOME  (  722): gesture.c: _apps_status_get(123) > apps status:0
05-31 17:41:05.860+0900 W/W_HOME  (  722): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:0 info->offtime:14827
05-31 17:41:05.860+0900 W/W_HOME  (  722): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-31 17:41:05.860+0900 W/W_HOME  (  722): event_manager.c: _lcd_on_cb(691) > lcd state: 1
05-31 17:41:05.860+0900 W/W_HOME  (  722): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 17:41:05.915+0900 I/efl-extension(  722): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 17:41:05.915+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [unknown] after screen off time [14827]ms
05-31 17:41:05.915+0900 W/STARTER (  697): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
05-31 17:41:05.930+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : 1075153676[0;m
05-31 17:41:05.960+0900 I/APP_CORE( 3656): appcore-efl.c: __do_app(429) > [APP 3656] Event: RESUME State: PAUSED
05-31 17:41:05.960+0900 I/CAPI_APPFW_APPLICATION( 3656): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 17:41:05.960+0900 I/efl-extension( 1724): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 17:41:05.970+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
05-31 17:41:05.975+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-31 17:41:05.975+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_set_param(1248) > [SVOICE] set param [keyword length] : 0
05-31 17:41:05.985+0900 I/SHealth_Common( 1102): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
05-31 17:41:05.985+0900 I/SHealth_Service( 1102): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-31 17:41:05.990+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-31 17:41:05.990+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Enable start
05-31 17:41:06.000+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-31 17:41:06.000+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 17:41:06.000+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
05-31 17:41:06.000+0900 I/HIGEAR  ( 1080): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
05-31 17:41:06.010+0900 W/MUSIC_CONTROL_SERVICE( 1056): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1056]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
05-31 17:41:06.040+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:41:06.040+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:41:06.040+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1526804896)
05-31 17:41:06.040+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:41:06.040+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 15:00:00 (UTC).
05-31 17:41:06.040+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:41:06.040+0900 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[1526804896] is removed.
05-31 17:41:06.050+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [unknown]
05-31 17:41:06.050+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
05-31 17:41:06.060+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
05-31 17:41:06.060+0900 W/W_HOME  (  722): gesture.c: _manual_render_enable(133) > 0
05-31 17:41:06.080+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:41:06.090+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3656
05-31 17:41:06.100+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-31 17:41:06.100+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-31 17:41:06.100+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : pedometer_inactive_period error
05-31 17:41:06.105+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-31 17:41:06.105+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-31 17:41:06.105+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : inactive_10min_precaution_millisec error
05-31 17:41:06.105+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-31 17:41:06.105+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-31 17:41:06.105+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : inactive_before_10min_precaution_millisec error
05-31 17:41:06.255+0900 I/aa      ( 3656): res = 0
05-31 17:41:06.255+0900 I/aa      ( 3656): res = 0
05-31 17:41:06.255+0900 I/aa      ( 3656): db hi = 0
05-31 17:41:07.255+0900 I/aa      ( 3656): res = 0
05-31 17:41:07.255+0900 I/aa      ( 3656): res = 0
05-31 17:41:07.255+0900 I/aa      ( 3656): db hi = 0
05-31 17:41:08.265+0900 I/aa      ( 3656): res = 0
05-31 17:41:08.265+0900 I/aa      ( 3656): res = 0
05-31 17:41:08.265+0900 I/aa      ( 3656): db hi = 0
05-31 17:41:09.265+0900 I/aa      ( 3656): res = 0
05-31 17:41:09.265+0900 I/aa      ( 3656): res = 0
05-31 17:41:09.265+0900 I/aa      ( 3656): db hi = 0
05-31 17:41:10.270+0900 I/aa      ( 3656): res = 0
05-31 17:41:10.270+0900 I/aa      ( 3656): res = 0
05-31 17:41:10.270+0900 I/aa      ( 3656): db hi = 0
05-31 17:41:11.100+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:41:11.160+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3656
05-31 17:41:11.270+0900 I/aa      ( 3656): res = 0
05-31 17:41:11.270+0900 I/aa      ( 3656): res = 0
05-31 17:41:11.270+0900 I/aa      ( 3656): db hi = 0
05-31 17:41:12.275+0900 I/aa      ( 3656): res = 0
05-31 17:41:12.275+0900 I/aa      ( 3656): res = 0
05-31 17:41:12.275+0900 I/aa      ( 3656): db hi = 0
05-31 17:41:13.275+0900 I/aa      ( 3656): res = 0
05-31 17:41:13.275+0900 I/aa      ( 3656): res = 0
05-31 17:41:13.275+0900 I/aa      ( 3656): db hi = 0
05-31 17:41:14.280+0900 I/aa      ( 3656): res = 0
05-31 17:41:14.280+0900 I/aa      ( 3656): res = 0
05-31 17:41:14.280+0900 I/aa      ( 3656): db hi = 0
05-31 17:41:15.285+0900 I/aa      ( 3656): res = 0
05-31 17:41:15.285+0900 I/aa      ( 3656): res = 0
05-31 17:41:15.330+0900 I/aa      ( 3656): db hi = 0
05-31 17:41:16.180+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:41:16.250+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3656
05-31 17:41:16.330+0900 I/aa      ( 3656): res = 0
05-31 17:41:16.330+0900 I/aa      ( 3656): res = 0
05-31 17:41:16.330+0900 I/aa      ( 3656): db hi = 0
05-31 17:41:17.060+0900 E/EFL     ( 3656): evas_main<3656> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=40374355 button=1 downs=1
05-31 17:41:17.160+0900 E/EFL     ( 3656): evas_main<3656> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=40374378 button=1 downs=0
05-31 17:41:17.335+0900 I/aa      ( 3656): res = 0
05-31 17:41:17.335+0900 I/aa      ( 3656): res = 0
05-31 17:41:17.335+0900 I/aa      ( 3656): db hi = -24.432285
05-31 17:41:17.350+0900 I/HAP     ( 3656): Updating UI with data 주의 하세요!
05-31 17:41:17.365+0900 E/EFL     ( 3656): edje<3656> edje_embryo.c:3148 _edje_embryo_test_run() ERROR with embryo script. OBJECT NAME: 'elm/scroller/base/default', OBJECT FILE: '/usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj', ENTRY POINT: '_p4', SIGNAL: 'elm,action,show_notalways,vbar', SOURCE: 'elm', ERROR: 'Embryo_Program not initialized (or doubly initialized)'
05-31 17:41:17.750+0900 W/CRASH_MANAGER( 3896): worker.c: worker_job(1199) > 1103656686170146468407
