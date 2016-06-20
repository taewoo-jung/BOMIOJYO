S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.5
Build-Number: R732XXU2CPC5
Build-Date: 2016.03.21 17:05:24

Crash Information
Process Name: hap
PID: 610
Date: 2016-05-31 17:16:27+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 610, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000001, r3   = 0x00000000
r4   = 0x00000000, r5   = 0x44e4a278
r6   = 0x46839488, r7   = 0x468394f0
r8   = 0x414f2f58, r9   = 0x46835944
r10  = 0x00000000, fp   = 0x416dec38
ip   = 0x402d0cec, sp   = 0xbead19e0
lr   = 0x404e41e8, pc   = 0x4024375c
cpsr = 0x20000030

Memory Information
MemTotal:   491012 KB
MemFree:      9020 KB
Buffers:     12460 KB
Cached:      92356 KB
VmPeak:     197024 KB
VmSize:     194992 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       30496 KB
VmRSS:       30496 KB
VmData:     122428 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       29300 KB
VmPTE:          94 KB
VmSwap:          0 KB

Threads Information
Threads: 14
PID = 610 TID = 610
610 736 737 738 753 755 779 780 782 785 786 788 794 824 

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
43cb2000 444b1000 rwxp [stack:755]
444b2000 44cb1000 rwxp [stack:753]
44e4c000 44e4d000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44e55000 44e56000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44e5e000 44e5f000 r-xp /usr/lib/gstreamer-0.10/libgstapp.so
44e67000 44e6a000 r-xp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
44e73000 44e7a000 r-xp /usr/lib/libfeedback.so.0.1.4
44e83000 44e84000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44e8c000 44e8e000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
44e96000 44ea0000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
44f27000 44f33000 r-xp /usr/lib/gstreamer-0.10/libgstencodebin.so
44f3b000 44f40000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
44fd6000 457d5000 rwxp [stack:736]
457d6000 45fd5000 rwxp [stack:737]
45fd6000 467d5000 rwxp [stack:738]
46c2b000 46c5f000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
46c68000 46c88000 r-xp /usr/lib/gstreamer-0.10/libgstomx.so
46c90000 46dee000 r-xp /usr/lib/gstreamer-0.10/libgstffmpeg.so
46ed6000 46edc000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
46eeb000 46f14000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
46f1d000 46f35000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
46f3e000 46f56000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
46f5e000 46f63000 r-xp /usr/lib/gstreamer-0.10/libgstsecrecord.so
46f74000 46f79000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
46f89000 46fc1000 r-xp /usr/lib/libsaac.so
46fc2000 46fc8000 r-xp /usr/lib/libscmn.so
46fd0000 46fe0000 r-xp /usr/lib/gstreamer-0.10/libgstalsa.so
46fe8000 46ff3000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
46ffd000 47035000 r-xp /usr/lib/libsamrnb.so
47056000 47070000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
47079000 4707c000 r-xp /usr/lib/gstreamer-0.10/libgstwavenc.so
47085000 47884000 rwxp [stack:779]
47885000 48084000 rwxp [stack:780]
48887000 49086000 rwxp [stack:782]
49087000 49886000 rwxp [stack:785]
49c87000 4a486000 rwxp [stack:786]
4a487000 4ac86000 rwxp [stack:788]
4ac87000 4b486000 rwxp [stack:824]
4b487000 4bc86000 rwxp [stack:794]
beab2000 bead3000 rwxp [stack]
End of Maps Information

Callstack Information (PID:610)
Call Stack Count: 17
 0: evas_object_textblock_text_markup_get + 0x57 (0x4024375c) [/usr/lib/libevas.so.1] + 0x4975c
 1: (0x40330a25) [/usr/lib/libedje.so.1] + 0x15a25
 2: (0x40332003) [/usr/lib/libedje.so.1] + 0x17003
 3: (0x40333861) [/usr/lib/libedje.so.1] + 0x18861
 4: (0x40333669) [/usr/lib/libedje.so.1] + 0x18669
 5: (0x40333669) [/usr/lib/libedje.so.1] + 0x18669
 6: (0x40335a37) [/usr/lib/libedje.so.1] + 0x1aa37
 7: (0x4022fb2f) [/usr/lib/libevas.so.1] + 0x35b2f
 8: (0x402552e3) [/usr/lib/libevas.so.1] + 0x5b2e3
 9: (0x407b6071) [/usr/lib/libecore_evas.so.1] + 0x12071
10: (0x407b36ed) [/usr/lib/libecore_evas.so.1] + 0xf6ed
11: (0x402f7f25) [/usr/lib/libecore.so.1] + 0xaf25
12: (0x402f934f) [/usr/lib/libecore.so.1] + 0xc34f
13: ecore_main_loop_begin + 0x30 (0x402f98b9) [/usr/lib/libecore.so.1] + 0xc8b9
14: appcore_efl_main + 0x20e (0x40044503) [/usr/lib/libappcore-efl.so.1] + 0x3503
15: ui_app_main + 0xb0 (0x41532421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
16: app_run + 0xea (0x4155fe87) [/opt/usr/apps/org.example.hap/bin/hap] + 0x2e87
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
39) > path : /usr/bin/data-provider-master, ret : 0
05-31 17:15:53.675+0900 I/AUL_AMD (  498): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-31 17:15:53.675+0900 E/AUL_AMD (  498): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-31 17:15:53.675+0900 W/AUL_AMD (  498): amd_launch.c: _start_app(1702) > caller pid : 699
05-31 17:15:53.695+0900 E/RESOURCED(  499): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-31 17:15:53.695+0900 E/RESOURCED(  499): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-31 17:15:53.700+0900 W/AUL_AMD (  498): amd_launch.c: _start_app(2080) > pad pid(-5)
05-31 17:15:53.700+0900 W/AUL_PAD ( 1201): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-31 17:15:53.700+0900 W/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(272) > Check app launching
05-31 17:15:53.765+0900 I/efl-extension(  467): efl_extension.c: eext_mod_init(40) > Init
05-31 17:15:53.780+0900 I/CAPI_APPFW_APPLICATION(  467): app_main.c: ui_app_main(704) > app_efl_main
05-31 17:15:53.785+0900 I/CAPI_APPFW_APPLICATION(  467): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-31 17:15:53.805+0900 E/AUL     (  498): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-31 17:15:53.855+0900 E/TBM     (  467): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-31 17:15:53.895+0900 E/E17     (  388): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04800002)
05-31 17:15:53.965+0900 E/EFL     (  467): ecore_evas<467> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-31 17:15:53.995+0900 I/efl-extension(  467): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0x418aa768]'s widget[0x41892550] to elm_conformant widget[0x41868c18]
05-31 17:15:54.095+0900 I/HAP     (  467): SUCCESSFULLY create sap agent
05-31 17:15:54.100+0900 I/HAP     (  467): connectivity type(1): bt
05-31 17:15:54.230+0900 I/HAP     (  467): agent is initialized
05-31 17:15:54.230+0900 I/HAP     (  467): agent initialized callback is over
05-31 17:15:54.230+0900 I/HAP     (  467): SAP >>> getRegisteredServiceAgent() >>> 0
05-31 17:15:54.325+0900 E/TIZEN_N_RECORDER(  467): recorder.c: __convert_recorder_error_code(193) > [audio-channel] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:15:54.325+0900 E/TIZEN_N_RECORDER(  467): recorder.c: __convert_recorder_error_code(193) > [audio-device] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:15:54.350+0900 I/APP_CORE(  467): appcore-efl.c: __do_app(429) > [APP 467] Event: RESET State: CREATED
05-31 17:15:54.350+0900 I/CAPI_APPFW_APPLICATION(  467): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-31 17:15:54.365+0900 I/APP_CORE(  467): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-31 17:15:54.365+0900 I/APP_CORE(  467): appcore-efl.c: __do_app(474) > [APP 467] Initial Launching, call the resume_cb
05-31 17:15:54.365+0900 I/CAPI_APPFW_APPLICATION(  467): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 17:15:54.375+0900 W/APP_CORE(  467): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4800002
05-31 17:15:54.380+0900 I/efl-extension(  467): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x418aa768 = w: 0 h: 0  obj 0x41892550 w: 360 h: 360
05-31 17:15:54.380+0900 I/efl-extension(  467): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-31 17:15:54.445+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: PAUSE State: RUNNING
05-31 17:15:54.445+0900 I/CAPI_APPFW_APPLICATION( 2547): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-31 17:15:54.460+0900 W/AUL_AMD (  498): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 17:15:54.460+0900 W/AUL_AMD (  498): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-31 17:15:54.465+0900 E/weather-widget(  784): WidgetMain.cpp: PauseWidgetInstance(1395) > [0;40;31mPauseWidgetInstance[0;m
05-31 17:15:54.480+0900 E/weather-widget(  784): WidgetView.cpp: HideActivityIndicator(753) > [0;40;31m[HideActivityIndicator(): 753] (refreshButtonLayout == NULL) [return][0;m
05-31 17:15:54.480+0900 E/weather-widget(  784): WidgetView.cpp: Pause(1739) > [0;40;31mOnClosed[0;m
05-31 17:15:54.480+0900 E/weather-widget(  784): WidgetMain.cpp: DeleteUpdateTimerData(267) > [0;40;31m[DeleteUpdateTimerData(): 267] (size < 1) [return][0;m
05-31 17:15:54.500+0900 E/weather-widget(  784): WidgetMain.cpp: PauseWidgetInstance(1436) > [0;40;31mlocationID : 4111500000[0;m
05-31 17:15:54.500+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_pause_cb(296) > widget obj was paused
05-31 17:15:54.505+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __check_status_for_cgroup(145) > enter background group
05-31 17:15:54.515+0900 I/APP_CORE(  467): appcore-efl.c: __do_app(429) > [APP 467] Event: RESUME State: RUNNING
05-31 17:15:54.825+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:15:54.825+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 467
05-31 17:15:54.830+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 12
05-31 17:15:54.850+0900 E/AUL     (  498): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-31 17:15:55.070+0900 I/AUL_PAD (  532): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-31 17:15:56.350+0900 E/EFL     (  467): evas_main<467> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=38853643 button=1 downs=1
05-31 17:15:56.420+0900 E/EFL     (  467): evas_main<467> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=38853690 button=1 downs=0
05-31 17:15:56.685+0900 I/aa      (  467): here = On
05-31 17:15:56.685+0900 I/aa      (  467): here2 = On
05-31 17:15:56.685+0900 E/TIZEN_N_RECORDER(  467): recorder.c: __convert_recorder_error_code(193) > [recorder_set_filename] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:15:56.685+0900 E/TIZEN_N_RECORDER(  467): recorder.c: __convert_recorder_error_code(193) > [file-format] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:15:56.685+0900 E/TIZEN_N_RECORDER(  467): recorder.c: __convert_recorder_error_code(193) > [audio-encoder] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:15:56.765+0900 I/PRIVACY-MANAGER-CLIENT(  467): PrivacyChecker.cpp: initialize(168) > Got lock. Starting initialize
05-31 17:15:56.770+0900 I/PRIVACY-MANAGER-CLIENT(  467): PrivacyChecker.cpp: runSignalListenerThread(194) > Running g main loop for signal
05-31 17:15:56.770+0900 I/PRIVACY-MANAGER-CLIENT(  467): PrivacyChecker.cpp: initializeDbus(220) > Starting initialize
05-31 17:15:56.820+0900 I/PRIVACY-MANAGER-CLIENT(  467): PrivacyChecker.cpp: initializeDbus(235) > Initialized
05-31 17:15:56.820+0900 I/PRIVACY-MANAGER-CLIENT(  467): PrivacyChecker.cpp: initialize(186) > Initialized
05-31 17:15:57.705+0900 E/TIZEN_N_RECORDER(  467): recorder.c: __convert_recorder_error_code(193) > [recorder_start] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:15:57.705+0900 E/EFL     (  467): <467> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:15:57.740+0900 E/EFL     (  467): <467> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:15:57.795+0900 I/aa      (  467): chk1 = Off
05-31 17:15:58.065+0900 E/WMS     (  496): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 2 -> 1
05-31 17:15:58.085+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-31 17:15:58.085+0900 E/WMS     (  496): ==========
05-31 17:15:58.085+0900 E/WMS     (  496): ##WMS SEND : mgr_gear_wear_onoff_req
05-31 17:15:58.085+0900 E/WMS     (  496): ==========
05-31 17:15:58.085+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-31 17:15:58.165+0900 W/SHealth_Service( 1102): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1007[0;m
05-31 17:15:58.165+0900 E/SHealth_Service( 1102): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-31 17:15:58.800+0900 I/aa      (  467): res = 0
05-31 17:15:58.800+0900 I/aa      (  467): res = 0
05-31 17:15:58.800+0900 I/aa      (  467): db hi = -18.892799
05-31 17:15:58.820+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:15:58.855+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 467
05-31 17:15:58.890+0900 I/HAP     (  467): Updating UI with data 주의 하세요!
05-31 17:15:59.470+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: MEM_FLUSH State: PAUSED
05-31 17:16:00.150+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-31 17:16:00.150+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-31 17:16:00.160+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : pedometer_inactive_period error
05-31 17:16:00.165+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-31 17:16:00.165+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-31 17:16:00.170+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : inactive_10min_precaution_millisec error
05-31 17:16:00.170+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-31 17:16:00.170+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-31 17:16:00.180+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : inactive_before_10min_precaution_millisec error
05-31 17:16:02.030+0900 I/aa      (  467): db hi = 0
05-31 17:16:02.035+0900 E/EFL     (  467): <467> elm_main.c:1162 elm_object_part_text_set() safety check failed: obj == NULL
05-31 17:16:02.695+0900 E/EFL     (  467): evas_main<467> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=38859984 button=1 downs=1
05-31 17:16:02.735+0900 E/EFL     (  467): evas_main<467> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=38860021 button=1 downs=0
05-31 17:16:03.015+0900 I/aa      (  467): here = Off
05-31 17:16:03.015+0900 I/aa      (  467): here3 = Off
05-31 17:16:03.020+0900 I/aa      (  467): here4 = On
05-31 17:16:03.040+0900 I/aa      (  467): res = 0
05-31 17:16:03.040+0900 I/aa      (  467): res = 0
05-31 17:16:03.040+0900 I/aa      (  467): db hi = -11.244521
05-31 17:16:03.055+0900 I/HAP     (  467): Updating UI with data 주의 하세요!
05-31 17:16:03.405+0900 W/AUL_AMD (  498): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 17:16:03.405+0900 W/AUL_AMD (  498): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-31 17:16:03.480+0900 W/CRASH_MANAGER(  572): worker.c: worker_job(1199) > 11004676861701464682563
05-31 17:16:03.510+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: RESUME State: PAUSED
05-31 17:16:03.510+0900 I/CAPI_APPFW_APPLICATION( 2547): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 17:16:03.545+0900 E/weather-widget(  784): WidgetMain.cpp: ResumeWidgetInstance(1447) > [0;40;31mResumeWidgetInstance[0;m
05-31 17:16:03.545+0900 E/weather-widget(  784): WidgetMain.cpp: GetUpdateTimerData(243) > [0;40;31m[GetUpdateTimerData(): 243] (size < 1) [return][0;m
05-31 17:16:03.545+0900 E/weather-widget(  784): WidgetMain.cpp: DeleteUpdateTimerData(267) > [0;40;31m[DeleteUpdateTimerData(): 267] (size < 1) [return][0;m
05-31 17:16:03.545+0900 E/weather-widget(  784): WidgetMain.cpp: ResumeWidgetInstance(1474) > [0;40;31mhomerun[0;m
05-31 17:16:03.545+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_resume_cb(314) > widget obj was resumed
05-31 17:16:03.545+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
05-31 17:16:03.570+0900 E/weather-widget(  784): WidgetMain.cpp: UpdateWidgetInstance(1691) > [0;40;31mUpdateWidgetInstance[0;m
05-31 17:16:03.570+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-31 17:16:03.805+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:16:03.815+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-31 17:16:03.820+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 4
05-31 17:16:03.820+0900 E/AUL_AMD (  498): amd_request.c: __app_process_by_pid(193) > pid(467) is dead. cmd(4) is canceled
05-31 17:16:03.830+0900 I/AUL_AMD (  498): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 467
05-31 17:16:03.870+0900 E/weather-widget(  784): WidgetMain.cpp: UpdateWidgetInstanceTimerCb(1574) > [0;40;31mUpdateWidgetInstanceTimerCb[0;m
05-31 17:16:03.885+0900 E/weather-widget(  784): WidgetMain.cpp: UpdateWidgetInstanceTimerCb(1615) > [0;40;31mcontent is NULL[0;m
05-31 17:16:03.895+0900 E/weather-widget(  784): WidgetView.cpp: CreateCityNameLayout(543) > [0;40;31mlanguageCode : ko_KR.UTF-8[0;m
05-31 17:16:03.935+0900 E/weather-widget(  784): WidgetView.cpp: UpdateViewPage(299) > [0;40;31mUpdateViewPage locationId : 4111500000[0;m
05-31 17:16:04.050+0900 E/weather-widget(  784): WidgetView.cpp: SetBackgroundImage(155) > [0;40;31mbackground color code:AO096[0;m
05-31 17:16:04.080+0900 E/weather-widget(  784): WidgetView.cpp: SetBackgroundImage(165) > [0;40;31mbackground image color code:AO0951[0;m
05-31 17:16:04.105+0900 W/LOCATION(  784): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
05-31 17:16:04.110+0900 E/weather-common(  784): Location.cpp: IsLocationServiceAvailable(297) > [0;40;31menabled : 1[0;m
05-31 17:16:04.115+0900 E/weather-widget(  784): WidgetMain.cpp: CheckAndRequestAutoRefresh(1170) > [0;40;31mnow : 1464682564, lastRefreshedTime : 1464672542, refreshInterval : 10800[0;m
05-31 17:16:04.115+0900 E/weather-widget(  784): WidgetMain.cpp: CheckAndRequestAutoRefresh(1186) > [0;40;31mwe don't need to refresh[0;m
05-31 17:16:04.120+0900 E/EFL     (  784): edje<784> edje_util.c:3770 edje_object_size_min_restricted_calc() group widgetViewPage has a non-fixed part 'timeSwallow'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 17:16:04.125+0900 E/EFL     (  784): edje<784> edje_util.c:3770 edje_object_size_min_restricted_calc() group highLowTemperature has a non-fixed part 'low'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 17:16:04.130+0900 E/EFL     (  784): edje<784> edje_util.c:3770 edje_object_size_min_restricted_calc() group widgetViewPage has a non-fixed part 'weatherIconSwallow'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 17:16:05.775+0900 E/EFL     ( 2547): evas_main<2547> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=38863071 button=1 downs=1
05-31 17:16:05.785+0900 E/EFL     ( 2547): evas_main<2547> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=38863082 button=1 downs=0
05-31 17:16:05.845+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 0
05-31 17:16:05.860+0900 I/AUL_AMD (  498): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-31 17:16:05.875+0900 I/AUL_AMD (  498): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-31 17:16:05.875+0900 E/AUL_AMD (  498): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-31 17:16:05.875+0900 W/AUL_AMD (  498): amd_launch.c: _start_app(1702) > caller pid : 699
05-31 17:16:05.895+0900 E/RESOURCED(  499): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-31 17:16:05.895+0900 E/RESOURCED(  499): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-31 17:16:05.905+0900 W/AUL_AMD (  498): amd_launch.c: _start_app(2080) > pad pid(-5)
05-31 17:16:05.905+0900 W/AUL_PAD ( 1201): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-31 17:16:05.905+0900 W/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(272) > Check app launching
05-31 17:16:05.975+0900 I/efl-extension(  532): efl_extension.c: eext_mod_init(40) > Init
05-31 17:16:05.990+0900 I/CAPI_APPFW_APPLICATION(  532): app_main.c: ui_app_main(704) > app_efl_main
05-31 17:16:06.000+0900 I/CAPI_APPFW_APPLICATION(  532): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-31 17:16:06.005+0900 E/AUL     (  498): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-31 17:16:06.085+0900 E/TBM     (  532): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-31 17:16:06.150+0900 E/E17     (  388): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x07a00002)
05-31 17:16:06.225+0900 E/EFL     (  532): ecore_evas<532> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-31 17:16:06.270+0900 I/efl-extension(  532): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0x43b924c8]'s widget[0x43b8d648] to elm_conformant widget[0x41c8c740]
05-31 17:16:06.395+0900 I/HAP     (  532): SUCCESSFULLY create sap agent
05-31 17:16:06.395+0900 I/HAP     (  532): connectivity type(1): bt
05-31 17:16:06.560+0900 I/HAP     (  532): agent is initialized
05-31 17:16:06.560+0900 I/HAP     (  532): agent initialized callback is over
05-31 17:16:06.560+0900 I/HAP     (  532): SAP >>> getRegisteredServiceAgent() >>> 0
05-31 17:16:06.665+0900 E/TIZEN_N_RECORDER(  532): recorder.c: __convert_recorder_error_code(193) > [audio-channel] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:16:06.665+0900 E/TIZEN_N_RECORDER(  532): recorder.c: __convert_recorder_error_code(193) > [audio-device] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:16:06.690+0900 I/APP_CORE(  532): appcore-efl.c: __do_app(429) > [APP 532] Event: RESET State: CREATED
05-31 17:16:06.690+0900 I/CAPI_APPFW_APPLICATION(  532): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-31 17:16:06.705+0900 I/APP_CORE(  532): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-31 17:16:06.705+0900 I/APP_CORE(  532): appcore-efl.c: __do_app(474) > [APP 532] Initial Launching, call the resume_cb
05-31 17:16:06.705+0900 I/CAPI_APPFW_APPLICATION(  532): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 17:16:06.715+0900 W/APP_CORE(  532): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7a00002
05-31 17:16:06.720+0900 I/efl-extension(  532): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x43b924c8 = w: 0 h: 0  obj 0x43b8d648 w: 360 h: 360
05-31 17:16:06.720+0900 I/efl-extension(  532): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-31 17:16:06.790+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: PAUSE State: RUNNING
05-31 17:16:06.790+0900 I/CAPI_APPFW_APPLICATION( 2547): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-31 17:16:06.805+0900 E/weather-widget(  784): WidgetMain.cpp: PauseWidgetInstance(1395) > [0;40;31mPauseWidgetInstance[0;m
05-31 17:16:06.810+0900 W/AUL_AMD (  498): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 17:16:06.810+0900 W/AUL_AMD (  498): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-31 17:16:06.815+0900 E/weather-widget(  784): WidgetView.cpp: HideActivityIndicator(753) > [0;40;31m[HideActivityIndicator(): 753] (refreshButtonLayout == NULL) [return][0;m
05-31 17:16:06.815+0900 E/weather-widget(  784): WidgetView.cpp: Pause(1739) > [0;40;31mOnClosed[0;m
05-31 17:16:06.820+0900 E/weather-widget(  784): WidgetMain.cpp: DeleteUpdateTimerData(267) > [0;40;31m[DeleteUpdateTimerData(): 267] (size < 1) [return][0;m
05-31 17:16:06.840+0900 E/weather-widget(  784): WidgetMain.cpp: PauseWidgetInstance(1436) > [0;40;31mlocationID : 4111500000[0;m
05-31 17:16:06.840+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_pause_cb(296) > widget obj was paused
05-31 17:16:06.845+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __check_status_for_cgroup(145) > enter background group
05-31 17:16:06.870+0900 I/APP_CORE(  532): appcore-efl.c: __do_app(429) > [APP 532] Event: RESUME State: RUNNING
05-31 17:16:07.240+0900 E/AUL     (  498): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-31 17:16:07.305+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:16:07.310+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 532
05-31 17:16:07.315+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 12
05-31 17:16:07.390+0900 I/AUL_PAD (  610): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-31 17:16:08.360+0900 E/EFL     (  532): evas_main<532> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=38865653 button=1 downs=1
05-31 17:16:08.410+0900 E/EFL     (  532): evas_main<532> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=38865697 button=1 downs=0
05-31 17:16:08.685+0900 I/aa      (  532): here = On
05-31 17:16:08.690+0900 I/aa      (  532): here2 = On
05-31 17:16:08.690+0900 E/TIZEN_N_RECORDER(  532): recorder.c: __convert_recorder_error_code(193) > [recorder_set_filename] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:16:08.690+0900 E/TIZEN_N_RECORDER(  532): recorder.c: __convert_recorder_error_code(193) > [file-format] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:16:08.690+0900 E/TIZEN_N_RECORDER(  532): recorder.c: __convert_recorder_error_code(193) > [audio-encoder] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:16:08.735+0900 I/PRIVACY-MANAGER-CLIENT(  532): PrivacyChecker.cpp: initialize(168) > Got lock. Starting initialize
05-31 17:16:08.735+0900 I/PRIVACY-MANAGER-CLIENT(  532): PrivacyChecker.cpp: runSignalListenerThread(194) > Running g main loop for signal
05-31 17:16:08.740+0900 I/PRIVACY-MANAGER-CLIENT(  532): PrivacyChecker.cpp: initializeDbus(220) > Starting initialize
05-31 17:16:08.780+0900 I/PRIVACY-MANAGER-CLIENT(  532): PrivacyChecker.cpp: initializeDbus(235) > Initialized
05-31 17:16:08.780+0900 I/PRIVACY-MANAGER-CLIENT(  532): PrivacyChecker.cpp: initialize(186) > Initialized
05-31 17:16:09.645+0900 E/TIZEN_N_RECORDER(  532): recorder.c: __convert_recorder_error_code(193) > [recorder_start] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:16:09.645+0900 E/EFL     (  532): <532> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:16:09.645+0900 E/EFL     (  532): <532> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:16:09.650+0900 I/aa      (  532): chk1 = Off
05-31 17:16:10.650+0900 I/aa      (  532): res = 0
05-31 17:16:10.650+0900 I/aa      (  532): res = 0
05-31 17:16:10.650+0900 I/aa      (  532): db hi = 1076939232
05-31 17:16:10.655+0900 E/EFL     (  532): <532> elm_main.c:1162 elm_object_part_text_set() safety check failed: obj == NULL
05-31 17:16:11.015+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:16:11.020+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 532
05-31 17:16:11.655+0900 I/aa      (  532): res = 0
05-31 17:16:11.655+0900 I/aa      (  532): res = 0
05-31 17:16:11.655+0900 I/aa      (  532): db hi = -16.788363
05-31 17:16:11.660+0900 I/HAP     (  532): Updating UI with data 주의 하세요!
05-31 17:16:11.815+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: MEM_FLUSH State: PAUSED
05-31 17:16:14.765+0900 I/aa      (  532): db hi = 0
05-31 17:16:14.765+0900 E/EFL     (  532): <532> elm_main.c:1162 elm_object_part_text_set() safety check failed: obj == NULL
05-31 17:16:14.940+0900 E/EFL     (  532): evas_main<532> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=38872233 button=1 downs=1
05-31 17:16:15.020+0900 E/EFL     (  532): evas_main<532> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=38872314 button=1 downs=0
05-31 17:16:15.265+0900 I/aa      (  532): here = Off
05-31 17:16:15.265+0900 I/aa      (  532): here3 = Off
05-31 17:16:15.275+0900 I/aa      (  532): here4 = On
05-31 17:16:15.765+0900 I/aa      (  532): res = 0
05-31 17:16:15.765+0900 I/aa      (  532): res = 0
05-31 17:16:15.765+0900 I/aa      (  532): db hi = -11.653666
05-31 17:16:15.800+0900 I/HAP     (  532): Updating UI with data 주의 하세요!
05-31 17:16:15.830+0900 F/EFL     (  532): <532> eina_list.c:188 _eina_list_mempool_accounting_free() *** Eina Magic Check Failed !!!
05-31 17:16:15.830+0900 F/EFL     (  532):     Input handle has already been freed!
05-31 17:16:15.830+0900 F/EFL     (  532): *** NAUGHTY PROGRAMMER!!!
05-31 17:16:15.830+0900 F/EFL     (  532): *** SPANK SPANK SPANK!!!
05-31 17:16:15.830+0900 F/EFL     (  532): *** Now go fix your code. Tut tut tut!
05-31 17:16:15.830+0900 F/EFL     (  532): 
05-31 17:16:15.840+0900 F/EFL     (  532): <532> eina_list.c:730 eina_list_remove_list() *** Eina Magic Check Failed !!!
05-31 17:16:15.840+0900 F/EFL     (  532):     Input handle has already been freed!
05-31 17:16:15.840+0900 F/EFL     (  532): *** NAUGHTY PROGRAMMER!!!
05-31 17:16:15.840+0900 F/EFL     (  532): *** SPANK SPANK SPANK!!!
05-31 17:16:15.840+0900 F/EFL     (  532): *** Now go fix your code. Tut tut tut!
05-31 17:16:15.840+0900 F/EFL     (  532): 
05-31 17:16:16.025+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:16:16.040+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 532
05-31 17:16:16.150+0900 W/CRASH_MANAGER(  572): worker.c: worker_job(1199) > 06005326861701464682575
05-31 17:16:16.265+0900 W/AUL_AMD (  498): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 17:16:16.265+0900 W/AUL_AMD (  498): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-31 17:16:16.435+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: RESUME State: PAUSED
05-31 17:16:16.435+0900 I/CAPI_APPFW_APPLICATION( 2547): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 17:16:16.455+0900 E/weather-widget(  784): WidgetMain.cpp: ResumeWidgetInstance(1447) > [0;40;31mResumeWidgetInstance[0;m
05-31 17:16:16.455+0900 E/weather-widget(  784): WidgetMain.cpp: GetUpdateTimerData(243) > [0;40;31m[GetUpdateTimerData(): 243] (size < 1) [return][0;m
05-31 17:16:16.455+0900 E/weather-widget(  784): WidgetMain.cpp: DeleteUpdateTimerData(267) > [0;40;31m[DeleteUpdateTimerData(): 267] (size < 1) [return][0;m
05-31 17:16:16.455+0900 E/weather-widget(  784): WidgetMain.cpp: ResumeWidgetInstance(1474) > [0;40;31mhomerun[0;m
05-31 17:16:16.455+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_resume_cb(314) > widget obj was resumed
05-31 17:16:16.455+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
05-31 17:16:16.645+0900 I/AUL_AMD (  498): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 532
05-31 17:16:16.755+0900 E/weather-widget(  784): WidgetMain.cpp: UpdateWidgetInstanceTimerCb(1574) > [0;40;31mUpdateWidgetInstanceTimerCb[0;m
05-31 17:16:16.770+0900 E/weather-widget(  784): WidgetMain.cpp: UpdateWidgetInstanceTimerCb(1615) > [0;40;31mcontent is NULL[0;m
05-31 17:16:16.770+0900 E/weather-widget(  784): WidgetView.cpp: CreateCityNameLayout(543) > [0;40;31mlanguageCode : ko_KR.UTF-8[0;m
05-31 17:16:16.820+0900 E/weather-widget(  784): WidgetView.cpp: UpdateViewPage(299) > [0;40;31mUpdateViewPage locationId : 4111500000[0;m
05-31 17:16:16.895+0900 E/weather-widget(  784): WidgetView.cpp: SetBackgroundImage(155) > [0;40;31mbackground color code:AO096[0;m
05-31 17:16:16.895+0900 E/weather-widget(  784): WidgetView.cpp: SetBackgroundImage(165) > [0;40;31mbackground image color code:AO0951[0;m
05-31 17:16:16.910+0900 W/LOCATION(  784): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
05-31 17:16:16.910+0900 E/weather-common(  784): Location.cpp: IsLocationServiceAvailable(297) > [0;40;31menabled : 1[0;m
05-31 17:16:16.915+0900 E/weather-widget(  784): WidgetMain.cpp: CheckAndRequestAutoRefresh(1170) > [0;40;31mnow : 1464682576, lastRefreshedTime : 1464672542, refreshInterval : 10800[0;m
05-31 17:16:16.915+0900 E/weather-widget(  784): WidgetMain.cpp: CheckAndRequestAutoRefresh(1186) > [0;40;31mwe don't need to refresh[0;m
05-31 17:16:16.915+0900 E/EFL     (  784): edje<784> edje_util.c:3770 edje_object_size_min_restricted_calc() group widgetViewPage has a non-fixed part 'timeSwallow'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 17:16:16.920+0900 E/EFL     (  784): edje<784> edje_util.c:3770 edje_object_size_min_restricted_calc() group highLowTemperature has a non-fixed part 'low'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 17:16:16.920+0900 E/EFL     (  784): edje<784> edje_util.c:3770 edje_object_size_min_restricted_calc() group widgetViewPage has a non-fixed part 'weatherIconSwallow'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 17:16:21.010+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:16:21.025+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-31 17:16:21.030+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 4
05-31 17:16:21.030+0900 E/AUL_AMD (  498): amd_request.c: __app_process_by_pid(193) > pid(532) is dead. cmd(4) is canceled
05-31 17:16:21.545+0900 I/watchface-viewer(  752): viewer-data-provider.cpp: AddPendingChanges(1088) > added [37] to pending list
05-31 17:16:21.545+0900 I/watchface-viewer(  752): viewer-data-provider.cpp: AddPendingChanges(1088) > added [39] to pending list
05-31 17:16:21.545+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 57 -> 56 1464682581 90
05-31 17:16:21.545+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 56 696 374 650
05-31 17:16:21.545+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 56 0 0 1114
05-31 17:16:21.545+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 56 963 373 899
05-31 17:16:21.545+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 56 132 5 123
05-31 17:16:21.545+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 56 467 23 436
05-31 17:16:22.150+0900 E/EFL     ( 2547): evas_main<2547> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=38879443 button=1 downs=1
05-31 17:16:22.180+0900 E/EFL     ( 2547): evas_main<2547> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=38879476 button=1 downs=0
05-31 17:16:22.275+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 0
05-31 17:16:22.295+0900 I/AUL_AMD (  498): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-31 17:16:22.305+0900 I/AUL_AMD (  498): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-31 17:16:22.305+0900 E/AUL_AMD (  498): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-31 17:16:22.305+0900 W/AUL_AMD (  498): amd_launch.c: _start_app(1702) > caller pid : 699
05-31 17:16:22.320+0900 E/RESOURCED(  499): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-31 17:16:22.320+0900 E/RESOURCED(  499): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-31 17:16:22.320+0900 W/AUL_AMD (  498): amd_launch.c: _start_app(2080) > pad pid(-5)
05-31 17:16:22.320+0900 W/AUL_PAD ( 1201): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-31 17:16:22.320+0900 W/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(272) > Check app launching
05-31 17:16:22.435+0900 I/efl-extension(  610): efl_extension.c: eext_mod_init(40) > Init
05-31 17:16:22.455+0900 I/CAPI_APPFW_APPLICATION(  610): app_main.c: ui_app_main(704) > app_efl_main
05-31 17:16:22.470+0900 I/CAPI_APPFW_APPLICATION(  610): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-31 17:16:22.525+0900 E/AUL     (  498): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-31 17:16:22.595+0900 E/TBM     (  610): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-31 17:16:22.665+0900 E/E17     (  388): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04800002)
05-31 17:16:22.730+0900 E/EFL     (  610): ecore_evas<610> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-31 17:16:22.765+0900 I/efl-extension(  610): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0x418a6600]'s widget[0x41892550] to elm_conformant widget[0x41868c18]
05-31 17:16:22.860+0900 I/HAP     (  610): SUCCESSFULLY create sap agent
05-31 17:16:22.860+0900 I/HAP     (  610): connectivity type(1): bt
05-31 17:16:23.020+0900 I/HAP     (  610): agent is initialized
05-31 17:16:23.020+0900 I/HAP     (  610): agent initialized callback is over
05-31 17:16:23.020+0900 I/HAP     (  610): SAP >>> getRegisteredServiceAgent() >>> 0
05-31 17:16:23.125+0900 E/TIZEN_N_RECORDER(  610): recorder.c: __convert_recorder_error_code(193) > [audio-channel] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:16:23.125+0900 E/TIZEN_N_RECORDER(  610): recorder.c: __convert_recorder_error_code(193) > [audio-device] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:16:23.155+0900 I/APP_CORE(  610): appcore-efl.c: __do_app(429) > [APP 610] Event: RESET State: CREATED
05-31 17:16:23.155+0900 I/CAPI_APPFW_APPLICATION(  610): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-31 17:16:23.170+0900 I/APP_CORE(  610): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-31 17:16:23.170+0900 I/APP_CORE(  610): appcore-efl.c: __do_app(474) > [APP 610] Initial Launching, call the resume_cb
05-31 17:16:23.170+0900 I/CAPI_APPFW_APPLICATION(  610): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 17:16:23.180+0900 W/APP_CORE(  610): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4800002
05-31 17:16:23.185+0900 I/efl-extension(  610): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x418a6600 = w: 0 h: 0  obj 0x41892550 w: 360 h: 360
05-31 17:16:23.185+0900 I/efl-extension(  610): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-31 17:16:23.255+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: PAUSE State: RUNNING
05-31 17:16:23.255+0900 I/CAPI_APPFW_APPLICATION( 2547): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-31 17:16:23.265+0900 W/AUL_AMD (  498): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 17:16:23.265+0900 W/AUL_AMD (  498): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-31 17:16:23.285+0900 I/APP_CORE(  610): appcore-efl.c: __do_app(429) > [APP 610] Event: RESUME State: RUNNING
05-31 17:16:23.315+0900 E/weather-widget(  784): WidgetMain.cpp: PauseWidgetInstance(1395) > [0;40;31mPauseWidgetInstance[0;m
05-31 17:16:23.320+0900 E/weather-widget(  784): WidgetView.cpp: HideActivityIndicator(753) > [0;40;31m[HideActivityIndicator(): 753] (refreshButtonLayout == NULL) [return][0;m
05-31 17:16:23.320+0900 E/weather-widget(  784): WidgetView.cpp: Pause(1739) > [0;40;31mOnClosed[0;m
05-31 17:16:23.325+0900 E/weather-widget(  784): WidgetMain.cpp: DeleteUpdateTimerData(267) > [0;40;31m[DeleteUpdateTimerData(): 267] (size < 1) [return][0;m
05-31 17:16:23.340+0900 E/weather-widget(  784): WidgetMain.cpp: PauseWidgetInstance(1436) > [0;40;31mlocationID : 4111500000[0;m
05-31 17:16:23.340+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_pause_cb(296) > widget obj was paused
05-31 17:16:23.345+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __check_status_for_cgroup(145) > enter background group
05-31 17:16:23.565+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:16:23.570+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 610
05-31 17:16:23.580+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 12
05-31 17:16:23.630+0900 E/AUL     (  498): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-31 17:16:23.975+0900 I/AUL_PAD (  742): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-31 17:16:24.190+0900 E/RESOURCED( 2655): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:16:24.190+0900 E/AUL     ( 2655): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-31 17:16:24.195+0900 E/RESOURCED( 2655): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:16:24.195+0900 E/AUL     ( 2655): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-31 17:16:24.200+0900 E/RESOURCED( 2655): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:16:24.200+0900 E/AUL     ( 2655): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-31 17:16:24.205+0900 E/RESOURCED( 2655): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:16:24.205+0900 E/AUL     ( 2655): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-31 17:16:24.210+0900 E/RESOURCED( 2655): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:16:24.210+0900 E/AUL     ( 2655): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-31 17:16:24.235+0900 E/EFL     (  610): evas_main<610> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=38881528 button=1 downs=1
05-31 17:16:24.325+0900 E/EFL     (  610): evas_main<610> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=38881593 button=1 downs=0
05-31 17:16:24.555+0900 I/aa      (  610): here = On
05-31 17:16:24.555+0900 I/aa      (  610): here2 = On
05-31 17:16:24.555+0900 E/TIZEN_N_RECORDER(  610): recorder.c: __convert_recorder_error_code(193) > [recorder_set_filename] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:16:24.555+0900 E/TIZEN_N_RECORDER(  610): recorder.c: __convert_recorder_error_code(193) > [file-format] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:16:24.555+0900 E/TIZEN_N_RECORDER(  610): recorder.c: __convert_recorder_error_code(193) > [audio-encoder] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:16:24.600+0900 I/PRIVACY-MANAGER-CLIENT(  610): PrivacyChecker.cpp: initialize(168) > Got lock. Starting initialize
05-31 17:16:24.600+0900 I/PRIVACY-MANAGER-CLIENT(  610): PrivacyChecker.cpp: runSignalListenerThread(194) > Running g main loop for signal
05-31 17:16:24.600+0900 I/PRIVACY-MANAGER-CLIENT(  610): PrivacyChecker.cpp: initializeDbus(220) > Starting initialize
05-31 17:16:24.640+0900 I/PRIVACY-MANAGER-CLIENT(  610): PrivacyChecker.cpp: initializeDbus(235) > Initialized
05-31 17:16:24.640+0900 I/PRIVACY-MANAGER-CLIENT(  610): PrivacyChecker.cpp: initialize(186) > Initialized
05-31 17:16:25.445+0900 E/TIZEN_N_RECORDER(  610): recorder.c: __convert_recorder_error_code(193) > [recorder_start] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:16:25.445+0900 E/EFL     (  610): <610> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:16:25.445+0900 E/EFL     (  610): <610> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:16:25.445+0900 I/aa      (  610): chk1 = Off
05-31 17:16:25.950+0900 E/EFL     (  610): evas_main<610> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=38883246 button=1 downs=1
05-31 17:16:25.985+0900 E/EFL     (  610): evas_main<610> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=38883278 button=1 downs=0
05-31 17:16:26.275+0900 I/aa      (  610): here = Off
05-31 17:16:26.275+0900 I/aa      (  610): here3 = Off
05-31 17:16:26.280+0900 I/aa      (  610): here4 = On
05-31 17:16:26.480+0900 I/aa      (  610): res = 0
05-31 17:16:26.480+0900 I/aa      (  610): res = 0
05-31 17:16:26.480+0900 I/aa      (  610): db hi = 1076939232
05-31 17:16:26.485+0900 E/EFL     (  610): <610> elm_main.c:1162 elm_object_part_text_set() safety check failed: obj == NULL
05-31 17:16:27.330+0900 E/EFL     (  610): evas_main<610> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=38884624 button=1 downs=1
05-31 17:16:27.370+0900 E/EFL     (  610): evas_main<610> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=38884665 button=1 downs=0
05-31 17:16:27.485+0900 I/aa      (  610): res = 0
05-31 17:16:27.485+0900 I/aa      (  610): res = 0
05-31 17:16:27.485+0900 I/aa      (  610): db hi = -22.806963
05-31 17:16:27.500+0900 I/HAP     (  610): Updating UI with data 주의 하세요!
05-31 17:16:27.520+0900 E/EFL     (  610): evas_main<610> evas_object_image.c:3928 evas_object_image_is_inside() Couldn't get image pixels RGBA_Image 0x4195bd28: im=0x4195bd28, data=0x46813348, err=1
05-31 17:16:27.530+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:16:27.540+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 610
05-31 17:16:27.620+0900 E/EFL     (  610): edje<610> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "shadow". Already calculating XY [03] axes. Need to calculate XY [03] axes
05-31 17:16:27.620+0900 E/EFL     (  610): edje<610> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "lt_padding". Already calculating X [01] axes. Need to calculate XY [03] axes
05-31 17:16:27.645+0900 I/aa      (  610): here = On
05-31 17:16:27.645+0900 I/aa      (  610): here2 = On
05-31 17:16:27.645+0900 E/TIZEN_N_RECORDER(  610): recorder.c: recorder_set_filename(953) > invalid state 5
05-31 17:16:27.645+0900 E/TIZEN_N_RECORDER(  610): recorder.c: _recorder_check_and_set_attribute(417) > invalid state 5
05-31 17:16:27.645+0900 E/TIZEN_N_RECORDER(  610): recorder.c: _recorder_check_and_set_attribute(417) > invalid state 5
05-31 17:16:27.645+0900 E/TIZEN_N_RECORDER(  610): recorder.c: recorder_prepare(736) > [recorder_prepare] mm_camcorder_realize fail
05-31 17:16:27.645+0900 E/TIZEN_N_RECORDER(  610): recorder.c: __convert_recorder_error_code(193) > [recorder_prepare] INVALID_STATE(0xfe6b0012) : core frameworks error code(0x80000817)
05-31 17:16:27.645+0900 E/TIZEN_N_RECORDER(  610): recorder.c: __convert_recorder_error_code(193) > [recorder_start] INVALID_STATE(0xfe6b0012) : core frameworks error code(0x80000817)
05-31 17:16:27.645+0900 E/EFL     (  610): <610> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:16:27.650+0900 E/EFL     (  610): <610> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:16:27.655+0900 E/EFL     (  610): edje<610> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "text_right_padding". Already calculating X [01] axes. Need to calculate XY [03] axes
05-31 17:16:27.655+0900 E/EFL     (  610): edje<610> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "icon_text_padding". Already calculating X [01] axes. Need to calculate X [01] axes
05-31 17:16:27.655+0900 F/EFL     (  610): <610> eina_binbuf_template_c.x:80 eina_ustrbuf_free() *** Eina Magic Check Failed !!!
05-31 17:16:27.655+0900 F/EFL     (  610):     Input handle has already been freed!
05-31 17:16:27.655+0900 F/EFL     (  610): *** NAUGHTY PROGRAMMER!!!
05-31 17:16:27.655+0900 F/EFL     (  610): *** SPANK SPANK SPANK!!!
05-31 17:16:27.655+0900 F/EFL     (  610): *** Now go fix your code. Tut tut tut!
05-31 17:16:27.655+0900 F/EFL     (  610): 
05-31 17:16:27.660+0900 F/EFL     (  610): <610> eina_binbuf_template_c.x:151 eina_ustrbuf_length_get() *** Eina Magic Check Failed !!!
05-31 17:16:27.660+0900 F/EFL     (  610):     Input handle pointer is NULL !
05-31 17:16:27.660+0900 F/EFL     (  610): *** NAUGHTY PROGRAMMER!!!
05-31 17:16:27.660+0900 F/EFL     (  610): *** SPANK SPANK SPANK!!!
05-31 17:16:27.660+0900 F/EFL     (  610): *** Now go fix your code. Tut tut tut!
05-31 17:16:27.660+0900 F/EFL     (  610): 
05-31 17:16:27.660+0900 F/EFL     (  610): <610> eina_binbuf_template_c.x:130 eina_ustrbuf_string_get() *** Eina Magic Check Failed !!!
05-31 17:16:27.660+0900 F/EFL     (  610):     Input handle pointer is NULL !
05-31 17:16:27.660+0900 F/EFL     (  610): *** NAUGHTY PROGRAMMER!!!
05-31 17:16:27.660+0900 F/EFL     (  610): *** SPANK SPANK SPANK!!!
05-31 17:16:27.660+0900 F/EFL     (  610): *** Now go fix your code. Tut tut tut!
05-31 17:16:27.660+0900 F/EFL     (  610): 
05-31 17:16:27.660+0900 I/aa      (  610): chk1 = Off
05-31 17:16:27.665+0900 E/EFL     (  610): <610> eina_unicode.c:116 eina_unicode_strndup() safety check failed: text == NULL
05-31 17:16:27.665+0900 E/EFL     (  610): <610> eina_unicode.c:376 eina_unicode_unicode_to_utf8() safety check failed: uni == NULL
05-31 17:16:27.665+0900 F/EFL     (  610): <610> eina_binbuf_template_c.x:80 eina_ustrbuf_free() *** Eina Magic Check Failed !!!
05-31 17:16:27.665+0900 F/EFL     (  610):     Input handle pointer is NULL !
05-31 17:16:27.665+0900 F/EFL     (  610): *** NAUGHTY PROGRAMMER!!!
05-31 17:16:27.665+0900 F/EFL     (  610): *** SPANK SPANK SPANK!!!
05-31 17:16:27.665+0900 F/EFL     (  610): *** Now go fix your code. Tut tut tut!
05-31 17:16:27.665+0900 F/EFL     (  610): 
05-31 17:16:27.845+0900 W/CRASH_MANAGER(  572): worker.c: worker_job(1199) > 1100610686170146468258
