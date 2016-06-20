S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.5
Build-Number: R732XXU2CPC5
Build-Date: 2016.03.21 17:05:24

Crash Information
Process Name: hap
PID: 4869
Date: 2016-05-29 20:21:12+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x41b7a504, r1   = 0xffffffff
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x4000dacc, r5   = 0xbeef8ec0
r6   = 0x41ca9c00, r7   = 0xbeef8e98
r8   = 0x43c29500, r9   = 0x40359861
r10  = 0x405014b8, fp   = 0x00000000
ip   = 0x41488a20, sp   = 0xbeef8c80
lr   = 0x40413070, pc   = 0x40413090
cpsr = 0x40000010

Memory Information
MemTotal:   491012 KB
MemFree:      9076 KB
Buffers:     17608 KB
Cached:     160356 KB
VmPeak:      75904 KB
VmSize:      73444 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18956 KB
VmRSS:       18956 KB
VmData:      41048 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       28068 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 4869 TID = 4869
4869 4871 4872 4875 

Maps Information
40000000 40006000 r-xp /opt/usr/apps/org.example.hap/bin/hap
4000d000 4000e000 rwxp /opt/usr/apps/org.example.hap/bin/hap
4000f000 4002c000 r-xp /lib/ld-2.13.so
40033000 40034000 r-xp /lib/ld-2.13.so
40034000 40035000 rwxp /lib/ld-2.13.so
40035000 40039000 r-xp /usr/lib/libsys-assert.so
40041000 40042000 rwxp /usr/lib/libsys-assert.so
40042000 4004d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
40055000 40056000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
40057000 40059000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
40061000 40062000 rwxp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
40062000 40066000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4006d000 4006e000 rwxp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4006e000 40073000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4007a000 4007b000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
4007b000 4007d000 r-xp /usr/lib/libdlog.so.0.0.0
40084000 40085000 rwxp /usr/lib/libdlog.so.0.0.0
40085000 400a6000 r-xp /usr/lib/libefl-extension.so.0.1.0
400ad000 400ae000 rwxp /usr/lib/libefl-extension.so.0.1.0
400ae000 400ef000 r-xp /usr/lib/libeina.so.1.7.99
400f6000 400f8000 rwxp /usr/lib/libeina.so.1.7.99
400f8000 40232000 r-xp /usr/lib/libelementary.so.1.7.99
40239000 40241000 rwxp /usr/lib/libelementary.so.1.7.99
40248000 40316000 r-xp /usr/lib/libevas.so.1.7.99
4031e000 40328000 rwxp /usr/lib/libevas.so.1.7.99
4033b000 4034d000 r-xp /usr/lib/libtts.so
40354000 40355000 rwxp /usr/lib/libtts.so
40355000 40362000 r-xp /usr/lib/libsap-client-stub-api.so.1.0.0
40369000 4036a000 rwxp /usr/lib/libsap-client-stub-api.so.1.0.0
4036a000 403d3000 r-xp /lib/libm-2.13.so
403da000 403db000 r-xp /lib/libm-2.13.so
403db000 403dc000 rwxp /lib/libm-2.13.so
403dc000 404f7000 r-xp /lib/libc-2.13.so
404ff000 40501000 r-xp /lib/libc-2.13.so
40501000 40502000 rwxp /lib/libc-2.13.so
40505000 40510000 r-xp /lib/libunwind.so.8.0.1
40517000 40518000 rwxp /lib/libunwind.so.8.0.1
4053d000 4053f000 r-xp /lib/libdl-2.13.so
40546000 40547000 r-xp /lib/libdl-2.13.so
40547000 40548000 rwxp /lib/libdl-2.13.so
40548000 40550000 r-xp /lib/libgcc_s-4.6.so.1
40550000 40551000 rwxp /lib/libgcc_s-4.6.so.1
40551000 4055d000 r-xp /usr/lib/libaul.so.0.1.0
40565000 40566000 rwxp /usr/lib/libaul.so.0.1.0
40567000 40589000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
40590000 40591000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
40591000 405a5000 r-xp /lib/libpthread-2.13.so
405ac000 405ad000 r-xp /lib/libpthread-2.13.so
405ad000 405ae000 rwxp /lib/libpthread-2.13.so
405b0000 405b4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
405bc000 405bd000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
405bd000 405c2000 r-xp /usr/lib/libappcore-efl.so.1.1
405c9000 405ca000 rwxp /usr/lib/libappcore-efl.so.1.1
405ca000 405cf000 r-xp /usr/lib/libappcore-common.so.1.1
405d6000 405d7000 rwxp /usr/lib/libappcore-common.so.1.1
405d7000 405d9000 r-xp /usr/lib/libiniparser.so.0
405e1000 405e2000 rwxp /usr/lib/libiniparser.so.0
405e2000 406ae000 r-xp /usr/lib/libxml2.so.2.7.8
406b5000 406ba000 rwxp /usr/lib/libxml2.so.2.7.8
406bb000 4070b000 r-xp /usr/lib/libecore_x.so.1.7.99
4070b000 4070d000 rwxp /usr/lib/libecore_x.so.1.7.99
4070d000 40724000 r-xp /usr/lib/libecore.so.1.7.99
4072c000 4072d000 rwxp /usr/lib/libecore.so.1.7.99
4073b000 40798000 r-xp /usr/lib/libedje.so.1.7.99
407a0000 407a2000 rwxp /usr/lib/libedje.so.1.7.99
407a2000 4085a000 r-xp /usr/lib/libcairo.so.2.11200.14
40861000 40864000 rwxp /usr/lib/libcairo.so.2.11200.14
40865000 40946000 r-xp /usr/lib/libX11.so.6.3.0
4094d000 40951000 rwxp /usr/lib/libX11.so.6.3.0
40951000 4095a000 r-xp /usr/lib/libXi.so.6.1.0
40961000 40962000 rwxp /usr/lib/libXi.so.6.1.0
40962000 4098a000 r-xp /usr/lib/libfontconfig.so.1.8.0
4098a000 4098b000 rwxp /usr/lib/libfontconfig.so.1.8.0
4098b000 40991000 r-xp /lib/librt-2.13.so
40998000 40999000 r-xp /lib/librt-2.13.so
40999000 4099a000 rwxp /lib/librt-2.13.so
4099a000 409b3000 r-xp /usr/lib/libeet.so.1.7.99
409bb000 409bc000 rwxp /usr/lib/libeet.so.1.7.99
409c4000 409e6000 r-xp /usr/lib/libecore_evas.so.1.7.99
409ed000 409ef000 rwxp /usr/lib/libecore_evas.so.1.7.99
409ef000 409f4000 r-xp /usr/lib/libecore_file.so.1.7.99
409fb000 409fc000 rwxp /usr/lib/libecore_file.so.1.7.99
409fc000 40a0d000 r-xp /usr/lib/libecore_input.so.1.7.99
40a14000 40a15000 rwxp /usr/lib/libecore_input.so.1.7.99
40a15000 40a19000 r-xp /usr/lib/libvconf.so.0.2.45
40a20000 40a21000 rwxp /usr/lib/libvconf.so.0.2.45
40a21000 40a2a000 r-xp /usr/lib/libedbus.so.1.7.99
40a31000 40a32000 rwxp /usr/lib/libedbus.so.1.7.99
40a32000 40a5c000 r-xp /usr/lib/libdbus-1.so.3.8.12
40a64000 40a65000 rwxp /usr/lib/libdbus-1.so.3.8.12
40a65000 40a7f000 r-xp /usr/lib/libecore_con.so.1.7.99
40a86000 40a87000 rwxp /usr/lib/libecore_con.so.1.7.99
40a88000 40a9b000 r-xp /usr/lib/libfribidi.so.0.3.1
40aa2000 40aa3000 rwxp /usr/lib/libfribidi.so.0.3.1
40aa3000 40ae0000 r-xp /usr/lib/libharfbuzz.so.0.940.0
40ae7000 40ae8000 rwxp /usr/lib/libharfbuzz.so.0.940.0
40ae9000 40b3f000 r-xp /usr/lib/libfreetype.so.6.11.3
40b47000 40b4b000 rwxp /usr/lib/libfreetype.so.6.11.3
40b4b000 40ba1000 r-xp /usr/lib/libpixman-1.so.0.28.2
40ba9000 40bae000 rwxp /usr/lib/libpixman-1.so.0.28.2
40bae000 40c7e000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40c7e000 40c7f000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
40c7f000 40d52000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40d59000 40d5d000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
40d5d000 40d91000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40d98000 40d9a000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
40d9a000 40da2000 r-xp /usr/lib/libsap_client.so.0.0.0
40da9000 40daa000 rwxp /usr/lib/libsap_client.so.0.0.0
40daa000 40dad000 r-xp /usr/lib/libbundle.so.0.1.22
40db4000 40db5000 rwxp /usr/lib/libbundle.so.0.1.22
40db5000 40dcc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40dd3000 40dd4000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
40dd4000 40dd9000 r-xp /usr/lib/libxdgmime.so.1.1.0
40de0000 40de1000 rwxp /usr/lib/libxdgmime.so.1.1.0
40de1000 40e1d000 r-xp /usr/lib/libsystemd.so.0.4.0
40e24000 40e25000 r-xp /usr/lib/libsystemd.so.0.4.0
40e25000 40e26000 rwxp /usr/lib/libsystemd.so.0.4.0
40e26000 40e29000 r-xp /usr/lib/libproc-stat.so.0.2.86
40e30000 40e31000 rwxp /usr/lib/libproc-stat.so.0.2.86
40e31000 40e47000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40e4e000 40e4f000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
40e4f000 40ec4000 r-xp /usr/lib/libsqlite3.so.0.8.6
40ecb000 40ece000 rwxp /usr/lib/libsqlite3.so.0.8.6
40ece000 40ed4000 r-xp /usr/lib/libappsvc.so.0.1.0
40edb000 40edc000 rwxp /usr/lib/libappsvc.so.0.1.0
40edc000 40ee2000 r-xp /usr/lib/libecore_imf.so.1.7.99
40ee9000 40eea000 rwxp /usr/lib/libecore_imf.so.1.7.99
40eea000 40f00000 r-xp /lib/libz.so.1.2.5
40f07000 40f08000 rwxp /lib/libz.so.1.2.5
40f08000 40f0f000 r-xp /usr/lib/libXcursor.so.1.0.2
40f16000 40f17000 rwxp /usr/lib/libXcursor.so.1.0.2
40f17000 40f19000 r-xp /usr/lib/libXdamage.so.1.1.0
40f20000 40f21000 rwxp /usr/lib/libXdamage.so.1.1.0
40f21000 40f23000 r-xp /usr/lib/libXcomposite.so.1.0.0
40f2a000 40f2b000 rwxp /usr/lib/libXcomposite.so.1.0.0
40f2b000 40f2d000 r-xp /usr/lib/libXgesture.so.7.0.0
40f34000 40f35000 rwxp /usr/lib/libXgesture.so.7.0.0
40f35000 40f38000 r-xp /usr/lib/libXfixes.so.3.1.0
40f3f000 40f40000 rwxp /usr/lib/libXfixes.so.3.1.0
40f40000 40f41000 r-xp /usr/lib/libXinerama.so.1.0.0
40f49000 40f4a000 rwxp /usr/lib/libXinerama.so.1.0.0
40f4a000 40f50000 r-xp /usr/lib/libXrandr.so.2.2.0
40f57000 40f58000 rwxp /usr/lib/libXrandr.so.2.2.0
40f58000 40f5e000 r-xp /usr/lib/libXrender.so.1.3.0
40f65000 40f66000 rwxp /usr/lib/libXrender.so.1.3.0
40f66000 40f6a000 r-xp /usr/lib/libXtst.so.6.1.0
40f71000 40f72000 rwxp /usr/lib/libXtst.so.6.1.0
40f72000 40f7c000 r-xp /usr/lib/libXext.so.6.4.0
40f84000 40f85000 rwxp /usr/lib/libXext.so.6.4.0
40f85000 40f8c000 r-xp /usr/lib/libembryo.so.1.7.99
40f93000 40f94000 rwxp /usr/lib/libembryo.so.1.7.99
40f94000 40fab000 r-xp /usr/lib/liblua-5.1.so
40fb3000 40fb4000 rwxp /usr/lib/liblua-5.1.so
40fb4000 40fb5000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40fbc000 40fbd000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
40fbd000 40fcb000 r-xp /usr/lib/libGLESv2.so.2.0
40fd3000 40fd4000 rwxp /usr/lib/libGLESv2.so.2.0
40fd4000 40fec000 r-xp /usr/lib/libpng12.so.0.50.0
40ff3000 40ff4000 rwxp /usr/lib/libpng12.so.0.50.0
40ff4000 40ff5000 r-xp /usr/lib/libxcb-shm.so.0.0.0
40ffd000 40ffe000 rwxp /usr/lib/libxcb-shm.so.0.0.0
40ffe000 41004000 r-xp /usr/lib/libxcb-render.so.0.0.0
4100b000 4100c000 rwxp /usr/lib/libxcb-render.so.0.0.0
4100d000 41020000 r-xp /usr/lib/libxcb.so.1.1.0
41028000 41029000 rwxp /usr/lib/libxcb.so.1.1.0
41029000 4102c000 r-xp /usr/lib/libEGL.so.1.4
41033000 41034000 rwxp /usr/lib/libEGL.so.1.4
41034000 4104a000 r-xp /lib/libexpat.so.1.5.2
41052000 41054000 rwxp /lib/libexpat.so.1.5.2
41054000 41077000 r-xp /usr/lib/libjpeg.so.8.0.2
4107e000 4107f000 rwxp /usr/lib/libjpeg.so.8.0.2
4108f000 41094000 r-xp /usr/lib/libecore_fb.so.1.7.99
4109b000 4109d000 rwxp /usr/lib/libecore_fb.so.1.7.99
4109e000 410a2000 r-xp /usr/lib/libecore_ipc.so.1.7.99
410aa000 410ab000 rwxp /usr/lib/libecore_ipc.so.1.7.99
410ab000 410ae000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
410b5000 410b6000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
410b6000 410fa000 r-xp /usr/lib/libcurl.so.4.3.0
41101000 41103000 rwxp /usr/lib/libcurl.so.4.3.0
41103000 41104000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
4110b000 4110c000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
4110d000 41112000 r-xp /usr/lib/libffi.so.5.0.10
41119000 4111a000 rwxp /usr/lib/libffi.so.5.0.10
4111a000 4111c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
41123000 41124000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
41124000 41134000 r-xp /lib/libresolv-2.13.so
41134000 41135000 r-xp /lib/libresolv-2.13.so
41135000 41136000 rwxp /lib/libresolv-2.13.so
41138000 4113e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
41146000 41147000 rwxp /usr/lib/libcapi-base-common.so.0.1.8
41147000 4115f000 r-xp /usr/lib/liblzma.so.5.0.3
41166000 41167000 rwxp /usr/lib/liblzma.so.5.0.3
41168000 411e4000 r-xp /usr/lib/libgcrypt.so.20.0.3
411eb000 411f0000 rwxp /usr/lib/libgcrypt.so.20.0.3
411f0000 411f2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
411fa000 411fb000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
411fb000 411fd000 r-xp /usr/lib/journal/libjournal.so.0.1.0
41204000 41205000 rwxp /usr/lib/journal/libjournal.so.0.1.0
41205000 41207000 r-xp /usr/lib/libXau.so.6.0.0
4120e000 4120f000 rwxp /usr/lib/libXau.so.6.0.0
41210000 41219000 r-xp /usr/lib/libcares.so.2.1.0
41221000 41222000 rwxp /usr/lib/libcares.so.2.1.0
41222000 41250000 r-xp /usr/lib/libidn.so.11.5.44
41257000 41258000 rwxp /usr/lib/libidn.so.11.5.44
41258000 412a5000 r-xp /usr/lib/libssl.so.1.0.0
412ac000 412b1000 rwxp /usr/lib/libssl.so.1.0.0
412b1000 41459000 r-xp /usr/lib/libcrypto.so.1.0.0
41459000 4146e000 rwxp /usr/lib/libcrypto.so.1.0.0
41473000 4147e000 r-xp /usr/lib/libgpg-error.so.0.15.0
41485000 41486000 rwxp /usr/lib/libgpg-error.so.0.15.0
4148a000 41554000 r-xp /usr/lib/libCOREGL.so.4.0
4155c000 4155e000 rwxp /usr/lib/libCOREGL.so.4.0
41566000 4158a000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41591000 41593000 rwxp /usr/lib/ecore/immodules/libisf-imf-module.so
41593000 41662000 r-xp /usr/lib/libscim-1.0.so.8.2.3
41669000 41678000 rwxp /usr/lib/libscim-1.0.so.8.2.3
41678000 4170c000 r-xp /usr/lib/libstdc++.so.6.0.16
41714000 41717000 r-xp /usr/lib/libstdc++.so.6.0.16
41717000 41719000 rwxp /usr/lib/libstdc++.so.6.0.16
4171f000 4174c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
41753000 41754000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
41754000 41757000 r-xp /usr/lib/libsmack.so.1.0.0
4175e000 4175f000 rwxp /usr/lib/libsmack.so.1.0.0
4175f000 4177c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
41784000 41785000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
41785000 41787000 r-xp /usr/lib/libiri.so
4178e000 4178f000 rwxp /usr/lib/libiri.so
4178f000 41792000 r-xp /lib/libcap.so.2.21
41799000 4179a000 rwxp /lib/libcap.so.2.21
4179a000 417a1000 r-xp /lib/libcrypt-2.13.so
417a8000 417a9000 r-xp /lib/libcrypt-2.13.so
417a9000 417aa000 rwxp /lib/libcrypt-2.13.so
417d1000 417d4000 r-xp /lib/libattr.so.1.1.0
417db000 417dc000 rwxp /lib/libattr.so.1.1.0
417dc000 417e6000 r-xp /lib/libnss_files-2.13.so
417ed000 417ee000 r-xp /lib/libnss_files-2.13.so
417ee000 417ef000 rwxp /lib/libnss_files-2.13.so
417ef000 41866000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
4186e000 41870000 rwxp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
41877000 4187a000 rwxp [stack:4872]
4187a000 4187e000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41885000 41886000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41886000 4188a000 rwxs /dev/mali
4188b000 4188d000 r-xp /usr/lib/libdri2.so.0.0.0
41894000 41895000 rwxp /usr/lib/libdri2.so.0.0.0
41895000 4189d000 r-xp /usr/lib/libdrm.so.2.4.0
418a4000 418a5000 rwxp /usr/lib/libdrm.so.2.4.0
418a5000 418ac000 r-xp /usr/lib/libtbm.so.1.0.0
418b3000 418b4000 rwxp /usr/lib/libtbm.so.1.0.0
418b4000 418b7000 r-xp /usr/lib/libnative-buffer.so.0.1.0
418be000 418bf000 rwxp /usr/lib/libnative-buffer.so.0.1.0
418bf000 418c7000 rwxs /dev/mali
418c7000 418c9000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
418c9000 4197a000 rwxp [heap]
4197a000 41b7a000 r-xp /usr/share/locale/locale-archive
41b7a000 41cab000 r-xp /usr/share/locale/locale-archive
41dab000 41ef3000 r-xp /usr/lib/egl/libMali.so
41ef3000 41ef8000 rwxp /usr/lib/egl/libMali.so
41ef9000 426f8000 rwxp [stack:4871]
426f8000 42700000 rwxs /dev/mali
42700000 42714000 r-xs /opt/home/app/.cache/evas_gl_common_caches/ARM::OpenGL
42714000 42718000 rwxs /dev/mali
42718000 4271c000 rwxs /dev/mali
4271c000 42724000 rwxs /dev/mali
42724000 4272c000 rwxs /dev/mali
4272c000 428cb000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
428cb000 428e2000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
428ea000 428ef000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
428ef000 428f6000 r-xs /usr/lib/gconv/gconv-modules.cache
429f7000 429f9000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
42a00000 42a01000 rwxp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43b01000 43b41000 rwxs /dev/mali
43b55000 43b79000 rwxs /dev/mali
43b79000 43b7d000 rwxs /dev/mali
43b7d000 43ba1000 rwxs /dev/mali
43ba1000 43ba5000 rwxs /dev/mali
43ba5000 43bc9000 rwxs /dev/mali
43bc9000 43bcd000 rwxs /dev/mali
43bf6000 43bf9000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
43bf9000 43bfd000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
43d00000 43d0f000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
43d0f000 43d9b000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
43d9b000 43e26000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
43e27000 44626000 rwxp [stack:4875]
44626000 446a8000 rwxs /dev/dri/card0
446a8000 447a8000 rwxs /dev/mali
beed9000 beefa000 rwxp [stack]
End of Maps Information

Callstack Information (PID:4869)
Call Stack Count: 1
 0: (0x40413090) [/lib/libc.so.6] + 0x37090
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
ed!!
05-29 20:20:59.385+0900 I/efl-extension( 1366): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2199) > called!!
05-29 20:20:59.385+0900 I/efl-extension( 1366): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
05-29 20:20:59.390+0900 I/efl-extension( 1366): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
05-29 20:20:59.390+0900 I/efl-extension( 1366): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
05-29 20:20:59.400+0900 I/efl-extension( 1366): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2273) > called!!
05-29 20:20:59.400+0900 I/efl-extension( 1366): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
05-29 20:20:59.405+0900 I/efl-extension( 1366): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
05-29 20:20:59.405+0900 I/efl-extension( 1366): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
05-29 20:20:59.410+0900 I/efl-extension( 1366): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2273) > called!!
05-29 20:20:59.415+0900 I/efl-extension( 1366): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
05-29 20:20:59.415+0900 I/efl-extension( 4822): efl_extension.c: eext_mod_init(40) > Init
05-29 20:20:59.415+0900 I/wnotibp ( 1366): w-notification-board-common.c: wnotib_common_get_category_name(2224) > application_id: 218, default_name: 카카오톡
05-29 20:20:59.415+0900 I/efl-extension( 1366): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
05-29 20:20:59.415+0900 I/efl-extension( 1366): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
05-29 20:20:59.425+0900 I/efl-extension( 1366): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2273) > called!!
05-29 20:20:59.430+0900 I/efl-extension( 1366): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
05-29 20:20:59.430+0900 I/wnotibp ( 1366): w-notification-board-action-drawer.c: _wnotib_action_drawer_create_pages(4431) > Number of pages: 4 for 218
05-29 20:20:59.430+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4822): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-29 20:20:59.430+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4822): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-29 20:20:59.430+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4822): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-29 20:20:59.430+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4822): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-29 20:20:59.430+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4822): system_settings.c: system_settings_set_changed_cb(534) > Enter [system_settings_set_changed_cb]
05-29 20:20:59.430+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4822): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-29 20:20:59.430+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4822): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-29 20:20:59.480+0900 I/efl-extension( 1366): efl_extension_more_option.c: _cue_hide_cb(234) > called!!
05-29 20:20:59.480+0900 W/APP_CORE( 1366): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:600000a
05-29 20:20:59.490+0900 I/efl-extension( 1366): efl_extension_rotary_selector.c: _item_update_animator_cb(1376) > called
05-29 20:20:59.495+0900 I/efl-extension( 1366): efl_extension_rotary_selector.c: _item_update_animator_cb(1385) > item_list(0x1145008856), count(5)
05-29 20:20:59.520+0900 E/PKGMGR  ( 4822): pkgmgr.c: pkgmgr_client_set_status_type(2914) > [0;31m[pkgmgr_client_set_status_type(): 2914](status_type == PKGMGR_CLIENT_STATUS_ALL) status_type is PKGMGR_CLIENT_STATUS_ALL[0;m
05-29 20:20:59.565+0900 E/EFL     ( 1366): evas_main<1366> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
05-29 20:20:59.565+0900 E/EFL     ( 1366): evas_main<1366> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
05-29 20:20:59.565+0900 E/EFL     ( 1366): evas_main<1366> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
05-29 20:20:59.565+0900 I/wnotibp ( 1366): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-29 20:20:59.565+0900 I/wnotibp ( 1366): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-29 20:20:59.570+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1366): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-29 20:20:59.570+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1366): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-29 20:20:59.570+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1366): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-29 20:20:59.570+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1366): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-29 20:20:59.630+0900 W/W_HOME  (  725): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-29 20:20:59.630+0900 W/W_HOME  (  725): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-29 20:20:59.630+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:20:59.630+0900 W/W_HOME  (  725): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-29 20:20:59.630+0900 I/APP_CORE(  725): appcore-efl.c: __do_app(429) > [APP 725] Event: PAUSE State: PAUSED
05-29 20:20:59.630+0900 I/APP_CORE(  725): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
05-29 20:20:59.635+0900 I/wnotib  (  725): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-29 20:20:59.635+0900 E/wnotib  (  725): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 20:20:59.640+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:20:59.640+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 20:20:59.655+0900 I/wnotibp ( 1366): wnotiboard-popup.c: _wnotib_popup_ecore_x_event_visibility_changed_cb(1037) > fully_obscured: 0 [0x600000a 0x600000a 0x6000008 ]
05-29 20:20:59.655+0900 I/APP_CORE( 1366): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
05-29 20:20:59.670+0900 I/MALI    ( 1366): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x43aa1f40] swap changed from async to sync
05-29 20:20:59.670+0900 W/wnotibp ( 1366): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3713) > ::UI:: VI TYPE : 1
05-29 20:20:59.675+0900 W/wnotibp ( 1366): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3719) > alert_type : 1, is_source_companion: 1
05-29 20:20:59.675+0900 W/TIZEN_N_RECORDER( 1366): recorder_product.c: recorder_is_in_recording(82) > pid =/proc/0 , state =0, alive=0
05-29 20:20:59.675+0900 W/wnotibp ( 1366): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1272) > ::APP:: application_id: 218, is_disaster: 0, is_CMAS: 0, disaster_info: (null), app_feedback_type: 0 is_recording: 0
05-29 20:20:59.675+0900 I/wnotibp ( 1366): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1281) > Gear side feedback setting is_sound_on: 0, is_vibration_on: 1, is_vibrate_when_noti_on: 0
05-29 20:20:59.675+0900 W/wnotibp ( 1366): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1315) > ::APP:: Determined feedback: sound 0, vibration: 0
05-29 20:20:59.675+0900 I/wnotibp ( 1366): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1319) > No feedback.
05-29 20:21:00.060+0900 W/wnotibp ( 1366): wnotiboard-popup-view.c: _wnotiboard_popup_simple_popup_show_finished_cb(1023) > ::UI:: popup effect is finished (705, 48363240)
05-29 20:21:00.060+0900 W/wnotibp ( 1366): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [simple popup] is UNLOCK , 0000 <=== ]]]
05-29 20:21:00.065+0900 W/wnotibp ( 1366): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
05-29 20:21:00.075+0900 E/wnoti-service(  865): wnoti-db-client.c: wnoti_get_alert_categories(546) > _query_step failed(NO ROW)
05-29 20:21:00.080+0900 E/wnoti-service(  865): wnoti-db-utility.c: set_pm_lock(503) > >> set_pm_lock status : 2
05-29 20:21:00.080+0900 E/wnoti-service(  865): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 0
05-29 20:21:00.090+0900 E/wnoti-proxy( 1366): wnoti.c: wnoti_get_category_list(1249) > failed: GDBus.Error:org.freedesktop.DBus.Error.Failed: Empty List
05-29 20:21:00.090+0900 E/wnotibp ( 1366): wnotiboard-popup-data.c: wnotibp_get_alert_list(916) > ::DATA:: No categories available.
05-29 20:21:00.090+0900 W/wnotibp ( 1366): wnotiboard-popup-data.c: wnotibp_get_alert_list(919) > ::DATA:: read alert list : 0, list count : 1
05-29 20:21:00.440+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 20:21:00.455+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
05-29 20:21:00.470+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
05-29 20:21:00.470+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 20:21:00.470+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1702) > caller pid : 4847
05-29 20:21:00.475+0900 W/AUL_AMD (  495): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 1921
05-29 20:21:00.480+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: RESET State: PAUSED
05-29 20:21:00.480+0900 I/CAPI_APPFW_APPLICATION( 1921): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 20:21:00.485+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(1921), cmd(0)
05-29 20:21:00.505+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-29 20:21:00.505+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(481) > [APP 1921] App already running, raise the window
05-29 20:21:00.520+0900 E/E17     (  379): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04400002)
05-29 20:21:00.520+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(485) > [APP 1921] Call the resume_cb
05-29 20:21:00.520+0900 I/CAPI_APPFW_APPLICATION( 1921): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 20:21:00.525+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:21:00.525+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 20:21:00.705+0900 E/wnoti-service(  865): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 1
05-29 20:21:00.730+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 20:21:00.740+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 20:21:00.755+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 20:21:00.755+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 20:21:00.755+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1702) > caller pid : 700
05-29 20:21:00.775+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-29 20:21:00.775+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 20:21:00.780+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2080) > pad pid(-5)
05-29 20:21:00.780+0900 W/AUL_PAD ( 1191): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-29 20:21:00.780+0900 W/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(272) > Check app launching
05-29 20:21:00.785+0900 E/AUL_PAD ( 4759): launchpad_loader.c: __candidate_process_prepare_exec(259) > fail to set privileges - check your package's credential : -1
05-29 20:21:00.785+0900 E/AUL_PAD ( 4759): launchpad_loader.c: __candidate_process_launchpad_main_loop(402) > __candidate_process_prepare_exec() failed
05-29 20:21:00.830+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:00.830+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:00.935+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:00.935+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:01.035+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:01.035+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:01.135+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:01.135+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:01.235+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:01.235+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:01.335+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:01.335+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:01.435+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:01.435+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:01.535+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:01.535+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:01.635+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:01.640+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:01.740+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:01.740+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:01.840+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:01.840+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:01.940+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:01.940+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:02.040+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:02.040+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:02.140+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:02.140+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:02.240+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:02.240+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:02.345+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:02.345+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:02.450+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:02.450+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:02.455+0900 E/RESOURCED(  498): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 20:21:02.550+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:02.550+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:02.655+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:02.660+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:02.710+0900 E/wnoti-service(  865): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 0
05-29 20:21:02.765+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:02.765+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:02.875+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:02.875+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:02.875+0900 E/RESOURCED(  498): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 20:21:02.980+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:02.980+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:03.085+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:03.090+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:03.195+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:03.195+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:03.300+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:03.305+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:03.410+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:03.410+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:03.515+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:03.515+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:03.620+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:03.620+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:03.725+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:03.725+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:03.835+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:03.835+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:03.940+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:03.940+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:04.045+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:04.045+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:04.155+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:04.155+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:04.265+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:04.265+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:04.370+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:04.375+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:04.475+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:04.475+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:04.575+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:04.580+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:04.685+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:04.685+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:04.790+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:04.790+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:04.895+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:04.895+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:05.000+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:05.000+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:05.105+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:05.105+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:05.210+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:05.210+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:05.315+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:05.315+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:05.425+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:05.425+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:05.530+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:05.530+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:05.640+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:05.640+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:05.645+0900 E/RESOURCED(  498): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 20:21:05.750+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:05.750+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:05.860+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:05.860+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:21:05.965+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(312) > process launched, but cmdline not changed
05-29 20:21:05.970+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:21:06.050+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 20:21:06.060+0900 E/RESOURCED(  498): procfs.c: proc_get_oom_score_adj(124) > [proc_get_oom_score_adj,124] fopen /proc/4759/oom_score_adj failed
05-29 20:21:06.060+0900 E/RESOURCED(  498): proc-main.c: resourced_proc_status_change(860) > [resourced_proc_status_change,860] Empty pid or process not exists. 4759
05-29 20:21:06.090+0900 W/WATCH_CORE(  749): appcore-watch.c: __widget_resume(1012) > widget_resume
05-29 20:21:06.095+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppResume(721) > 
05-29 20:21:06.095+0900 I/watchface-viewer(  749): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [37]
05-29 20:21:06.095+0900 I/watchface-viewer(  749): viewer-part-resource.cpp: SetUpdateImage(1981) > new mThread[0x476cd698]
05-29 20:21:06.095+0900 I/watchface-viewer(  749): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [39]
05-29 20:21:06.095+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:21:06.095+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:21:06.120+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 26
05-29 20:21:06.145+0900 W/wnotibp ( 1366): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1904) > state : (2, 1, 1)
05-29 20:21:06.145+0900 I/wnotibp ( 1366): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1917) > simple popup=48363240, view_state=1
05-29 20:21:06.145+0900 W/wnotibp ( 1366): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-29 20:21:06.145+0900 W/wnotibp ( 1366): wnotiboard-popup.c: wnotiboard_popup_reset_view_lock(998) > ::UI:: lock state = 0000
05-29 20:21:06.150+0900 W/wnotibp ( 1366): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1989) > device_power_release_lock CPU>>>>>>>
05-29 20:21:06.165+0900 I/efl-extension( 1366): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
05-29 20:21:06.165+0900 I/wnotibp ( 1366): w-notification-board-action-drawer.c: wnotib_action_drawer_hide(4568) > Panel open state: 0 for 86, 218
05-29 20:21:06.165+0900 I/efl-extension( 1366): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
05-29 20:21:06.165+0900 I/wnotibp ( 1366): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(2024) > ::INFO:: call lower
05-29 20:21:06.165+0900 W/wnotibp ( 1366): wnotiboard-popup-view.c: _wnotiboard_popup_simple_popup_del_cb(425) > ::UI:: (3, 48363240, 48363240, 0)
05-29 20:21:06.165+0900 I/wnotibp ( 1366): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(926) > ::DATA:: remove notification data, 705
05-29 20:21:06.165+0900 I/wnotibp ( 1366): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(956) > ::DATA:: CHECK DATA : 0, 0
05-29 20:21:06.165+0900 W/wnotibp ( 1366): wnotiboard-popup.c: wnotiboard_popup_view_unlock(911) > ::UI:: [[[ [simple popup] is not in lock state , 0000  <===]]]
05-29 20:21:06.165+0900 W/wnotibp ( 1366): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 0 0
05-29 20:21:06.165+0900 I/efl-extension( 1366): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45166a10, elm_genlist, _activated_obj : 0x0, activated : 0
05-29 20:21:06.180+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
05-29 20:21:06.195+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
05-29 20:21:06.195+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 20:21:06.195+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1702) > caller pid : 488
05-29 20:21:06.245+0900 I/watchface-viewer(  749): viewer-part-resource.cpp: ThreadCallback(2108) > thread[0x476cd698]
05-29 20:21:06.245+0900 I/watchface-viewer(  749): viewer-part-resource.cpp: ThreadNotifyCallback(2170) > thread[0x476cd698]
05-29 20:21:06.250+0900 I/watchface-viewer(  749): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
05-29 20:21:06.260+0900 I/wnotibp ( 1366): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_w_input_selector(4828) > No need to close w-input-selector.
05-29 20:21:06.280+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:21:06.280+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:21:06.285+0900 I/watchface-viewer(  749): viewer-part-resource.cpp: ThreadEndCallback(2206) > thread[0x476cd698]
05-29 20:21:06.300+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2080) > pad pid(-5)
05-29 20:21:06.355+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-29 20:21:06.355+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 20:21:06.365+0900 I/APP_CORE( 1921): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
05-29 20:21:06.465+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:21:06.465+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:21:06.660+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:21:06.660+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:21:06.855+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:21:06.855+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:21:07.025+0900 W/AUL_PAD ( 1191): launchpad.c: __launchpad_main_loop(607) > Candidate is not prepared, enter legacy logic
05-29 20:21:07.025+0900 W/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(272) > Check app launching
05-29 20:21:07.025+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2091) > Launch with legacy way : no launchpad
05-29 20:21:07.045+0900 W/AUL_AMD (  495): amd_launch.c: start_process(580) > child process: 4869
05-29 20:21:07.080+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:21:07.080+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:21:07.140+0900 E/RESOURCED( 1097): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:21:07.140+0900 E/AUL     ( 1097): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-29 20:21:07.140+0900 E/CAPI_APPFW_APP_MANAGER( 1097): app_manager.c: app_manager_error(78) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
05-29 20:21:07.150+0900 W/AUL_AMD (  495): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 4869
05-29 20:21:07.150+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:21:07.160+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:21:07.200+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 20:21:07.200+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 4759
05-29 20:21:07.200+0900 I/wnotibp ( 1366): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_notifiboard_selector(4863) > ret : 0, is_running : 0
05-29 20:21:07.200+0900 I/efl-extension( 1366): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
05-29 20:21:07.200+0900 I/wnotibp ( 1366): w-notification-board-action-drawer.c: wnotib_action_drawer_hide(4568) > Panel open state: 0 for 86, 218
05-29 20:21:07.200+0900 I/efl-extension( 1366): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
05-29 20:21:07.210+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:21:07.210+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-29 20:21:07.220+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:21:07.220+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 20:21:07.265+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:21:07.265+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:21:07.275+0900 I/efl-extension( 4869): efl_extension.c: eext_mod_init(40) > Init
05-29 20:21:07.280+0900 I/efl-extension( 1366): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x45166a10, obj: 0x45166a10
05-29 20:21:07.280+0900 I/efl-extension( 1366): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 20:21:07.300+0900 I/efl-extension( 1366): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 20:21:07.305+0900 I/efl-extension( 1366): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45166a10, elm_genlist, func : 0x41825dfd
05-29 20:21:07.305+0900 I/efl-extension( 1366): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 20:21:07.310+0900 I/CAPI_APPFW_APPLICATION( 4869): app_main.c: ui_app_main(704) > app_efl_main
05-29 20:21:07.330+0900 I/MALI    ( 1366): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43aa1f40] swap changed from sync to async
05-29 20:21:07.335+0900 I/efl-extension( 1366): efl_extension_more_option.c: _cue_hide_cb(234) > called!!
05-29 20:21:07.340+0900 W/APP_CORE( 1366): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:600000a
05-29 20:21:07.345+0900 I/APP_CORE( 1366): appcore-efl.c: __do_app(429) > [APP 1366] Event: PAUSE State: RUNNING
05-29 20:21:07.345+0900 I/CAPI_APPFW_APPLICATION( 1366): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 20:21:07.395+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:21:07.400+0900 W/wnotibp ( 1366): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(268) > fg_app : 1
05-29 20:21:07.400+0900 W/wnotibp ( 1366): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-29 20:21:07.400+0900 W/wnotibp ( 1366): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1369) > [0, 0, 3, 0000]
05-29 20:21:07.400+0900 W/wnotibp ( 1366): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1370) > [1, 0]
05-29 20:21:07.400+0900 W/wnotibp ( 1366): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1371) > [0, 3, 0, 2, 0]
05-29 20:21:07.405+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4869
05-29 20:21:07.405+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 20:21:07.450+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:21:07.455+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:21:07.645+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:21:07.645+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:21:07.700+0900 I/CAPI_APPFW_APPLICATION( 4869): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-29 20:21:07.730+0900 I/AUL_PAD ( 4868): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 20:21:07.805+0900 E/TBM     ( 4869): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 20:21:07.835+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:21:07.835+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:21:08.000+0900 E/E17     (  379): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04600003)
05-29 20:21:08.025+0900 E/EFL     ( 4869): ecore_evas<4869> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-29 20:21:08.030+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:21:08.030+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:21:08.075+0900 I/efl-extension( 4869): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0x42958828]'s widget[0x4293bfb0] to elm_conformant widget[0x41d61230]
05-29 20:21:08.195+0900 I/HAP     ( 4869): SUCCESSFULLY create sap agent
05-29 20:21:08.195+0900 I/HAP     ( 4869): connectivity type(1): bt
05-29 20:21:08.225+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:21:08.225+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:21:08.415+0900 I/HAP     ( 4869): agent is initialized
05-29 20:21:08.420+0900 I/HAP     ( 4869): agent initialized callback is over
05-29 20:21:08.420+0900 I/HAP     ( 4869): SAP >>> getRegisteredServiceAgent() >>> 0
05-29 20:21:08.420+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:21:08.425+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:21:08.515+0900 I/APP_CORE( 4869): appcore-efl.c: __do_app(429) > [APP 4869] Event: RESET State: CREATED
05-29 20:21:08.515+0900 I/CAPI_APPFW_APPLICATION( 4869): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 20:21:08.545+0900 I/APP_CORE( 4869): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 20:21:08.545+0900 I/APP_CORE( 4869): appcore-efl.c: __do_app(474) > [APP 4869] Initial Launching, call the resume_cb
05-29 20:21:08.545+0900 I/CAPI_APPFW_APPLICATION( 4869): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 20:21:08.555+0900 W/APP_CORE( 4869): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4600003
05-29 20:21:08.560+0900 I/efl-extension( 4869): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x42958828 = w: 0 h: 0  obj 0x4293bfb0 w: 360 h: 360
05-29 20:21:08.565+0900 I/efl-extension( 4869): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 20:21:08.620+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:21:08.620+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:21:08.640+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: PAUSE State: RUNNING
05-29 20:21:08.640+0900 I/CAPI_APPFW_APPLICATION( 1921): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 20:21:08.640+0900 I/APP_CORE( 4869): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
05-29 20:21:08.640+0900 I/APP_CORE( 1921): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
05-29 20:21:08.655+0900 W/WATCH_CORE(  749): appcore-watch.c: __widget_pause(1001) > widget_pause
05-29 20:21:08.655+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppPause(713) > 
05-29 20:21:08.655+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:21:08.655+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:21:08.655+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:21:08.655+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:21:08.655+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:21:08.655+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:21:08.685+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:21:08.685+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 20:21:09.045+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:21:09.090+0900 I/MALI    ( 4869): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x41971f58] swap changed from async to sync
05-29 20:21:11.000+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:21:11.075+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4869
05-29 20:21:12.405+0900 I/APP_CORE( 1366): appcore-efl.c: __do_app(429) > [APP 1366] Event: MEM_FLUSH State: PAUSED
05-29 20:21:12.490+0900 I/HAP     ( 4869): routes length: 21
05-29 20:21:12.495+0900 I/HAP     ( 4869): 장다리로 을 따라 162m 이동/37.27655039833677/127.03127993829892
05-29 20:21:12.495+0900 I/HAP     ( 4869): lat: 37.277 lon: 127.031 num:0
05-29 20:21:12.505+0900 I/HAP     ( 4869): 우측 횡단보도 후 보행자도로 을 따라 26m 이동 /37.27795302297102/127.03180485142347
05-29 20:21:12.505+0900 I/HAP     ( 4869): lat: 37.278 lon: 127.032 num:1
05-29 20:21:12.505+0900 I/HAP     ( 4869): 직진 후 중부대로 을 따라 68m 이동 /37.27791969851095/127.03208538245273
05-29 20:21:12.505+0900 I/HAP     ( 4869): lat: 37.278 lon: 127.032 num:2
05-29 20:21:12.505+0900 I/HAP     ( 4869): 횡단보도 후 보행자도로 을 따라 8m 이동 /37.277830832970096/127.03281587420162
05-29 20:21:12.505+0900 I/HAP     ( 4869): lat: 37.278 lon: 127.033 num:3
05-29 20:21:12.505+0900 I/HAP     ( 4869): 직진 후 중부대로 을 따라 163m 이동 /37.27781416982219/127.03290475549065
05-29 20:21:12.505+0900 I/HAP     ( 4869): lat: 37.278 lon: 127.033 num:4
05-29 20:21:12.505+0900 I/HAP     ( 4869): 횡단보도 후 보행자도로 을 따라 9m 이동 /37.27737536309203/127.03465738649457
05-29 20:21:12.505+0900 I/HAP     ( 4869): lat: 37.277 lon: 127.035 num:5
05-29 20:21:12.505+0900 I/HAP     ( 4869): 직진 후 중부대로 을 따라 251m 이동 /37.27734481291254/127.03476015580091
05-29 20:21:12.505+0900 I/HAP     ( 4869): lat: 37.277 lon: 127.035 num:6
05-29 20:21:12.505+0900 I/HAP     ( 4869): 좌측 횡단보도 후 5m 이동 /37.27659494818776/127.03746826436145
05-29 20:21:12.505+0900 I/HAP     ( 4869): lat: 37.277 lon: 127.037 num:7
05-29 20:21:12.505+0900 I/HAP     ( 4869): 좌측 횡단보도 후 보행자도로 을 따라 27m 이동 /37.276619946035844/127.03750992654794
05-29 20:21:12.505+0900 I/HAP     ( 4869): lat: 37.277 lon: 127.038 num:8
05-29 20:21:12.505+0900 I/HAP     ( 4869): 우회전 후 권광로 을 따라 7m 이동 /37.27685047671701/127.03761268854973
05-29 20:21:12.505+0900 I/HAP     ( 4869): lat: 37.277 lon: 127.038 num:9
05-29 20:21:12.505+0900 I/HAP     ( 4869): 횡단보도 후 9m 이동 /37.27689213964827/127.03767379295
05-29 20:21:12.505+0900 I/HAP     ( 4869): lat: 37.277 lon: 127.038 num:10
05-29 20:21:12.505+0900 I/HAP     ( 4869): 직진 후 15m 이동 /37.27686436667676/127.03776267455035
05-29 20:21:12.505+0900 I/HAP     ( 4869): lat: 37.277 lon: 127.038 num:11
05-29 20:21:12.505+0900 I/HAP     ( 4869): 횡단보도 후 7m 이동 /37.27681437539752/127.03792654996703
05-29 20:21:12.505+0900 I/HAP     ( 4869): lat: 37.277 lon: 127.038 num:12
05-29 20:21:12.505+0900 I/HAP     ( 4869): 좌측 횡단보도 후 보행자도로 을 따라 10m 이동 /37.27678660202898/127.03799321136158
05-29 20:21:12.505+0900 I/HAP     ( 4869): lat: 37.277 lon: 127.038 num:13
05-29 20:21:12.505+0900 I/HAP     ( 4869): 좌회전 후 53m 이동 /37.27683937533004/127.038084868234
05-29 20:21:12.505+0900 I/HAP     ( 4869): lat: 37.277 lon: 127.038 num:14
05-29 20:21:12.505+0900 I/HAP     ( 4869): 우회전 후 권광로 을 따라 6m 이동 /37.27730598956949/127.03817651352684
05-29 20:21:12.505+0900 I/HAP     ( 4869): lat: 37.277 lon: 127.038 num:15
05-29 20:21:12.505+0900 I/HAP     ( 4869): 좌회전 후 권광로340번길 을 따라 93m 이동 /37.27733098801315/127.03825150602198
05-29 20:21:12.505+0900 I/HAP     ( 4869): lat: 37.277 lon: 127.038 num:16
05-29 20:21:12.505+0900 I/HAP     ( 4869): 10시 방향 좌회전 후 권광로348번길 을 따라 79m 이동 /37.27763096998274/127.03918752379786
05-29 20:21:12.505+0900 I/HAP     ( 4869): lat: 37.278 lon: 127.039 num:17
05-29 20:21:12.505+0900 I/HAP     ( 4869): UBF수원 에서 좌회전 후 중부대로223번길 을 따라 14m 이동 /37.27902250807859/127.04101509678411
05-29 20:21:12.520+0900 I/HAP     ( 4869): lat: 37.279 lon: 127.041 num:18
05-29 20:21:12.520+0900 I/HAP     ( 4869): 도착/37.279150270457/127.04098176289973
05-29 20:21:12.520+0900 I/HAP     ( 4869): lat: 37.279 lon: 127.041 num:19
05-29 20:21:12.840+0900 W/CRASH_MANAGER( 4896): worker.c: worker_job(1199) > 1104869686170146452087
