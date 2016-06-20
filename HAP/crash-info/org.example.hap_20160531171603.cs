S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.5
Build-Number: R732XXU2CPC5
Build-Date: 2016.03.21 17:05:24

Crash Information
Process Name: hap
PID: 467
Date: 2016-05-31 17:16:03+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 467, uid 5000)

Register Information
r0   = 0x00000016, r1   = 0x4bc27f0c
r2   = 0x4bd47f25, r3   = 0x4bd47ff6
r4   = 0x00000001, r5   = 0x0d6704df
r6   = 0x417be717, r7   = 0x44ea19f0
r8   = 0x4bc27fc8, r9   = 0x00000000
r10  = 0x00000001, fp   = 0x00000070
ip   = 0x00000000, sp   = 0x4bc27eb0
lr   = 0x40ce8007, pc   = 0x40cefa34
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:      7880 KB
Buffers:     13644 KB
Cached:      94132 KB
VmPeak:     196880 KB
VmSize:     194844 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29316 KB
VmRSS:       29316 KB
VmData:     121104 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       29300 KB
VmPTE:          94 KB
VmSwap:          0 KB

Threads Information
Threads: 13
PID = 467 TID = 568
467 524 525 527 543 545 558 559 562 563 565 566 568 

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
43cb2000 444b1000 rwxp [stack:543]
445b2000 44db1000 rwxp [stack:545]
44dc0000 44dc1000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44ded000 44dee000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44df6000 44df7000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45018000 45817000 rwxp [stack:524]
45818000 46017000 rwxp [stack:525]
46018000 46817000 rwxp [stack:527]
469e8000 469e9000 r-xp /usr/lib/gstreamer-0.10/libgstapp.so
469f1000 469f4000 r-xp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
469fd000 46a04000 r-xp /usr/lib/libfeedback.so.0.1.4
46a0d000 46a0f000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
46a17000 46a21000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
46ba6000 46bda000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
46be3000 46c03000 r-xp /usr/lib/gstreamer-0.10/libgstomx.so
46c0b000 46c17000 r-xp /usr/lib/gstreamer-0.10/libgstencodebin.so
46c1f000 46d7d000 r-xp /usr/lib/gstreamer-0.10/libgstffmpeg.so
46e65000 46e6a000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
46e7a000 46ea3000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
46eac000 46ec4000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
46ecd000 46ed3000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
46ee2000 46efa000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
46f02000 46f07000 r-xp /usr/lib/gstreamer-0.10/libgstsecrecord.so
46f18000 46f1d000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
46f2d000 46f65000 r-xp /usr/lib/libsaac.so
46f66000 46f6c000 r-xp /usr/lib/libscmn.so
46f74000 46f84000 r-xp /usr/lib/gstreamer-0.10/libgstalsa.so
46f8c000 46f97000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
46fa1000 46fd9000 r-xp /usr/lib/libsamrnb.so
46ffa000 47014000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
4701d000 47020000 r-xp /usr/lib/gstreamer-0.10/libgstwavenc.so
47029000 47828000 rwxp [stack:558]
47829000 48028000 rwxp [stack:559]
4882b000 4902a000 rwxp [stack:562]
4902b000 4982a000 rwxp [stack:563]
49c2b000 4a42a000 rwxp [stack:565]
4a42b000 4ac2a000 rwxp [stack:566]
4b42b000 4bc2a000 rwxp [stack:568]
bed81000 beda2000 rwxp [stack]
End of Maps Information

Callstack Information (PID:467)
Call Stack Count: 1
 0: inflate_fast_copy_neon + 0x94 (0x40cefa34) [/lib/libz.so.1] + 0x10a34
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
end_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:42.235+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:42.335+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:42.335+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:42.435+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:42.435+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:42.535+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:42.535+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:42.640+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:42.640+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:42.740+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:42.740+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:42.740+0900 I/RESOURCED(  499): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-31 17:15:42.740+0900 I/RESOURCED(  499): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-31 17:15:42.740+0900 I/RESOURCED(  499): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
05-31 17:15:42.840+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:42.840+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:42.940+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:42.940+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:43.005+0900 E/EFL     ( 2547): evas_main<2547> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=38840302 button=1 downs=1
05-31 17:15:43.040+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:43.040+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:43.115+0900 E/EFL     ( 2547): evas_main<2547> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=38840411 button=1 downs=0
05-31 17:15:43.140+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:43.140+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:43.240+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:43.240+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:43.345+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:43.350+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:43.460+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:43.460+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:43.565+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:43.565+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:43.575+0900 E/RESOURCED(  499): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-31 17:15:43.675+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:43.675+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:43.780+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:43.780+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:43.785+0900 E/RESOURCED(  499): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-31 17:15:43.885+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:43.890+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:43.995+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:43.995+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:44.100+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:44.100+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:44.100+0900 E/RESOURCED(  499): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-31 17:15:44.205+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:44.205+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:44.270+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-31 17:15:44.270+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-31 17:15:44.275+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:15:44.275+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:15:44.275+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-31 17:15:44.305+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:44.305+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:44.355+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [gesture]
05-31 17:15:44.355+0900 W/STARTER (  697): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-31 17:15:44.355+0900 E/STARTER (  697): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-31 17:15:44.355+0900 W/STARTER (  697): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-31 17:15:44.355+0900 W/STARTER (  697): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-31 17:15:44.360+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-31 17:15:44.370+0900 W/W_HOME  (  722): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-31 17:15:44.370+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-31 17:15:44.370+0900 W/W_HOME  (  722): gesture.c: _manual_render_enable(133) > 1
05-31 17:15:44.370+0900 W/W_HOME  (  722): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-31 17:15:44.370+0900 W/W_HOME  (  722): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 17:15:44.375+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-31 17:15:44.375+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-31 17:15:44.375+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-31 17:15:44.380+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-31 17:15:44.410+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:44.410+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:44.465+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-31 17:15:44.465+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 17:15:44.470+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-31 17:15:44.470+0900 I/HIGEAR  ( 1080): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-31 17:15:44.475+0900 I/SHealth_Common( 1102): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-31 17:15:44.475+0900 I/watchface-viewer(  752): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
05-31 17:15:44.475+0900 I/SHealth_Service( 1102): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-31 17:15:44.480+0900 W/MUSIC_CONTROL_SERVICE( 1056): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1056]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-31 17:15:44.485+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [gesture]
05-31 17:15:44.485+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-31 17:15:44.485+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-31 17:15:44.485+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-31 17:15:44.495+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: PAUSE State: RUNNING
05-31 17:15:44.495+0900 I/CAPI_APPFW_APPLICATION( 2547): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-31 17:15:44.505+0900 E/ALARM_MANAGER(  697): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(31-5-2016, 17:16:05), repeat(1), interval(20), type(-1073741822)
05-31 17:15:44.510+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:15:44.510+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:15:44.510+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:44.510+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:44.550+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 282808063, next duetime: 1464682565
05-31 17:15:44.550+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(282808063)
05-31 17:15:44.550+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464706800), due_time(1464682565)
05-31 17:15:44.550+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:15:44.550+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 08:16:05 (UTC).
05-31 17:15:44.550+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:15:44.610+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:44.610+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:44.715+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:44.715+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:44.825+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:44.825+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:44.825+0900 E/RESOURCED(  499): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-31 17:15:44.940+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:44.940+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:44.980+0900 E/RESOURCED(  499): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-31 17:15:45.050+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:45.050+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:45.070+0900 E/RESOURCED(  499): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-31 17:15:45.155+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:45.160+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:45.265+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:45.265+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:45.370+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:45.370+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:45.475+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:45.475+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:45.580+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:45.585+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:45.695+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:45.695+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:45.800+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:45.800+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:45.910+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:45.910+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:46.015+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:46.015+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:46.120+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:46.120+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:46.230+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:46.230+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:46.340+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:46.340+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:46.405+0900 I/APP_CORE(  722): appcore-efl.c: __do_app(429) > [APP 722] Event: MEM_FLUSH State: PAUSED
05-31 17:15:46.445+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:46.445+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:46.550+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:46.550+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:46.660+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:46.660+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:15:46.760+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(312) > process launched, but cmdline not changed
05-31 17:15:46.785+0900 E/RESOURCED(  499): procfs.c: proc_get_oom_score_adj(124) > [proc_get_oom_score_adj,124] fopen /proc/328/oom_score_adj failed
05-31 17:15:46.785+0900 E/RESOURCED(  499): proc-main.c: resourced_proc_status_change(860) > [resourced_proc_status_change,860] Empty pid or process not exists. 328
05-31 17:15:46.880+0900 E/AUL     (  498): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-31 17:15:46.880+0900 I/AUL_AMD (  498): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 328
05-31 17:15:46.930+0900 E/WMS     (  496): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-31 17:15:46.930+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-31 17:15:46.930+0900 E/WMS     (  496): ==========
05-31 17:15:46.930+0900 E/WMS     (  496): ##WMS SEND : mgr_gear_wear_onoff_req
05-31 17:15:46.930+0900 E/WMS     (  496): ==========
05-31 17:15:46.930+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-31 17:15:46.955+0900 E/AUL     (  498): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-31 17:15:46.970+0900 E/weather-widget(  784): WidgetMain.cpp: PauseWidgetInstance(1395) > [0;40;31mPauseWidgetInstance[0;m
05-31 17:15:47.000+0900 E/weather-widget(  784): WidgetView.cpp: HideActivityIndicator(753) > [0;40;31m[HideActivityIndicator(): 753] (refreshButtonLayout == NULL) [return][0;m
05-31 17:15:47.025+0900 E/weather-widget(  784): WidgetView.cpp: Pause(1739) > [0;40;31mOnClosed[0;m
05-31 17:15:47.030+0900 E/weather-widget(  784): WidgetMain.cpp: DeleteUpdateTimerData(267) > [0;40;31m[DeleteUpdateTimerData(): 267] (size < 1) [return][0;m
05-31 17:15:47.070+0900 W/SHealth_Service( 1102): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
05-31 17:15:47.070+0900 E/SHealth_Service( 1102): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-31 17:15:47.075+0900 E/weather-widget(  784): WidgetMain.cpp: PauseWidgetInstance(1436) > [0;40;31mlocationID : 4111500000[0;m
05-31 17:15:47.075+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_pause_cb(296) > widget obj was paused
05-31 17:15:47.075+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __check_status_for_cgroup(145) > enter background group
05-31 17:15:47.080+0900 E/weather-widget(  784): WidgetMain.cpp: ResumeWidgetInstance(1447) > [0;40;31mResumeWidgetInstance[0;m
05-31 17:15:47.080+0900 E/weather-widget(  784): WidgetMain.cpp: GetUpdateTimerData(243) > [0;40;31m[GetUpdateTimerData(): 243] (size < 1) [return][0;m
05-31 17:15:47.080+0900 E/weather-widget(  784): WidgetMain.cpp: DeleteUpdateTimerData(267) > [0;40;31m[DeleteUpdateTimerData(): 267] (size < 1) [return][0;m
05-31 17:15:47.085+0900 E/weather-widget(  784): WidgetMain.cpp: ResumeWidgetInstance(1474) > [0;40;31mhomerun[0;m
05-31 17:15:47.085+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_resume_cb(314) > widget obj was resumed
05-31 17:15:47.085+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
05-31 17:15:47.090+0900 E/weather-widget(  784): WidgetMain.cpp: PauseWidgetInstance(1395) > [0;40;31mPauseWidgetInstance[0;m
05-31 17:15:47.105+0900 E/weather-widget(  784): WidgetView.cpp: HideActivityIndicator(753) > [0;40;31m[HideActivityIndicator(): 753] (refreshButtonLayout == NULL) [return][0;m
05-31 17:15:47.105+0900 E/weather-widget(  784): WidgetView.cpp: Pause(1739) > [0;40;31mOnClosed[0;m
05-31 17:15:47.115+0900 E/weather-widget(  784): WidgetMain.cpp: PauseWidgetInstance(1436) > [0;40;31mlocationID : 4111500000[0;m
05-31 17:15:47.115+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_pause_cb(296) > widget obj was paused
05-31 17:15:47.115+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __check_status_for_cgroup(145) > enter background group
05-31 17:15:47.775+0900 W/AUL_AMD (  498): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 17:15:47.775+0900 W/AUL_AMD (  498): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-31 17:15:47.895+0900 E/RESOURCED( 1102): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:15:47.895+0900 E/AUL     ( 1102): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-31 17:15:47.910+0900 E/CAPI_APPFW_APP_MANAGER( 1102): app_manager.c: app_manager_error(78) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
05-31 17:15:48.240+0900 I/SHealth_Common( 1102): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
05-31 17:15:48.245+0900 I/watchface-viewer(  752): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
05-31 17:15:48.260+0900 W/wnotibp ( 2643): wnotiboard-popup-view.c: _wnotibp_event_lcd_on_cb(1419) > ::APP:: view state=0, 2, 0
05-31 17:15:48.270+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
05-31 17:15:48.270+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1149) > Call the time_tick_cb
05-31 17:15:48.270+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:15:48.270+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:15:48.270+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-31 17:15:48.275+0900 W/W_HOME  (  722): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-31 17:15:48.275+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_set(161) > timer set
05-31 17:15:48.275+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-31 17:15:48.275+0900 W/W_HOME  (  722): gesture.c: _apps_status_get(123) > apps status:0
05-31 17:15:48.275+0900 W/W_HOME  (  722): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:0 info->offtime:3958
05-31 17:15:48.275+0900 W/W_HOME  (  722): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-31 17:15:48.275+0900 W/W_HOME  (  722): event_manager.c: _lcd_on_cb(691) > lcd state: 1
05-31 17:15:48.275+0900 W/W_HOME  (  722): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 17:15:48.275+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [unknown] after screen off time [3958]ms
05-31 17:15:48.275+0900 W/STARTER (  697): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
05-31 17:15:48.280+0900 I/efl-extension( 2643): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 17:15:48.285+0900 I/efl-extension(  722): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 17:15:48.300+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: RESUME State: PAUSED
05-31 17:15:48.300+0900 I/CAPI_APPFW_APPLICATION( 2547): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 17:15:48.305+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : 1075153676[0;m
05-31 17:15:48.305+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
05-31 17:15:48.305+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:15:48.305+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:15:48.305+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(282808063)
05-31 17:15:48.310+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:15:48.310+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 15:00:00 (UTC).
05-31 17:15:48.310+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:15:48.310+0900 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[282808063] is removed.
05-31 17:15:48.315+0900 E/weather-widget(  784): WidgetMain.cpp: ResumeWidgetInstance(1447) > [0;40;31mResumeWidgetInstance[0;m
05-31 17:15:48.315+0900 E/weather-widget(  784): WidgetMain.cpp: GetUpdateTimerData(243) > [0;40;31m[GetUpdateTimerData(): 243] (size < 1) [return][0;m
05-31 17:15:48.315+0900 E/weather-widget(  784): WidgetMain.cpp: DeleteUpdateTimerData(267) > [0;40;31m[DeleteUpdateTimerData(): 267] (size < 1) [return][0;m
05-31 17:15:48.315+0900 E/weather-widget(  784): WidgetMain.cpp: ResumeWidgetInstance(1474) > [0;40;31mhomerun[0;m
05-31 17:15:48.315+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_resume_cb(314) > widget obj was resumed
05-31 17:15:48.315+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
05-31 17:15:48.320+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-31 17:15:48.325+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_set_param(1248) > [SVOICE] set param [keyword length] : 0
05-31 17:15:48.325+0900 W/MUSIC_CONTROL_SERVICE( 1056): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1056]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
05-31 17:15:48.330+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-31 17:15:48.350+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Enable start
05-31 17:15:48.370+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [unknown]
05-31 17:15:48.370+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
05-31 17:15:48.430+0900 I/SHealth_Service( 1102): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-31 17:15:48.450+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-31 17:15:48.450+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-31 17:15:48.450+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : pedometer_inactive_period error
05-31 17:15:48.455+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-31 17:15:48.455+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-31 17:15:48.455+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : inactive_10min_precaution_millisec error
05-31 17:15:48.455+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-31 17:15:48.455+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-31 17:15:48.455+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : inactive_before_10min_precaution_millisec error
05-31 17:15:48.465+0900 I/AUL_PAD (  467): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-31 17:15:48.475+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
05-31 17:15:48.475+0900 W/W_HOME  (  722): gesture.c: _manual_render_enable(133) > 0
05-31 17:15:48.605+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-31 17:15:48.605+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 17:15:48.605+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
05-31 17:15:48.605+0900 I/HIGEAR  ( 1080): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
05-31 17:15:48.615+0900 E/weather-widget(  784): WidgetMain.cpp: UpdateWidgetInstanceTimerCb(1574) > [0;40;31mUpdateWidgetInstanceTimerCb[0;m
05-31 17:15:48.625+0900 E/weather-widget(  784): WidgetMain.cpp: UpdateWidgetInstanceTimerCb(1615) > [0;40;31mcontent is NULL[0;m
05-31 17:15:48.630+0900 E/weather-widget(  784): WidgetView.cpp: CreateCityNameLayout(543) > [0;40;31mlanguageCode : ko_KR.UTF-8[0;m
05-31 17:15:48.650+0900 E/weather-widget(  784): WidgetView.cpp: UpdateViewPage(299) > [0;40;31mUpdateViewPage locationId : 4111500000[0;m
05-31 17:15:48.700+0900 E/weather-widget(  784): WidgetView.cpp: SetBackgroundImage(155) > [0;40;31mbackground color code:AO096[0;m
05-31 17:15:48.705+0900 E/weather-widget(  784): WidgetView.cpp: SetBackgroundImage(165) > [0;40;31mbackground image color code:AO0951[0;m
05-31 17:15:48.715+0900 W/LOCATION(  784): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
05-31 17:15:48.715+0900 E/weather-common(  784): Location.cpp: IsLocationServiceAvailable(297) > [0;40;31menabled : 1[0;m
05-31 17:15:48.720+0900 E/weather-widget(  784): WidgetMain.cpp: CheckAndRequestAutoRefresh(1170) > [0;40;31mnow : 1464682548, lastRefreshedTime : 1464672542, refreshInterval : 10800[0;m
05-31 17:15:48.720+0900 E/weather-widget(  784): WidgetMain.cpp: CheckAndRequestAutoRefresh(1186) > [0;40;31mwe don't need to refresh[0;m
05-31 17:15:48.720+0900 E/EFL     (  784): edje<784> edje_util.c:3770 edje_object_size_min_restricted_calc() group widgetViewPage has a non-fixed part 'timeSwallow'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 17:15:48.725+0900 E/EFL     (  784): edje<784> edje_util.c:3770 edje_object_size_min_restricted_calc() group highLowTemperature has a non-fixed part 'low'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 17:15:48.730+0900 E/EFL     (  784): edje<784> edje_util.c:3770 edje_object_size_min_restricted_calc() group widgetViewPage has a non-fixed part 'weatherIconSwallow'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 17:15:48.770+0900 I/MALI    (  722): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-31 17:15:49.590+0900 E/EFL     ( 2547): evas_main<2547> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=38846884 button=1 downs=1
05-31 17:15:49.650+0900 E/EFL     ( 2547): evas_main<2547> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=38846944 button=1 downs=0
05-31 17:15:51.795+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:15:51.870+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-31 17:15:51.875+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 4
05-31 17:15:51.890+0900 E/AUL_AMD (  498): amd_request.c: __app_process_by_pid(193) > pid(328) is dead. cmd(4) is canceled
05-31 17:15:53.505+0900 E/EFL     ( 2547): evas_main<2547> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=38850799 button=1 downs=1
05-31 17:15:53.530+0900 E/EFL     ( 2547): evas_main<2547> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=38850825 button=1 downs=0
05-31 17:15:53.640+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 0
05-31 17:15:53.665+0900 I/AUL_AMD (  498): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
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
05-31 17:16:03.480+0900 W/CRASH_MANAGER(  572): worker.c: worker_job(1199) > 1100467686170146468256
