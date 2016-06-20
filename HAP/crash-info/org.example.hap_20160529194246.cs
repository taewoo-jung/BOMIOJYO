S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.5
Build-Number: R732XXU2CPC5
Build-Date: 2016.03.21 17:05:24

Crash Information
Process Name: hap
PID: 11921
Date: 2016-05-29 19:42:46+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x41b68504, r1   = 0xffffffff
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xbed71d30, r5   = 0x00000068
r6   = 0x41c97c00, r7   = 0xbed71d04
r8   = 0x429735b8, r9   = 0x40359861
r10  = 0x405014b8, fp   = 0x00000000
ip   = 0x41488a20, sp   = 0xbed71af8
lr   = 0x40413070, pc   = 0x40413090
cpsr = 0x40000010

Memory Information
MemTotal:   489992 KB
MemFree:     11808 KB
Buffers:     19640 KB
Cached:     117472 KB
VmPeak:      75380 KB
VmSize:      72920 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18592 KB
VmRSS:       18592 KB
VmData:      40524 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       28068 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 11921 TID = 11921
11921 11928 11929 11932 

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
41877000 4187a000 rwxp [stack:11929]
4187a000 4187e000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41885000 41886000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41886000 4188a000 rwxs /dev/mali
4188b000 4188d000 r-xp /usr/lib/libdri2.so.0.0.0
41894000 41895000 rwxp /usr/lib/libdri2.so.0.0.0
41895000 4189d000 r-xp /usr/lib/libdrm.so.2.4.0
418a4000 418a5000 rwxp /usr/lib/libdrm.so.2.4.0
418a5000 418ac000 r-xp /usr/lib/libtbm.so.1.0.0
418b3000 418b4000 rwxp /usr/lib/libtbm.so.1.0.0
418b4000 418b6000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
418b6000 41968000 rwxp [heap]
41968000 41b68000 r-xp /usr/share/locale/locale-archive
41b68000 41c99000 r-xp /usr/share/locale/locale-archive
41d99000 41ee1000 r-xp /usr/lib/egl/libMali.so
41ee1000 41ee6000 rwxp /usr/lib/egl/libMali.so
41ee6000 41ee9000 r-xp /usr/lib/libnative-buffer.so.0.1.0
41ef0000 41ef1000 rwxp /usr/lib/libnative-buffer.so.0.1.0
41ef2000 426f1000 rwxp [stack:11928]
426f1000 426f9000 rwxs /dev/mali
426f9000 42701000 rwxs /dev/mali
42701000 42715000 r-xs /opt/home/app/.cache/evas_gl_common_caches/ARM::OpenGL
42715000 42719000 rwxs /dev/mali
42719000 4271d000 rwxs /dev/mali
4271d000 42725000 rwxs /dev/mali
42725000 4272d000 rwxs /dev/mali
4272d000 428cc000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
428cc000 428e3000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
428eb000 428f0000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
428f0000 428f7000 r-xs /usr/lib/gconv/gconv-modules.cache
429f8000 429fa000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
42a01000 42a02000 rwxp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43281000 43284000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
43284000 43288000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
43288000 43297000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
43297000 432d7000 rwxs /dev/mali
432eb000 432ef000 rwxs /dev/mali
432ef000 432f3000 rwxs /dev/mali
432f3000 432f7000 rwxs /dev/mali
43c00000 43c24000 rwxs /dev/mali
43c24000 43c48000 rwxs /dev/mali
43c48000 43c6c000 rwxs /dev/mali
43cf5000 43d81000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
43d81000 43e0c000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
43e0d000 4460c000 rwxp [stack:11932]
4460c000 4468e000 rwxs /dev/dri/card0
4468e000 4478e000 rwxs /dev/mali
bed52000 bed73000 rwxp [stack]
End of Maps Information

Callstack Information (PID:11921)
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
ntrol-service-message-port]
05-29 19:42:36.021+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-29 19:42:36.021+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-29 19:42:36.021+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 19:42:36.026+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 19:42:36.026+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 19:42:36.026+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 19:42:36.026+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-29 19:42:36.026+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-29 19:42:36.026+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 19:42:36.026+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-29 19:42:36.026+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 19:42:36.026+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 19:42:36.026+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 19:42:36.026+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 19:42:36.026+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-29 19:42:36.026+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-29 19:42:36.026+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 19:42:36.026+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-29 19:42:36.026+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-29 19:42:36.026+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-29 19:42:36.026+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 19:42:36.031+0900 W/W_HOME  (  718): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
05-29 19:42:36.031+0900 E/W_HOME  (  718): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-29 19:42:36.056+0900 I/CAPI_WATCH_APPLICATION(  755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 19:42:36.056+0900 E/watchface-loader(  755): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 19:42:36.071+0900 I/GESTURE (  144): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
05-29 19:42:36.071+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), block(2)
05-29 19:42:36.071+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), ev->cur.canvas.x(56) ev->cur.canvas.y(213)
05-29 19:42:36.071+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), hold(0) freeze(0)
05-29 19:42:36.071+0900 E/EFL     (  718): evas_main<718> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=19061591 button=1 downs=1
05-29 19:42:36.081+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), block(2)
05-29 19:42:36.081+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), ev->cur.canvas.x(59) ev->cur.canvas.y(212)
05-29 19:42:36.081+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), hold(0) freeze(0)
05-29 19:42:36.096+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), block(2)
05-29 19:42:36.096+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), ev->cur.canvas.x(60) ev->cur.canvas.y(211)
05-29 19:42:36.096+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), hold(0) freeze(0)
05-29 19:42:36.106+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), block(2)
05-29 19:42:36.106+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), ev->cur.canvas.x(61) ev->cur.canvas.y(210)
05-29 19:42:36.106+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), hold(0) freeze(0)
05-29 19:42:36.116+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), block(2)
05-29 19:42:36.116+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), ev->cur.canvas.x(66) ev->cur.canvas.y(208)
05-29 19:42:36.116+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), hold(0) freeze(0)
05-29 19:42:36.141+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), block(2)
05-29 19:42:36.146+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), ev->cur.canvas.x(76) ev->cur.canvas.y(208)
05-29 19:42:36.146+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), hold(0) freeze(0)
05-29 19:42:36.151+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), block(2)
05-29 19:42:36.151+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), ev->cur.canvas.x(88) ev->cur.canvas.y(208)
05-29 19:42:36.151+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), hold(0) freeze(0)
05-29 19:42:36.151+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), block(2)
05-29 19:42:36.156+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), ev->cur.canvas.x(103) ev->cur.canvas.y(209)
05-29 19:42:36.156+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), hold(0) freeze(0)
05-29 19:42:36.156+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:4250 _elm_scroll_mouse_move_event_cb() [DDO] animator
05-29 19:42:36.156+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3354 _elm_scroll_post_event_move() [DDO] obj(45c93cc8), type(elm_scroller)
05-29 19:42:36.156+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3355 _elm_scroll_post_event_move() [DDO] hold_parent(0)
05-29 19:42:36.156+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3383 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(45c93cc8), type(elm_scroller)
05-29 19:42:36.166+0900 W/W_HOME  (  718): home_navigation.c: _is_rightedge(188) > (360 360) not right edge: 0 0 0x45ce3ac0 -> 360 0 0x466be558
05-29 19:42:36.171+0900 W/W_HOME  (  718): event_manager.c: _home_scroll_cb(564) > scroll,start
05-29 19:42:36.171+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), block(2)
05-29 19:42:36.171+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), ev->cur.canvas.x(122) ev->cur.canvas.y(212)
05-29 19:42:36.176+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), hold(0) freeze(0)
05-29 19:42:36.176+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), block(2)
05-29 19:42:36.176+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), ev->cur.canvas.x(148) ev->cur.canvas.y(214)
05-29 19:42:36.176+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), hold(0) freeze(0)
05-29 19:42:36.176+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3618 _elm_scroll_hold_animator() [DDO] obj(45c93cc8), locked_x(0)
05-29 19:42:36.176+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3844 _elm_scroll_hold_animator() [DDO] obj(45c93cc8)
05-29 19:42:36.176+0900 W/W_HOME  (  718): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
05-29 19:42:36.176+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 19:42:36.181+0900 I/ELM_RPANEL(  718): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 19:42:36.186+0900 E/W_HOME  (  718): page_indicator.c: page_indicator_item_at(248) > (index < 0 || index >= PAGE_INDICATOR_MAX) -> page_indicator_item_at() return
05-29 19:42:36.196+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4474) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
05-29 19:42:36.236+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), block(2)
05-29 19:42:36.236+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), ev->cur.canvas.x(173) ev->cur.canvas.y(215)
05-29 19:42:36.236+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), hold(0) freeze(0)
05-29 19:42:36.241+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), block(2)
05-29 19:42:36.241+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), ev->cur.canvas.x(192) ev->cur.canvas.y(219)
05-29 19:42:36.241+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), hold(0) freeze(0)
05-29 19:42:36.241+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), block(2)
05-29 19:42:36.246+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), ev->cur.canvas.x(202) ev->cur.canvas.y(228)
05-29 19:42:36.246+0900 I/CAPI_WATCH_APPLICATION(  755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 19:42:36.246+0900 E/watchface-loader(  755): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 19:42:36.246+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), hold(0) freeze(0)
05-29 19:42:36.246+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), block(2)
05-29 19:42:36.246+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), ev->cur.canvas.x(202) ev->cur.canvas.y(231)
05-29 19:42:36.246+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), hold(0) freeze(0)
05-29 19:42:36.251+0900 E/EFL     (  718): evas_main<718> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=19061744 button=1 downs=0
05-29 19:42:36.251+0900 E/EFL     (  718): elementary<718> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c93cc8), type(elm_scroller)
05-29 19:42:36.256+0900 W/W_HOME  (  718): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
05-29 19:42:36.256+0900 I/ELM_RPANEL(  718): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 19:42:36.271+0900 I/wnotib  (  718): w-notification-board-panel-basic.c: _wnotib_basic_panel_activate(2700) > page_index: 0.
05-29 19:42:36.271+0900 W/W_HOME  (  718): noti_broker.c: _handler_indicator_select(581) > 0
05-29 19:42:36.271+0900 W/W_HOME  (  718): noti_broker.c: _handler_indicator_select(591) > select index:1
05-29 19:42:36.276+0900 W/W_HOME  (  718): noti_broker.c: _handler_indicator_show(541) > 
05-29 19:42:36.276+0900 W/W_HOME  (  718): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:0x49ce5478
05-29 19:42:36.276+0900 W/wnotib  (  718): w-notification-board-panel-basic.c: _wnotib_basic_panel_activate(2710) > Hide home indicator.
05-29 19:42:36.276+0900 W/W_HOME  (  718): noti_broker.c: _handler_noti_indicator_hide(498) > 
05-29 19:42:36.281+0900 E/wnoti-service(  859): wnoti-server-mgr-stub.c: __wnoti_change_new_flag_stub(2327) > change_type : 0, value : 0
05-29 19:42:36.291+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 19:42:36.296+0900 I/ELM_RPANEL(  718): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 19:42:36.306+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
05-29 19:42:36.316+0900 I/ELM_RPANEL(  718): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 19:42:36.316+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
05-29 19:42:36.321+0900 E/AUL_AMD (  496): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 19:42:36.321+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 11908
05-29 19:42:36.326+0900 W/AUL_AMD (  496): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 2594
05-29 19:42:36.331+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(429) > [APP 2594] Event: RESET State: PAUSED
05-29 19:42:36.331+0900 I/CAPI_APPFW_APPLICATION( 2594): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 19:42:36.336+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(2594), cmd(0)
05-29 19:42:36.346+0900 I/ELM_RPANEL(  718): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 19:42:36.356+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-29 19:42:36.356+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(481) > [APP 2594] App already running, raise the window
05-29 19:42:36.366+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04400002)
05-29 19:42:36.371+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(485) > [APP 2594] Call the resume_cb
05-29 19:42:36.371+0900 I/CAPI_APPFW_APPLICATION( 2594): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 19:42:36.371+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:42:36.371+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 19:42:36.381+0900 W/wnotib  (  718): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-29 19:42:36.386+0900 I/efl-extension(  718): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c93cc8 : elm_scroller] CurrentPage(0)
05-29 19:42:36.396+0900 W/WATCH_CORE(  755): appcore-watch.c: __widget_pause(1001) > widget_pause
05-29 19:42:36.396+0900 E/watchface-loader(  755): watchface-loader.cpp: OnAppPause(713) > 
05-29 19:42:36.396+0900 E/watchface-viewer(  755): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 19:42:36.396+0900 E/watchface-viewer(  755): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 19:42:36.396+0900 E/watchface-viewer(  755): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 19:42:36.396+0900 E/watchface-viewer(  755): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 19:42:36.396+0900 E/watchface-viewer(  755): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 19:42:36.396+0900 E/watchface-viewer(  755): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-29 19:42:36.506+0900 W/W_HOME  (  718): event_manager.c: _home_scroll_cb(564) > scroll,done
05-29 19:42:36.521+0900 W/W_HOME  (  718): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-29 19:42:36.521+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 19:42:36.521+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 19:42:36.521+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 19:42:36.521+0900 W/W_HOME  (  718): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-29 19:42:36.541+0900 I/MALI    (  718): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-29 19:42:36.561+0900 W/W_HOME  (  718): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-29 19:42:36.561+0900 W/W_HOME  (  718): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-29 19:42:36.566+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 19:42:36.566+0900 W/W_HOME  (  718): event_manager.c: _state_control(333) > appcore paused manually
05-29 19:42:36.566+0900 W/W_HOME  (  718): main.c: home_appcore_pause(717) > Home Appcore Paused
05-29 19:42:36.566+0900 W/W_HOME  (  718): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-29 19:42:36.566+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 19:42:36.571+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 19:42:36.571+0900 W/W_HOME  (  718): main.c: home_pause(751) > clock/widget paused
05-29 19:42:36.571+0900 W/W_HOME  (  718): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 19:42:36.571+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 19:42:36.571+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 19:42:36.571+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 19:42:36.571+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-29 19:42:36.571+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-29 19:42:36.571+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 19:42:36.571+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-29 19:42:36.571+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 19:42:36.576+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 19:42:36.576+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 19:42:36.576+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 19:42:36.576+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-29 19:42:36.576+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-29 19:42:36.576+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 19:42:36.576+0900 I/MESSAGE_PORT(  456): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-29 19:42:36.576+0900 I/MESSAGE_PORT(  456): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-29 19:42:36.576+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-29 19:42:36.576+0900 I/MESSAGE_PORT(  456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 19:42:36.576+0900 E/CAPI_APPFW_APP_CONTROL( 1053): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-29 19:42:36.576+0900 W/MUSIC_CONTROL_SERVICE( 1053): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1053]   [com.samsung.w-home]register msg port [false][0m
05-29 19:42:36.581+0900 W/W_HOME  (  718): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-29 19:42:36.581+0900 I/APP_CORE(  718): appcore-efl.c: __do_app(429) > [APP 718] Event: PAUSE State: RUNNING
05-29 19:42:36.581+0900 I/CAPI_APPFW_APPLICATION(  718): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 19:42:36.581+0900 W/W_HOME  (  718): main.c: _appcore_pause_cb(690) > appcore pause
05-29 19:42:36.581+0900 E/W_HOME  (  718): main.c: _pause_cb(668) > paused already
05-29 19:42:36.606+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(429) > [APP 2594] Event: RESUME State: RUNNING
05-29 19:42:36.656+0900 I/wnotib  (  718): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-29 19:42:36.656+0900 E/wnotib  (  718): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 19:42:36.681+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 19:42:36.691+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 19:42:36.706+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 19:42:36.706+0900 E/AUL_AMD (  496): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 19:42:36.706+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 697
05-29 19:42:36.716+0900 E/RESOURCED(  497): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-29 19:42:36.716+0900 E/RESOURCED(  497): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 19:42:36.721+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(2080) > pad pid(-5)
05-29 19:42:36.721+0900 W/AUL_PAD ( 1161): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-29 19:42:36.721+0900 W/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(272) > Check app launching
05-29 19:42:36.726+0900 E/AUL_PAD (11810): launchpad_loader.c: __candidate_process_prepare_exec(259) > fail to set privileges - check your package's credential : -1
05-29 19:42:36.726+0900 E/AUL_PAD (11810): launchpad_loader.c: __candidate_process_launchpad_main_loop(402) > __candidate_process_prepare_exec() failed
05-29 19:42:36.766+0900 E/EFL     ( 2594): evas_main<2594> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=19062279 button=1 downs=1
05-29 19:42:36.791+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:36.791+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:36.891+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:36.891+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:36.926+0900 E/EFL     ( 2594): evas_main<2594> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=19062444 button=1 downs=0
05-29 19:42:36.986+0900 W/W_HOME  (  718): noti_broker.c: _handler_indicator_hide(552) > 
05-29 19:42:36.986+0900 W/W_HOME  (  718): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
05-29 19:42:36.991+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:36.991+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:37.081+0900 I/APP_CORE(  718): appcore-efl.c: __do_app(429) > [APP 718] Event: MEM_FLUSH State: PAUSED
05-29 19:42:37.091+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:37.091+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:37.196+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:37.196+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:37.296+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:37.296+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:37.396+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:37.396+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:37.496+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:37.496+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:37.596+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:37.596+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:37.696+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:37.696+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:37.796+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:37.796+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:37.901+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:37.901+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:38.001+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:38.001+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:38.101+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:38.101+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:38.201+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:38.201+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:38.306+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:38.311+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:38.416+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:38.416+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:38.416+0900 E/RESOURCED(  497): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 19:42:38.526+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:38.526+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:38.636+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:38.636+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:38.741+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:38.741+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:38.846+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:38.846+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:38.956+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:38.956+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:38.966+0900 E/RESOURCED(  497): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 19:42:39.066+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:39.066+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:39.171+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:39.171+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:39.276+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:39.276+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:39.386+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:39.386+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:39.501+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:39.501+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:39.611+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:39.611+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:39.716+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:39.716+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:39.821+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:39.821+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:39.926+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:39.926+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:40.031+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:40.031+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:40.141+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:40.141+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:40.156+0900 E/RESOURCED(  497): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 19:42:40.246+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:40.246+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:40.356+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:40.356+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:40.461+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:40.461+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:40.566+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:40.566+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:40.671+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:40.671+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:40.776+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:40.776+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:40.891+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:40.891+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:40.906+0900 E/RESOURCED(  497): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 19:42:40.996+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:40.996+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:41.001+0900 E/RESOURCED(  497): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-29 19:42:41.106+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:41.106+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:41.211+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:41.211+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:41.316+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:41.316+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:41.421+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:41.421+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:41.526+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:41.526+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:41.586+0900 I/APP_CORE(  718): appcore-efl.c: __do_app(429) > [APP 718] Event: MEM_FLUSH State: PAUSED
05-29 19:42:41.631+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:41.631+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:41.736+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:41.736+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:41.846+0900 E/RESOURCED( 1161): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:41.846+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-29 19:42:41.881+0900 E/AUL     (  697): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
05-29 19:42:41.921+0900 E/AUL     (  496): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
05-29 19:42:41.921+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(2098) > Launch with legacy way : Timeout
05-29 19:42:41.931+0900 W/AUL_AMD (  496): amd_launch.c: start_process(580) > child process: 11921
05-29 19:42:41.946+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(312) > process launched, but cmdline not changed
05-29 19:42:41.946+0900 E/AUL_PAD ( 1161): launchpad.c: __real_send(253) > send failed due to EPIPE.
05-29 19:42:41.946+0900 E/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(317) > send SIGKILL: No such process
05-29 19:42:42.086+0900 W/AUL_AMD (  496): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 11921
05-29 19:42:42.086+0900 E/AUL_AMD (  496): amd_launch.c: __real_send(824) > send failed due to EPIPE.
05-29 19:42:42.086+0900 E/AUL_AMD (  496): amd_launch.c: __real_send(826) > send fail to client
05-29 19:42:42.086+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:42:42.111+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11921
05-29 19:42:42.146+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 19:42:42.146+0900 I/AUL_AMD (  496): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 11810
05-29 19:42:42.156+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:42:42.171+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11921
05-29 19:42:42.171+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 19:42:42.171+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 19:42:42.221+0900 I/efl-extension(11921): efl_extension.c: eext_mod_init(40) > Init
05-29 19:42:42.241+0900 I/CAPI_APPFW_APPLICATION(11921): app_main.c: ui_app_main(704) > app_efl_main
05-29 19:42:42.481+0900 I/CAPI_APPFW_APPLICATION(11921): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-29 19:42:42.581+0900 E/TBM     (11921): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 19:42:42.731+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04600003)
05-29 19:42:42.741+0900 E/EFL     (11921): ecore_evas<11921> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-29 19:42:42.821+0900 I/efl-extension(11921): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0x429489f0]'s widget[0x4293d560] to elm_conformant widget[0x41d4f7b0]
05-29 19:42:42.916+0900 I/HAP     (11921): SUCCESSFULLY create sap agent
05-29 19:42:42.921+0900 I/HAP     (11921): connectivity type(1): bt
05-29 19:42:42.981+0900 E/RESOURCED( 1094): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-29 19:42:43.006+0900 E/AUL     ( 1094): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-29 19:42:43.006+0900 E/CAPI_APPFW_APP_MANAGER( 1094): app_manager.c: app_manager_error(78) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
05-29 19:42:43.086+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:42:43.086+0900 W/AUL_AMD (  496): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-29 19:42:43.121+0900 I/HAP     (11921): agent is initialized
05-29 19:42:43.121+0900 I/HAP     (11921): agent initialized callback is over
05-29 19:42:43.121+0900 I/HAP     (11921): SAP >>> getRegisteredServiceAgent() >>> 0
05-29 19:42:43.191+0900 I/APP_CORE(11921): appcore-efl.c: __do_app(429) > [APP 11921] Event: RESET State: CREATED
05-29 19:42:43.196+0900 I/CAPI_APPFW_APPLICATION(11921): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 19:42:43.221+0900 I/APP_CORE(11921): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 19:42:43.221+0900 I/APP_CORE(11921): appcore-efl.c: __do_app(474) > [APP 11921] Initial Launching, call the resume_cb
05-29 19:42:43.221+0900 I/CAPI_APPFW_APPLICATION(11921): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 19:42:43.231+0900 W/APP_CORE(11921): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4600003
05-29 19:42:43.241+0900 I/efl-extension(11921): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x429489f0 = w: 0 h: 0  obj 0x4293d560 w: 360 h: 360
05-29 19:42:43.246+0900 I/efl-extension(11921): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 19:42:43.316+0900 I/APP_CORE( 2594): appcore-efl.c: __do_app(429) > [APP 2594] Event: PAUSE State: RUNNING
05-29 19:42:43.316+0900 I/CAPI_APPFW_APPLICATION( 2594): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 19:42:43.316+0900 I/APP_CORE(11921): appcore-efl.c: __do_app(429) > [APP 11921] Event: RESUME State: RUNNING
05-29 19:42:43.341+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:42:43.341+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 19:42:43.391+0900 I/AUL_PAD (11933): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 19:42:43.726+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 19:42:43.761+0900 I/MALI    (11921): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x419569a8] swap changed from async to sync
05-29 19:42:44.896+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 19:42:45.006+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 19:42:45.041+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 19:42:45.041+0900 E/AUL_AMD (  496): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 19:42:45.046+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 697
05-29 19:42:45.091+0900 W/AUL_AMD (  496): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 11921
05-29 19:42:45.091+0900 I/APP_CORE(11921): appcore-efl.c: __do_app(429) > [APP 11921] Event: RESET State: RUNNING
05-29 19:42:45.091+0900 I/CAPI_APPFW_APPLICATION(11921): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 19:42:45.091+0900 I/APP_CORE(11921): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-29 19:42:45.091+0900 I/APP_CORE(11921): appcore-efl.c: __do_app(481) > [APP 11921] App already running, raise the window
05-29 19:42:45.111+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04600003)
05-29 19:42:45.116+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(11921), cmd(0)
05-29 19:42:45.116+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 19:42:46.116+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:42:46.116+0900 W/AUL_AMD (  496): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-29 19:42:46.736+0900 W/CRASH_MANAGER(11944): worker.c: worker_job(1199) > 1111921686170146451856
