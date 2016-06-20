S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.5
Build-Number: R732XXU2CPC5
Build-Date: 2016.03.21 17:05:24

Crash Information
Process Name: hap
PID: 13653
Date: 2016-05-29 19:56:28+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x10

Register Information
r0   = 0x00000010, r1   = 0x00000010
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0x400054ba
r6   = 0xbecc8778, r7   = 0x00000010
r8   = 0x00000020, r9   = 0x41488a30
r10  = 0x4000549b, fp   = 0xbecc876c
ip   = 0x00000000, sp   = 0xbecc8208
lr   = 0x4041b5b8, pc   = 0x4044edc4
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     34900 KB
Buffers:     21584 KB
Cached:     120192 KB
VmPeak:      75904 KB
VmSize:      73444 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19052 KB
VmRSS:       19052 KB
VmData:      41048 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       28068 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 13653 TID = 13653
13653 13660 13661 13664 

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
417ef000 41920000 r-xp /usr/share/locale/locale-archive
41921000 41924000 rwxp [stack:13661]
41924000 41928000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
4192f000 41930000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41930000 41934000 rwxs /dev/mali
41935000 41937000 r-xp /usr/lib/libdri2.so.0.0.0
4193e000 4193f000 rwxp /usr/lib/libdri2.so.0.0.0
4193f000 41947000 r-xp /usr/lib/libdrm.so.2.4.0
4194e000 4194f000 rwxp /usr/lib/libdrm.so.2.4.0
4194f000 41956000 r-xp /usr/lib/libtbm.so.1.0.0
4195d000 4195e000 rwxp /usr/lib/libtbm.so.1.0.0
4195e000 41961000 r-xp /usr/lib/libnative-buffer.so.0.1.0
41968000 41969000 rwxp /usr/lib/libnative-buffer.so.0.1.0
41969000 41971000 rwxs /dev/mali
41971000 41979000 rwxs /dev/mali
41979000 4198d000 r-xs /opt/home/app/.cache/evas_gl_common_caches/ARM::OpenGL
4198d000 41991000 rwxs /dev/mali
41991000 41995000 rwxs /dev/mali
41995000 41a47000 rwxp [heap]
41a47000 41c47000 r-xp /usr/share/locale/locale-archive
41d47000 41dbe000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
41dc6000 41dc8000 rwxp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
41dce000 41f16000 r-xp /usr/lib/egl/libMali.so
41f16000 41f1b000 rwxp /usr/lib/egl/libMali.so
41f1c000 4271b000 rwxp [stack:13660]
4271b000 42723000 rwxs /dev/mali
42723000 4272b000 rwxs /dev/mali
4272b000 4272d000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
4272d000 428cc000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
428cc000 428e3000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
428eb000 428f0000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
428f0000 428f7000 r-xs /usr/lib/gconv/gconv-modules.cache
429f8000 429fa000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
42a01000 42a02000 rwxp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43b02000 43b42000 rwxs /dev/mali
43b56000 43b7a000 rwxs /dev/mali
43b7a000 43b7e000 rwxs /dev/mali
43b7e000 43ba2000 rwxs /dev/mali
43ba2000 43ba6000 rwxs /dev/mali
43ba6000 43bca000 rwxs /dev/mali
43bca000 43bce000 rwxs /dev/mali
43bf7000 43bfa000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
43bfa000 43bfe000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
43d00000 43d0f000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
43d0f000 43d9b000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
43d9b000 43e26000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
43e27000 44626000 rwxp [stack:13664]
44626000 446a8000 rwxs /dev/dri/card0
446a8000 447a8000 rwxs /dev/mali
beca9000 becca000 rwxp [stack]
End of Maps Information

Callstack Information (PID:13653)
Call Stack Count: 1
 0: strlen + 0x4 (0x4044edc4) [/lib/libc.so.6] + 0x72dc4
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

05-29 19:56:09.476+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 19:56:09.476+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-29 19:56:09.476+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 19:56:09.476+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 19:56:09.476+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 19:56:09.476+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 19:56:09.476+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-29 19:56:09.476+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-29 19:56:09.476+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 19:56:09.476+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-29 19:56:09.476+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-29 19:56:09.476+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-29 19:56:09.476+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 19:56:10.481+0900 E/PKGMGR_SERVER(13540): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
05-29 19:56:10.661+0900 E/PKGMGR_SERVER(13540): pkgmgr-server.c: sighandler(409) > child NORMAL exit [13541]
05-29 19:56:10.681+0900 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_log_package(4560) > package [_________] callback : [UPDATE, PROCESSING]
05-29 19:56:10.701+0900 W/W_HOME  (  718): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.example.hap is updated, need to check validation
05-29 19:56:10.701+0900 W/W_HOME  (  718): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:com.samsung.watchface
05-29 19:56:10.716+0900 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_log_package(4560) > package [_________] callback : [UPDATE, COMPLETED]
05-29 19:56:10.716+0900 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6943) > package install complete
05-29 19:56:10.716+0900 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_package_install_event(4815) > 
05-29 19:56:10.716+0900 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1762) > Found in install_req_list?[0], index[-1]
05-29 19:56:10.791+0900 E/STARTER (  695): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
05-29 19:56:10.846+0900 E/APPS    (  718): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
05-29 19:56:10.886+0900 E/PKGMGR_INFO(  493): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
05-29 19:56:12.486+0900 E/PKGMGR_SERVER(13540): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
05-29 19:56:12.486+0900 E/PKGMGR_SERVER(13540): pkgmgr-server.c: main(2185) > package manager server terminated.
05-29 19:56:14.316+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 19:56:14.321+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 19:56:16.921+0900 I/efl-extension(  718): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:56:16.921+0900 I/efl-extension(  718): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x46683838, elm_layout, time_stamp : 19882438
05-29 19:56:16.921+0900 W/APPS    (  718): AppsViewNecklace.cpp: onRotary(4702) >  __nTimeStamp:[0], __isFastMoving[0]
05-29 19:56:16.921+0900 W/APPS    (  718): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[23], __pAppsItemList.size[24]
05-29 19:56:16.921+0900 I/efl-extension( 2686): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:56:16.926+0900 I/efl-extension( 5514): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:56:16.926+0900 I/efl-extension(10647): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:56:17.196+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 19:56:17.216+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
05-29 19:56:17.226+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
05-29 19:56:17.226+0900 E/AUL_AMD (  496): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 19:56:17.226+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 13640
05-29 19:56:17.236+0900 W/AUL_AMD (  496): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 2594
05-29 19:56:17.241+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(2594), cmd(0)
05-29 19:56:17.241+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(429) > [APP 2594] Event: RESET State: PAUSED
05-29 19:56:17.241+0900 I/CAPI_APPFW_APPLICATION( 2594): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 19:56:17.256+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-29 19:56:17.261+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(481) > [APP 2594] App already running, raise the window
05-29 19:56:17.276+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04400002)
05-29 19:56:17.276+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(485) > [APP 2594] Call the resume_cb
05-29 19:56:17.276+0900 I/CAPI_APPFW_APPLICATION( 2594): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 19:56:17.276+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:56:17.276+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 19:56:17.461+0900 W/W_HOME  (  718): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-29 19:56:17.461+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 19:56:17.461+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 19:56:17.466+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 19:56:17.471+0900 W/W_HOME  (  718): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-29 19:56:17.476+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 19:56:17.476+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 19:56:17.501+0900 I/MALI    (  718): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-29 19:56:17.536+0900 W/W_HOME  (  718): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-29 19:56:17.536+0900 W/W_HOME  (  718): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-29 19:56:17.536+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 19:56:17.541+0900 W/W_HOME  (  718): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-29 19:56:17.546+0900 I/APP_CORE(  718): appcore-efl.c: __do_app(429) > [APP 718] Event: PAUSE State: RUNNING
05-29 19:56:17.546+0900 I/CAPI_APPFW_APPLICATION(  718): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 19:56:17.546+0900 W/W_HOME  (  718): main.c: _appcore_pause_cb(690) > appcore pause
05-29 19:56:17.546+0900 W/W_HOME  (  718): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-29 19:56:17.546+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 19:56:17.546+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 19:56:17.551+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 19:56:17.551+0900 W/W_HOME  (  718): rotary.c: rotary_deattach(156) > rotary_deattach:0x46683838
05-29 19:56:17.551+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 19:56:17.551+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46683838, elm_layout, func : 0x4004b469
05-29 19:56:17.551+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-29 19:56:17.551+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-29 19:56:17.551+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 19:56:17.556+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96248, elm_box, _activated_obj : 0x46683838, activated : 1
05-29 19:56:17.556+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 19:56:17.556+0900 E/wnotib  (  718): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 19:56:17.556+0900 I/wnotib  (  718): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-29 19:56:17.571+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 19:56:17.571+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 19:56:17.571+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 19:56:17.571+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-29 19:56:17.571+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-29 19:56:17.571+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 19:56:17.571+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-29 19:56:17.571+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 19:56:17.576+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 19:56:17.576+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 19:56:17.581+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 19:56:17.581+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-29 19:56:17.581+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-29 19:56:17.581+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 19:56:17.581+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-29 19:56:17.581+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-29 19:56:17.581+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-29 19:56:17.581+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 19:56:17.581+0900 E/CAPI_APPFW_APP_CONTROL( 1053): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-29 19:56:17.581+0900 W/MUSIC_CONTROL_SERVICE( 1053): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1053]   [com.samsung.w-home]register msg port [false][0m
05-29 19:56:17.586+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 19:56:17.586+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 19:56:17.591+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(429) > [APP 2594] Event: RESUME State: RUNNING
05-29 19:56:17.641+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 19:56:17.656+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 19:56:17.671+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 19:56:17.671+0900 E/AUL_AMD (  496): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 19:56:17.671+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 697
05-29 19:56:17.681+0900 E/RESOURCED(  497): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-29 19:56:17.681+0900 E/RESOURCED(  497): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 19:56:17.686+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(2080) > pad pid(-5)
05-29 19:56:17.686+0900 W/AUL_PAD ( 1161): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-29 19:56:17.686+0900 W/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(272) > Check app launching
05-29 19:56:17.691+0900 E/AUL_PAD (13543): launchpad_loader.c: __candidate_process_prepare_exec(259) > fail to set privileges - check your package's credential : -1
05-29 19:56:17.691+0900 E/AUL_PAD (13543): launchpad_loader.c: __candidate_process_launchpad_main_loop(402) > __candidate_process_prepare_exec() failed
05-29 19:56:17.716+0900 I/wnotib  (  718): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-29 19:56:17.716+0900 E/wnotib  (  718): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 19:56:17.731+0900 W/APPS    (  718): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-29 19:56:17.766+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:17.766+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:17.866+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:17.866+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:17.966+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:17.966+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:18.066+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:18.066+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:18.086+0900 I/APP_CORE(  718): appcore-efl.c: __do_app(429) > [APP 718] Event: MEM_FLUSH State: PAUSED
05-29 19:56:18.166+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:18.166+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:18.266+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:18.266+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:18.371+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:18.371+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:18.471+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:18.471+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:18.571+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:18.571+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:18.671+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:18.671+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:18.771+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:18.771+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:18.871+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:18.871+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:18.971+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:18.971+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:19.071+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:19.071+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:19.171+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:19.171+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:19.271+0900 E/EFL     ( 2594): evas_main<2594> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=19884788 button=1 downs=1
05-29 19:56:19.271+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:19.271+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:19.306+0900 E/EFL     ( 2594): evas_main<2594> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=19884826 button=1 downs=0
05-29 19:56:19.371+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:19.371+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:19.496+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:19.496+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:19.601+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:19.601+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:19.601+0900 E/RESOURCED(  497): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 19:56:19.711+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:19.711+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:19.726+0900 E/RESOURCED(  497): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 19:56:19.821+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:19.821+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:19.926+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:19.926+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:20.031+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:20.036+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:20.041+0900 E/RESOURCED(  497): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 19:56:20.141+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:20.141+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:20.246+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:20.246+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:20.366+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:20.371+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:20.476+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:20.476+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:20.581+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:20.586+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:20.686+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:20.691+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:20.791+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:20.791+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:20.906+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:20.906+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:21.016+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:21.016+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:21.121+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:21.121+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:21.226+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:21.226+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:21.326+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:21.331+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:21.436+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:21.436+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:21.541+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:21.541+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:21.646+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:21.646+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:21.751+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:21.751+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:21.866+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:21.866+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:21.971+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:21.971+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:22.076+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:22.076+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:22.086+0900 E/RESOURCED(  497): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 19:56:22.181+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:22.181+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:22.286+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:22.286+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:22.391+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:22.391+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:22.396+0900 E/RESOURCED(  497): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 19:56:22.501+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:22.501+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:22.601+0900 I/APP_CORE(  718): appcore-efl.c: __do_app(429) > [APP 718] Event: MEM_FLUSH State: PAUSED
05-29 19:56:22.606+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:22.606+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:22.606+0900 E/RESOURCED(  497): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 19:56:22.706+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:22.711+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:22.816+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:22.816+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:56:22.841+0900 E/AUL     (  697): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
05-29 19:56:22.886+0900 E/AUL     (  496): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
05-29 19:56:22.886+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(2098) > Launch with legacy way : Timeout
05-29 19:56:22.891+0900 W/AUL_AMD (  496): amd_launch.c: start_process(580) > child process: 13653
05-29 19:56:22.916+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(312) > process launched, but cmdline not changed
05-29 19:56:22.916+0900 E/AUL_PAD ( 1161): launchpad.c: __real_send(253) > send failed due to EPIPE.
05-29 19:56:22.916+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(317) > send SIGKILL: No such process
05-29 19:56:22.996+0900 W/AUL_AMD (  496): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 13653
05-29 19:56:23.001+0900 E/AUL_AMD (  496): amd_launch.c: __real_send(824) > send failed due to EPIPE.
05-29 19:56:23.001+0900 E/AUL_AMD (  496): amd_launch.c: __real_send(826) > send fail to client
05-29 19:56:23.036+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 19:56:23.036+0900 I/AUL_AMD (  496): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 13543
05-29 19:56:23.051+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 19:56:23.091+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:56:23.101+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13653
05-29 19:56:23.101+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 19:56:23.136+0900 I/efl-extension(13653): efl_extension.c: eext_mod_init(40) > Init
05-29 19:56:23.156+0900 I/CAPI_APPFW_APPLICATION(13653): app_main.c: ui_app_main(704) > app_efl_main
05-29 19:56:23.391+0900 I/CAPI_APPFW_APPLICATION(13653): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-29 19:56:23.496+0900 E/TBM     (13653): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 19:56:23.656+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04600003)
05-29 19:56:23.676+0900 E/EFL     (13653): ecore_evas<13653> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-29 19:56:23.741+0900 I/efl-extension(13653): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0x429e79b0]'s widget[0x4293d3a8] to elm_conformant widget[0x41cfd398]
05-29 19:56:23.836+0900 I/HAP     (13653): SUCCESSFULLY create sap agent
05-29 19:56:23.836+0900 I/HAP     (13653): connectivity type(1): bt
05-29 19:56:23.981+0900 E/RESOURCED( 1094): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:56:23.981+0900 E/AUL     ( 1094): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-29 19:56:23.981+0900 E/CAPI_APPFW_APP_MANAGER( 1094): app_manager.c: app_manager_error(78) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
05-29 19:56:24.001+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:56:24.001+0900 W/AUL_AMD (  496): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-29 19:56:24.041+0900 I/HAP     (13653): agent is initialized
05-29 19:56:24.041+0900 I/HAP     (13653): agent initialized callback is over
05-29 19:56:24.041+0900 I/HAP     (13653): SAP >>> getRegisteredServiceAgent() >>> 0
05-29 19:56:24.126+0900 I/APP_CORE(13653): appcore-efl.c: __do_app(429) > [APP 13653] Event: RESET State: CREATED
05-29 19:56:24.126+0900 I/CAPI_APPFW_APPLICATION(13653): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 19:56:24.156+0900 I/APP_CORE(13653): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 19:56:24.156+0900 I/APP_CORE(13653): appcore-efl.c: __do_app(474) > [APP 13653] Initial Launching, call the resume_cb
05-29 19:56:24.156+0900 I/CAPI_APPFW_APPLICATION(13653): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 19:56:24.166+0900 W/APP_CORE(13653): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4600003
05-29 19:56:24.171+0900 I/efl-extension(13653): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x429e79b0 = w: 0 h: 0  obj 0x4293d3a8 w: 360 h: 360
05-29 19:56:24.181+0900 I/efl-extension(13653): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 19:56:24.256+0900 I/APP_CORE(13653): appcore-efl.c: __do_app(429) > [APP 13653] Event: RESUME State: RUNNING
05-29 19:56:24.261+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(429) > [APP 2594] Event: PAUSE State: RUNNING
05-29 19:56:24.261+0900 I/CAPI_APPFW_APPLICATION( 2594): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 19:56:24.271+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:56:24.271+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 19:56:24.336+0900 I/AUL_PAD (13665): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 19:56:24.661+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 19:56:24.701+0900 I/MALI    (13653): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x41a3f308] swap changed from async to sync
05-29 19:56:25.851+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 19:56:25.946+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 19:56:26.001+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 19:56:26.001+0900 E/AUL_AMD (  496): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 19:56:26.006+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 697
05-29 19:56:26.036+0900 W/AUL_AMD (  496): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 13653
05-29 19:56:26.046+0900 I/APP_CORE(13653): appcore-efl.c: __do_app(429) > [APP 13653] Event: RESET State: RUNNING
05-29 19:56:26.046+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(13653), cmd(0)
05-29 19:56:26.056+0900 I/CAPI_APPFW_APPLICATION(13653): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 19:56:26.056+0900 I/APP_CORE(13653): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-29 19:56:26.056+0900 I/APP_CORE(13653): appcore-efl.c: __do_app(481) > [APP 13653] App already running, raise the window
05-29 19:56:26.081+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 19:56:26.101+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04600003)
05-29 19:56:26.681+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 19:56:26.681+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 19:56:26.681+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(2068650896)
05-29 19:56:26.681+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 19:56:26.681+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 19:56:26.681+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 19:56:26.681+0900 E/ALARM_MANAGER(  492): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[2068650896] is removed.
05-29 19:56:26.691+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 19:56:26.691+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 19:56:26.701+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:56:26.711+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:56:26.721+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:56:26.731+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:56:26.731+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-29 19:56:26.731+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-29 19:56:26.741+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:56:26.756+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:56:26.756+0900 E/ALARM_MANAGER(  492): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464519390, Sun May 29 19:56:30 2016
05-29 19:56:26.756+0900 E/ALARM_MANAGER(  492): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 238445819, next duetime: 1464519390
05-29 19:56:26.756+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(238445819)
05-29 19:56:26.756+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464519390)
05-29 19:56:26.756+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 19:56:26.756+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 10:56:30 (UTC).
05-29 19:56:26.756+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 19:56:26.761+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 19:56:26.761+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 19:56:26.761+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(238445819)
05-29 19:56:26.761+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 19:56:26.761+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 19:56:26.761+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 19:56:26.761+0900 E/ALARM_MANAGER(  492): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[238445819] is removed.
05-29 19:56:26.771+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 19:56:26.771+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 19:56:26.781+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:56:26.791+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:56:26.801+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:56:26.811+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:56:26.811+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-29 19:56:26.811+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-29 19:56:26.821+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:56:26.831+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 19:56:26.831+0900 E/ALARM_MANAGER(  492): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464562586, Mon May 30 07:56:26 2016
05-29 19:56:26.831+0900 E/ALARM_MANAGER(  492): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 238445819, next duetime: 1464562586
05-29 19:56:26.831+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(238445819)
05-29 19:56:26.831+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464562586)
05-29 19:56:26.831+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 19:56:26.831+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 19:56:26.831+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 19:56:27.046+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:56:27.046+0900 W/AUL_AMD (  496): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-29 19:56:28.196+0900 I/HAP     (13653): routes length: 21
05-29 19:56:28.196+0900 I/HAP     (13653): description: 장다리로 을 따라 162m 이동, lat: 37.27655039833677,lon: 127.03127993829892
05-29 19:56:28.206+0900 I/HAP     (13653): description: 우측 횡단보도 후 보행자도로 을 따라 26m 이동 , lat: 37.27795302297102,lon: 127.03180485142347
05-29 19:56:28.216+0900 I/HAP     (13653): description: 직진 후 중부대로 을 따라 68m 이동 , lat: 37.27791969851095,lon: 127.03208538245273
05-29 19:56:28.221+0900 I/HAP     (13653): description: 횡단보도 후 보행자도로 을 따라 8m 이동 , lat: 37.277830832970096,lon: 127.03281587420162
05-29 19:56:28.221+0900 I/HAP     (13653): description: 직진 후 중부대로 을 따라 163m 이동 , lat: 37.27781416982219,lon: 127.03290475549065
05-29 19:56:28.221+0900 I/HAP     (13653): description: 횡단보도 후 보행자도로 을 따라 9m 이동 , lat: 37.27737536309203,lon: 127.03465738649457
05-29 19:56:28.221+0900 I/HAP     (13653): description: 직진 후 중부대로 을 따라 251m 이동 , lat: 37.27734481291254,lon: 127.03476015580091
05-29 19:56:28.221+0900 I/HAP     (13653): description: 좌측 횡단보도 후 5m 이동 , lat: 37.27659494818776,lon: 127.03746826436145
05-29 19:56:28.221+0900 I/HAP     (13653): description: 좌측 횡단보도 후 보행자도로 을 따라 27m 이동 , lat: 37.276619946035844,lon: 127.03750992654794
05-29 19:56:28.221+0900 I/HAP     (13653): description: 우회전 후 권광로 을 따라 7m 이동 , lat: 37.27685047671701,lon: 127.03761268854973
05-29 19:56:28.221+0900 I/HAP     (13653): description: 횡단보도 후 9m 이동 , lat: 37.27689213964827,lon: 127.03767379295
05-29 19:56:28.221+0900 I/HAP     (13653): description: 직진 후 15m 이동 , lat: 37.27686436667676,lon: 127.03776267455035
05-29 19:56:28.221+0900 I/HAP     (13653): description: 횡단보도 후 7m 이동 , lat: 37.27681437539752,lon: 127.03792654996703
05-29 19:56:28.221+0900 I/HAP     (13653): description: 좌측 횡단보도 후 보행자도로 을 따라 10m 이동 , lat: 37.27678660202898,lon: 127.03799321136158
05-29 19:56:28.221+0900 I/HAP     (13653): description: 좌회전 후 53m 이동 , lat: 37.27683937533004,lon: 127.038084868234
05-29 19:56:28.221+0900 I/HAP     (13653): description: 우회전 후 권광로 을 따라 6m 이동 , lat: 37.27730598956949,lon: 127.03817651352684
05-29 19:56:28.221+0900 I/HAP     (13653): description: 좌회전 후 권광로340번길 을 따라 93m 이동 , lat: 37.27733098801315,lon: 127.03825150602198
05-29 19:56:28.221+0900 I/HAP     (13653): description: 10시 방향 좌회전 후 권광로348번길 을 따라 79m 이동 , lat: 37.27763096998274,lon: 127.03918752379786
05-29 19:56:28.221+0900 I/HAP     (13653): description: UBF수원 에서 좌회전 후 중부대로223번길 을 따라 14m 이동 , lat: 37.27902250807859,lon: 127.04101509678411
05-29 19:56:28.221+0900 I/HAP     (13653): description: 도착, lat: 37.279150270457,lon: 127.04098176289973
05-29 19:56:28.596+0900 W/CRASH_MANAGER(13683): worker.c: worker_job(1199) > 1113653686170146451938
