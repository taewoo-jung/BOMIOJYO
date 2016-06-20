S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.5
Build-Number: R732XXU2CPC5
Build-Date: 2016.03.21 17:05:24

Crash Information
Process Name: hap
PID: 1642
Date: 2016-05-31 17:19:59+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 1642, uid 5000)

Register Information
r0   = 0xbef08878, r1   = 0x00000000
r2   = 0x48409df0, r3   = 0x0000003d
r4   = 0x43c24108, r5   = 0x4843f938
r6   = 0x43c241a8, r7   = 0x00000112
r8   = 0x00000001, r9   = 0x00000001
r10  = 0x0001869f, fp   = 0x43c241ac
ip   = 0x00000000, sp   = 0xbef08868
lr   = 0x40242723, pc   = 0x4023c362
cpsr = 0x20000030

Memory Information
MemTotal:   491012 KB
MemFree:     12132 KB
Buffers:     11292 KB
Cached:      92892 KB
VmPeak:     196228 KB
VmSize:     194192 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28760 KB
VmRSS:       28760 KB
VmData:     120452 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       29300 KB
VmPTE:          96 KB
VmSwap:          0 KB

Threads Information
Threads: 13
PID = 1642 TID = 1642
1642 1727 1728 1729 1733 1735 1747 1748 1749 1750 1751 1752 1755 

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
41874000 4187c000 r-xp /usr/lib/libsap_client.so.0.0.0
41884000 41889000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41891000 41898000 r-xp /usr/lib/libtbm.so.1.0.0
418a0000 418a3000 rw-p [heap]
418a3000 419d5000 rw-p [heap]
419d5000 41a70000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
41a7c000 41b34000 r-xp /usr/lib/libcairo.so.2.11200.14
41b3f000 41b4c000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
41b55000 41b5e000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
41b66000 41b87000 r-xp /usr/lib/libexif.so.12.3.3
41b9a000 41bb0000 r-xp /usr/lib/libmmfsound.so.0.1.0
41bc2000 41bc7000 r-xp /usr/lib/libmmfsession.so.0.0.0
41bcf000 41c07000 r-xp /usr/lib/libpulse.so.0.16.2
41c08000 41c0a000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
41c12000 41c17000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41c1f000 41c38000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
41c41000 41c4b000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
41c57000 41c5e000 r-xp /usr/lib/libmmfcommon.so.0.0.0
41c66000 41c97000 r-xp /usr/lib/libmdm.so.1.1.85
41c9f000 41cad000 r-xp /usr/lib/libGLESv2.so.2.0
41cb6000 41cb7000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41cc0000 41cc6000 r-xp /usr/lib/libxcb-render.so.0.0.0
41cce000 41cd1000 r-xp /usr/lib/libEGL.so.1.4
41cd9000 41ce1000 r-xp /usr/lib/libdrm.so.2.4.0
41ce9000 41d2a000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
41d33000 41d37000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
41d40000 41d56000 r-xp /usr/lib/libavsysaudio.so.0.0.1
41d5f000 41d64000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
41d6c000 41d6f000 r-xp /usr/lib/libpulse-simple.so.0.0.4
41d77000 41dd8000 r-xp /usr/lib/libasound.so.2.0.0
41de2000 41de5000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
41ded000 41dfa000 r-xp /usr/lib/libail.so.0.1.0
41e03000 41f40000 r-xp /usr/lib/libicui18n.so.51.1
41f50000 42034000 r-xp /usr/lib/libicuuc.so.51.1
435d0000 435e0000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
43601000 43609000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
43618000 4361d000 r-xp /usr/lib/libjson.so.0.0.1
43625000 4366d000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
4366e000 436b1000 r-xp /usr/lib/libsndfile.so.1.0.25
436be000 436c4000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
436cc000 436d4000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
436dc000 436e1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
436e9000 436ec000 r-xp /usr/lib/libcompress.so.0.2.0
436f4000 43716000 r-xp /usr/lib/libvorbis.so.0.4.3
4371e000 43722000 r-xp /usr/lib/libogg.so.0.7.1
4372a000 43746000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4374f000 43756000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4375f000 43761000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43769000 43770000 r-xp /usr/lib/libminizip.so.1.0.0
43778000 43842000 r-xp /usr/lib/libCOREGL.so.4.0
43c85000 43c90000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c99000 43c9d000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43cae000 43cb0000 r-xp /usr/lib/libdri2.so.0.0.0
43cb8000 43ccf000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43cdc000 43cde000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43ce7000 444e6000 rwxp [stack:1735]
444e7000 44ce6000 rwxp [stack:1733]
44cf5000 44cf6000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44cfe000 44cff000 r-xp /usr/lib/gstreamer-0.10/libgstapp.so
44d07000 44d0a000 r-xp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
44d13000 44d1a000 r-xp /usr/lib/libfeedback.so.0.1.4
44d23000 44d24000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44d2c000 44d2e000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
44d36000 44d40000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
44dc7000 44dd3000 r-xp /usr/lib/gstreamer-0.10/libgstencodebin.so
44ddb000 44de0000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
44e76000 44e77000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
4500b000 4580a000 rwxp [stack:1727]
4580b000 4600a000 rwxp [stack:1728]
4600b000 4680a000 rwxp [stack:1729]
46b06000 46b3a000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
46b43000 46b63000 r-xp /usr/lib/gstreamer-0.10/libgstomx.so
46b6b000 46cc9000 r-xp /usr/lib/gstreamer-0.10/libgstffmpeg.so
46db1000 46db7000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
46dc6000 46def000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
46df8000 46e10000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
46e19000 46e31000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
46e39000 46e3e000 r-xp /usr/lib/gstreamer-0.10/libgstsecrecord.so
46e4f000 46e54000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
46e64000 46e9c000 r-xp /usr/lib/libsaac.so
46e9d000 46ea3000 r-xp /usr/lib/libscmn.so
46eab000 46ebb000 r-xp /usr/lib/gstreamer-0.10/libgstalsa.so
46ec3000 46ece000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
46ed8000 46f10000 r-xp /usr/lib/libsamrnb.so
46f31000 46f4b000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
46f54000 46f57000 r-xp /usr/lib/gstreamer-0.10/libgstwavenc.so
46f60000 4775f000 rwxp [stack:1747]
47760000 47f5f000 rwxp [stack:1748]
48902000 49101000 rwxp [stack:1749]
49102000 49901000 rwxp [stack:1750]
49d02000 4a501000 rwxp [stack:1751]
4a502000 4ad01000 rwxp [stack:1752]
4b502000 4bd01000 rwxp [stack:1755]
beee9000 bef0a000 rwxp [stack]
End of Maps Information

Callstack Information (PID:1642)
Call Stack Count: 1
 0: (0x4023c362) [/usr/lib/libevas.so.1] + 0x42362
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
ameworks error code(0x80000817)
05-31 17:19:32.290+0900 E/TIZEN_N_RECORDER( 1560): recorder.c: __convert_recorder_error_code(193) > [recorder_start] INVALID_STATE(0xfe6b0012) : core frameworks error code(0x80000817)
05-31 17:19:32.290+0900 E/EFL     ( 1560): <1560> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:19:32.290+0900 E/EFL     ( 1560): <1560> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:19:32.290+0900 I/aa      ( 1560): chk1 = On
05-31 17:19:33.300+0900 I/aa      ( 1560): res = 0
05-31 17:19:33.300+0900 I/aa      ( 1560): res = 0
05-31 17:19:33.300+0900 I/aa      ( 1560): db hi = -9.787082
05-31 17:19:33.385+0900 I/HAP     ( 1560): Updating UI with data 주의 하세요!
05-31 17:19:34.290+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:19:34.365+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1560
05-31 17:19:34.995+0900 I/aa      ( 1560): db hi = 0
05-31 17:19:36.005+0900 I/aa      ( 1560): res = 0
05-31 17:19:36.005+0900 I/aa      ( 1560): res = 0
05-31 17:19:36.010+0900 I/aa      ( 1560): db hi = -9.465911
05-31 17:19:36.075+0900 I/HAP     ( 1560): Updating UI with data 주의 하세요!
05-31 17:19:36.120+0900 E/EFL     ( 1560): edje<1560> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "focus_bg_size". Already calculating XY [03] axes. Need to calculate XY [03] axes
05-31 17:19:36.480+0900 I/aa      ( 1560): db hi = 0
05-31 17:19:37.480+0900 I/aa      ( 1560): res = 0
05-31 17:19:37.480+0900 I/aa      ( 1560): res = 0
05-31 17:19:37.480+0900 I/aa      ( 1560): db hi = -9.827880
05-31 17:19:37.575+0900 I/HAP     ( 1560): Updating UI with data 주의 하세요!
05-31 17:19:39.160+0900 I/aa      ( 1560): db hi = 0
05-31 17:19:39.285+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:19:39.345+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1560
05-31 17:19:40.075+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:19:40.080+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:19:40.080+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(440442050)
05-31 17:19:40.080+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:19:40.080+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 15:00:00 (UTC).
05-31 17:19:40.080+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:19:40.080+0900 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[440442050] is removed.
05-31 17:19:40.100+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:19:40.100+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:19:40.130+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:19:40.155+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:19:40.165+0900 I/aa      ( 1560): res = 0
05-31 17:19:40.165+0900 I/aa      ( 1560): res = 0
05-31 17:19:40.165+0900 I/aa      ( 1560): db hi = -10.061147
05-31 17:19:40.180+0900 I/HAP     ( 1560): Updating UI with data 주의 하세요!
05-31 17:19:40.200+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:19:40.210+0900 E/EFL     ( 1560): edje<1560> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "shadow_left_glow". Already calculating XY [03] axes. Need to calculate XY [03] axes
05-31 17:19:40.215+0900 E/EFL     ( 1560): edje<1560> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "lt_padding". Already calculating XY [03] axes. Need to calculate X [01] axes
05-31 17:19:40.215+0900 E/EFL     ( 1560): edje<1560> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "bg". Already calculating X [01] axes. Need to calculate XY [03] axes
05-31 17:19:40.215+0900 E/EFL     ( 1560): edje<1560> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "bg". Already calculating X [01] axes. Need to calculate X [01] axes
05-31 17:19:40.215+0900 E/EFL     ( 1560): edje<1560> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "bg". Already calculating X [01] axes. Need to calculate X [01] axes
05-31 17:19:40.215+0900 E/EFL     ( 1560): edje<1560> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "right.line". Already calculating X [01] axes. Need to calculate X [01] axes
05-31 17:19:40.215+0900 E/EFL     ( 1560): edje<1560> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "right.line". Already calculating X [01] axes. Need to calculate X [01] axes
05-31 17:19:40.215+0900 E/EFL     ( 1560): edje<1560> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "right.line". Already calculating X [01] axes. Need to calculate XY [03] axes
05-31 17:19:40.235+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:19:40.235+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-31 17:19:40.240+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-31 17:19:40.260+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:19:40.275+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:19:40.275+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464682784, Tue May 31 17:19:44 2016
05-31 17:19:40.275+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 442348555, next duetime: 1464682784
05-31 17:19:40.275+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(442348555)
05-31 17:19:40.275+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464706800), due_time(1464682784)
05-31 17:19:40.275+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:19:40.275+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 08:19:44 (UTC).
05-31 17:19:40.275+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:19:40.285+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:19:40.285+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:19:40.290+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(442348555)
05-31 17:19:40.290+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-31 17:19:40.290+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-31 17:19:40.295+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:40.295+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:40.295+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-31 17:19:40.295+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:19:40.295+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 15:00:00 (UTC).
05-31 17:19:40.295+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:19:40.295+0900 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[442348555] is removed.
05-31 17:19:40.340+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-31 17:19:40.345+0900 W/W_HOME  (  722): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-31 17:19:40.345+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-31 17:19:40.345+0900 W/W_HOME  (  722): gesture.c: _manual_render_enable(133) > 1
05-31 17:19:40.345+0900 W/W_HOME  (  722): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-31 17:19:40.345+0900 W/W_HOME  (  722): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 17:19:40.350+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [gesture]
05-31 17:19:40.350+0900 W/STARTER (  697): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-31 17:19:40.350+0900 E/STARTER (  697): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-31 17:19:40.355+0900 W/STARTER (  697): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-31 17:19:40.355+0900 W/STARTER (  697): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-31 17:19:40.370+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:19:40.375+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:19:40.385+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-31 17:19:40.385+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-31 17:19:40.390+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-31 17:19:40.390+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-31 17:19:40.400+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:19:40.405+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-31 17:19:40.405+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 17:19:40.405+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-31 17:19:40.405+0900 I/HIGEAR  ( 1080): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-31 17:19:40.415+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:19:40.430+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:19:40.445+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:19:40.445+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-31 17:19:40.445+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-31 17:19:40.460+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:19:40.475+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:19:40.475+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464725980, Wed Jun  1 05:19:40 2016
05-31 17:19:40.475+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 442348555, next duetime: 1464725980
05-31 17:19:40.475+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(442348555)
05-31 17:19:40.475+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464706800), due_time(1464725980)
05-31 17:19:40.475+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:19:40.475+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 15:00:00 (UTC).
05-31 17:19:40.475+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:19:40.515+0900 W/MUSIC_CONTROL_SERVICE( 1056): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1056]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-31 17:19:40.520+0900 I/watchface-viewer(  752): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
05-31 17:19:40.545+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [gesture]
05-31 17:19:40.545+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-31 17:19:40.545+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-31 17:19:40.545+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-31 17:19:40.570+0900 I/APP_CORE( 1560): appcore-efl.c: __do_app(429) > [APP 1560] Event: PAUSE State: RUNNING
05-31 17:19:40.570+0900 I/CAPI_APPFW_APPLICATION( 1560): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-31 17:19:40.580+0900 E/ALARM_MANAGER(  697): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(31-5-2016, 17:20:01), repeat(1), interval(20), type(-1073741822)
05-31 17:19:40.590+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:19:40.590+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:19:40.640+0900 I/aa      ( 1560): db hi = 0
05-31 17:19:40.655+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 442348556, next duetime: 1464682801
05-31 17:19:40.655+0900 I/SHealth_Common( 1102): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-31 17:19:40.660+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(442348556)
05-31 17:19:40.660+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464706800), due_time(1464682801)
05-31 17:19:40.660+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:19:40.660+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 08:20:01 (UTC).
05-31 17:19:40.660+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:19:40.665+0900 I/SHealth_Service( 1102): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-31 17:19:41.640+0900 I/aa      ( 1560): res = 0
05-31 17:19:41.640+0900 I/aa      ( 1560): res = 0
05-31 17:19:41.640+0900 I/aa      ( 1560): db hi = 0
05-31 17:19:42.460+0900 W/MUSIC_CONTROL_SERVICE( 1056): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1056]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
05-31 17:19:42.460+0900 I/watchface-viewer(  752): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
05-31 17:19:42.495+0900 W/wnotibp ( 2643): wnotiboard-popup-view.c: _wnotibp_event_lcd_on_cb(1419) > ::APP:: view state=0, 2, 0
05-31 17:19:42.500+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
05-31 17:19:42.500+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1149) > Call the time_tick_cb
05-31 17:19:42.500+0900 W/W_HOME  (  722): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-31 17:19:42.500+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_set(161) > timer set
05-31 17:19:42.500+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-31 17:19:42.500+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:42.500+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:42.500+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-31 17:19:42.500+0900 W/W_HOME  (  722): gesture.c: _apps_status_get(123) > apps status:0
05-31 17:19:42.500+0900 W/W_HOME  (  722): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:0 info->offtime:2162
05-31 17:19:42.500+0900 W/W_HOME  (  722): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-31 17:19:42.500+0900 W/W_HOME  (  722): event_manager.c: _lcd_on_cb(691) > lcd state: 1
05-31 17:19:42.500+0900 W/W_HOME  (  722): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 17:19:42.510+0900 I/efl-extension( 2643): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 17:19:42.515+0900 I/efl-extension(  722): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 17:19:42.525+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [unknown] after screen off time [2162]ms
05-31 17:19:42.525+0900 W/STARTER (  697): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
05-31 17:19:42.535+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:19:42.535+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:19:42.535+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(442348556)
05-31 17:19:42.535+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:19:42.535+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 15:00:00 (UTC).
05-31 17:19:42.535+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:19:42.535+0900 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[442348556] is removed.
05-31 17:19:42.535+0900 I/APP_CORE( 1560): appcore-efl.c: __do_app(429) > [APP 1560] Event: RESUME State: PAUSED
05-31 17:19:42.535+0900 I/CAPI_APPFW_APPLICATION( 1560): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 17:19:42.550+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : 1075153676[0;m
05-31 17:19:42.550+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
05-31 17:19:42.555+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-31 17:19:42.555+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_set_param(1248) > [SVOICE] set param [keyword length] : 0
05-31 17:19:42.560+0900 I/SHealth_Common( 1102): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
05-31 17:19:42.560+0900 I/SHealth_Service( 1102): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-31 17:19:42.565+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-31 17:19:42.585+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Enable start
05-31 17:19:42.590+0900 I/efl-extension(  722): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 17:19:42.590+0900 I/efl-extension( 2643): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 17:19:42.605+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [unknown]
05-31 17:19:42.605+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
05-31 17:19:42.620+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-31 17:19:42.620+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 17:19:42.620+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
05-31 17:19:42.620+0900 I/HIGEAR  ( 1080): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
05-31 17:19:42.640+0900 I/aa      ( 1560): res = 0
05-31 17:19:42.640+0900 I/aa      ( 1560): res = 0
05-31 17:19:42.640+0900 I/aa      ( 1560): db hi = 0
05-31 17:19:42.640+0900 W/W_HOME  (  722): gesture.c: _widget_updated_cb(190) > widget updated
05-31 17:19:42.640+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-31 17:19:42.640+0900 W/W_HOME  (  722): gesture.c: _manual_render(176) > 
05-31 17:19:42.655+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-31 17:19:42.655+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-31 17:19:42.655+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : pedometer_inactive_period error
05-31 17:19:42.655+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-31 17:19:42.655+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-31 17:19:42.655+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : inactive_10min_precaution_millisec error
05-31 17:19:42.655+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-31 17:19:42.660+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-31 17:19:42.660+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : inactive_before_10min_precaution_millisec error
05-31 17:19:42.665+0900 W/W_HOME  (  722): gesture.c: _manual_render(176) > 
05-31 17:19:42.695+0900 W/W_HOME  (  722): gesture.c: _manual_render_enable(133) > 0
05-31 17:19:42.735+0900 I/efl-extension(  722): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 17:19:42.740+0900 I/efl-extension( 2643): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 17:19:42.740+0900 I/RESOURCED(  499): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-31 17:19:42.740+0900 I/RESOURCED(  499): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-31 17:19:42.815+0900 E/WMS     (  496): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-31 17:19:42.815+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-31 17:19:42.815+0900 E/WMS     (  496): ==========
05-31 17:19:42.815+0900 E/WMS     (  496): ##WMS SEND : mgr_gear_wear_onoff_req
05-31 17:19:42.815+0900 E/WMS     (  496): ==========
05-31 17:19:42.815+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-31 17:19:42.855+0900 W/SHealth_Service( 1102): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
05-31 17:19:42.855+0900 E/SHealth_Service( 1102): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-31 17:19:43.245+0900 I/aa      ( 1560): db hi = 0
05-31 17:19:43.630+0900 I/efl-extension(  722): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 17:19:43.630+0900 I/efl-extension( 2643): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 17:19:43.640+0900 I/aa      ( 1560): res = 0
05-31 17:19:43.640+0900 I/aa      ( 1560): res = 0
05-31 17:19:43.640+0900 I/aa      ( 1560): db hi = 0
05-31 17:19:44.175+0900 I/efl-extension(  722): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 17:19:44.175+0900 I/efl-extension( 2643): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 17:19:44.195+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:19:44.210+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1560
05-31 17:19:44.245+0900 I/aa      ( 1560): res = 0
05-31 17:19:44.245+0900 I/aa      ( 1560): res = 0
05-31 17:19:44.245+0900 I/aa      ( 1560): db hi = 0
05-31 17:19:44.640+0900 I/aa      ( 1560): res = 0
05-31 17:19:44.640+0900 I/aa      ( 1560): res = 0
05-31 17:19:44.640+0900 I/aa      ( 1560): db hi = 0
05-31 17:19:45.255+0900 I/aa      ( 1560): res = 0
05-31 17:19:45.255+0900 I/aa      ( 1560): res = 0
05-31 17:19:45.255+0900 I/aa      ( 1560): db hi = 0
05-31 17:19:45.640+0900 I/aa      ( 1560): res = 0
05-31 17:19:45.640+0900 I/aa      ( 1560): res = 0
05-31 17:19:45.640+0900 I/aa      ( 1560): db hi = 0
05-31 17:19:46.255+0900 I/aa      ( 1560): res = 0
05-31 17:19:46.255+0900 I/aa      ( 1560): res = 0
05-31 17:19:46.255+0900 I/aa      ( 1560): db hi = -15.343091
05-31 17:19:46.320+0900 I/HAP     ( 1560): Updating UI with data 주의 하세요!
05-31 17:19:46.640+0900 I/aa      ( 1560): res = 0
05-31 17:19:46.640+0900 I/aa      ( 1560): res = 0
05-31 17:19:46.640+0900 I/aa      ( 1560): db hi = -14.773602
05-31 17:19:46.670+0900 I/HAP     ( 1560): Updating UI with data 주의 하세요!
05-31 17:19:46.920+0900 W/CRASH_MANAGER( 1615): worker.c: worker_job(1199) > 11015606861701464682786
05-31 17:19:47.115+0900 W/AUL_AMD (  498): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 17:19:47.115+0900 W/AUL_AMD (  498): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-31 17:19:47.220+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: RESUME State: PAUSED
05-31 17:19:47.220+0900 I/CAPI_APPFW_APPLICATION( 2547): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 17:19:47.250+0900 W/WATCH_CORE(  752): appcore-watch.c: __widget_resume(1012) > widget_resume
05-31 17:19:47.250+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppResume(721) > 
05-31 17:19:47.250+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:47.250+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:47.445+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:47.445+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:47.555+0900 I/AUL_AMD (  498): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 1560
05-31 17:19:47.645+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:47.645+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:47.840+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:47.840+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:48.035+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:48.035+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:48.225+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:48.230+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:48.425+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:48.425+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:48.620+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:48.620+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:48.815+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:48.815+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:48.870+0900 E/EFL     ( 2547): evas_main<2547> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=39086167 button=1 downs=1
05-31 17:19:48.925+0900 E/EFL     ( 2547): evas_main<2547> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=39086222 button=1 downs=0
05-31 17:19:49.015+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:49.015+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:49.195+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:19:49.205+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-31 17:19:49.210+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 4
05-31 17:19:49.210+0900 E/AUL_AMD (  498): amd_request.c: __app_process_by_pid(193) > pid(1560) is dead. cmd(4) is canceled
05-31 17:19:49.215+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:49.215+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:49.410+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:49.410+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:49.610+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:49.610+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:49.810+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:49.810+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:49.860+0900 E/WMS     (  496): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 2 -> 1
05-31 17:19:49.860+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-31 17:19:49.860+0900 E/WMS     (  496): ==========
05-31 17:19:49.860+0900 E/WMS     (  496): ##WMS SEND : mgr_gear_wear_onoff_req
05-31 17:19:49.860+0900 E/WMS     (  496): ==========
05-31 17:19:49.860+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-31 17:19:49.965+0900 W/SHealth_Service( 1102): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1007[0;m
05-31 17:19:49.975+0900 E/SHealth_Service( 1102): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-31 17:19:50.010+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:50.010+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:50.140+0900 E/EFL     ( 2547): evas_main<2547> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=39087435 button=1 downs=1
05-31 17:19:50.210+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:50.210+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:50.215+0900 E/EFL     ( 2547): evas_main<2547> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=39087511 button=1 downs=0
05-31 17:19:50.300+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 0
05-31 17:19:50.315+0900 I/AUL_AMD (  498): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-31 17:19:50.330+0900 I/AUL_AMD (  498): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-31 17:19:50.330+0900 E/AUL_AMD (  498): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-31 17:19:50.330+0900 W/AUL_AMD (  498): amd_launch.c: _start_app(1702) > caller pid : 699
05-31 17:19:50.345+0900 E/RESOURCED(  499): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-31 17:19:50.345+0900 E/RESOURCED(  499): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-31 17:19:50.350+0900 W/AUL_AMD (  498): amd_launch.c: _start_app(2080) > pad pid(-5)
05-31 17:19:50.350+0900 W/AUL_PAD ( 1201): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-31 17:19:50.350+0900 W/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(272) > Check app launching
05-31 17:19:50.410+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:50.410+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:50.445+0900 I/efl-extension( 1642): efl_extension.c: eext_mod_init(40) > Init
05-31 17:19:50.460+0900 I/CAPI_APPFW_APPLICATION( 1642): app_main.c: ui_app_main(704) > app_efl_main
05-31 17:19:50.465+0900 I/CAPI_APPFW_APPLICATION( 1642): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-31 17:19:50.555+0900 E/TBM     ( 1642): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-31 17:19:50.560+0900 E/AUL     (  498): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-31 17:19:50.605+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:50.605+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:50.695+0900 E/E17     (  388): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04800002)
05-31 17:19:50.725+0900 E/EFL     ( 1642): ecore_evas<1642> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-31 17:19:50.805+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:50.805+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:50.815+0900 I/efl-extension( 1642): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0x43c2c160]'s widget[0x43b8c648] to elm_conformant widget[0x419c1b50]
05-31 17:19:50.990+0900 I/HAP     ( 1642): SUCCESSFULLY create sap agent
05-31 17:19:50.990+0900 I/HAP     ( 1642): connectivity type(1): bt
05-31 17:19:51.005+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:51.005+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:51.205+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:51.205+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:51.210+0900 I/HAP     ( 1642): agent is initialized
05-31 17:19:51.215+0900 I/HAP     ( 1642): agent initialized callback is over
05-31 17:19:51.215+0900 I/HAP     ( 1642): SAP >>> getRegisteredServiceAgent() >>> 0
05-31 17:19:51.365+0900 E/TIZEN_N_RECORDER( 1642): recorder.c: __convert_recorder_error_code(193) > [audio-channel] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:19:51.365+0900 E/TIZEN_N_RECORDER( 1642): recorder.c: __convert_recorder_error_code(193) > [audio-device] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:19:51.400+0900 I/APP_CORE( 1642): appcore-efl.c: __do_app(429) > [APP 1642] Event: RESET State: CREATED
05-31 17:19:51.400+0900 I/CAPI_APPFW_APPLICATION( 1642): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-31 17:19:51.405+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:51.405+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:51.430+0900 I/APP_CORE( 1642): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-31 17:19:51.430+0900 I/APP_CORE( 1642): appcore-efl.c: __do_app(474) > [APP 1642] Initial Launching, call the resume_cb
05-31 17:19:51.430+0900 I/CAPI_APPFW_APPLICATION( 1642): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 17:19:51.440+0900 W/APP_CORE( 1642): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4800002
05-31 17:19:51.445+0900 E/EFL     ( 1642): evas_main<1642> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=39088157 button=1 downs=1
05-31 17:19:51.445+0900 E/EFL     ( 1642): evas_main<1642> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=39088223 button=1 downs=0
05-31 17:19:51.445+0900 E/EFL     ( 1642): evas_main<1642> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=39088473 button=1 downs=1
05-31 17:19:51.445+0900 E/EFL     ( 1642): evas_main<1642> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=39088538 button=1 downs=0
05-31 17:19:51.445+0900 E/EFL     ( 1642): evas_main<1642> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=39088714 button=1 downs=1
05-31 17:19:51.455+0900 I/efl-extension( 1642): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x43c2c160 = w: 0 h: 0  obj 0x43b8c648 w: 360 h: 360
05-31 17:19:51.460+0900 I/efl-extension( 1642): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-31 17:19:51.525+0900 E/EFL     ( 1642): evas_main<1642> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=39088780 button=1 downs=0
05-31 17:19:51.525+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: PAUSE State: RUNNING
05-31 17:19:51.525+0900 I/CAPI_APPFW_APPLICATION( 2547): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-31 17:19:51.525+0900 I/APP_CORE( 1642): appcore-efl.c: __do_app(429) > [APP 1642] Event: RESUME State: RUNNING
05-31 17:19:51.545+0900 W/AUL_AMD (  498): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 17:19:51.545+0900 W/AUL_AMD (  498): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-31 17:19:51.605+0900 W/WATCH_CORE(  752): appcore-watch.c: __widget_pause(1001) > widget_pause
05-31 17:19:51.605+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppPause(713) > 
05-31 17:19:51.605+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-31 17:19:51.605+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-31 17:19:51.605+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-31 17:19:51.605+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-31 17:19:51.605+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-31 17:19:51.605+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-31 17:19:51.645+0900 E/EFL     ( 1642): evas_main<1642> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=39088941 button=1 downs=1
05-31 17:19:51.665+0900 E/EFL     ( 1642): evas_main<1642> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=39088962 button=1 downs=0
05-31 17:19:51.720+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:19:51.725+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1642
05-31 17:19:51.730+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 12
05-31 17:19:51.870+0900 E/EFL     ( 1642): evas_main<1642> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=39089164 button=1 downs=1
05-31 17:19:51.920+0900 E/AUL     (  498): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-31 17:19:51.920+0900 E/EFL     ( 1642): evas_main<1642> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=39089218 button=1 downs=0
05-31 17:19:52.095+0900 I/watchface-viewer(  752): viewer-data-provider.cpp: AddPendingChanges(1088) > added [37] to pending list
05-31 17:19:52.095+0900 I/watchface-viewer(  752): viewer-data-provider.cpp: AddPendingChanges(1088) > added [39] to pending list
05-31 17:19:52.095+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 55 -> 54 1464682792 91
05-31 17:19:52.095+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 54 693 376 624
05-31 17:19:52.095+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 54 0 0 1073
05-31 17:19:52.095+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 54 958 375 862
05-31 17:19:52.095+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 54 126 5 113
05-31 17:19:52.095+0900 I/RESOURCED(  499): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 54 438 25 394
05-31 17:19:52.180+0900 I/AUL_PAD ( 1730): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-31 17:19:52.535+0900 E/EFL     ( 1642): evas_main<1642> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=39089832 button=1 downs=1
05-31 17:19:52.625+0900 E/EFL     ( 1642): evas_main<1642> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=39089920 button=1 downs=0
05-31 17:19:52.860+0900 I/aa      ( 1642): here = On
05-31 17:19:52.860+0900 I/aa      ( 1642): here2 = On
05-31 17:19:52.860+0900 E/TIZEN_N_RECORDER( 1642): recorder.c: __convert_recorder_error_code(193) > [recorder_set_filename] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:19:52.860+0900 E/TIZEN_N_RECORDER( 1642): recorder.c: __convert_recorder_error_code(193) > [file-format] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:19:52.860+0900 E/TIZEN_N_RECORDER( 1642): recorder.c: __convert_recorder_error_code(193) > [audio-encoder] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:19:52.905+0900 I/PRIVACY-MANAGER-CLIENT( 1642): PrivacyChecker.cpp: initialize(168) > Got lock. Starting initialize
05-31 17:19:52.905+0900 I/PRIVACY-MANAGER-CLIENT( 1642): PrivacyChecker.cpp: runSignalListenerThread(194) > Running g main loop for signal
05-31 17:19:52.905+0900 I/PRIVACY-MANAGER-CLIENT( 1642): PrivacyChecker.cpp: initializeDbus(220) > Starting initialize
05-31 17:19:52.950+0900 I/PRIVACY-MANAGER-CLIENT( 1642): PrivacyChecker.cpp: initializeDbus(235) > Initialized
05-31 17:19:52.950+0900 I/PRIVACY-MANAGER-CLIENT( 1642): PrivacyChecker.cpp: initialize(186) > Initialized
05-31 17:19:53.820+0900 E/TIZEN_N_RECORDER( 1642): recorder.c: __convert_recorder_error_code(193) > [recorder_start] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:19:53.820+0900 E/EFL     ( 1642): <1642> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:19:53.820+0900 E/EFL     ( 1642): <1642> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:19:53.825+0900 I/aa      ( 1642): chk1 = Off
05-31 17:19:54.825+0900 I/aa      ( 1642): res = 0
05-31 17:19:54.830+0900 I/aa      ( 1642): res = 0
05-31 17:19:54.830+0900 I/aa      ( 1642): db hi = -8.047776
05-31 17:19:54.840+0900 I/HAP     ( 1642): Updating UI with data 주의 하세요!
05-31 17:19:55.565+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:19:55.570+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1642
05-31 17:19:56.550+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: MEM_FLUSH State: PAUSED
05-31 17:19:57.935+0900 I/aa      ( 1642): db hi = 0
05-31 17:19:58.770+0900 E/EFL     ( 1642): evas_main<1642> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=39096059 button=1 downs=1
05-31 17:19:58.895+0900 E/EFL     ( 1642): evas_main<1642> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=39096172 button=1 downs=0
05-31 17:19:58.935+0900 I/aa      ( 1642): res = 0
05-31 17:19:58.935+0900 I/aa      ( 1642): res = 0
05-31 17:19:58.935+0900 I/aa      ( 1642): db hi = -10.227484
05-31 17:19:58.945+0900 I/HAP     ( 1642): Updating UI with data 주의 하세요!
05-31 17:19:58.985+0900 E/EFL     ( 1642): evas_main<1642> evas_object_image.c:3928 evas_object_image_is_inside() Couldn't get image pixels RGBA_Image 0x43c748c8: im=0x43c748c8, data=0x484102a0, err=1
05-31 17:19:59.130+0900 W/CRASH_MANAGER( 1615): worker.c: worker_job(1199) > 1101642686170146468279
