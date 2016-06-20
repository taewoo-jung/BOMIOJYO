S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.5
Build-Number: R732XXU2CPC5
Build-Date: 2016.03.21 17:05:24

Crash Information
Process Name: hap
PID: 2009
Date: 2016-05-29 20:06:09+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x10

Register Information
r0   = 0x00000010, r1   = 0x00000010
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0x400054ea
r6   = 0xbea51768, r7   = 0x00000010
r8   = 0x00000020, r9   = 0x41488a30
r10  = 0x400054cb, fp   = 0xbea5175c
ip   = 0x00000000, sp   = 0xbea511f8
lr   = 0x4041b5b8, pc   = 0x4044edc4
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     14368 KB
Buffers:     13608 KB
Cached:     163412 KB
VmPeak:      77180 KB
VmSize:      74720 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19232 KB
VmRSS:       19232 KB
VmData:      42244 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       28084 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 2009 TID = 2009
2009 2010 2011 2015 

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
417ef000 419ef000 r-xp /usr/share/locale/locale-archive
419ef000 41b20000 r-xp /usr/share/locale/locale-archive
41b20000 41b97000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
41b9f000 41ba1000 rwxp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
41ba8000 41bab000 rwxp [stack:2011]
41bab000 41baf000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41bb6000 41bb7000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41bb7000 41bbb000 rwxs /dev/mali
41bbc000 41bbe000 r-xp /usr/lib/libdri2.so.0.0.0
41bc5000 41bc6000 rwxp /usr/lib/libdri2.so.0.0.0
41bc6000 41bce000 r-xp /usr/lib/libdrm.so.2.4.0
41bd5000 41bd6000 rwxp /usr/lib/libdrm.so.2.4.0
41bd6000 41bdd000 r-xp /usr/lib/libtbm.so.1.0.0
41be4000 41be5000 rwxp /usr/lib/libtbm.so.1.0.0
41be5000 41be8000 r-xp /usr/lib/libnative-buffer.so.0.1.0
41bef000 41bf0000 rwxp /usr/lib/libnative-buffer.so.0.1.0
41bf0000 41bf8000 rwxs /dev/mali
41bf8000 41c00000 rwxs /dev/mali
41c00000 41c14000 r-xs /opt/home/app/.cache/evas_gl_common_caches/ARM::OpenGL
41c14000 41c18000 rwxs /dev/mali
41c18000 41c1c000 rwxs /dev/mali
41c1c000 41c24000 rwxs /dev/mali
41c24000 41c2c000 rwxs /dev/mali
41c2c000 41c2e000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
41c2e000 41c45000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
41c4d000 41c52000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
41c52000 41c54000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
41c5b000 41c5c000 rwxp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
41c5c000 41c63000 r-xs /usr/lib/gconv/gconv-modules.cache
41c63000 41c66000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
41c66000 41c6a000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
41c6a000 41c79000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
41c79000 41c7d000 rwxp [heap]
41c7d000 41d4f000 rwxp [heap]
41d4f000 41e97000 r-xp /usr/lib/egl/libMali.so
41e97000 41e9c000 rwxp /usr/lib/egl/libMali.so
41e9d000 4279c000 rwxp [stack:2010]
4279c000 4293b000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
4323b000 432c7000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
432c7000 432ca000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
432d1000 432d2000 rwxp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
432d7000 432fb000 rwxs /dev/mali
432fb000 432ff000 rwxs /dev/mali
43c00000 43c40000 rwxs /dev/mali
43c40000 43c64000 rwxs /dev/mali
43c64000 43c68000 rwxs /dev/mali
43c68000 43c8c000 rwxs /dev/mali
43c8c000 43c90000 rwxs /dev/mali
43c90000 43c91000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
43c98000 43c99000 rwxp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
43cf5000 43d80000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
43d81000 44680000 rwxp [stack:2015]
44680000 44702000 rwxs /dev/dri/card0
44702000 44802000 rwxs /dev/mali
bea32000 bea53000 rwxp [stack]
End of Maps Information

Callstack Information (PID:2009)
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
) > 
05-29 20:05:38.995+0900 I/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 20:05:38.995+0900 W/W_HOME  (  725): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-29 20:05:38.995+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:05:38.995+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:05:39.010+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:05:39.010+0900 W/W_HOME  (  725): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-29 20:05:39.010+0900 W/W_HOME  (  725): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-29 20:05:39.010+0900 W/W_HOME  (  725): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-29 20:05:39.010+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:05:39.010+0900 W/W_HOME  (  725): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-29 20:05:39.015+0900 I/APP_CORE(  725): appcore-efl.c: __do_app(429) > [APP 725] Event: PAUSE State: RUNNING
05-29 20:05:39.015+0900 I/CAPI_APPFW_APPLICATION(  725): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 20:05:39.015+0900 W/W_HOME  (  725): main.c: _appcore_pause_cb(690) > appcore pause
05-29 20:05:39.015+0900 W/W_HOME  (  725): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-29 20:05:39.015+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:05:39.040+0900 I/APP_CORE( 1196): appcore-efl.c: __do_app(429) > [APP 1196] Event: RESUME State: RUNNING
05-29 20:05:39.045+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:05:39.045+0900 W/W_HOME  (  725): main.c: home_pause(751) > clock/widget paused
05-29 20:05:39.045+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:05:39.045+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 20:05:39.045+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 20:05:39.045+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 20:05:39.045+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-29 20:05:39.045+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-29 20:05:39.045+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 20:05:39.045+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-29 20:05:39.045+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 20:05:39.045+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:05:39.045+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 20:05:39.050+0900 I/MALI    ( 1195): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-29 20:05:39.050+0900 I/MALI    ( 1195): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=1195   close drm_fd=25 
05-29 20:05:39.050+0900 I/MALI    ( 1195): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-29 20:05:39.055+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 20:05:39.060+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 20:05:39.060+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 20:05:39.060+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-29 20:05:39.060+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-29 20:05:39.060+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 20:05:39.060+0900 I/MESSAGE_PORT(  451): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-29 20:05:39.060+0900 I/MESSAGE_PORT(  451): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-29 20:05:39.060+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-29 20:05:39.060+0900 I/MESSAGE_PORT(  451): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 20:05:39.060+0900 E/CAPI_APPFW_APP_CONTROL( 1034): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-29 20:05:39.060+0900 W/MUSIC_CONTROL_SERVICE( 1034): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1034]   [com.samsung.w-home]register msg port [false][0m
05-29 20:05:39.140+0900 I/wnotib  (  725): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-29 20:05:39.140+0900 E/wnotib  (  725): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 20:05:39.155+0900 I/UXT     ( 1195): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 20:05:39.165+0900 W/W_HOME  (  725): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-29 20:05:39.165+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:05:39.165+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:05:39.165+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:05:39.165+0900 W/W_HOME  (  725): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-29 20:05:39.265+0900 W/W_HOME  (  725): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
05-29 20:05:39.380+0900 I/efl-extension( 1195): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-29 20:05:39.420+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:05:39.460+0900 I/MALI    ( 1196): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x414f9418] swap changed from async to sync
05-29 20:05:39.560+0900 I/APP_CORE(  725): appcore-efl.c: __do_app(429) > [APP 725] Event: MEM_FLUSH State: PAUSED
05-29 20:05:39.590+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 1195
05-29 20:05:39.935+0900 I/efl-extension(  725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:05:39.935+0900 I/efl-extension( 1366): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:05:39.940+0900 I/efl-extension( 1196): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:05:39.940+0900 I/efl-extension( 1196): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x453dffa8, elm_image, time_stamp : 370569
05-29 20:05:40.040+0900 I/efl-extension(  725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:05:40.040+0900 I/efl-extension( 1366): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:05:40.045+0900 I/efl-extension( 1196): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:05:40.045+0900 I/efl-extension( 1196): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x453dffa8, elm_image, time_stamp : 370676
05-29 20:05:40.645+0900 I/efl-extension(  725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:05:40.645+0900 I/efl-extension( 1366): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:05:40.650+0900 I/efl-extension( 1196): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:05:40.655+0900 I/efl-extension( 1196): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x453dffa8, elm_image, time_stamp : 371281
05-29 20:05:40.815+0900 W/AUL_AMD (  495): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-29 20:05:41.025+0900 I/efl-extension(  725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:05:41.025+0900 I/efl-extension( 1366): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:05:41.035+0900 I/efl-extension( 1196): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 20:05:41.035+0900 I/efl-extension( 1196): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x453dffa8, elm_image, time_stamp : 371659
05-29 20:05:41.740+0900 E/EFL     ( 1196): elementary<1196> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(4456c680), block(1)
05-29 20:05:41.740+0900 E/EFL     ( 1196): elementary<1196> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(4456c680), ev->cur.canvas.x(206) ev->cur.canvas.y(188)
05-29 20:05:41.740+0900 E/EFL     ( 1196): elementary<1196> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(4456c680), hold(0) freeze(0)
05-29 20:05:41.740+0900 E/EFL     ( 1196): evas_main<1196> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=372367 button=1 downs=1
05-29 20:05:41.755+0900 E/EFL     ( 1196): elementary<1196> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(4456c680), block(1)
05-29 20:05:41.755+0900 E/EFL     ( 1196): elementary<1196> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(4456c680), ev->cur.canvas.x(208) ev->cur.canvas.y(188)
05-29 20:05:41.755+0900 E/EFL     ( 1196): elementary<1196> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(4456c680), hold(0) freeze(0)
05-29 20:05:41.760+0900 E/EFL     ( 1196): elementary<1196> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(4456c680), block(1)
05-29 20:05:41.760+0900 E/EFL     ( 1196): elementary<1196> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(4456c680), ev->cur.canvas.x(209) ev->cur.canvas.y(188)
05-29 20:05:41.760+0900 E/EFL     ( 1196): elementary<1196> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(4456c680), hold(0) freeze(0)
05-29 20:05:41.775+0900 E/EFL     ( 1196): elementary<1196> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(4456c680), block(1)
05-29 20:05:41.775+0900 E/EFL     ( 1196): elementary<1196> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(4456c680), ev->cur.canvas.x(210) ev->cur.canvas.y(188)
05-29 20:05:41.775+0900 E/EFL     ( 1196): elementary<1196> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(4456c680), hold(0) freeze(0)
05-29 20:05:41.800+0900 E/EFL     ( 1196): elementary<1196> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(4456c680), block(1)
05-29 20:05:41.800+0900 E/EFL     ( 1196): elementary<1196> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(4456c680), ev->cur.canvas.x(210) ev->cur.canvas.y(186)
05-29 20:05:41.800+0900 E/EFL     ( 1196): elementary<1196> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(4456c680), hold(0) freeze(0)
05-29 20:05:41.800+0900 E/EFL     ( 1196): evas_main<1196> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=372432 button=1 downs=0
05-29 20:05:41.845+0900 I/efl-extension( 1196): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-29 20:05:41.845+0900 I/efl-extension( 1196): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4540f530, elm_image, _activated_obj : 0x453dffa8, activated : 1
05-29 20:05:41.850+0900 I/efl-extension( 1196): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 20:05:41.875+0900 I/efl-extension( 1196): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(846) > Put the surface[0x454757e0]'s widget[0x45e52d88] to layout widget[0x4540f0b0]
05-29 20:05:41.880+0900 I/efl-extension( 1196): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x454757e0 = w: 0 h: 0  obj 0x45e52d88 w: 360 h: 360
05-29 20:05:41.885+0900 I/efl-extension( 1196): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 20:05:41.970+0900 I/W-SETTING( 1196): setting-connection.c: _gl_connections_title_get(537) > bt state : 1
05-29 20:05:42.035+0900 I/W-SETTING( 1196): setting-connection.c: _gl_connections_title_get(537) > bt state : 1
05-29 20:05:43.435+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 20:05:43.455+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
05-29 20:05:43.470+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
05-29 20:05:43.470+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 20:05:43.470+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1702) > caller pid : 2002
05-29 20:05:43.490+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2080) > pad pid(-5)
05-29 20:05:43.490+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 20:05:43.490+0900 W/AUL_PAD ( 1191): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-29 20:05:43.490+0900 W/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(272) > Check app launching
05-29 20:05:43.530+0900 I/efl-extension( 1921): efl_extension.c: eext_mod_init(40) > Init
05-29 20:05:43.530+0900 I/CAPI_APPFW_APPLICATION( 1921): app_main.c: ui_app_main(704) > app_efl_main
05-29 20:05:43.540+0900 I/CAPI_APPFW_APPLICATION( 1921): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-29 20:05:43.560+0900 E/TBM     ( 1921): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 20:05:43.580+0900 E/E17     (  379): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04400002)
05-29 20:05:43.595+0900 E/RESOURCED(  498): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.tizen.widget_viewer_sdk
05-29 20:05:43.625+0900 I/MALI    ( 1196): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x414f9418] swap changed from sync to async
05-29 20:05:43.750+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: RESET State: CREATED
05-29 20:05:43.750+0900 I/CAPI_APPFW_APPLICATION( 1921): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 20:05:43.830+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 20:05:43.830+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(474) > [APP 1921] Initial Launching, call the resume_cb
05-29 20:05:43.830+0900 I/CAPI_APPFW_APPLICATION( 1921): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 20:05:43.835+0900 W/APP_CORE( 1921): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4400002
05-29 20:05:44.065+0900 I/APP_CORE(  725): appcore-efl.c: __do_app(429) > [APP 725] Event: MEM_FLUSH State: PAUSED
05-29 20:05:44.135+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:05:44.135+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 20:05:44.145+0900 I/APP_CORE( 1196): appcore-efl.c: __do_app(429) > [APP 1196] Event: PAUSE State: RUNNING
05-29 20:05:44.145+0900 I/CAPI_APPFW_APPLICATION( 1196): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 20:05:44.155+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: RESUME State: RUNNING
05-29 20:05:44.250+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 20:05:44.265+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 20:05:44.275+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 20:05:44.275+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 20:05:44.275+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1702) > caller pid : 700
05-29 20:05:44.285+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-29 20:05:44.285+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 20:05:44.290+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2080) > pad pid(-5)
05-29 20:05:44.595+0900 W/AUL_PAD ( 1191): launchpad.c: __launchpad_main_loop(607) > Candidate is not prepared, enter legacy logic
05-29 20:05:44.595+0900 W/AUL_PAD ( 1191): launchpad.c: __send_result_to_caller(272) > Check app launching
05-29 20:05:44.595+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2091) > Launch with legacy way : no launchpad
05-29 20:05:44.595+0900 W/AUL_AMD (  495): amd_launch.c: start_process(580) > child process: 2009
05-29 20:05:44.645+0900 W/AUL_AMD (  495): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 2009
05-29 20:05:44.650+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:05:44.655+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1921
05-29 20:05:44.655+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:05:44.660+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:05:44.660+0900 E/RESOURCED(  498): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.hap
05-29 20:05:44.665+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 20:05:44.675+0900 I/efl-extension( 2009): efl_extension.c: eext_mod_init(40) > Init
05-29 20:05:44.690+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:05:44.695+0900 I/CAPI_APPFW_APPLICATION( 2009): app_main.c: ui_app_main(704) > app_efl_main
05-29 20:05:44.695+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2009
05-29 20:05:44.700+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 20:05:44.945+0900 I/AUL_PAD ( 2008): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 20:05:44.950+0900 I/CAPI_APPFW_APPLICATION( 2009): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-29 20:05:45.035+0900 E/TBM     ( 2009): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 20:05:45.205+0900 E/E17     (  379): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04e00003)
05-29 20:05:45.225+0900 E/EFL     ( 2009): ecore_evas<2009> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-29 20:05:45.290+0900 I/efl-extension( 2009): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0x4330ffc0]'s widget[0x427834f0] to elm_conformant widget[0x42731408]
05-29 20:05:45.390+0900 I/HAP     ( 2009): SUCCESSFULLY create sap agent
05-29 20:05:45.390+0900 I/HAP     ( 2009): connectivity type(1): bt
05-29 20:05:45.515+0900 I/HAP     ( 2009): agent is initialized
05-29 20:05:45.515+0900 I/HAP     ( 2009): agent initialized callback is over
05-29 20:05:45.515+0900 I/HAP     ( 2009): SAP >>> getRegisteredServiceAgent() >>> 0
05-29 20:05:45.635+0900 I/APP_CORE( 2009): appcore-efl.c: __do_app(429) > [APP 2009] Event: RESET State: CREATED
05-29 20:05:45.635+0900 I/CAPI_APPFW_APPLICATION( 2009): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 20:05:45.650+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:05:45.650+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-29 20:05:45.680+0900 I/APP_CORE( 2009): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 20:05:45.680+0900 I/APP_CORE( 2009): appcore-efl.c: __do_app(474) > [APP 2009] Initial Launching, call the resume_cb
05-29 20:05:45.680+0900 I/CAPI_APPFW_APPLICATION( 2009): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 20:05:45.690+0900 W/APP_CORE( 2009): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4e00003
05-29 20:05:45.700+0900 I/efl-extension( 2009): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x4330ffc0 = w: 0 h: 0  obj 0x427834f0 w: 360 h: 360
05-29 20:05:45.705+0900 I/efl-extension( 2009): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 20:05:45.785+0900 I/APP_CORE( 2009): appcore-efl.c: __do_app(429) > [APP 2009] Event: RESUME State: RUNNING
05-29 20:05:45.790+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: PAUSE State: RUNNING
05-29 20:05:45.790+0900 I/CAPI_APPFW_APPLICATION( 1921): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 20:05:45.805+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 20:05:45.805+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 20:05:45.990+0900 I/TIZEN_N_SOUND_MANAGER( 2017): sound_manager.c: sound_manager_set_session_type(155) > >> enter : type=0
05-29 20:05:45.990+0900 I/TIZEN_N_SOUND_MANAGER( 2017): sound_manager.c: sound_manager_set_session_type(220) > << leave : type=0, ret=0x0
05-29 20:05:45.995+0900 W/TIZEN_N_SOUND_MANAGER( 2017): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_set_session_type] ERROR_NONE (0x00000000)
05-29 20:05:45.995+0900 I/TIZEN_N_SOUND_MANAGER( 2017): sound_manager.c: sound_manager_set_media_session_option(279) > >> enter : option for starting=1, for during play=0
05-29 20:05:45.995+0900 I/TIZEN_N_SOUND_MANAGER( 2017): sound_manager.c: sound_manager_set_media_session_option(346) > << leave : updated
05-29 20:05:45.995+0900 W/TIZEN_N_SOUND_MANAGER( 2017): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_set_media_session_option] ERROR_NONE (0x00000000)
05-29 20:05:46.065+0900 I/TIZEN_N_AUDIO_IO( 2017): audio_io_private.c: audio_out_create_private(381) > mm_sound_pcm_play_open() success
05-29 20:05:46.065+0900 I/TIZEN_N_AUDIO_IO( 2017): audio_io_private.c: audio_out_create_private(395) > mm_sound_pcm_set_message_callback() success
05-29 20:05:46.065+0900 I/TIZEN_N_AUDIO_IO( 2017): audio_io.c: audio_out_set_interrupted_cb(473) > [audio_out_set_interrupted_cb] current interrupted cb (0x4000c1a1) / data ((nil))
05-29 20:05:46.180+0900 E/AUL     (  495): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 20:05:46.695+0900 I/MALI    ( 2009): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x41d3e368] swap changed from async to sync
05-29 20:05:49.165+0900 I/APP_CORE( 1196): appcore-efl.c: __do_app(429) > [APP 1196] Event: MEM_FLUSH State: PAUSED
05-29 20:05:49.660+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:05:49.735+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2009
05-29 20:05:50.280+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 20:05:50.280+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 20:05:50.290+0900 I/RESOURCED(  498): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
05-29 20:05:50.815+0900 I/APP_CORE( 1921): appcore-efl.c: __do_app(429) > [APP 1921] Event: MEM_FLUSH State: PAUSED
05-29 20:05:54.745+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:05:54.830+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2009
05-29 20:05:55.645+0900 W/WATCH_CORE(  749): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-29 20:05:55.650+0900 W/W_HOME  (  725): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-29 20:05:55.650+0900 W/W_HOME  (  725): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 20:05:55.650+0900 W/W_HOME  (  725): gesture.c: _manual_render_enable(133) > 1
05-29 20:05:55.650+0900 W/W_HOME  (  725): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-29 20:05:55.650+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:05:55.655+0900 W/STARTER (  692): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
05-29 20:05:55.655+0900 W/STARTER (  692): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-29 20:05:55.660+0900 E/STARTER (  692): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-29 20:05:55.660+0900 W/STARTER (  692): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-29 20:05:55.660+0900 W/STARTER (  692): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-29 20:05:55.690+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-29 20:05:55.695+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-29 20:05:55.695+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-29 20:05:55.700+0900 I/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-29 20:05:55.730+0900 I/watchface-viewer(  749): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
05-29 20:05:55.750+0900 I/SHealth_Common( 1097): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-29 20:05:55.840+0900 W/STARTER (  692): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
05-29 20:05:55.840+0900 W/STARTER (  692): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-29 20:05:55.840+0900 W/STARTER (  692): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-29 20:05:55.840+0900 W/STARTER (  692): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-29 20:05:55.855+0900 I/APP_CORE( 2009): appcore-efl.c: __do_app(429) > [APP 2009] Event: PAUSE State: RUNNING
05-29 20:05:55.855+0900 I/CAPI_APPFW_APPLICATION( 2009): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 20:05:55.885+0900 E/ALARM_MANAGER(  692): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(29-5-2016, 20:06:16), repeat(1), interval(20), type(-1073741822)
05-29 20:05:55.895+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:05:55.895+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:05:55.945+0900 W/MUSIC_CONTROL_SERVICE( 1034): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1034]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-29 20:05:55.965+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1130606454, next duetime: 1464519976
05-29 20:05:55.965+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1130606454)
05-29 20:05:55.965+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464519976)
05-29 20:05:55.965+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:05:55.965+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 11:06:16 (UTC).
05-29 20:05:55.965+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:05:55.970+0900 I/SHealth_Service( 1097): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-29 20:05:55.970+0900 I/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-29 20:05:55.970+0900 W/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-29 20:05:55.970+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-29 20:05:55.970+0900 I/HIGEAR  ( 1081): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-29 20:05:56.270+0900 W/MUSIC_CONTROL_SERVICE( 1034): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1034]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
05-29 20:05:56.270+0900 I/watchface-viewer(  749): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
05-29 20:05:56.295+0900 W/wnotibp ( 1366): wnotiboard-popup-view.c: _wnotibp_event_lcd_on_cb(1419) > ::APP:: view state=0, 2, 0
05-29 20:05:56.305+0900 W/WATCH_CORE(  749): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
05-29 20:05:56.305+0900 I/WATCH_CORE(  749): appcore-watch.c: __signal_lcd_status_handler(1149) > Call the time_tick_cb
05-29 20:05:56.310+0900 I/CAPI_WATCH_APPLICATION(  749): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 20:05:56.310+0900 E/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 20:05:56.310+0900 I/watchface-loader(  749): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 20:05:56.310+0900 W/W_HOME  (  725): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-29 20:05:56.310+0900 W/W_HOME  (  725): gesture.c: _manual_render_disable_timer_set(161) > timer set
05-29 20:05:56.310+0900 W/W_HOME  (  725): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 20:05:56.310+0900 W/W_HOME  (  725): gesture.c: _apps_status_get(123) > apps status:0
05-29 20:05:56.310+0900 W/W_HOME  (  725): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:0 info->offtime:736
05-29 20:05:56.310+0900 W/W_HOME  (  725): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-29 20:05:56.310+0900 W/W_HOME  (  725): event_manager.c: _lcd_on_cb(691) > lcd state: 1
05-29 20:05:56.310+0900 W/W_HOME  (  725): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 20:05:56.315+0900 W/STARTER (  692): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [unknown] after screen off time [736]ms
05-29 20:05:56.315+0900 W/STARTER (  692): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
05-29 20:05:56.335+0900 I/APP_CORE( 2009): appcore-efl.c: __do_app(429) > [APP 2009] Event: RESUME State: PAUSED
05-29 20:05:56.335+0900 I/CAPI_APPFW_APPLICATION( 2009): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 20:05:56.345+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 20:05:56.350+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 20:05:56.350+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1130606454)
05-29 20:05:56.350+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 20:05:56.350+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 20:05:56.350+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 20:05:56.350+0900 E/ALARM_MANAGER(  487): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[1130606454] is removed.
05-29 20:05:56.400+0900 I/SHealth_Common( 1097): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
05-29 20:05:56.405+0900 I/SHealth_Service( 1097): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-29 20:05:56.405+0900 W/STARTER (  692): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [unknown]
05-29 20:05:56.405+0900 W/STARTER (  692): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
05-29 20:05:56.420+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : 1075153676[0;m
05-29 20:05:56.420+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
05-29 20:05:56.420+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-29 20:05:56.420+0900 I/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_product.c: sound_manager_svoice_set_param(1248) > [SVOICE] set param [keyword length] : 0
05-29 20:05:56.425+0900 W/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-29 20:05:56.430+0900 I/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Enable start
05-29 20:05:56.465+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-29 20:05:56.465+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-29 20:05:56.465+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: preference_get_double(1214) > preference_get_double(1097) : pedometer_inactive_period error
05-29 20:05:56.465+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 20:05:56.465+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 20:05:56.465+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: preference_get_double(1214) > preference_get_double(1097) : inactive_10min_precaution_millisec error
05-29 20:05:56.465+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 20:05:56.470+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 20:05:56.470+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: preference_get_double(1214) > preference_get_double(1097) : inactive_before_10min_precaution_millisec error
05-29 20:05:56.510+0900 W/W_HOME  (  725): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
05-29 20:05:56.510+0900 W/W_HOME  (  725): gesture.c: _manual_render_enable(133) > 0
05-29 20:05:56.670+0900 I/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-29 20:05:56.670+0900 W/TIZEN_N_SOUND_MANAGER( 1081): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-29 20:05:56.670+0900 W/WAKEUP-SERVICE( 1081): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
05-29 20:05:56.670+0900 I/HIGEAR  ( 1081): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
05-29 20:05:59.660+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:05:59.730+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2009
05-29 20:06:01.375+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-29 20:06:01.375+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-29 20:06:01.380+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: preference_get_double(1214) > preference_get_double(1097) : pedometer_inactive_period error
05-29 20:06:01.405+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 20:06:01.405+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 20:06:01.410+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: preference_get_double(1214) > preference_get_double(1097) : inactive_10min_precaution_millisec error
05-29 20:06:01.425+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 20:06:01.425+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 20:06:01.425+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1097): preference.c: preference_get_double(1214) > preference_get_double(1097) : inactive_before_10min_precaution_millisec error
05-29 20:06:01.770+0900 I/watchface-viewer(  749): viewer-data-provider.cpp: AddPendingChanges(1088) > added [37] to pending list
05-29 20:06:01.780+0900 I/watchface-viewer(  749): viewer-data-provider.cpp: AddPendingChanges(1088) > added [39] to pending list
05-29 20:06:01.800+0900 I/RESOURCED(  498): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 30 -> 29 1464519961 150
05-29 20:06:01.800+0900 I/RESOURCED(  498): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 29 629 288 304
05-29 20:06:01.800+0900 I/RESOURCED(  498): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 29 0 0 1158
05-29 20:06:01.800+0900 I/RESOURCED(  498): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 29 1373 259 664
05-29 20:06:01.800+0900 I/RESOURCED(  498): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 29 179 5 87
05-29 20:06:01.800+0900 I/RESOURCED(  498): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 29 448 24 217
05-29 20:06:04.735+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 20:06:04.810+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2009
05-29 20:06:07.865+0900 E/SHealth_Common( 1097): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-29 20:06:09.275+0900 I/HAP     ( 2009): routes length: 21
05-29 20:06:09.275+0900 I/HAP     ( 2009): description: 장다리로 을 따라 162m 이동, lat: 37.27655039833677,lon: 127.03127993829892
05-29 20:06:09.275+0900 I/HAP     ( 2009): lat: 37.276550
05-29 20:06:09.275+0900 I/HAP     ( 2009): description: 우측 횡단보도 후 보행자도로 을 따라 26m 이동 , lat: 37.27795302297102,lon: 127.03180485142347
05-29 20:06:09.275+0900 I/HAP     ( 2009): lat: 37.277953
05-29 20:06:09.275+0900 I/HAP     ( 2009): description: 직진 후 중부대로 을 따라 68m 이동 , lat: 37.27791969851095,lon: 127.03208538245273
05-29 20:06:09.275+0900 I/HAP     ( 2009): lat: 37.277920
05-29 20:06:09.275+0900 I/HAP     ( 2009): description: 횡단보도 후 보행자도로 을 따라 8m 이동 , lat: 37.277830832970096,lon: 127.03281587420162
05-29 20:06:09.275+0900 I/HAP     ( 2009): lat: 37.277831
05-29 20:06:09.275+0900 I/HAP     ( 2009): description: 직진 후 중부대로 을 따라 163m 이동 , lat: 37.27781416982219,lon: 127.03290475549065
05-29 20:06:09.275+0900 I/HAP     ( 2009): lat: 37.277814
05-29 20:06:09.275+0900 I/HAP     ( 2009): description: 횡단보도 후 보행자도로 을 따라 9m 이동 , lat: 37.27737536309203,lon: 127.03465738649457
05-29 20:06:09.275+0900 I/HAP     ( 2009): lat: 37.277375
05-29 20:06:09.275+0900 I/HAP     ( 2009): description: 직진 후 중부대로 을 따라 251m 이동 , lat: 37.27734481291254,lon: 127.03476015580091
05-29 20:06:09.275+0900 I/HAP     ( 2009): lat: 37.277345
05-29 20:06:09.275+0900 I/HAP     ( 2009): description: 좌측 횡단보도 후 5m 이동 , lat: 37.27659494818776,lon: 127.03746826436145
05-29 20:06:09.275+0900 I/HAP     ( 2009): lat: 37.276595
05-29 20:06:09.275+0900 I/HAP     ( 2009): description: 좌측 횡단보도 후 보행자도로 을 따라 27m 이동 , lat: 37.276619946035844,lon: 127.03750992654794
05-29 20:06:09.275+0900 I/HAP     ( 2009): lat: 37.276620
05-29 20:06:09.275+0900 I/HAP     ( 2009): description: 우회전 후 권광로 을 따라 7m 이동 , lat: 37.27685047671701,lon: 127.03761268854973
05-29 20:06:09.275+0900 I/HAP     ( 2009): lat: 37.276850
05-29 20:06:09.275+0900 I/HAP     ( 2009): description: 횡단보도 후 9m 이동 , lat: 37.27689213964827,lon: 127.03767379295
05-29 20:06:09.275+0900 I/HAP     ( 2009): lat: 37.276892
05-29 20:06:09.275+0900 I/HAP     ( 2009): description: 직진 후 15m 이동 , lat: 37.27686436667676,lon: 127.03776267455035
05-29 20:06:09.275+0900 I/HAP     ( 2009): lat: 37.276864
05-29 20:06:09.285+0900 I/HAP     ( 2009): description: 횡단보도 후 7m 이동 , lat: 37.27681437539752,lon: 127.03792654996703
05-29 20:06:09.285+0900 I/HAP     ( 2009): lat: 37.276814
05-29 20:06:09.285+0900 I/HAP     ( 2009): description: 좌측 횡단보도 후 보행자도로 을 따라 10m 이동 , lat: 37.27678660202898,lon: 127.03799321136158
05-29 20:06:09.285+0900 I/HAP     ( 2009): lat: 37.276787
05-29 20:06:09.285+0900 I/HAP     ( 2009): description: 좌회전 후 53m 이동 , lat: 37.27683937533004,lon: 127.038084868234
05-29 20:06:09.285+0900 I/HAP     ( 2009): lat: 37.276839
05-29 20:06:09.285+0900 I/HAP     ( 2009): description: 우회전 후 권광로 을 따라 6m 이동 , lat: 37.27730598956949,lon: 127.03817651352684
05-29 20:06:09.285+0900 I/HAP     ( 2009): lat: 37.277306
05-29 20:06:09.285+0900 I/HAP     ( 2009): description: 좌회전 후 권광로340번길 을 따라 93m 이동 , lat: 37.27733098801315,lon: 127.03825150602198
05-29 20:06:09.285+0900 I/HAP     ( 2009): lat: 37.277331
05-29 20:06:09.285+0900 I/HAP     ( 2009): description: 10시 방향 좌회전 후 권광로348번길 을 따라 79m 이동 , lat: 37.27763096998274,lon: 127.03918752379786
05-29 20:06:09.285+0900 I/HAP     ( 2009): lat: 37.277631
05-29 20:06:09.285+0900 I/HAP     ( 2009): description: UBF수원 에서 좌회전 후 중부대로223번길 을 따라 14m 이동 , lat: 37.27902250807859,lon: 127.04101509678411
05-29 20:06:09.285+0900 I/HAP     ( 2009): lat: 37.279023
05-29 20:06:09.285+0900 I/HAP     ( 2009): description: 도착, lat: 37.279150270457,lon: 127.04098176289973
05-29 20:06:09.285+0900 I/HAP     ( 2009): lat: 37.279150
05-29 20:06:09.670+0900 W/CRASH_MANAGER( 2055): worker.c: worker_job(1199) > 1102009686170146451996
