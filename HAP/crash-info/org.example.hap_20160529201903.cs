S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.5
Build-Number: R732XXU2CPC5
Build-Date: 2016.03.21 17:05:24

Crash Information
Process Name: hap
PID: 4459
Date: 2016-05-29 20:19:03+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x41b88504, r1   = 0xffffffff
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x4000daa4, r5   = 0xbeaacd30
r6   = 0x41cb7c00, r7   = 0xbeaacd08
r8   = 0x43c61000, r9   = 0x40359861
r10  = 0x405014b8, fp   = 0x00000000
ip   = 0x41488a20, sp   = 0xbeaacaf8
lr   = 0x40413070, pc   = 0x40413090
cpsr = 0x40000010

Memory Information
MemTotal:   491012 KB
MemFree:     14644 KB
Buffers:     17036 KB
Cached:     162464 KB
VmPeak:      76920 KB
VmSize:      74460 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19032 KB
VmRSS:       19032 KB
VmData:      42064 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       28068 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 4459 TID = 4459
4459 4467 4468 4472 

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
41877000 4187a000 rwxp [stack:4468]
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
418c7000 418cf000 rwxs /dev/mali
418cf000 418d3000 rwxs /dev/mali
418d3000 418d7000 rwxs /dev/mali
418d7000 41988000 rwxp [heap]
41988000 41b88000 r-xp /usr/share/locale/locale-archive
41b88000 41cb9000 r-xp /usr/share/locale/locale-archive
41db9000 41f01000 r-xp /usr/lib/egl/libMali.so
41f01000 41f06000 rwxp /usr/lib/egl/libMali.so
41f07000 42706000 rwxp [stack:4467]
42706000 4271a000 r-xs /opt/home/app/.cache/evas_gl_common_caches/ARM::OpenGL
4271a000 42722000 rwxs /dev/mali
42722000 4272a000 rwxs /dev/mali
4272a000 4272c000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
4272c000 428cb000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
428cb000 428e2000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
428ea000 428ef000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
428ef000 428f6000 r-xs /usr/lib/gconv/gconv-modules.cache
429f7000 429f9000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
42a00000 42a01000 rwxp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43b01000 43b04000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
43b04000 43b08000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
43b08000 43b17000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
43b17000 43ba3000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
43ba3000 43be3000 rwxs /dev/mali
43bf7000 43bfb000 rwxs /dev/mali
43bfb000 43bff000 rwxs /dev/mali
43d00000 43d8b000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
43d8c000 4468b000 rwxp [stack:4472]
4468b000 4470d000 rwxs /dev/dri/card0
4470d000 4480d000 rwxs /dev/mali
4480d000 44831000 rwxs /dev/mali
44831000 44855000 rwxs /dev/mali
44855000 44879000 rwxs /dev/mali
44879000 4487d000 rwxs /dev/mali
bea8d000 beaae000 rwxp [stack]
End of Maps Information

Callstack Information (PID:4459)
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
n(2185) > package manager server terminated.
05-29 20:18:31.995+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_handler_idle(1360) > Lock the display not to enter LCD OFF
05-29 20:18:32.035+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __display_lock_state(1692) > Lock LCD OFF is successfully done
05-29 20:18:32.095+0900 E/RESOURCED(  498): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 870
05-29 20:18:32.140+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_expired(1322) > alarm_id[829832006] is expired.
05-29 20:18:32.140+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(829832006)
05-29 20:18:32.140+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:18:32.145+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 20:18:32.145+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:18:32.145+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_handler_idle(1386) > Unlock the display from LCD OFF
05-29 20:18:32.165+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __display_unlock_state(1735) > Unlock LCD OFF is successfully done
05-29 20:18:32.165+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:18:32.170+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:18:32.200+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:18:32.220+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:18:32.230+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:18:32.245+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:18:32.245+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-29 20:18:32.250+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-29 20:18:32.265+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:18:32.275+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:18:32.280+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464520713, Sun May 29 20:18:33 2016
05-29 20:18:32.280+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 686436327, next duetime: 1464520713
05-29 20:18:32.280+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(686436327)
05-29 20:18:32.280+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464520713)
05-29 20:18:32.280+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:18:32.280+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 11:18:33 (UTC).
05-29 20:18:32.280+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:18:32.995+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_handler_idle(1360) > Lock the display not to enter LCD OFF
05-29 20:18:33.025+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __display_lock_state(1692) > Lock LCD OFF is successfully done
05-29 20:18:33.075+0900 E/RESOURCED(  498): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 870
05-29 20:18:33.080+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_expired(1322) > alarm_id[686436327] is expired.
05-29 20:18:33.080+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(686436327)
05-29 20:18:33.080+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:18:33.080+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 20:18:33.080+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:18:33.080+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_handler_idle(1386) > Unlock the display from LCD OFF
05-29 20:18:33.090+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __display_unlock_state(1735) > Unlock LCD OFF is successfully done
05-29 20:18:33.180+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:18:33.180+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:18:33.245+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:18:33.290+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:18:33.325+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:18:33.345+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:18:33.345+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-29 20:18:33.345+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-29 20:18:33.370+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:18:33.385+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:18:33.385+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464563913, Mon May 30 08:18:33 2016
05-29 20:18:33.385+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 385966732, next duetime: 1464563913
05-29 20:18:33.385+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(385966732)
05-29 20:18:33.385+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464563913)
05-29 20:18:33.385+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:18:33.385+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 20:18:33.385+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:18:33.775+0900 I/RESOURCED(  498): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 25 -> 24 1464520713 241
05-29 20:18:33.775+0900 I/RESOURCED(  498): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 24 621 293 248
05-29 20:18:33.775+0900 I/RESOURCED(  498): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 24 0 0 971
05-29 20:18:33.775+0900 I/RESOURCED(  498): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 24 1349 264 540
05-29 20:18:33.775+0900 I/RESOURCED(  498): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 24 132 5 53
05-29 20:18:33.775+0900 I/RESOURCED(  498): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 24 393 28 157
05-29 20:18:33.780+0900 I/watchface-viewer(  749): viewer-data-provider.cpp: AddPendingChanges(1088) > added [37] to pending list
05-29 20:18:33.780+0900 I/watchface-viewer(  749): viewer-data-provider.cpp: AddPendingChanges(1088) > added [39] to pending list
05-29 20:18:40.295+0900 E/PKGMGR  ( 4361): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
05-29 20:18:40.445+0900 E/PKGMGR_SERVER( 4363): pkgmgr-server.c: main(2131) > package manager server start
05-29 20:18:40.530+0900 E/PKGMGR_SERVER( 4363): pkgmgr-server.c: req_cb(650) > req_id=[org.example.hap_1296890800], req_type=[1], pkg_type=[rpm], pkgid=[org.example.hap], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.hap_1296890800' '-r' 'org.example.hap'], cookie=[h1Wno7FchCcOdSBwb1G7r+KX9+E=], backend_flag=[0]
05-29 20:18:40.530+0900 E/PKGMGR  ( 4363): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.hap]
05-29 20:18:40.530+0900 E/PKGMGR_SERVER( 4363): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.hap 
05-29 20:18:40.535+0900 E/PKGMGR_SERVER( 4364): pkgmgr-server.c: queue_job(1815) > INSTALL start, pkg path=[org.example.hap]
05-29 20:18:40.540+0900 E/PKGMGR  ( 4361): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[43610002]
05-29 20:18:40.720+0900 W/W_HOME  (  725): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.hap is being updateded:0
05-29 20:18:40.725+0900 E/WMS     (  492): wms_event_handler.c: _wms_event_handler_cb_log_package(4560) > package [_________] callback : [UPDATE, STARTED]
05-29 20:18:40.730+0900 W/AUL_AMD (  495): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
05-29 20:18:40.750+0900 E/WMS     (  492): wms_event_handler.c: _wms_event_handler_cb_log_package(4560) > package [_________] callback : [UPDATE, PROCESSING]
05-29 20:18:40.885+0900 W/CERT_SVC( 4364): DUID.cpp: CheckCertifiedDevice(675) > No device id on distributor certificate
05-29 20:18:40.965+0900 E/PKGMGR_CERT( 4364): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
05-29 20:18:40.975+0900 E/PKGMGR_CERT( 4364): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 94
05-29 20:18:40.975+0900 E/WMS     (  492): wms_event_handler.c: _wms_event_handler_cb_log_package(4560) > package [_________] callback : [UPDATE, PROCESSING]
05-29 20:18:40.975+0900 E/PKGMGR_CERT( 4364): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 94
05-29 20:18:40.975+0900 E/PKGMGR_CERT( 4364): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 18 2
05-29 20:18:40.980+0900 E/PKGMGR_CERT( 4364): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 19 2
05-29 20:18:40.980+0900 E/PKGMGR_CERT( 4364): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 20 2
05-29 20:18:40.980+0900 E/PKGMGR_CERT( 4364): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 1
05-29 20:18:41.000+0900 E/PKGMGR_CERT( 4364): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
05-29 20:18:41.150+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 4037
05-29 20:18:41.205+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3925
05-29 20:18:41.405+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3927
05-29 20:18:41.685+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 4367
05-29 20:18:41.885+0900 I/AUL_PAD ( 4365): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 20:18:42.365+0900 E/PKGMGR_SERVER( 4363): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
05-29 20:18:42.825+0900 I/efl-extension( 4366): efl_extension.c: eext_mod_init(40) > Init
05-29 20:18:42.915+0900 W/MM_CAMCORDER( 4368): mm_camcorder_internal.c: _mmcamcorder_constructor(204) >  start
05-29 20:18:42.915+0900 W/MM_CAMCORDER( 4368): mm_camcorder_internal.c: _mmcamcorder_constructor(214) >  done
05-29 20:18:42.925+0900 I/efl-extension( 4368): efl_extension.c: eext_mod_init(40) > Init
05-29 20:18:42.940+0900 E/rpm-installer( 4364): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
05-29 20:18:43.035+0900 I/UXT     ( 4366): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-29 20:18:43.665+0900 I/AUL_PAD ( 4366): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 20:18:43.830+0900 I/AUL     ( 4368): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-29 20:18:43.835+0900 E/TBM     ( 4366): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 20:18:43.850+0900 I/AUL     ( 4368): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-29 20:18:43.850+0900 E/AUL     ( 4368): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-29 20:18:43.850+0900 E/AUL     ( 4368): aul_path.c: __get_path(169) > root_path is NULL!
05-29 20:18:43.870+0900 I/AUL     ( 4368): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-29 20:18:43.885+0900 I/AUL     ( 4368): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-29 20:18:43.885+0900 E/AUL     ( 4368): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-29 20:18:43.885+0900 E/AUL     ( 4368): aul_path.c: __get_path(169) > root_path is NULL!
05-29 20:18:43.915+0900 I/UXT     ( 4368): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-29 20:18:44.155+0900 E/TBM     ( 4368): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 20:18:44.365+0900 E/PKGMGR_SERVER( 4363): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
05-29 20:18:46.365+0900 E/PKGMGR_SERVER( 4363): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
05-29 20:18:46.590+0900 E/PKGMGR_SERVER( 4363): pkgmgr-server.c: sighandler(409) > child NORMAL exit [4364]
05-29 20:18:46.600+0900 E/WMS     (  492): wms_event_handler.c: _wms_event_handler_cb_log_package(4560) > package [_________] callback : [UPDATE, PROCESSING]
05-29 20:18:46.620+0900 W/W_HOME  (  725): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.example.hap is updated, need to check validation
05-29 20:18:46.620+0900 W/W_HOME  (  725): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:com.samsung.watchface
05-29 20:18:46.650+0900 E/WMS     (  492): wms_event_handler.c: _wms_event_handler_cb_log_package(4560) > package [_________] callback : [UPDATE, COMPLETED]
05-29 20:18:46.650+0900 E/WMS     (  492): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6943) > package install complete
05-29 20:18:46.650+0900 E/WMS     (  492): wms_event_handler.c: _wms_event_handler_package_install_event(4815) > 
05-29 20:18:46.650+0900 E/WMS     (  492): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1762) > Found in install_req_list?[0], index[-1]
05-29 20:18:46.710+0900 E/STARTER (  692): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
05-29 20:18:46.725+0900 E/APPS    (  725): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
05-29 20:18:46.820+0900 E/PKGMGR_INFO(  488): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
05-29 20:18:48.365+0900 E/PKGMGR_SERVER( 4363): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
05-29 20:18:48.365+0900 E/PKGMGR_SERVER( 4363): pkgmgr-server.c: main(2185) > package manager server terminated.
05-29 20:18:50.275+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 20:18:50.275+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 20:18:54.880+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 20:18:54.935+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
05-29 20:18:54.965+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
05-29 20:18:54.965+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 20:18:54.965+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1702) > caller pid : 4451
05-29 20:18:54.990+0900 W/AUL_AMD (  495): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 1921
05-29 20:18:54.990+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(916) > listen fd(20) , send fd(13), pid(1921), cmd(0)
05-29 20:18:55.000+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: RESET State: PAUSED
05-29 20:18:55.000+0900 I/CAPI_APPFW_APPLICATION( 1921): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 20:18:55.030+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-29 20:18:55.035+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(481) > [APP 1921] App already running, raise the window
05-29 20:18:55.055+0900 E/E17     (  379): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04400002)
05-29 20:18:55.055+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(485) > [APP 1921] Call the resume_cb
05-29 20:18:55.055+0900 I/CAPI_APPFW_APPLICATION( 1921): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 20:18:55.060+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:18:55.060+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 20:18:55.195+0900 W/W_HOME  (  725): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-29 20:18:55.195+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:18:55.195+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:18:55.195+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:18:55.195+0900 W/W_HOME  (  725): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-29 20:18:55.265+0900 W/W_HOME  (  725): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-29 20:18:55.265+0900 W/W_HOME  (  725): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-29 20:18:55.265+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:18:55.265+0900 W/W_HOME  (  725): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-29 20:18:55.265+0900 I/APP_CORE(  725): appcore-efl.c: __do_app(429) > [APP 725] Event: PAUSE State: PAUSED
05-29 20:18:55.270+0900 I/APP_CORE(  725): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
05-29 20:18:55.270+0900 I/wnotib  (  725): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-29 20:18:55.270+0900 E/wnotib  (  725): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 20:18:55.290+0900 I/APP_CORE( 1921): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
05-29 20:18:55.320+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 20:18:55.330+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 20:18:55.345+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 20:18:55.345+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 20:18:55.345+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1702) > caller pid : 700
05-29 20:18:55.360+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-29 20:18:55.360+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 20:18:55.360+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2080) > pad pid(-5)
05-29 20:18:55.365+0900 W/AUL_PAD ( 1191): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-29 20:18:55.365+0900 W/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(272) > Check app launching
05-29 20:18:55.370+0900 E/AUL_PAD ( 4365): launchpad_loader.c: __candidate_process_prepare_exec(259) > fail to set privileges - check your package's credential : -1
05-29 20:18:55.370+0900 E/AUL_PAD ( 4365): launchpad_loader.c: __candidate_process_launchpad_main_loop(402) > __candidate_process_prepare_exec() failed
05-29 20:18:55.440+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:55.440+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:55.540+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:55.540+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:55.640+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:55.640+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:55.740+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:55.740+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:55.840+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:55.840+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:55.945+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:55.945+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:56.045+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:56.045+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:56.145+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:56.145+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:56.245+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:56.245+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:56.345+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:56.345+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:56.445+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:56.445+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:56.545+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:56.545+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:56.645+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:56.645+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:56.745+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:56.745+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:56.845+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:56.845+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:56.950+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:56.950+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:57.055+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:57.055+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:57.165+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:57.165+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:57.270+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:57.270+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:57.375+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:57.375+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:57.480+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:57.485+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:57.590+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:57.590+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:57.695+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:57.695+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:57.805+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:57.805+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:57.910+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:57.910+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:58.015+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:58.015+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:58.120+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:58.120+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:58.225+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:58.225+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:58.330+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:58.330+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:58.435+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:58.435+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:58.545+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:58.545+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:58.645+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:58.650+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:58.755+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:58.760+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:58.865+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:58.865+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:58.970+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:58.970+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:59.075+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:59.075+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:59.180+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:59.185+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:59.290+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:59.290+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:59.395+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:59.395+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:59.505+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:59.505+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:59.610+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:59.610+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:59.715+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:59.715+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:59.825+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:59.825+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:18:59.930+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:18:59.930+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:19:00.035+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:19:00.040+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:19:00.145+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:19:00.145+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:19:00.250+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:19:00.250+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:19:00.355+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:19:00.355+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:19:00.460+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:19:00.465+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:19:00.565+0900 E/AUL     (  495): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
05-29 20:19:00.565+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2098) > Launch with legacy way : Timeout
05-29 20:19:00.575+0900 E/AUL     (  700): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
05-29 20:19:00.580+0900 W/AUL_AMD (  495): amd_launch.c: start_process(580) > child process: 4459
05-29 20:19:00.590+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(312) > process launched, but cmdline not changed
05-29 20:19:00.590+0900 E/AUL_PAD ( 1191): launchpad.c: __real_send(253) > send failed due to EPIPE.
05-29 20:19:00.590+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(317) > send SIGKILL: No such process
05-29 20:19:00.685+0900 W/WATCH_CORE(  749): appcore-watch.c: __widget_resume(1012) > widget_resume
05-29 20:19:00.695+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppResume(721) > 
05-29 20:19:00.695+0900 I/watchface-viewer(  749): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [37]
05-29 20:19:00.695+0900 I/watchface-viewer(  749): viewer-part-resource.cpp: SetUpdateImage(1981) > new mThread[0x476cd698]
05-29 20:19:00.695+0900 I/watchface-viewer(  749): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [39]
05-29 20:19:00.695+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:19:00.695+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:19:00.720+0900 I/watchface-viewer(  749): viewer-part-resource.cpp: ThreadCallback(2108) > thread[0x476cd698]
05-29 20:19:00.740+0900 I/watchface-viewer(  749): viewer-part-resource.cpp: ThreadNotifyCallback(2170) > thread[0x476cd698]
05-29 20:19:00.740+0900 I/watchface-viewer(  749): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
05-29 20:19:00.745+0900 E/AUL_AMD (  495): amd_launch.c: __check_cmdline(520) > error founded when being launched with 4459
05-29 20:19:00.745+0900 I/watchface-viewer(  749): viewer-part-resource.cpp: ThreadEndCallback(2206) > thread[0x476cd698]
05-29 20:19:00.795+0900 W/AUL_AMD (  495): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 4459
05-29 20:19:00.860+0900 E/AUL_AMD (  495): amd_launch.c: __real_send(824) > send failed due to EPIPE.
05-29 20:19:00.860+0900 E/AUL_AMD (  495): amd_launch.c: __real_send(826) > send fail to client
05-29 20:19:00.890+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:19:00.900+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4459
05-29 20:19:00.900+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:19:00.905+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 4365
05-29 20:19:00.905+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 20:19:00.905+0900 I/efl-extension( 4459): efl_extension.c: eext_mod_init(40) > Init
05-29 20:19:00.910+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:19:00.925+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:19:00.925+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:19:00.935+0900 I/CAPI_APPFW_APPLICATION( 4459): app_main.c: ui_app_main(704) > app_efl_main
05-29 20:19:01.100+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:19:01.100+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:19:01.190+0900 I/CAPI_APPFW_APPLICATION( 4459): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-29 20:19:01.270+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:19:01.275+0900 E/TBM     ( 4459): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 20:19:01.280+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4459
05-29 20:19:01.280+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:19:01.280+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:19:01.455+0900 E/E17     (  379): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04600003)
05-29 20:19:01.465+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:19:01.465+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:19:01.480+0900 E/EFL     ( 4459): ecore_evas<4459> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-29 20:19:01.540+0900 I/efl-extension( 4459): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0x42959e98]'s widget[0x4293c510] to elm_conformant widget[0x41d6f798]
05-29 20:19:01.615+0900 E/RESOURCED( 1097): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:19:01.615+0900 E/AUL     ( 1097): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-29 20:19:01.615+0900 E/CAPI_APPFW_APP_MANAGER( 1097): app_manager.c: app_manager_error(78) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
05-29 20:19:01.650+0900 I/HAP     ( 4459): SUCCESSFULLY create sap agent
05-29 20:19:01.650+0900 I/HAP     ( 4459): connectivity type(1): bt
05-29 20:19:01.655+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:19:01.655+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:19:01.845+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:19:01.845+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:19:01.850+0900 I/HAP     ( 4459): agent is initialized
05-29 20:19:01.850+0900 I/HAP     ( 4459): agent initialized callback is over
05-29 20:19:01.850+0900 I/HAP     ( 4459): SAP >>> getRegisteredServiceAgent() >>> 0
05-29 20:19:01.860+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:19:01.860+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-29 20:19:01.930+0900 I/APP_CORE( 4459): appcore-efl.c: __do_app(429) > [APP 4459] Event: RESET State: CREATED
05-29 20:19:01.935+0900 I/CAPI_APPFW_APPLICATION( 4459): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 20:19:01.965+0900 I/APP_CORE( 4459): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 20:19:01.965+0900 I/APP_CORE( 4459): appcore-efl.c: __do_app(474) > [APP 4459] Initial Launching, call the resume_cb
05-29 20:19:01.965+0900 I/CAPI_APPFW_APPLICATION( 4459): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 20:19:01.975+0900 W/APP_CORE( 4459): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4600003
05-29 20:19:01.980+0900 I/efl-extension( 4459): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x42959e98 = w: 0 h: 0  obj 0x4293c510 w: 360 h: 360
05-29 20:19:01.990+0900 I/efl-extension( 4459): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 20:19:02.040+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:19:02.040+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:19:02.060+0900 I/APP_CORE( 4459): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
05-29 20:19:02.060+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: PAUSE State: RUNNING
05-29 20:19:02.060+0900 I/CAPI_APPFW_APPLICATION( 1921): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 20:19:02.060+0900 I/APP_CORE( 1921): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
05-29 20:19:02.080+0900 W/WATCH_CORE(  749): appcore-watch.c: __widget_pause(1001) > widget_pause
05-29 20:19:02.080+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppPause(713) > 
05-29 20:19:02.080+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:19:02.080+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:19:02.080+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:19:02.080+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:19:02.080+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:19:02.080+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:19:02.095+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:19:02.095+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 20:19:02.170+0900 I/AUL_PAD ( 4471): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 20:19:02.470+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:19:02.520+0900 I/MALI    ( 4459): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x419769a0] swap changed from async to sync
05-29 20:19:03.595+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 20:19:03.680+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 20:19:03.705+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 20:19:03.715+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 20:19:03.715+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1702) > caller pid : 700
05-29 20:19:03.750+0900 W/AUL_AMD (  495): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 4459
05-29 20:19:03.755+0900 I/APP_CORE( 4459): appcore-efl.c: __do_app(429) > [APP 4459] Event: RESET State: RUNNING
05-29 20:19:03.755+0900 I/CAPI_APPFW_APPLICATION( 4459): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 20:19:03.755+0900 I/APP_CORE( 4459): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-29 20:19:03.755+0900 I/APP_CORE( 4459): appcore-efl.c: __do_app(481) > [APP 4459] App already running, raise the window
05-29 20:19:03.770+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(916) > listen fd(20) , send fd(13), pid(4459), cmd(0)
05-29 20:19:03.810+0900 E/E17     (  379): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04600003)
05-29 20:19:03.825+0900 I/HAP     ( 4459): routes length: 21
05-29 20:19:03.830+0900 I/HAP     ( 4459): lat: 37.277 lon: 127.031 num:0
05-29 20:19:03.830+0900 I/HAP     ( 4459): lat: 37.278 lon: 127.032 num:1
05-29 20:19:03.830+0900 I/HAP     ( 4459): lat: 37.278 lon: 127.032 num:2
05-29 20:19:03.830+0900 I/HAP     ( 4459): lat: 37.278 lon: 127.033 num:3
05-29 20:19:03.830+0900 I/HAP     ( 4459): lat: 37.278 lon: 127.033 num:4
05-29 20:19:03.830+0900 I/HAP     ( 4459): lat: 37.277 lon: 127.035 num:5
05-29 20:19:03.830+0900 I/HAP     ( 4459): lat: 37.277 lon: 127.035 num:6
05-29 20:19:03.830+0900 I/HAP     ( 4459): lat: 37.277 lon: 127.037 num:7
05-29 20:19:03.830+0900 I/HAP     ( 4459): lat: 37.277 lon: 127.038 num:8
05-29 20:19:03.830+0900 I/HAP     ( 4459): lat: 37.277 lon: 127.038 num:9
05-29 20:19:03.830+0900 I/HAP     ( 4459): lat: 37.277 lon: 127.038 num:10
05-29 20:19:03.835+0900 I/HAP     ( 4459): lat: 37.277 lon: 127.038 num:11
05-29 20:19:03.835+0900 I/HAP     ( 4459): lat: 37.277 lon: 127.038 num:12
05-29 20:19:03.835+0900 I/HAP     ( 4459): lat: 37.277 lon: 127.038 num:13
05-29 20:19:03.835+0900 I/HAP     ( 4459): lat: 37.277 lon: 127.038 num:14
05-29 20:19:03.835+0900 I/HAP     ( 4459): lat: 37.277 lon: 127.038 num:15
05-29 20:19:03.835+0900 I/HAP     ( 4459): lat: 37.277 lon: 127.038 num:16
05-29 20:19:03.835+0900 I/HAP     ( 4459): lat: 37.278 lon: 127.039 num:17
05-29 20:19:03.835+0900 I/HAP     ( 4459): lat: 37.279 lon: 127.041 num:18
05-29 20:19:03.835+0900 I/HAP     ( 4459): lat: 37.279 lon: 127.041 num:19
05-29 20:19:04.155+0900 W/CRASH_MANAGER( 4482): worker.c: worker_job(1199) > 1104459686170146452074
