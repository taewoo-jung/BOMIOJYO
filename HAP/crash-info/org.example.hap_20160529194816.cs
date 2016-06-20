S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.5
Build-Number: R732XXU2CPC5
Build-Date: 2016.03.21 17:05:24

Crash Information
Process Name: hap
PID: 12802
Date: 2016-05-29 19:48:16+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x41aef504, r1   = 0xffffffff
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x4000da9c, r5   = 0xbea7ed30
r6   = 0x41c1ec00, r7   = 0xbea7ed08
r8   = 0x4336b000, r9   = 0x40359861
r10  = 0x405014b8, fp   = 0x00000000
ip   = 0x41488a20, sp   = 0xbea7eb00
lr   = 0x40413070, pc   = 0x40413090
cpsr = 0x40000010

Memory Information
MemTotal:   489992 KB
MemFree:     39980 KB
Buffers:     20604 KB
Cached:     119628 KB
VmPeak:      75212 KB
VmSize:      72752 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18800 KB
VmRSS:       18800 KB
VmData:      40356 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       28068 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 12802 TID = 12802
12802 12809 12810 12814 

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
41df5000 41df8000 rwxp [stack:12810]
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
41e3e000 4263d000 rwxp [stack:12809]
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
43c74000 43c98000 rwxs /dev/mali
43c98000 43cbc000 rwxs /dev/mali
43cbc000 43cc0000 rwxs /dev/mali
43cf5000 43d80000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
43d81000 44580000 rwxp [stack:12814]
44580000 44602000 rwxs /dev/dri/card0
44602000 44702000 rwxs /dev/mali
bea5f000 bea80000 rwxp [stack]
End of Maps Information

Callstack Information (PID:12802)
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
ege check in case of preloaded apps
05-29 19:47:52.411+0900 W/AUL_AMD (  496): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 718
05-29 19:47:52.416+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(718), cmd(0)
05-29 19:47:52.416+0900 I/APP_CORE(  718): appcore-efl.c: __do_app(429) > [APP 718] Event: RESET State: RUNNING
05-29 19:47:52.416+0900 I/CAPI_APPFW_APPLICATION(  718): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-29 19:47:52.416+0900 W/W_HOME  (  718): main.c: _app_control(1726) > Service value : launch_apps
05-29 19:47:52.416+0900 W/W_HOME  (  718): move.c: move_move_to_apps(216) > move to apps
05-29 19:47:52.416+0900 W/W_HOME  (  718): rotary.c: rotary_attach(138) > rotary_attach:0x45d3bd18
05-29 19:47:52.416+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45d3bd18, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-29 19:47:52.416+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 19:47:52.416+0900 W/W_HOME  (  718): event_manager.c: _move_module_anim_start_cb(635) > state: 0 -> 1
05-29 19:47:52.416+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 19:47:52.416+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 19:47:52.456+0900 I/APP_CORE(  718): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
05-29 19:47:52.456+0900 W/W_HOME  (  718): event_manager.c: _apptray_visibility_cb(578) > apps,show,start
05-29 19:47:52.456+0900 W/W_HOME  (  718): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 0
05-29 19:47:52.461+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 19:47:52.461+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 19:47:52.461+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 19:47:52.461+0900 W/W_HOME  (  718): noti_broker.c: _apptray_visibility_cb(788) > apps,show,start
05-29 19:47:52.461+0900 W/W_HOME  (  718): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80002
05-29 19:47:52.461+0900 I/wnotib  (  718): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80002
05-29 19:47:52.461+0900 I/wnotib  (  718): w-notification-board-broker-main.c: _wnotib_view_event_handler(1291) > Unhandled type: 0x80002
05-29 19:47:52.741+0900 W/W_HOME  (  718): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
05-29 19:47:52.746+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 19:47:52.746+0900 W/W_HOME  (  718): rotary.c: rotary_deattach(156) > rotary_deattach:0x45d3bd18
05-29 19:47:52.746+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 19:47:52.746+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45d3bd18, elm_layout, func : 0x4004b469
05-29 19:47:52.746+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-29 19:47:52.746+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-29 19:47:52.746+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 19:47:52.746+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96248, elm_box, _activated_obj : 0x45d3bd18, activated : 1
05-29 19:47:52.746+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 19:47:52.746+0900 E/wnotib  (  718): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 19:47:52.751+0900 I/wnotib  (  718): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-29 19:47:52.756+0900 W/W_HOME  (  718): event_manager.c: _apptray_visibility_cb(578) > apps,show
05-29 19:47:52.761+0900 W/W_HOME  (  718): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 1
05-29 19:47:52.761+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 19:47:52.761+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 19:47:52.761+0900 W/W_HOME  (  718): main.c: home_pause(751) > clock/widget paused
05-29 19:47:52.761+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 19:47:52.761+0900 W/APPS    (  718): apps_main.c: _time_changed_cb(295) >  date : 29->29
05-29 19:47:52.766+0900 W/W_HOME  (  718): rotary.c: rotary_attach(138) > rotary_attach:0x46683838
05-29 19:47:52.766+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46683838, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-29 19:47:52.766+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 19:47:52.766+0900 W/W_HOME  (  718): noti_broker.c: _apptray_visibility_cb(788) > apps,show
05-29 19:47:52.776+0900 W/W_HOME  (  718): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80000
05-29 19:47:52.776+0900 I/wnotib  (  718): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80000
05-29 19:47:52.776+0900 I/wnotib  (  718): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1709) > is_app_tray_displayed: 1
05-29 19:47:52.776+0900 E/APPS    (  718): apps_main.c: apps_main_resume(621) >  resumed already
05-29 19:47:52.786+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 19:47:52.786+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 19:47:52.786+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 19:47:52.786+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 19:47:52.856+0900 I/AUL     (12696): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-29 19:47:52.866+0900 W/W_HOME  (  718): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
05-29 19:47:52.901+0900 I/AUL     (12696): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-29 19:47:52.906+0900 E/AUL     (12696): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-29 19:47:52.906+0900 E/AUL     (12696): aul_path.c: __get_path(169) > root_path is NULL!
05-29 19:47:52.921+0900 I/AUL     (12696): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-29 19:47:52.936+0900 I/AUL     (12696): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-29 19:47:52.936+0900 E/AUL     (12696): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-29 19:47:52.936+0900 E/AUL     (12696): aul_path.c: __get_path(169) > root_path is NULL!
05-29 19:47:52.966+0900 I/UXT     (12696): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-29 19:47:53.101+0900 E/TBM     (12696): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 19:47:53.416+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:47:53.416+0900 W/AUL_AMD (  496): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-29 19:47:53.481+0900 E/PKGMGR_SERVER(12691): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
05-29 19:47:53.816+0900 E/PKGMGR_SERVER(12691): pkgmgr-server.c: sighandler(409) > child NORMAL exit [12692]
05-29 19:47:53.826+0900 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_log_package(4560) > package [_________] callback : [UPDATE, PROCESSING]
05-29 19:47:53.851+0900 W/W_HOME  (  718): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.example.hap is updated, need to check validation
05-29 19:47:53.851+0900 W/W_HOME  (  718): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:com.samsung.watchface
05-29 19:47:53.866+0900 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_log_package(4560) > package [_________] callback : [UPDATE, COMPLETED]
05-29 19:47:53.866+0900 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6943) > package install complete
05-29 19:47:53.866+0900 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_package_install_event(4815) > 
05-29 19:47:53.866+0900 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1762) > Found in install_req_list?[0], index[-1]
05-29 19:47:53.926+0900 E/STARTER (  695): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
05-29 19:47:53.986+0900 E/APPS    (  718): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
05-29 19:47:54.051+0900 E/PKGMGR_INFO(  493): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
05-29 19:47:55.481+0900 E/PKGMGR_SERVER(12691): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
05-29 19:47:55.481+0900 E/PKGMGR_SERVER(12691): pkgmgr-server.c: main(2185) > package manager server terminated.
05-29 19:48:00.751+0900 W/APPS    (  718): apps_main.c: _time_changed_cb(295) >  date : 29->29
05-29 19:48:01.861+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 19:48:01.876+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
05-29 19:48:01.891+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
05-29 19:48:01.891+0900 E/AUL_AMD (  496): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 19:48:01.891+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 12784
05-29 19:48:01.906+0900 W/AUL_AMD (  496): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 2594
05-29 19:48:01.911+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(429) > [APP 2594] Event: RESET State: PAUSED
05-29 19:48:01.911+0900 I/CAPI_APPFW_APPLICATION( 2594): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 19:48:01.916+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(20) , send fd(13), pid(2594), cmd(0)
05-29 19:48:01.931+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-29 19:48:01.931+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(481) > [APP 2594] App already running, raise the window
05-29 19:48:01.946+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04400002)
05-29 19:48:01.951+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(485) > [APP 2594] Call the resume_cb
05-29 19:48:01.951+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:48:01.951+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 19:48:01.956+0900 I/CAPI_APPFW_APPLICATION( 2594): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 19:48:02.071+0900 W/W_HOME  (  718): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-29 19:48:02.071+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 19:48:02.071+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 19:48:02.071+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 19:48:02.071+0900 W/W_HOME  (  718): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-29 19:48:02.071+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 19:48:02.071+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 19:48:02.126+0900 W/W_HOME  (  718): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-29 19:48:02.126+0900 W/W_HOME  (  718): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-29 19:48:02.126+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 19:48:02.126+0900 W/W_HOME  (  718): event_manager.c: _state_control(333) > appcore paused manually
05-29 19:48:02.126+0900 W/W_HOME  (  718): main.c: home_appcore_pause(717) > Home Appcore Paused
05-29 19:48:02.126+0900 W/W_HOME  (  718): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-29 19:48:02.126+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 19:48:02.126+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 19:48:02.126+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-29 19:48:02.126+0900 W/W_HOME  (  718): rotary.c: rotary_deattach(156) > rotary_deattach:0x46683838
05-29 19:48:02.126+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 19:48:02.126+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46683838, elm_layout, func : 0x4004b469
05-29 19:48:02.126+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-29 19:48:02.126+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-29 19:48:02.126+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 19:48:02.126+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96248, elm_box, _activated_obj : 0x46683838, activated : 1
05-29 19:48:02.126+0900 I/efl-extension(  718): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 19:48:02.126+0900 E/wnotib  (  718): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 19:48:02.126+0900 I/wnotib  (  718): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-29 19:48:02.151+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(429) > [APP 2594] Event: RESUME State: RUNNING
05-29 19:48:02.161+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 19:48:02.161+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 19:48:02.166+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 19:48:02.166+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-29 19:48:02.166+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-29 19:48:02.166+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 19:48:02.166+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-29 19:48:02.166+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 19:48:02.166+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 19:48:02.166+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 19:48:02.166+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 19:48:02.166+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-29 19:48:02.166+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-29 19:48:02.166+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 19:48:02.166+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-29 19:48:02.166+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-29 19:48:02.166+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-29 19:48:02.166+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 19:48:02.166+0900 E/CAPI_APPFW_APP_CONTROL( 1053): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-29 19:48:02.166+0900 W/MUSIC_CONTROL_SERVICE( 1053): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1053]   [com.samsung.w-home]register msg port [false][0m
05-29 19:48:02.166+0900 W/W_HOME  (  718): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-29 19:48:02.166+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 19:48:02.166+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 19:48:02.166+0900 I/APP_CORE(  718): appcore-efl.c: __do_app(429) > [APP 718] Event: PAUSE State: RUNNING
05-29 19:48:02.166+0900 I/CAPI_APPFW_APPLICATION(  718): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 19:48:02.166+0900 W/W_HOME  (  718): main.c: _appcore_pause_cb(690) > appcore pause
05-29 19:48:02.171+0900 E/W_HOME  (  718): main.c: _pause_cb(668) > paused already
05-29 19:48:02.211+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 19:48:02.226+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 19:48:02.236+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 19:48:02.236+0900 E/AUL_AMD (  496): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 19:48:02.236+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 697
05-29 19:48:02.246+0900 E/RESOURCED(  497): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-29 19:48:02.246+0900 E/RESOURCED(  497): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 19:48:02.256+0900 I/wnotib  (  718): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-29 19:48:02.256+0900 E/wnotib  (  718): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 19:48:02.261+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(2080) > pad pid(-5)
05-29 19:48:02.261+0900 W/AUL_PAD ( 1161): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-29 19:48:02.261+0900 W/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(272) > Check app launching
05-29 19:48:02.266+0900 E/AUL_PAD (12693): launchpad_loader.c: __candidate_process_prepare_exec(259) > fail to set privileges - check your package's credential : -1
05-29 19:48:02.266+0900 E/AUL_PAD (12693): launchpad_loader.c: __candidate_process_launchpad_main_loop(402) > __candidate_process_prepare_exec() failed
05-29 19:48:02.286+0900 W/APPS    (  718): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-29 19:48:02.326+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:02.326+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:02.426+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:02.426+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:02.526+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:02.526+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:02.626+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:02.626+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:02.666+0900 I/APP_CORE(  718): appcore-efl.c: __do_app(429) > [APP 718] Event: MEM_FLUSH State: PAUSED
05-29 19:48:02.731+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:02.731+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:02.831+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:02.831+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:02.931+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:02.931+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:03.031+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:03.031+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:03.131+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:03.131+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:03.231+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:03.231+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:03.331+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:03.331+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:03.431+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:03.431+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:03.531+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:03.531+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:03.631+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:03.631+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:03.731+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:03.731+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:03.836+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:03.836+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:03.941+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:03.941+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:04.046+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:04.046+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:04.151+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:04.156+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:04.266+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:04.266+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:04.371+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:04.371+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:04.476+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:04.476+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:04.586+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:04.586+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:04.696+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:04.696+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:04.801+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:04.801+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:04.906+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:04.906+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:05.011+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:05.016+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:05.121+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:05.121+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:05.226+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:05.226+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:05.331+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:05.336+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:05.436+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:05.436+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:05.541+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:05.541+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:05.661+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:05.661+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:05.761+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:05.766+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:05.866+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:05.866+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:05.971+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:05.971+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:06.076+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:06.076+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:06.181+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:06.181+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:06.291+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:06.291+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:06.301+0900 E/RESOURCED(  497): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 19:48:06.401+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:06.401+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:06.511+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:06.511+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:06.616+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:06.616+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:06.721+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:06.721+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:06.826+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:06.826+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:06.931+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:06.931+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:07.036+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:07.036+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:07.146+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:07.146+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:07.186+0900 I/APP_CORE(  718): appcore-efl.c: __do_app(429) > [APP 718] Event: MEM_FLUSH State: PAUSED
05-29 19:48:07.251+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:07.251+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:07.361+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:07.361+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:48:07.446+0900 E/AUL     (  697): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
05-29 19:48:07.461+0900 E/AUL     (  496): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
05-29 19:48:07.461+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(2098) > Launch with legacy way : Timeout
05-29 19:48:07.471+0900 W/AUL_AMD (  496): amd_launch.c: start_process(580) > child process: 12802
05-29 19:48:07.471+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(312) > process launched, but cmdline not changed
05-29 19:48:07.471+0900 E/AUL_PAD ( 1161): launchpad.c: __real_send(253) > send failed due to EPIPE.
05-29 19:48:07.471+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(317) > send SIGKILL: No such process
05-29 19:48:07.601+0900 E/AUL_AMD (  496): amd_launch.c: __check_cmdline(520) > error founded when being launched with 12802
05-29 19:48:07.651+0900 W/AUL_AMD (  496): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 12802
05-29 19:48:07.656+0900 E/AUL_AMD (  496): amd_launch.c: __real_send(824) > send failed due to EPIPE.
05-29 19:48:07.656+0900 E/AUL_AMD (  496): amd_launch.c: __real_send(826) > send fail to client
05-29 19:48:07.681+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 19:48:07.681+0900 I/AUL_AMD (  496): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 12693
05-29 19:48:07.691+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 19:48:07.761+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:48:07.776+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12802
05-29 19:48:07.781+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 19:48:07.791+0900 I/efl-extension(12802): efl_extension.c: eext_mod_init(40) > Init
05-29 19:48:07.806+0900 I/CAPI_APPFW_APPLICATION(12802): app_main.c: ui_app_main(704) > app_efl_main
05-29 19:48:08.036+0900 I/CAPI_APPFW_APPLICATION(12802): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-29 19:48:08.141+0900 E/TBM     (12802): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 19:48:08.296+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04600003)
05-29 19:48:08.331+0900 E/EFL     (12802): ecore_evas<12802> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-29 19:48:08.381+0900 I/efl-extension(12802): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0x43300750]'s widget[0x4271b2e8] to elm_conformant widget[0x426c8800]
05-29 19:48:08.486+0900 I/HAP     (12802): SUCCESSFULLY create sap agent
05-29 19:48:08.486+0900 I/HAP     (12802): connectivity type(1): bt
05-29 19:48:08.501+0900 E/RESOURCED( 1094): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:48:08.501+0900 E/AUL     ( 1094): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-29 19:48:08.501+0900 E/CAPI_APPFW_APP_MANAGER( 1094): app_manager.c: app_manager_error(78) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
05-29 19:48:08.656+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:48:08.656+0900 W/AUL_AMD (  496): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-29 19:48:08.676+0900 I/HAP     (12802): agent is initialized
05-29 19:48:08.676+0900 I/HAP     (12802): agent initialized callback is over
05-29 19:48:08.676+0900 I/HAP     (12802): SAP >>> getRegisteredServiceAgent() >>> 0
05-29 19:48:08.746+0900 I/APP_CORE(12802): appcore-efl.c: __do_app(429) > [APP 12802] Event: RESET State: CREATED
05-29 19:48:08.746+0900 I/CAPI_APPFW_APPLICATION(12802): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 19:48:08.776+0900 I/APP_CORE(12802): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 19:48:08.776+0900 I/APP_CORE(12802): appcore-efl.c: __do_app(474) > [APP 12802] Initial Launching, call the resume_cb
05-29 19:48:08.776+0900 I/CAPI_APPFW_APPLICATION(12802): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 19:48:08.786+0900 W/APP_CORE(12802): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4600003
05-29 19:48:08.791+0900 I/efl-extension(12802): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x43300750 = w: 0 h: 0  obj 0x4271b2e8 w: 360 h: 360
05-29 19:48:08.796+0900 I/efl-extension(12802): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 19:48:08.876+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(429) > [APP 2594] Event: PAUSE State: RUNNING
05-29 19:48:08.876+0900 I/CAPI_APPFW_APPLICATION( 2594): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 19:48:08.901+0900 I/APP_CORE(12802): appcore-efl.c: __do_app(429) > [APP 12802] Event: RESUME State: RUNNING
05-29 19:48:08.911+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:48:08.911+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 19:48:09.031+0900 I/TIZEN_N_SOUND_MANAGER(12816): sound_manager.c: sound_manager_set_session_type(155) > >> enter : type=0
05-29 19:48:09.036+0900 I/TIZEN_N_SOUND_MANAGER(12816): sound_manager.c: sound_manager_set_session_type(220) > << leave : type=0, ret=0x0
05-29 19:48:09.036+0900 I/AUL_PAD (12813): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 19:48:09.036+0900 W/TIZEN_N_SOUND_MANAGER(12816): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_set_session_type] ERROR_NONE (0x00000000)
05-29 19:48:09.036+0900 I/TIZEN_N_SOUND_MANAGER(12816): sound_manager.c: sound_manager_set_media_session_option(279) > >> enter : option for starting=1, for during play=0
05-29 19:48:09.036+0900 I/TIZEN_N_SOUND_MANAGER(12816): sound_manager.c: sound_manager_set_media_session_option(346) > << leave : updated
05-29 19:48:09.036+0900 W/TIZEN_N_SOUND_MANAGER(12816): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_set_media_session_option] ERROR_NONE (0x00000000)
05-29 19:48:09.086+0900 I/TIZEN_N_AUDIO_IO(12816): audio_io_private.c: audio_out_create_private(381) > mm_sound_pcm_play_open() success
05-29 19:48:09.086+0900 I/TIZEN_N_AUDIO_IO(12816): audio_io_private.c: audio_out_create_private(395) > mm_sound_pcm_set_message_callback() success
05-29 19:48:09.086+0900 I/TIZEN_N_AUDIO_IO(12816): audio_io.c: audio_out_set_interrupted_cb(473) > [audio_out_set_interrupted_cb] current interrupted cb (0x4000c1a1) / data ((nil))
05-29 19:48:09.261+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 19:48:09.521+0900 E/EFL     (12802): evas_main<12802> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=19394596 button=1 downs=1
05-29 19:48:09.551+0900 E/EFL     (12802): evas_main<12802> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=19394662 button=1 downs=0
05-29 19:48:09.696+0900 I/MALI    (12802): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x4154b758] swap changed from async to sync
05-29 19:48:10.461+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 19:48:10.566+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 19:48:10.681+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 19:48:10.681+0900 E/AUL_AMD (  496): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 19:48:10.691+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 697
05-29 19:48:10.751+0900 W/AUL_AMD (  496): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 12802
05-29 19:48:10.751+0900 I/APP_CORE(12802): appcore-efl.c: __do_app(429) > [APP 12802] Event: RESET State: RUNNING
05-29 19:48:10.751+0900 I/CAPI_APPFW_APPLICATION(12802): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 19:48:10.751+0900 I/APP_CORE(12802): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-29 19:48:10.751+0900 I/APP_CORE(12802): appcore-efl.c: __do_app(481) > [APP 12802] App already running, raise the window
05-29 19:48:10.776+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04600003)
05-29 19:48:10.781+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(20) , send fd(13), pid(12802), cmd(0)
05-29 19:48:10.781+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 19:48:11.781+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:48:11.781+0900 W/AUL_AMD (  496): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-29 19:48:13.906+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(429) > [APP 2594] Event: MEM_FLUSH State: PAUSED
05-29 19:48:14.321+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 19:48:14.321+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 19:48:16.116+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:48:16.206+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12802
05-29 19:48:16.576+0900 I/HAP     (12802): routes length: 21
05-29 19:48:17.496+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:48:17.496+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 19:48:17.541+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(429) > [APP 2594] Event: RESUME State: PAUSED
05-29 19:48:17.541+0900 I/CAPI_APPFW_APPLICATION( 2594): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 19:48:17.606+0900 W/CRASH_MANAGER(12841): worker.c: worker_job(1199) > 1112802686170146451889
