S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.5
Build-Number: R732XXU2CPC5
Build-Date: 2016.03.21 17:05:24

Crash Information
Process Name: hap
PID: 4025
Date: 2016-05-29 20:17:50+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x41aef504, r1   = 0xffffffff
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x4000daa0, r5   = 0xbed18d30
r6   = 0x41c1ec00, r7   = 0xbed18d08
r8   = 0x4336ac48, r9   = 0x40359861
r10  = 0x405014b8, fp   = 0x00000000
ip   = 0x41488a20, sp   = 0xbed18af8
lr   = 0x40413070, pc   = 0x40413090
cpsr = 0x40000010

Memory Information
MemTotal:   491012 KB
MemFree:     16456 KB
Buffers:     16556 KB
Cached:     162236 KB
VmPeak:      75220 KB
VmSize:      72760 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18676 KB
VmRSS:       18676 KB
VmData:      40364 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       28068 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 4025 TID = 4025
4025 4033 4034 4038 

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
4158a000 41654000 r-xp /usr/lib/libCOREGL.so.4.0
4165c000 4165e000 rwxp /usr/lib/libCOREGL.so.4.0
41666000 4168a000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41691000 41693000 rwxp /usr/lib/ecore/immodules/libisf-imf-module.so
41693000 41762000 r-xp /usr/lib/libscim-1.0.so.8.2.3
41769000 41778000 rwxp /usr/lib/libscim-1.0.so.8.2.3
41778000 4180c000 r-xp /usr/lib/libstdc++.so.6.0.16
41814000 41817000 r-xp /usr/lib/libstdc++.so.6.0.16
41817000 41819000 rwxp /usr/lib/libstdc++.so.6.0.16
4181f000 4184c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
41853000 41854000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
41854000 41857000 r-xp /usr/lib/libsmack.so.1.0.0
4185e000 4185f000 rwxp /usr/lib/libsmack.so.1.0.0
4185f000 4187c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
41884000 41885000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
41885000 41887000 r-xp /usr/lib/libiri.so
4188e000 4188f000 rwxp /usr/lib/libiri.so
4188f000 41892000 r-xp /lib/libcap.so.2.21
41899000 4189a000 rwxp /lib/libcap.so.2.21
4189a000 418a1000 r-xp /lib/libcrypt-2.13.so
418a8000 418a9000 r-xp /lib/libcrypt-2.13.so
418a9000 418aa000 rwxp /lib/libcrypt-2.13.so
418d1000 418d4000 r-xp /lib/libattr.so.1.1.0
418db000 418dc000 rwxp /lib/libattr.so.1.1.0
418dc000 418e6000 r-xp /lib/libnss_files-2.13.so
418ed000 418ee000 r-xp /lib/libnss_files-2.13.so
418ee000 418ef000 rwxp /lib/libnss_files-2.13.so
418ef000 41aef000 r-xp /usr/share/locale/locale-archive
41aef000 41c20000 r-xp /usr/share/locale/locale-archive
41c20000 41c97000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
41c9f000 41ca1000 rwxp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
41ca7000 41def000 r-xp /usr/lib/egl/libMali.so
41def000 41df4000 rwxp /usr/lib/egl/libMali.so
41df5000 41df8000 rwxp [stack:4034]
41df8000 41dfc000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41e03000 41e04000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41e04000 41e08000 rwxs /dev/mali
41e09000 41e0b000 r-xp /usr/lib/libdri2.so.0.0.0
41e12000 41e13000 rwxp /usr/lib/libdri2.so.0.0.0
41e13000 41e1b000 r-xp /usr/lib/libdrm.so.2.4.0
41e22000 41e23000 rwxp /usr/lib/libdrm.so.2.4.0
41e23000 41e2a000 r-xp /usr/lib/libtbm.so.1.0.0
41e31000 41e32000 rwxp /usr/lib/libtbm.so.1.0.0
41e32000 41e35000 r-xp /usr/lib/libnative-buffer.so.0.1.0
41e3c000 41e3d000 rwxp /usr/lib/libnative-buffer.so.0.1.0
41e3e000 4263d000 rwxp [stack:4033]
4263d000 42645000 rwxs /dev/mali
42645000 4264d000 rwxs /dev/mali
4264d000 42661000 r-xs /opt/home/app/.cache/evas_gl_common_caches/ARM::OpenGL
42761000 42765000 rwxs /dev/mali
42765000 42769000 rwxs /dev/mali
42769000 42771000 rwxs /dev/mali
42771000 42779000 rwxs /dev/mali
42779000 4277b000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
4277b000 4291a000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
42a1a000 42a31000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
42a39000 42a3e000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
42a3e000 42a40000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
42a47000 42a48000 rwxp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43248000 4324f000 r-xs /usr/lib/gconv/gconv-modules.cache
4324f000 43252000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
43252000 43256000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
43256000 43265000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
43265000 432f1000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
432f5000 432f9000 rwxs /dev/mali
432f9000 432fd000 rwxs /dev/mali
43c00000 43c40000 rwxs /dev/mali
43c50000 43c74000 rwxs /dev/mali
43c74000 43c78000 rwxs /dev/mali
43c84000 43ca8000 rwxs /dev/mali
43ca8000 43ccc000 rwxs /dev/mali
43cf5000 43d80000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
43d81000 44580000 rwxp [stack:4038]
44580000 44602000 rwxs /dev/dri/card0
44602000 44702000 rwxs /dev/mali
becf9000 bed1a000 rwxp [stack]
End of Maps Information

Callstack Information (PID:4025)
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
ocess_prepare_exec() failed
05-29 20:16:08.415+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:08.415+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:08.520+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:08.520+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:08.620+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:08.620+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:08.720+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:08.720+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:08.820+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:08.820+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:08.920+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:08.920+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:09.020+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:09.020+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:09.120+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:09.120+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:09.220+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:09.220+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:09.325+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:09.325+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:09.425+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:09.425+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:09.525+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:09.525+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:09.625+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:09.625+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:09.725+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:09.725+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:09.825+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:09.825+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:09.930+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:09.930+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:10.040+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:10.040+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:10.145+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:10.145+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:10.250+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:10.250+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:10.355+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:10.360+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:10.465+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:10.465+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:10.570+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:10.570+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:10.680+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:10.680+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:10.785+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:10.785+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:10.890+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:10.890+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:11.000+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:11.000+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:11.110+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:11.110+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:11.220+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:11.220+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:11.330+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:11.330+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:11.435+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:11.435+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:11.535+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:11.540+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:11.645+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:11.645+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:11.750+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:11.750+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:11.855+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:11.855+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:11.960+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:11.960+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:12.070+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:12.070+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:12.175+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:12.175+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:12.275+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:12.280+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:12.385+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:12.385+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:12.495+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:12.495+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:12.600+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:12.600+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:12.705+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:12.705+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:12.810+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:12.810+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:12.915+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:12.915+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:13.020+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:13.025+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:13.130+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:13.130+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:13.235+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:13.235+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:13.345+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:13.345+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:13.450+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:13.450+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:16:13.485+0900 E/AUL     (  700): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
05-29 20:16:13.535+0900 E/AUL     (  495): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
05-29 20:16:13.535+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2098) > Launch with legacy way : Timeout
05-29 20:16:13.550+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(312) > process launched, but cmdline not changed
05-29 20:16:13.550+0900 E/AUL_PAD ( 1191): launchpad.c: __real_send(253) > send failed due to EPIPE.
05-29 20:16:13.550+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(317) > send SIGKILL: No such process
05-29 20:16:13.555+0900 W/AUL_AMD (  495): amd_launch.c: start_process(580) > child process: 4025
05-29 20:16:13.595+0900 W/WATCH_CORE(  749): appcore-watch.c: __widget_resume(1012) > widget_resume
05-29 20:16:13.600+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppResume(721) > 
05-29 20:16:13.600+0900 I/watchface-viewer(  749): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [37]
05-29 20:16:13.600+0900 I/watchface-viewer(  749): viewer-part-resource.cpp: SetUpdateImage(1981) > new mThread[0x476cd698]
05-29 20:16:13.600+0900 I/watchface-viewer(  749): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [39]
05-29 20:16:13.600+0900 I/watchface-viewer(  749): viewer-data-provider.cpp: FlushPendingChanges(1099) > notify pending [78]
05-29 20:16:13.630+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:16:13.630+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:16:13.645+0900 I/watchface-viewer(  749): viewer-part-resource.cpp: ThreadCallback(2108) > thread[0x476cd698]
05-29 20:16:13.660+0900 I/watchface-viewer(  749): viewer-part-resource-evas.cpp: CreateTextImage(601) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 ']
05-29 20:16:13.665+0900 I/watchface-viewer(  749): viewer-part-resource-evas.cpp: CreateTextImage(615) > formatted size 72x43
05-29 20:16:13.685+0900 I/watchface-viewer(  749): viewer-part-resource.cpp: ThreadNotifyCallback(2170) > thread[0x476cd698]
05-29 20:16:13.685+0900 I/watchface-viewer(  749): viewer-part-resource.cpp: ThreadEndCallback(2206) > thread[0x476cd698]
05-29 20:16:13.710+0900 W/AUL_AMD (  495): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 4025
05-29 20:16:13.725+0900 E/AUL_AMD (  495): amd_launch.c: __real_send(824) > send failed due to EPIPE.
05-29 20:16:13.725+0900 E/AUL_AMD (  495): amd_launch.c: __real_send(826) > send fail to client
05-29 20:16:13.755+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:16:13.755+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3924
05-29 20:16:13.770+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:16:13.825+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:16:13.835+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4025
05-29 20:16:13.850+0900 I/watchface-viewer(  749): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
05-29 20:16:13.855+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:16:13.855+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:16:13.880+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 20:16:13.880+0900 I/efl-extension( 4025): efl_extension.c: eext_mod_init(40) > Init
05-29 20:16:13.905+0900 I/CAPI_APPFW_APPLICATION( 4025): app_main.c: ui_app_main(704) > app_efl_main
05-29 20:16:14.045+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:16:14.045+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:16:14.150+0900 I/CAPI_APPFW_APPLICATION( 4025): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-29 20:16:14.235+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:16:14.235+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:16:14.240+0900 E/TBM     ( 4025): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 20:16:14.400+0900 E/E17     (  379): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04600003)
05-29 20:16:14.415+0900 E/EFL     ( 4025): ecore_evas<4025> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-29 20:16:14.440+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:16:14.440+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:16:14.480+0900 I/efl-extension( 4025): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0x429273b0]'s widget[0x4271ad68] to elm_conformant widget[0x426c8438]
05-29 20:16:14.585+0900 E/RESOURCED( 1097): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:16:14.585+0900 E/AUL     ( 1097): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-29 20:16:14.585+0900 E/CAPI_APPFW_APP_MANAGER( 1097): app_manager.c: app_manager_error(78) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
05-29 20:16:14.595+0900 I/HAP     ( 4025): SUCCESSFULLY create sap agent
05-29 20:16:14.595+0900 I/HAP     ( 4025): connectivity type(1): bt
05-29 20:16:14.630+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:16:14.630+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:16:14.725+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:16:14.725+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-29 20:16:14.825+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:16:14.825+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:16:14.855+0900 I/HAP     ( 4025): agent is initialized
05-29 20:16:14.855+0900 I/HAP     ( 4025): agent initialized callback is over
05-29 20:16:14.855+0900 I/HAP     ( 4025): SAP >>> getRegisteredServiceAgent() >>> 0
05-29 20:16:14.945+0900 I/APP_CORE( 4025): appcore-efl.c: __do_app(429) > [APP 4025] Event: RESET State: CREATED
05-29 20:16:14.945+0900 I/CAPI_APPFW_APPLICATION( 4025): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 20:16:14.970+0900 I/AUL_PAD ( 4037): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 20:16:14.985+0900 I/APP_CORE( 4025): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 20:16:14.985+0900 I/APP_CORE( 4025): appcore-efl.c: __do_app(474) > [APP 4025] Initial Launching, call the resume_cb
05-29 20:16:14.985+0900 I/CAPI_APPFW_APPLICATION( 4025): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 20:16:14.995+0900 W/APP_CORE( 4025): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4600003
05-29 20:16:15.005+0900 I/efl-extension( 4025): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x429273b0 = w: 0 h: 0  obj 0x4271ad68 w: 360 h: 360
05-29 20:16:15.010+0900 I/efl-extension( 4025): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 20:16:15.020+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:16:15.020+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:16:15.085+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: PAUSE State: RUNNING
05-29 20:16:15.085+0900 I/CAPI_APPFW_APPLICATION( 1921): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 20:16:15.085+0900 I/APP_CORE( 4025): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
05-29 20:16:15.085+0900 I/APP_CORE( 1921): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
05-29 20:16:15.115+0900 W/WATCH_CORE(  749): appcore-watch.c: __widget_pause(1001) > widget_pause
05-29 20:16:15.115+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppPause(713) > 
05-29 20:16:15.115+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:16:15.115+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:16:15.115+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:16:15.115+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:16:15.115+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:16:15.115+0900 E/watchface-viewer(  749): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 20:16:15.115+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:16:15.115+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 20:16:15.500+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:16:15.550+0900 I/MALI    ( 4025): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x4154b340] swap changed from async to sync
05-29 20:16:16.505+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 20:16:16.640+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 20:16:16.710+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 20:16:16.710+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 20:16:16.715+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1702) > caller pid : 700
05-29 20:16:16.770+0900 W/AUL_AMD (  495): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 4025
05-29 20:16:16.770+0900 I/APP_CORE( 4025): appcore-efl.c: __do_app(429) > [APP 4025] Event: RESET State: RUNNING
05-29 20:16:16.775+0900 I/CAPI_APPFW_APPLICATION( 4025): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 20:16:16.775+0900 I/APP_CORE( 4025): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-29 20:16:16.775+0900 I/APP_CORE( 4025): appcore-efl.c: __do_app(481) > [APP 4025] App already running, raise the window
05-29 20:16:16.790+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(4025), cmd(0)
05-29 20:16:16.815+0900 E/E17     (  379): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04600003)
05-29 20:16:17.795+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:16:17.795+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-29 20:16:20.110+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: MEM_FLUSH State: PAUSED
05-29 20:16:22.105+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:16:22.175+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4025
05-29 20:16:26.880+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:16:26.950+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4025
05-29 20:16:28.300+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:16:28.305+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:16:28.310+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(812249459)
05-29 20:16:28.320+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:16:28.320+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 20:16:28.325+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:16:28.330+0900 E/ALARM_MANAGER(  487): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[812249459] is removed.
05-29 20:16:28.385+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:16:28.390+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:16:28.420+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:16:28.450+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:16:28.465+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:16:28.475+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:16:28.475+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-29 20:16:28.480+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-29 20:16:28.495+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:16:28.510+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:16:28.510+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464520592, Sun May 29 20:16:32 2016
05-29 20:16:28.510+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 820856824, next duetime: 1464520592
05-29 20:16:28.510+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(820856824)
05-29 20:16:28.510+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464520592)
05-29 20:16:28.510+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:16:28.510+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 11:16:32 (UTC).
05-29 20:16:28.510+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:16:31.880+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:16:31.955+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4025
05-29 20:16:32.000+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_handler_idle(1360) > Lock the display not to enter LCD OFF
05-29 20:16:32.070+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __display_lock_state(1692) > Lock LCD OFF is successfully done
05-29 20:16:32.130+0900 E/RESOURCED(  498): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 870
05-29 20:16:32.160+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_expired(1322) > alarm_id[820856824] is expired.
05-29 20:16:32.160+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(820856824)
05-29 20:16:32.170+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:16:32.170+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 20:16:32.170+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:16:32.170+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_handler_idle(1386) > Unlock the display from LCD OFF
05-29 20:16:32.195+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __display_unlock_state(1735) > Unlock LCD OFF is successfully done
05-29 20:16:32.200+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:16:32.205+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:16:32.235+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:16:32.265+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:16:32.280+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:16:32.295+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:16:32.295+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-29 20:16:32.300+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-29 20:16:32.315+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:16:32.325+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:16:32.330+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464520593, Sun May 29 20:16:33 2016
05-29 20:16:32.330+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1753790763, next duetime: 1464520593
05-29 20:16:32.330+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1753790763)
05-29 20:16:32.330+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464520593)
05-29 20:16:32.330+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:16:32.330+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 11:16:33 (UTC).
05-29 20:16:32.330+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:16:33.000+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_handler_idle(1360) > Lock the display not to enter LCD OFF
05-29 20:16:33.080+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __display_lock_state(1692) > Lock LCD OFF is successfully done
05-29 20:16:33.135+0900 E/RESOURCED(  498): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 870
05-29 20:16:33.160+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_expired(1322) > alarm_id[1753790763] is expired.
05-29 20:16:33.160+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1753790763)
05-29 20:16:33.165+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:16:33.170+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 20:16:33.175+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:16:33.175+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_handler_idle(1386) > Unlock the display from LCD OFF
05-29 20:16:33.215+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __display_unlock_state(1735) > Unlock LCD OFF is successfully done
05-29 20:16:33.220+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:16:33.225+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:16:33.255+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:16:33.275+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:16:33.290+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:16:33.305+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:16:33.305+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-29 20:16:33.310+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-29 20:16:33.320+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:16:33.335+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:16:33.335+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464563793, Mon May 30 08:16:33 2016
05-29 20:16:33.335+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1455085359, next duetime: 1464563793
05-29 20:16:33.335+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1455085359)
05-29 20:16:33.335+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464563793)
05-29 20:16:33.335+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:16:33.335+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 20:16:33.335+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:16:36.905+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:16:36.975+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4025
05-29 20:16:41.880+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:16:41.950+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4025
05-29 20:16:46.880+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:16:46.960+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4025
05-29 20:16:50.290+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 20:16:50.290+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 20:16:51.890+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:16:51.985+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4025
05-29 20:16:56.904+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:16:56.980+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4025
05-29 20:17:01.885+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:17:01.955+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4025
05-29 20:17:06.890+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:17:06.970+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4025
05-29 20:17:11.890+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:17:11.960+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4025
05-29 20:17:16.880+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:17:16.950+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4025
05-29 20:17:21.880+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:17:21.955+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4025
05-29 20:17:26.890+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:17:26.960+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4025
05-29 20:17:30.275+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:17:30.295+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:17:30.295+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1455085359)
05-29 20:17:30.300+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:17:30.300+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 20:17:30.315+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:17:30.320+0900 E/ALARM_MANAGER(  487): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[1455085359] is removed.
05-29 20:17:30.340+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:17:30.340+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:17:30.375+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:17:30.405+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:17:30.425+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:17:30.440+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:17:30.440+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-29 20:17:30.440+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-29 20:17:30.460+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:17:30.470+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:17:30.475+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464520654, Sun May 29 20:17:34 2016
05-29 20:17:30.475+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1283316637, next duetime: 1464520654
05-29 20:17:30.475+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1283316637)
05-29 20:17:30.475+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464520654)
05-29 20:17:30.475+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:17:30.475+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 11:17:34 (UTC).
05-29 20:17:30.475+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:17:30.480+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:17:30.480+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:17:30.480+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1283316637)
05-29 20:17:30.485+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:17:30.485+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 20:17:30.485+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:17:30.485+0900 E/ALARM_MANAGER(  487): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[1283316637] is removed.
05-29 20:17:30.490+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:17:30.495+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:17:30.505+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:17:30.520+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:17:30.530+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:17:30.540+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:17:30.540+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-29 20:17:30.540+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-29 20:17:30.555+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:17:30.565+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:17:30.565+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464563850, Mon May 30 08:17:30 2016
05-29 20:17:30.565+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1283316637, next duetime: 1464563850
05-29 20:17:30.565+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1283316637)
05-29 20:17:30.565+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464563850)
05-29 20:17:30.565+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:17:30.565+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 20:17:30.565+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:17:31.880+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:17:31.960+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4025
05-29 20:17:36.895+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:17:36.970+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4025
05-29 20:17:41.890+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:17:41.960+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4025
05-29 20:17:46.880+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:17:46.950+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4025
05-29 20:17:50.275+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 20:17:50.275+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 20:17:50.275+0900 I/RESOURCED(  498): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
05-29 20:17:50.945+0900 I/HAP     ( 4025): routes length: 21
05-29 20:17:50.945+0900 I/HAP     ( 4025): lat: 37.277 lon: 127.031 num:
05-29 20:17:50.945+0900 I/HAP     ( 4025): lat: 37.278 lon: 127.032 num:
05-29 20:17:50.945+0900 I/HAP     ( 4025): lat: 37.278 lon: 127.032 num:
05-29 20:17:50.945+0900 I/HAP     ( 4025): lat: 37.278 lon: 127.033 num:
05-29 20:17:50.945+0900 I/HAP     ( 4025): lat: 37.278 lon: 127.033 num:
05-29 20:17:50.945+0900 I/HAP     ( 4025): lat: 37.277 lon: 127.035 num:
05-29 20:17:50.945+0900 I/HAP     ( 4025): lat: 37.277 lon: 127.035 num:
05-29 20:17:50.945+0900 I/HAP     ( 4025): lat: 37.277 lon: 127.037 num:
05-29 20:17:50.945+0900 I/HAP     ( 4025): lat: 37.277 lon: 127.038 num:
05-29 20:17:50.945+0900 I/HAP     ( 4025): lat: 37.277 lon: 127.038 num:
05-29 20:17:50.945+0900 I/HAP     ( 4025): lat: 37.277 lon: 127.038 num:
05-29 20:17:50.945+0900 I/HAP     ( 4025): lat: 37.277 lon: 127.038 num:
05-29 20:17:50.945+0900 I/HAP     ( 4025): lat: 37.277 lon: 127.038 num:
05-29 20:17:50.945+0900 I/HAP     ( 4025): lat: 37.277 lon: 127.038 num:
05-29 20:17:50.945+0900 I/HAP     ( 4025): lat: 37.277 lon: 127.038 num:
05-29 20:17:50.945+0900 I/HAP     ( 4025): lat: 37.277 lon: 127.038 num:
05-29 20:17:50.960+0900 I/HAP     ( 4025): lat: 37.277 lon: 127.038 num:
05-29 20:17:50.960+0900 I/HAP     ( 4025): lat: 37.278 lon: 127.039 num:
05-29 20:17:50.960+0900 I/HAP     ( 4025): lat: 37.279 lon: 127.041 num:
05-29 20:17:50.960+0900 I/HAP     ( 4025): lat: 37.279 lon: 127.041 num:
05-29 20:17:51.405+0900 W/CRASH_MANAGER( 4088): worker.c: worker_job(1199) > 1104025686170146452067
