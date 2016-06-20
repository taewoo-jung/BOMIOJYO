S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.5
Build-Number: R732XXU2CPC5
Build-Date: 2016.03.21 17:05:24

Crash Information
Process Name: hap
PID: 3547
Date: 2016-05-29 20:14:30+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x41aa7504, r1   = 0xffffffff
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x4000dac4, r5   = 0xbefe6d30
r6   = 0x41bd6c00, r7   = 0xbefe6d08
r8   = 0x429f0808, r9   = 0x40359861
r10  = 0x405014b8, fp   = 0x00000000
ip   = 0x41488a20, sp   = 0xbefe6af8
lr   = 0x40413070, pc   = 0x40413090
cpsr = 0x40000010

Memory Information
MemTotal:   491012 KB
MemFree:     18000 KB
Buffers:     15816 KB
Cached:     161952 KB
VmPeak:      77008 KB
VmSize:      74548 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19676 KB
VmRSS:       19676 KB
VmData:      42072 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       28084 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 3547 TID = 3547
3547 3553 3554 3557 

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
41760000 41763000 rwxp [stack:3554]
41763000 41765000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
41765000 41817000 rwxp [heap]
41817000 41834000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
4183c000 4183d000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
4183d000 4183f000 r-xp /usr/lib/libiri.so
41846000 41847000 rwxp /usr/lib/libiri.so
41847000 4184a000 r-xp /lib/libcap.so.2.21
41851000 41852000 rwxp /lib/libcap.so.2.21
41852000 41859000 r-xp /lib/libcrypt-2.13.so
41860000 41861000 r-xp /lib/libcrypt-2.13.so
41861000 41862000 rwxp /lib/libcrypt-2.13.so
41889000 4188c000 r-xp /lib/libattr.so.1.1.0
41893000 41894000 rwxp /lib/libattr.so.1.1.0
41894000 4189e000 r-xp /lib/libnss_files-2.13.so
418a5000 418a6000 r-xp /lib/libnss_files-2.13.so
418a6000 418a7000 rwxp /lib/libnss_files-2.13.so
418a7000 41aa7000 r-xp /usr/share/locale/locale-archive
41aa7000 41bd8000 r-xp /usr/share/locale/locale-archive
41cd8000 41d4f000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
41d57000 41d59000 rwxp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
41d5f000 41ea7000 r-xp /usr/lib/egl/libMali.so
41ea7000 41eac000 rwxp /usr/lib/egl/libMali.so
41eac000 41eb0000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41eb7000 41eb8000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41eb8000 41ebc000 rwxs /dev/mali
41ebc000 41ec0000 rwxs /dev/mali
41ec1000 41ec3000 r-xp /usr/lib/libdri2.so.0.0.0
41eca000 41ecb000 rwxp /usr/lib/libdri2.so.0.0.0
41ecb000 41ed3000 r-xp /usr/lib/libdrm.so.2.4.0
41eda000 41edb000 rwxp /usr/lib/libdrm.so.2.4.0
41edb000 41ee2000 r-xp /usr/lib/libtbm.so.1.0.0
41ee9000 41eea000 rwxp /usr/lib/libtbm.so.1.0.0
41eea000 41eed000 r-xp /usr/lib/libnative-buffer.so.0.1.0
41ef4000 41ef5000 rwxp /usr/lib/libnative-buffer.so.0.1.0
41ef6000 426f5000 rwxp [stack:3553]
426f5000 426fd000 rwxs /dev/mali
426fd000 42705000 rwxs /dev/mali
42705000 42719000 r-xs /opt/home/app/.cache/evas_gl_common_caches/ARM::OpenGL
42719000 4271d000 rwxs /dev/mali
4271d000 42725000 rwxs /dev/mali
42725000 4272d000 rwxs /dev/mali
4272d000 428cc000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
428cc000 428e3000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
428eb000 428f0000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
428f0000 428f7000 r-xs /usr/lib/gconv/gconv-modules.cache
429f8000 429fa000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
42a01000 42a02000 rwxp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43302000 43305000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
43305000 43309000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
43309000 43318000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
43318000 433a4000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
433a4000 433e4000 rwxs /dev/mali
433e4000 433e7000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
433ee000 433ef000 rwxp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
433ef000 433f0000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
433f7000 433f8000 rwxp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
433f8000 433fc000 rwxs /dev/mali
433fc000 43400000 rwxs /dev/mali
43d00000 43d8b000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
43d8c000 4468b000 rwxp [stack:3557]
4468b000 4470d000 rwxs /dev/dri/card0
4470d000 4480d000 rwxs /dev/mali
4480d000 44831000 rwxs /dev/mali
44831000 44855000 rwxs /dev/mali
44855000 44879000 rwxs /dev/mali
44879000 4487d000 rwxs /dev/mali
befc7000 befe8000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3547)
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
the cmdline, error: -1
05-29 20:14:01.080+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:01.085+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:01.190+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:01.190+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:01.300+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:01.300+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:01.385+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-29 20:14:01.390+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-29 20:14:01.405+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:01.405+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:01.435+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: preference_get_double(1214) > preference_get_double(1097) : pedometer_inactive_period error
05-29 20:14:01.465+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 20:14:01.470+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 20:14:01.470+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: preference_get_double(1214) > preference_get_double(1097) : inactive_10min_precaution_millisec error
05-29 20:14:01.490+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 20:14:01.490+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 20:14:01.495+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: preference_get_double(1214) > preference_get_double(1097) : inactive_before_10min_precaution_millisec error
05-29 20:14:01.505+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:01.505+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:01.610+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:01.610+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:01.715+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:01.720+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:01.825+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:01.825+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:01.930+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:01.930+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:02.035+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:02.035+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:02.140+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:02.140+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:02.245+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:02.245+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:02.350+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:02.350+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:02.455+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:02.455+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:02.565+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:02.565+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:02.570+0900 E/RESOURCED(  498): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 20:14:02.675+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:02.675+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:02.790+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:02.790+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:02.895+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:02.895+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:03.000+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:03.000+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:03.105+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:03.105+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:03.210+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:03.210+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:03.320+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:03.320+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:03.430+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:03.430+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:03.435+0900 E/RESOURCED(  498): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 20:14:03.535+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:03.535+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:03.655+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:03.655+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:03.665+0900 E/RESOURCED(  498): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 20:14:03.760+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:03.760+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:03.865+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:03.865+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:03.970+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:03.970+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:04.075+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:04.075+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:04.150+0900 I/APP_CORE(  725): appcore-efl.c: __do_app(429) > [APP 725] Event: MEM_FLUSH State: PAUSED
05-29 20:14:04.180+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:04.180+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:04.285+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:04.285+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:04.300+0900 E/RESOURCED(  498): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 20:14:04.390+0900 E/RESOURCED( 1191): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:04.390+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 20:14:04.475+0900 E/AUL     (  700): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
05-29 20:14:04.480+0900 E/AUL     (  495): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
05-29 20:14:04.480+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2098) > Launch with legacy way : Timeout
05-29 20:14:04.495+0900 W/AUL_AMD (  495): amd_launch.c: start_process(580) > child process: 3547
05-29 20:14:04.495+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(312) > process launched, but cmdline not changed
05-29 20:14:04.495+0900 E/AUL_PAD ( 1191): launchpad.c: __real_send(253) > send failed due to EPIPE.
05-29 20:14:04.495+0900 E/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(317) > send SIGKILL: No such process
05-29 20:14:04.595+0900 W/AUL_AMD (  495): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 3547
05-29 20:14:04.600+0900 E/AUL_AMD (  495): amd_launch.c: __real_send(824) > send failed due to EPIPE.
05-29 20:14:04.600+0900 E/AUL_AMD (  495): amd_launch.c: __real_send(826) > send fail to client
05-29 20:14:04.645+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:14:04.645+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3440
05-29 20:14:04.660+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:14:04.720+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:14:04.730+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3547
05-29 20:14:04.730+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 20:14:04.770+0900 I/efl-extension( 3547): efl_extension.c: eext_mod_init(40) > Init
05-29 20:14:04.790+0900 I/CAPI_APPFW_APPLICATION( 3547): app_main.c: ui_app_main(704) > app_efl_main
05-29 20:14:05.030+0900 I/CAPI_APPFW_APPLICATION( 3547): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-29 20:14:05.125+0900 E/TBM     ( 3547): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 20:14:05.280+0900 E/E17     (  379): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04600003)
05-29 20:14:05.305+0900 E/EFL     ( 3547): ecore_evas<3547> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-29 20:14:05.345+0900 I/efl-extension( 3547): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0x429430b0]'s widget[0x4293d3d8] to elm_conformant widget[0x41c8e3e0]
05-29 20:14:05.450+0900 I/HAP     ( 3547): SUCCESSFULLY create sap agent
05-29 20:14:05.450+0900 I/HAP     ( 3547): connectivity type(1): bt
05-29 20:14:05.510+0900 E/RESOURCED( 1097): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:05.510+0900 E/AUL     ( 1097): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-29 20:14:05.510+0900 E/CAPI_APPFW_APP_MANAGER( 1097): app_manager.c: app_manager_error(78) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
05-29 20:14:05.605+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:14:05.605+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-29 20:14:05.680+0900 I/HAP     ( 3547): agent is initialized
05-29 20:14:05.680+0900 I/HAP     ( 3547): agent initialized callback is over
05-29 20:14:05.680+0900 I/HAP     ( 3547): SAP >>> getRegisteredServiceAgent() >>> 0
05-29 20:14:05.755+0900 I/APP_CORE( 3547): appcore-efl.c: __do_app(429) > [APP 3547] Event: RESET State: CREATED
05-29 20:14:05.755+0900 I/CAPI_APPFW_APPLICATION( 3547): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 20:14:05.785+0900 I/APP_CORE( 3547): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 20:14:05.785+0900 I/APP_CORE( 3547): appcore-efl.c: __do_app(474) > [APP 3547] Initial Launching, call the resume_cb
05-29 20:14:05.785+0900 I/CAPI_APPFW_APPLICATION( 3547): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 20:14:05.795+0900 W/APP_CORE( 3547): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4600003
05-29 20:14:05.800+0900 I/efl-extension( 3547): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x429430b0 = w: 0 h: 0  obj 0x4293d3d8 w: 360 h: 360
05-29 20:14:05.810+0900 I/efl-extension( 3547): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 20:14:05.880+0900 I/APP_CORE( 3547): appcore-efl.c: __do_app(429) > [APP 3547] Event: RESUME State: RUNNING
05-29 20:14:05.885+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: PAUSE State: RUNNING
05-29 20:14:05.885+0900 I/CAPI_APPFW_APPLICATION( 1921): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 20:14:05.905+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:14:05.905+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 20:14:05.960+0900 I/AUL_PAD ( 3558): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 20:14:06.135+0900 E/RESOURCED( 2017): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:06.135+0900 E/AUL     ( 2017): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-29 20:14:06.170+0900 E/RESOURCED( 2017): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:06.170+0900 E/AUL     ( 2017): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-29 20:14:06.190+0900 E/RESOURCED( 2017): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:06.190+0900 E/AUL     ( 2017): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-29 20:14:06.210+0900 E/RESOURCED( 2017): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 20:14:06.210+0900 E/AUL     ( 2017): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-29 20:14:06.275+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:14:06.310+0900 I/MALI    ( 3547): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x4180f380] swap changed from async to sync
05-29 20:14:07.520+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 20:14:07.615+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 20:14:07.650+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 20:14:07.655+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 20:14:07.655+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1702) > caller pid : 700
05-29 20:14:07.700+0900 W/AUL_AMD (  495): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 3547
05-29 20:14:07.700+0900 I/APP_CORE( 3547): appcore-efl.c: __do_app(429) > [APP 3547] Event: RESET State: RUNNING
05-29 20:14:07.700+0900 I/CAPI_APPFW_APPLICATION( 3547): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 20:14:07.700+0900 I/APP_CORE( 3547): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-29 20:14:07.700+0900 I/APP_CORE( 3547): appcore-efl.c: __do_app(481) > [APP 3547] App already running, raise the window
05-29 20:14:07.715+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(3547), cmd(0)
05-29 20:14:07.715+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:14:07.730+0900 E/E17     (  379): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04600003)
05-29 20:14:07.795+0900 E/SHealth_Common( 1097): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-29 20:14:08.720+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:14:08.720+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-29 20:14:10.400+0900 W/WATCH_CORE(  749): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-29 20:14:10.405+0900 W/W_HOME  (  725): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-29 20:14:10.405+0900 W/W_HOME  (  725): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 20:14:10.405+0900 W/W_HOME  (  725): gesture.c: _manual_render_enable(133) > 1
05-29 20:14:10.405+0900 W/W_HOME  (  725): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-29 20:14:10.405+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 20:14:10.415+0900 W/STARTER (  692): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
05-29 20:14:10.415+0900 W/STARTER (  692): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-29 20:14:10.415+0900 E/STARTER (  692): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-29 20:14:10.430+0900 W/STARTER (  692): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-29 20:14:10.430+0900 W/STARTER (  692): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-29 20:14:10.465+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-29 20:14:10.480+0900 I/watchface-viewer(  749): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
05-29 20:14:10.510+0900 I/SHealth_Common( 1097): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-29 20:14:10.510+0900 W/STARTER (  692): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
05-29 20:14:10.510+0900 W/STARTER (  692): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-29 20:14:10.510+0900 W/STARTER (  692): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-29 20:14:10.510+0900 W/STARTER (  692): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-29 20:14:10.530+0900 I/APP_CORE( 3547): appcore-efl.c: __do_app(429) > [APP 3547] Event: PAUSE State: RUNNING
05-29 20:14:10.530+0900 I/CAPI_APPFW_APPLICATION( 3547): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 20:14:10.585+0900 E/ALARM_MANAGER(  692): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(29-5-2016, 20:14:31), repeat(1), interval(20), type(-1073741822)
05-29 20:14:10.600+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:14:10.600+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:14:10.625+0900 W/MUSIC_CONTROL_SERVICE( 1034): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1034]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-29 20:14:10.640+0900 I/SHealth_Service( 1097): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-29 20:14:10.650+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-29 20:14:10.655+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-29 20:14:10.655+0900 I/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-29 20:14:10.680+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1984943511, next duetime: 1464520471
05-29 20:14:10.680+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1984943511)
05-29 20:14:10.680+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464520471)
05-29 20:14:10.680+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:14:10.680+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 11:14:31 (UTC).
05-29 20:14:10.685+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:14:10.725+0900 I/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-29 20:14:10.725+0900 W/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-29 20:14:10.730+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-29 20:14:10.730+0900 I/HIGEAR  ( 1081): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-29 20:14:10.885+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: MEM_FLUSH State: PAUSED
05-29 20:14:12.370+0900 I/SHealth_Common( 1097): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
05-29 20:14:12.380+0900 I/watchface-viewer(  749): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
05-29 20:14:12.410+0900 W/wnotibp ( 1366): wnotiboard-popup-view.c: _wnotibp_event_lcd_on_cb(1419) > ::APP:: view state=0, 2, 0
05-29 20:14:12.435+0900 W/WATCH_CORE(  749): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
05-29 20:14:12.435+0900 I/WATCH_CORE(  749): appcore-watch.c: __signal_lcd_status_handler(1149) > Call the time_tick_cb
05-29 20:14:12.435+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:14:12.435+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:14:12.435+0900 I/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 20:14:12.440+0900 W/W_HOME  (  725): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-29 20:14:12.440+0900 W/W_HOME  (  725): gesture.c: _manual_render_disable_timer_set(161) > timer set
05-29 20:14:12.440+0900 W/W_HOME  (  725): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 20:14:12.440+0900 W/W_HOME  (  725): gesture.c: _apps_status_get(123) > apps status:0
05-29 20:14:12.440+0900 W/W_HOME  (  725): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:0 info->offtime:2087
05-29 20:14:12.440+0900 W/W_HOME  (  725): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-29 20:14:12.440+0900 W/W_HOME  (  725): event_manager.c: _lcd_on_cb(691) > lcd state: 1
05-29 20:14:12.440+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 20:14:12.450+0900 W/STARTER (  692): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [unknown] after screen off time [2087]ms
05-29 20:14:12.450+0900 W/STARTER (  692): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
05-29 20:14:12.490+0900 W/MUSIC_CONTROL_SERVICE( 1034): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1034]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
05-29 20:14:12.505+0900 I/APP_CORE( 3547): appcore-efl.c: __do_app(429) > [APP 3547] Event: RESUME State: PAUSED
05-29 20:14:12.505+0900 I/CAPI_APPFW_APPLICATION( 3547): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 20:14:12.535+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : 1075153676[0;m
05-29 20:14:12.535+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
05-29 20:14:12.535+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-29 20:14:12.535+0900 I/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_product.c: sound_manager_svoice_set_param(1248) > [SVOICE] set param [keyword length] : 0
05-29 20:14:12.545+0900 W/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-29 20:14:12.545+0900 I/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Enable start
05-29 20:14:12.570+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:14:12.575+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:14:12.575+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1984943511)
05-29 20:14:12.575+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:14:12.575+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 20:14:12.575+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:14:12.575+0900 E/ALARM_MANAGER(  487): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[1984943511] is removed.
05-29 20:14:12.585+0900 W/STARTER (  692): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [unknown]
05-29 20:14:12.585+0900 W/STARTER (  692): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
05-29 20:14:12.600+0900 I/SHealth_Service( 1097): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-29 20:14:12.640+0900 W/W_HOME  (  725): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
05-29 20:14:12.640+0900 W/W_HOME  (  725): gesture.c: _manual_render_enable(133) > 0
05-29 20:14:12.655+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-29 20:14:12.655+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-29 20:14:12.660+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: preference_get_double(1214) > preference_get_double(1097) : pedometer_inactive_period error
05-29 20:14:12.660+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 20:14:12.660+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 20:14:12.660+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: preference_get_double(1214) > preference_get_double(1097) : inactive_10min_precaution_millisec error
05-29 20:14:12.660+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 20:14:12.660+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 20:14:12.660+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: preference_get_double(1214) > preference_get_double(1097) : inactive_before_10min_precaution_millisec error
05-29 20:14:12.720+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:14:12.730+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3547
05-29 20:14:12.775+0900 I/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-29 20:14:12.775+0900 W/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-29 20:14:12.775+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
05-29 20:14:12.775+0900 I/HIGEAR  ( 1081): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
05-29 20:14:12.825+0900 I/efl-extension( 1196): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:14:12.825+0900 I/efl-extension(  725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:14:12.825+0900 I/efl-extension( 1366): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:14:17.750+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:14:17.830+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3547
05-29 20:14:22.820+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:14:22.895+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3547
05-29 20:14:27.030+0900 W/WATCH_CORE(  749): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-29 20:14:27.035+0900 W/W_HOME  (  725): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-29 20:14:27.040+0900 W/W_HOME  (  725): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 20:14:27.040+0900 W/W_HOME  (  725): gesture.c: _manual_render_enable(133) > 1
05-29 20:14:27.040+0900 W/W_HOME  (  725): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-29 20:14:27.040+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 20:14:27.050+0900 W/STARTER (  692): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
05-29 20:14:27.050+0900 W/STARTER (  692): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-29 20:14:27.055+0900 E/STARTER (  692): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-29 20:14:27.055+0900 W/STARTER (  692): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-29 20:14:27.060+0900 W/STARTER (  692): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-29 20:14:27.100+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-29 20:14:27.100+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-29 20:14:27.110+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-29 20:14:27.110+0900 I/watchface-viewer(  749): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
05-29 20:14:27.110+0900 W/MUSIC_CONTROL_SERVICE( 1034): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1034]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-29 20:14:27.125+0900 I/SHealth_Common( 1097): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-29 20:14:27.125+0900 I/SHealth_Service( 1097): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-29 20:14:27.130+0900 I/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-29 20:14:27.140+0900 W/STARTER (  692): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
05-29 20:14:27.140+0900 W/STARTER (  692): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-29 20:14:27.140+0900 W/STARTER (  692): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-29 20:14:27.140+0900 W/STARTER (  692): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-29 20:14:27.160+0900 I/APP_CORE( 3547): appcore-efl.c: __do_app(429) > [APP 3547] Event: PAUSE State: RUNNING
05-29 20:14:27.160+0900 I/CAPI_APPFW_APPLICATION( 3547): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 20:14:27.200+0900 E/ALARM_MANAGER(  692): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(29-5-2016, 20:14:47), repeat(1), interval(20), type(-1073741822)
05-29 20:14:27.210+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:14:27.215+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:14:27.240+0900 I/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-29 20:14:27.240+0900 W/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-29 20:14:27.240+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-29 20:14:27.240+0900 I/HIGEAR  ( 1081): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-29 20:14:27.270+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 37736169, next duetime: 1464520487
05-29 20:14:27.270+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(37736169)
05-29 20:14:27.270+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464520487)
05-29 20:14:27.270+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:14:27.270+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 11:14:47 (UTC).
05-29 20:14:27.270+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:14:27.730+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:14:27.810+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3547
05-29 20:14:28.160+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:14:28.165+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:14:28.180+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1873440025)
05-29 20:14:28.180+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:14:28.180+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 11:14:47 (UTC).
05-29 20:14:28.180+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:14:28.180+0900 E/ALARM_MANAGER(  487): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[1873440025] is removed.
05-29 20:14:28.235+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:14:28.235+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:14:28.265+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:14:28.295+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:14:28.315+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:14:28.330+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:14:28.330+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-29 20:14:28.335+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-29 20:14:28.350+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:14:28.370+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:14:28.370+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464520472, Sun May 29 20:14:32 2016
05-29 20:14:28.370+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1890759223, next duetime: 1464520472
05-29 20:14:28.370+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1890759223)
05-29 20:14:28.370+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464520487), due_time(1464520472)
05-29 20:14:28.370+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:14:28.375+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 11:14:32 (UTC).
05-29 20:14:28.375+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:14:28.385+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:14:28.385+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:14:28.385+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1890759223)
05-29 20:14:28.385+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:14:28.385+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 11:14:47 (UTC).
05-29 20:14:28.385+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:14:28.390+0900 E/ALARM_MANAGER(  487): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[1890759223] is removed.
05-29 20:14:28.400+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:14:28.400+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:14:28.415+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:14:28.430+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:14:28.445+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:14:28.455+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:14:28.455+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-29 20:14:28.455+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-29 20:14:28.470+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:14:28.485+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-29 20:14:28.485+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464563668, Mon May 30 08:14:28 2016
05-29 20:14:28.485+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1890759223, next duetime: 1464563668
05-29 20:14:28.485+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1890759223)
05-29 20:14:28.485+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464520487), due_time(1464563668)
05-29 20:14:28.485+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:14:28.485+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 11:14:47 (UTC).
05-29 20:14:28.485+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:14:30.415+0900 I/HAP     ( 3547): routes length: 21
05-29 20:14:30.420+0900 I/HAP     ( 3547): lat: 37.277
05-29 20:14:30.420+0900 I/HAP     ( 3547): lon: 127.031
05-29 20:14:30.420+0900 I/HAP     ( 3547): lat: 37.278
05-29 20:14:30.420+0900 I/HAP     ( 3547): lon: 127.032
05-29 20:14:30.420+0900 I/HAP     ( 3547): lat: 37.278
05-29 20:14:30.420+0900 I/HAP     ( 3547): lon: 127.032
05-29 20:14:30.420+0900 I/HAP     ( 3547): lat: 37.278
05-29 20:14:30.420+0900 I/HAP     ( 3547): lon: 127.033
05-29 20:14:30.420+0900 I/HAP     ( 3547): lat: 37.278
05-29 20:14:30.420+0900 I/HAP     ( 3547): lon: 127.033
05-29 20:14:30.420+0900 I/HAP     ( 3547): lat: 37.277
05-29 20:14:30.420+0900 I/HAP     ( 3547): lon: 127.035
05-29 20:14:30.420+0900 I/HAP     ( 3547): lat: 37.277
05-29 20:14:30.420+0900 I/HAP     ( 3547): lon: 127.035
05-29 20:14:30.420+0900 I/HAP     ( 3547): lat: 37.277
05-29 20:14:30.420+0900 I/HAP     ( 3547): lon: 127.037
05-29 20:14:30.420+0900 I/HAP     ( 3547): lat: 37.277
05-29 20:14:30.420+0900 I/HAP     ( 3547): lon: 127.038
05-29 20:14:30.420+0900 I/HAP     ( 3547): lat: 37.277
05-29 20:14:30.420+0900 I/HAP     ( 3547): lon: 127.038
05-29 20:14:30.420+0900 I/HAP     ( 3547): lat: 37.277
05-29 20:14:30.420+0900 I/HAP     ( 3547): lon: 127.038
05-29 20:14:30.420+0900 I/HAP     ( 3547): lat: 37.277
05-29 20:14:30.420+0900 I/HAP     ( 3547): lon: 127.038
05-29 20:14:30.420+0900 I/HAP     ( 3547): lat: 37.277
05-29 20:14:30.420+0900 I/HAP     ( 3547): lon: 127.038
05-29 20:14:30.420+0900 I/HAP     ( 3547): lat: 37.277
05-29 20:14:30.420+0900 I/HAP     ( 3547): lon: 127.038
05-29 20:14:30.420+0900 I/HAP     ( 3547): lat: 37.277
05-29 20:14:30.420+0900 I/HAP     ( 3547): lon: 127.038
05-29 20:14:30.420+0900 I/HAP     ( 3547): lat: 37.277
05-29 20:14:30.420+0900 I/HAP     ( 3547): lon: 127.038
05-29 20:14:30.420+0900 I/HAP     ( 3547): lat: 37.277
05-29 20:14:30.420+0900 I/HAP     ( 3547): lon: 127.038
05-29 20:14:30.420+0900 I/HAP     ( 3547): lat: 37.278
05-29 20:14:30.420+0900 I/HAP     ( 3547): lon: 127.039
05-29 20:14:30.420+0900 I/HAP     ( 3547): lat: 37.279
05-29 20:14:30.420+0900 I/HAP     ( 3547): lon: 127.041
05-29 20:14:30.420+0900 I/HAP     ( 3547): lat: 37.279
05-29 20:14:30.420+0900 I/HAP     ( 3547): lon: 127.041
05-29 20:14:30.825+0900 W/CRASH_MANAGER( 3615): worker.c: worker_job(1199) > 1103547686170146452047
