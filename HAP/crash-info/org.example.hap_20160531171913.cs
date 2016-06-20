S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.5
Build-Number: R732XXU2CPC5
Build-Date: 2016.03.21 17:05:24

Crash Information
Process Name: hap
PID: 1561
Date: 2016-05-31 17:19:13+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x14

Register Information
r0   = 0x45814850, r1   = 0x45814850
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x4469d9b0, r5   = 0x4469bfd8
r6   = 0x4469da50, r7   = 0x00000026
r8   = 0x00000000, r9   = 0x00000000
r10  = 0x00000049, fp   = 0x4469da54
ip   = 0x4036bcec, sp   = 0xbe9d2b48
lr   = 0x404981e8, pc   = 0x402dd6a6
cpsr = 0x20000030

Memory Information
MemTotal:   491012 KB
MemFree:     12340 KB
Buffers:     11276 KB
Cached:      92684 KB
VmPeak:     215336 KB
VmSize:     212556 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       30292 KB
VmRSS:       30288 KB
VmData:     138204 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       59316 KB
VmPTE:         102 KB
VmSwap:          0 KB

Threads Information
Threads: 16
PID = 1561 TID = 1561
1561 1563 1564 1568 1569 1570 1593 1594 1606 1607 1608 1609 1610 1611 1612 1613 

Maps Information
40000000 40008000 r-xp /opt/usr/apps/org.example.hap/bin/hap
4000f000 40010000 rwxp /opt/usr/apps/org.example.hap/bin/hap
40011000 4002e000 r-xp /lib/ld-2.13.so
40035000 40036000 r-xp /lib/ld-2.13.so
40036000 40037000 rwxp /lib/ld-2.13.so
40037000 4003b000 r-xp /usr/lib/libsys-assert.so
40043000 40044000 rwxp /usr/lib/libsys-assert.so
40044000 4004f000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
40057000 40058000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
40059000 4005b000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
40063000 40064000 rwxp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
40064000 40068000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4006f000 40070000 rwxp /usr/lib/libcapi-appfw-application.so.0.3.2.5
40070000 40078000 r-xp /usr/lib/libcapi-media-recorder.so.0.1.27
4007f000 40080000 rwxp /usr/lib/libcapi-media-recorder.so.0.1.27
40080000 40085000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
4008c000 4008d000 rwxp /usr/lib/libcapi-system-device.so.0.1.0
4008d000 40092000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
40099000 4009a000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
4009a000 4009c000 r-xp /usr/lib/libdlog.so.0.0.0
400a3000 400a4000 rwxp /usr/lib/libdlog.so.0.0.0
400a4000 400bb000 r-xp /usr/lib/libecore.so.1.7.99
400c3000 400c4000 rwxp /usr/lib/libecore.so.1.7.99
400d2000 400f3000 r-xp /usr/lib/libefl-extension.so.0.1.0
400fa000 400fb000 rwxp /usr/lib/libefl-extension.so.0.1.0
400fb000 4013c000 r-xp /usr/lib/libeina.so.1.7.99
40143000 40145000 rwxp /usr/lib/libeina.so.1.7.99
40145000 4027f000 r-xp /usr/lib/libelementary.so.1.7.99
40286000 4028e000 rwxp /usr/lib/libelementary.so.1.7.99
40295000 40363000 r-xp /usr/lib/libevas.so.1.7.99
4036b000 40375000 rwxp /usr/lib/libevas.so.1.7.99
40388000 4039a000 r-xp /usr/lib/libtts.so
403a1000 403a2000 rwxp /usr/lib/libtts.so
403a2000 403af000 r-xp /usr/lib/libsap-client-stub-api.so.1.0.0
403b6000 403b7000 rwxp /usr/lib/libsap-client-stub-api.so.1.0.0
403b7000 40420000 r-xp /lib/libm-2.13.so
40427000 40428000 r-xp /lib/libm-2.13.so
40428000 40429000 rwxp /lib/libm-2.13.so
40429000 40544000 r-xp /lib/libc-2.13.so
4054c000 4054e000 r-xp /lib/libc-2.13.so
4054e000 4054f000 rwxp /lib/libc-2.13.so
40552000 4055d000 r-xp /lib/libunwind.so.8.0.1
40564000 40565000 rwxp /lib/libunwind.so.8.0.1
4058a000 4058c000 r-xp /lib/libdl-2.13.so
40593000 40594000 r-xp /lib/libdl-2.13.so
40594000 40595000 rwxp /lib/libdl-2.13.so
40595000 4059d000 r-xp /lib/libgcc_s-4.6.so.1
4059d000 4059e000 rwxp /lib/libgcc_s-4.6.so.1
4059e000 405aa000 r-xp /usr/lib/libaul.so.0.1.0
405b2000 405b3000 rwxp /usr/lib/libaul.so.0.1.0
405b4000 405d6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
405dd000 405de000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
405de000 405f2000 r-xp /lib/libpthread-2.13.so
405f9000 405fa000 r-xp /lib/libpthread-2.13.so
405fa000 405fb000 rwxp /lib/libpthread-2.13.so
405fd000 40601000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
40609000 4060a000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4060a000 4060f000 r-xp /usr/lib/libappcore-efl.so.1.1
40616000 40617000 rwxp /usr/lib/libappcore-efl.so.1.1
40617000 4061c000 r-xp /usr/lib/libappcore-common.so.1.1
40623000 40624000 rwxp /usr/lib/libappcore-common.so.1.1
40624000 40636000 r-xp /usr/lib/libcapi-media-camera.so.0.1.34
4063d000 4063e000 rwxp /usr/lib/libcapi-media-camera.so.0.1.34
4063e000 40697000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
4069f000 406a5000 rwxp /usr/lib/libmmfcamcorder.so.0.0.0
406a5000 40740000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
40748000 4074b000 rwxp /usr/lib/libgstreamer-0.10.so.0.30.0
4074c000 40752000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
4075a000 4075b000 rwxp /usr/lib/libcapi-base-common.so.0.1.8
4075b000 4075f000 r-xp /usr/lib/libvconf.so.0.2.45
40766000 40767000 rwxp /usr/lib/libvconf.so.0.2.45
40767000 40837000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40837000 40838000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
40838000 4090b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40912000 40916000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
40916000 4094a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40951000 40953000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
40953000 40955000 r-xp /usr/lib/libiniparser.so.0
4095d000 4095e000 rwxp /usr/lib/libiniparser.so.0
4095e000 40a2a000 r-xp /usr/lib/libxml2.so.2.7.8
40a31000 40a36000 rwxp /usr/lib/libxml2.so.2.7.8
40a37000 40a3d000 r-xp /lib/librt-2.13.so
40a44000 40a45000 r-xp /lib/librt-2.13.so
40a45000 40a46000 rwxp /lib/librt-2.13.so
40a46000 40a96000 r-xp /usr/lib/libecore_x.so.1.7.99
40a96000 40a98000 rwxp /usr/lib/libecore_x.so.1.7.99
40a98000 40af5000 r-xp /usr/lib/libedje.so.1.7.99
40afd000 40aff000 rwxp /usr/lib/libedje.so.1.7.99
40aff000 40bb7000 r-xp /usr/lib/libcairo.so.2.11200.14
40bbe000 40bc1000 rwxp /usr/lib/libcairo.so.2.11200.14
40bc2000 40ca3000 r-xp /usr/lib/libX11.so.6.3.0
40caa000 40cae000 rwxp /usr/lib/libX11.so.6.3.0
40cae000 40cb7000 r-xp /usr/lib/libXi.so.6.1.0
40cbe000 40cbf000 rwxp /usr/lib/libXi.so.6.1.0
40cbf000 40ce7000 r-xp /usr/lib/libfontconfig.so.1.8.0
40ce7000 40ce8000 rwxp /usr/lib/libfontconfig.so.1.8.0
40ce8000 40d01000 r-xp /usr/lib/libeet.so.1.7.99
40d09000 40d0a000 rwxp /usr/lib/libeet.so.1.7.99
40d12000 40d34000 r-xp /usr/lib/libecore_evas.so.1.7.99
40d3b000 40d3d000 rwxp /usr/lib/libecore_evas.so.1.7.99
40d3d000 40d42000 r-xp /usr/lib/libecore_file.so.1.7.99
40d49000 40d4a000 rwxp /usr/lib/libecore_file.so.1.7.99
40d4a000 40d5b000 r-xp /usr/lib/libecore_input.so.1.7.99
40d62000 40d63000 rwxp /usr/lib/libecore_input.so.1.7.99
40d63000 40d6c000 r-xp /usr/lib/libedbus.so.1.7.99
40d73000 40d74000 rwxp /usr/lib/libedbus.so.1.7.99
40d74000 40d9e000 r-xp /usr/lib/libdbus-1.so.3.8.12
40da6000 40da7000 rwxp /usr/lib/libdbus-1.so.3.8.12
40da7000 40dc1000 r-xp /usr/lib/libecore_con.so.1.7.99
40dc8000 40dc9000 rwxp /usr/lib/libecore_con.so.1.7.99
40dca000 40ddd000 r-xp /usr/lib/libfribidi.so.0.3.1
40de4000 40de5000 rwxp /usr/lib/libfribidi.so.0.3.1
40de5000 40e22000 r-xp /usr/lib/libharfbuzz.so.0.940.0
40e29000 40e2a000 rwxp /usr/lib/libharfbuzz.so.0.940.0
40e2b000 40e81000 r-xp /usr/lib/libfreetype.so.6.11.3
40e89000 40e8d000 rwxp /usr/lib/libfreetype.so.6.11.3
40e8d000 40ee3000 r-xp /usr/lib/libpixman-1.so.0.28.2
40eeb000 40ef0000 rwxp /usr/lib/libpixman-1.so.0.28.2
40ef0000 40ef8000 r-xp /usr/lib/libsap_client.so.0.0.0
40eff000 40f00000 rwxp /usr/lib/libsap_client.so.0.0.0
40f00000 40f03000 r-xp /usr/lib/libbundle.so.0.1.22
40f0a000 40f0b000 rwxp /usr/lib/libbundle.so.0.1.22
40f0b000 40f22000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40f29000 40f2a000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
40f2a000 40f2f000 r-xp /usr/lib/libxdgmime.so.1.1.0
40f36000 40f37000 rwxp /usr/lib/libxdgmime.so.1.1.0
40f37000 40f73000 r-xp /usr/lib/libsystemd.so.0.4.0
40f7a000 40f7b000 r-xp /usr/lib/libsystemd.so.0.4.0
40f7b000 40f7c000 rwxp /usr/lib/libsystemd.so.0.4.0
40f7c000 40f7f000 r-xp /usr/lib/libproc-stat.so.0.2.86
40f86000 40f87000 rwxp /usr/lib/libproc-stat.so.0.2.86
40f87000 40f9d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40fa4000 40fa5000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
40fa5000 4101a000 r-xp /usr/lib/libsqlite3.so.0.8.6
41021000 41024000 rwxp /usr/lib/libsqlite3.so.0.8.6
41024000 4102a000 r-xp /usr/lib/libappsvc.so.0.1.0
41031000 41032000 rwxp /usr/lib/libappsvc.so.0.1.0
41032000 41038000 r-xp /usr/lib/libecore_imf.so.1.7.99
4103f000 41040000 rwxp /usr/lib/libecore_imf.so.1.7.99
41040000 41045000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
4104c000 4104d000 rwxp /usr/lib/libcapi-media-tool.so.0.1.5
4104d000 41054000 r-xp /usr/lib/libtbm.so.1.0.0
4105b000 4105c000 rwxp /usr/lib/libtbm.so.1.0.0
4105c000 41069000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
41071000 41072000 rwxp /usr/lib/libgstinterfaces-0.10.so.0.25.0
41072000 4107b000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
41082000 41083000 rwxp /usr/lib/libgstapp-0.10.so.0.25.0
41083000 410a4000 r-xp /usr/lib/libexif.so.12.3.3
410ab000 410b7000 rwxp /usr/lib/libexif.so.12.3.3
410b7000 410cd000 r-xp /usr/lib/libmmfsound.so.0.1.0
410d5000 410d6000 rwxp /usr/lib/libmmfsound.so.0.1.0
410df000 410e4000 r-xp /usr/lib/libmmfsession.so.0.0.0
410eb000 410ec000 rwxp /usr/lib/libmmfsession.so.0.0.0
410ec000 41124000 r-xp /usr/lib/libpulse.so.0.16.2
41124000 41125000 rwxp /usr/lib/libpulse.so.0.16.2
41125000 41127000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
4112e000 4112f000 rwxp /usr/lib/libcamsrcjpegenc.so.0.0.0
4112f000 41134000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
4113b000 4113c000 rwxp /usr/lib/libmmutil_imgp.so.0.0.0
4113c000 41155000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
4115d000 4115e000 rwxp /usr/lib/libprivacy-manager-client.so.0.0.7
4115e000 41168000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
41170000 41171000 rwxp /usr/lib/libaudio-session-mgr.so.0.0.0
41175000 4117c000 r-xp /usr/lib/libmmfcommon.so.0.0.0
41183000 41184000 rwxp /usr/lib/libmmfcommon.so.0.0.0
41184000 411b5000 r-xp /usr/lib/libmdm.so.1.1.85
411bc000 411bd000 rwxp /usr/lib/libmdm.so.1.1.85
411bd000 411bf000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
411c6000 411c7000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
411c7000 411c8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
411cf000 411d0000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
411d0000 411d5000 r-xp /usr/lib/libffi.so.5.0.10
411dc000 411dd000 rwxp /usr/lib/libffi.so.5.0.10
411de000 411f4000 r-xp /lib/libz.so.1.2.5
411fb000 411fc000 rwxp /lib/libz.so.1.2.5
411fc000 4120c000 r-xp /lib/libresolv-2.13.so
4120c000 4120d000 r-xp /lib/libresolv-2.13.so
4120d000 4120e000 rwxp /lib/libresolv-2.13.so
41210000 41217000 r-xp /usr/lib/libXcursor.so.1.0.2
4121e000 4121f000 rwxp /usr/lib/libXcursor.so.1.0.2
4121f000 41221000 r-xp /usr/lib/libXdamage.so.1.1.0
41228000 41229000 rwxp /usr/lib/libXdamage.so.1.1.0
41229000 4122b000 r-xp /usr/lib/libXcomposite.so.1.0.0
41232000 41233000 rwxp /usr/lib/libXcomposite.so.1.0.0
41234000 41236000 r-xp /usr/lib/libXgesture.so.7.0.0
4123d000 4123e000 rwxp /usr/lib/libXgesture.so.7.0.0
4123e000 41241000 r-xp /usr/lib/libXfixes.so.3.1.0
41248000 41249000 rwxp /usr/lib/libXfixes.so.3.1.0
41249000 4124a000 r-xp /usr/lib/libXinerama.so.1.0.0
41252000 41253000 rwxp /usr/lib/libXinerama.so.1.0.0
41253000 41259000 r-xp /usr/lib/libXrandr.so.2.2.0
41260000 41261000 rwxp /usr/lib/libXrandr.so.2.2.0
41261000 41267000 r-xp /usr/lib/libXrender.so.1.3.0
4126e000 4126f000 rwxp /usr/lib/libXrender.so.1.3.0
4126f000 41273000 r-xp /usr/lib/libXtst.so.6.1.0
4127a000 4127b000 rwxp /usr/lib/libXtst.so.6.1.0
4127c000 41286000 r-xp /usr/lib/libXext.so.6.4.0
4128e000 4128f000 rwxp /usr/lib/libXext.so.6.4.0
4128f000 41296000 r-xp /usr/lib/libembryo.so.1.7.99
4129d000 4129e000 rwxp /usr/lib/libembryo.so.1.7.99
4129e000 412b5000 r-xp /usr/lib/liblua-5.1.so
412bd000 412be000 rwxp /usr/lib/liblua-5.1.so
412be000 412bf000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
412c6000 412c7000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
412c7000 412d5000 r-xp /usr/lib/libGLESv2.so.2.0
412dd000 412de000 rwxp /usr/lib/libGLESv2.so.2.0
412df000 412f7000 r-xp /usr/lib/libpng12.so.0.50.0
412fe000 412ff000 rwxp /usr/lib/libpng12.so.0.50.0
412ff000 41300000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41308000 41309000 rwxp /usr/lib/libxcb-shm.so.0.0.0
41309000 4130f000 r-xp /usr/lib/libxcb-render.so.0.0.0
41316000 41317000 rwxp /usr/lib/libxcb-render.so.0.0.0
41317000 4132a000 r-xp /usr/lib/libxcb.so.1.1.0
41332000 41333000 rwxp /usr/lib/libxcb.so.1.1.0
41333000 41336000 r-xp /usr/lib/libEGL.so.1.4
4133d000 4133e000 rwxp /usr/lib/libEGL.so.1.4
4133f000 41355000 r-xp /lib/libexpat.so.1.5.2
4135d000 4135f000 rwxp /lib/libexpat.so.1.5.2
4135f000 41382000 r-xp /usr/lib/libjpeg.so.8.0.2
41389000 4138a000 rwxp /usr/lib/libjpeg.so.8.0.2
4139a000 4139f000 r-xp /usr/lib/libecore_fb.so.1.7.99
413a6000 413a8000 rwxp /usr/lib/libecore_fb.so.1.7.99
413a8000 413ac000 r-xp /usr/lib/libecore_ipc.so.1.7.99
413b4000 413b5000 rwxp /usr/lib/libecore_ipc.so.1.7.99
413b5000 413b8000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
413bf000 413c0000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
413c1000 41405000 r-xp /usr/lib/libcurl.so.4.3.0
4140c000 4140e000 rwxp /usr/lib/libcurl.so.4.3.0
4140e000 41426000 r-xp /usr/lib/liblzma.so.5.0.3
4142d000 4142e000 rwxp /usr/lib/liblzma.so.5.0.3
4142e000 414aa000 r-xp /usr/lib/libgcrypt.so.20.0.3
414b1000 414b6000 rwxp /usr/lib/libgcrypt.so.20.0.3
414b6000 414b8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
414c0000 414c1000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
414c1000 414c3000 r-xp /usr/lib/journal/libjournal.so.0.1.0
414ca000 414cb000 rwxp /usr/lib/journal/libjournal.so.0.1.0
414cc000 414d4000 r-xp /usr/lib/libdrm.so.2.4.0
414db000 414dc000 rwxp /usr/lib/libdrm.so.2.4.0
414dc000 4151d000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
41525000 41526000 rwxp /usr/lib/libgstbase-0.10.so.0.30.0
41526000 4152a000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
41532000 41533000 rwxp /usr/lib/libmmfsoundcommon.so.0.0.0
41533000 41549000 r-xp /usr/lib/libavsysaudio.so.0.0.1
41551000 41552000 rwxp /usr/lib/libavsysaudio.so.0.0.1
41552000 41557000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
4155e000 4155f000 rwxp /usr/lib/libascenario-0.2.so.0.0.0
41560000 41563000 r-xp /usr/lib/libpulse-simple.so.0.0.4
4156a000 4156b000 rwxp /usr/lib/libpulse-simple.so.0.0.4
4156b000 415cc000 r-xp /usr/lib/libasound.so.2.0.0
415d3000 415d6000 rwxp /usr/lib/libasound.so.2.0.0
415d6000 415d9000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
415e0000 415e1000 rwxp /usr/lib/libsyspopup_caller.so.0.1.0
415e1000 415ee000 r-xp /usr/lib/libail.so.0.1.0
415f6000 415f7000 rwxp /usr/lib/libail.so.0.1.0
415f7000 41734000 r-xp /usr/lib/libicui18n.so.51.1
4173c000 41744000 rwxp /usr/lib/libicui18n.so.51.1
41745000 41829000 r-xp /usr/lib/libicuuc.so.51.1
41830000 4183a000 rwxp /usr/lib/libicuuc.so.51.1
4183e000 42dbd000 r-xp /usr/lib/libicudata.so.51.1
42dc4000 42dc5000 rwxp /usr/lib/libicudata.so.51.1
42dc5000 42dd5000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
42dd5000 42dd9000 rwxp /usr/lib/lib_SamsungRec_TizenV04014.so
42df6000 42dfe000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
42e05000 42e06000 rwxp /usr/lib/lib_DNSe_NRSS_ver225.so
42e0d000 42e12000 r-xp /usr/lib/libjson.so.0.0.1
42e19000 42e1a000 rwxp /usr/lib/libjson.so.0.0.1
42e1b000 42e63000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
42e63000 42e64000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
42e64000 42ea7000 r-xp /usr/lib/libsndfile.so.1.0.25
42eae000 42eb0000 rwxp /usr/lib/libsndfile.so.1.0.25
42eb4000 42ee1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
42ee8000 42ee9000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
42ee9000 42f36000 r-xp /usr/lib/libssl.so.1.0.0
42f3d000 42f42000 rwxp /usr/lib/libssl.so.1.0.0
42f42000 430ea000 r-xp /usr/lib/libcrypto.so.1.0.0
430ea000 430ff000 rwxp /usr/lib/libcrypto.so.1.0.0
43104000 43107000 r-xp /usr/lib/libsmack.so.1.0.0
4310e000 4310f000 rwxp /usr/lib/libsmack.so.1.0.0
4310f000 43115000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4311c000 4311d000 rwxp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4311d000 43125000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4312c000 4312d000 rwxp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4312d000 43132000 r-xp /usr/lib/libcsc-feature.so.0.0.0
43139000 4313a000 rwxp /usr/lib/libcsc-feature.so.0.0.0
4313a000 431ce000 r-xp /usr/lib/libstdc++.so.6.0.16
431d6000 431d9000 r-xp /usr/lib/libstdc++.so.6.0.16
431d9000 431db000 rwxp /usr/lib/libstdc++.so.6.0.16
431e2000 431ea000 r-xp /usr/lib/libmdm-common.so.1.0.89
431ea000 431eb000 rwxp /usr/lib/libmdm-common.so.1.0.89
431eb000 431ed000 r-xp /usr/lib/libXau.so.6.0.0
431f4000 431f5000 rwxp /usr/lib/libXau.so.6.0.0
431f5000 431fe000 r-xp /usr/lib/libcares.so.2.1.0
43206000 43207000 rwxp /usr/lib/libcares.so.2.1.0
43208000 43236000 r-xp /usr/lib/libidn.so.11.5.44
4323d000 4323e000 rwxp /usr/lib/libidn.so.11.5.44
4323e000 43249000 r-xp /usr/lib/libgpg-error.so.0.15.0
43250000 43251000 rwxp /usr/lib/libgpg-error.so.0.15.0
43251000 43254000 r-xp /usr/lib/libcompress.so.0.2.0
4325b000 4325c000 rwxp /usr/lib/libcompress.so.0.2.0
4325d000 4327f000 r-xp /usr/lib/libvorbis.so.0.4.3
43286000 43287000 rwxp /usr/lib/libvorbis.so.0.4.3
43287000 4328b000 r-xp /usr/lib/libogg.so.0.7.1
43292000 43293000 rwxp /usr/lib/libogg.so.0.7.1
43293000 432b0000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
432b8000 432b9000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
432b9000 432d5000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
432dd000 432de000 rwxp /usr/lib/libpkgmgr-client.so.0.1.68
432df000 432e1000 r-xp /usr/lib/libiri.so
432e8000 432e9000 rwxp /usr/lib/libiri.so
432e9000 432ec000 r-xp /lib/libcap.so.2.21
432f3000 432f4000 rwxp /lib/libcap.so.2.21
432f4000 432fb000 r-xp /lib/libcrypt-2.13.so
43302000 43303000 r-xp /lib/libcrypt-2.13.so
43303000 43304000 rwxp /lib/libcrypt-2.13.so
4332b000 43332000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4333a000 4333b000 rwxp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4333b000 4333d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43344000 43345000 rwxp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43346000 4334d000 r-xp /usr/lib/libminizip.so.1.0.0
43354000 43355000 rwxp /usr/lib/libminizip.so.1.0.0
43355000 43358000 r-xp /lib/libattr.so.1.1.0
4335f000 43360000 rwxp /lib/libattr.so.1.1.0
43467000 43531000 r-xp /usr/lib/libCOREGL.so.4.0
43539000 4353b000 rwxp /usr/lib/libCOREGL.so.4.0
43543000 43567000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
4356e000 43570000 rwxp /usr/lib/ecore/immodules/libisf-imf-module.so
43570000 4363f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
43646000 43655000 rwxp /usr/lib/libscim-1.0.so.8.2.3
43655000 4365f000 r-xp /lib/libnss_files-2.13.so
43666000 43667000 r-xp /lib/libnss_files-2.13.so
43667000 43668000 rwxp /lib/libnss_files-2.13.so
43668000 43868000 r-xp /usr/share/locale/locale-archive
43868000 43999000 r-xp /usr/share/locale/locale-archive
43999000 43a10000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
43a18000 43a1a000 rwxp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
43a20000 43b68000 r-xp /usr/lib/egl/libMali.so
43b68000 43b6d000 rwxp /usr/lib/egl/libMali.so
43b6e000 43b71000 rwxp [stack:1564]
43b71000 43b75000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43b7c000 43b7d000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43b7d000 43b81000 rwxs /dev/mali
43b82000 43b84000 r-xp /usr/lib/libdri2.so.0.0.0
43b8b000 43b8c000 rwxp /usr/lib/libdri2.so.0.0.0
43b8c000 43b8f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43b96000 43b97000 rwxp /usr/lib/libnative-buffer.so.0.1.0
43b98000 44397000 rwxp [stack:1563]
44397000 4439f000 rwxs /dev/mali
4439f000 443a7000 rwxs /dev/mali
443a7000 443bb000 r-xs /opt/home/app/.cache/evas_gl_common_caches/ARM::OpenGL
444bb000 444bf000 rwxs /dev/mali
444bf000 444c3000 rwxs /dev/mali
444c3000 444cb000 rwxs /dev/mali
444cb000 444d3000 rwxs /dev/mali
444d3000 444d5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
444d5000 44674000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
44674000 4468b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44693000 44698000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44798000 4479a000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
447a1000 447a2000 rwxp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
447a3000 44fa2000 rwxp [stack:1594]
44fa3000 457a2000 rwxp [stack:1593]
457a2000 457a9000 r-xs /usr/lib/gconv/gconv-modules.cache
457a9000 457ac000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
457ac000 457b0000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
457b0000 457bf000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
457bf000 457c0000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
457c7000 457c8000 rwxp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
457c8000 457cc000 rwxs /dev/mali
457cc000 457dc000 rwxs /dev/mali
457dc000 45800000 rwxs /dev/mali
45900000 4592c000 rwxs /dev/mali
4592c000 4593c000 rwxs /dev/mali
4593c000 4593d000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45944000 45945000 rwxp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45945000 45946000 r-xp /usr/lib/gstreamer-0.10/libgstapp.so
4594d000 4594e000 rwxp /usr/lib/gstreamer-0.10/libgstapp.so
4594e000 45951000 r-xp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
45958000 45959000 rwxp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
4595a000 45961000 r-xp /usr/lib/libfeedback.so.0.1.4
45969000 4596a000 rwxp /usr/lib/libfeedback.so.0.1.4
4596c000 45970000 rwxs /dev/mali
45970000 45994000 rwxs /dev/mali
45994000 45998000 rwxs /dev/mali
45998000 459bc000 rwxs /dev/mali
459bc000 459c0000 rwxs /dev/mali
459c0000 459c1000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
459c8000 459c9000 rwxp /usr/lib/libmmfkeysound.so.0.0.0
459c9000 459cb000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
459d2000 459d3000 rwxp /usr/lib/libcapi-media-wav-player.so.0.1.10
459d3000 459dd000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
459e4000 459e5000 rwxp /usr/lib/libcapi-media-sound-manager.so.0.1.49
459e5000 459ea000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
459f1000 459f2000 rwxp /usr/lib/gstreamer-0.10/libgstvolume.so
459f5000 45a81000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
45a81000 45b0c000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
45b0d000 4630c000 rwxp [stack:1568]
4630d000 46b0c000 rwxp [stack:1569]
46b0d000 4740c000 rwxp [stack:1570]
4740c000 4748e000 rwxs /dev/dri/card0
4748e000 4758e000 rwxs /dev/mali
4758e000 475ce000 rwxs /dev/mali
475ce000 47602000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
47609000 4760b000 rwxp /usr/lib/gstreamer-0.10/libgstcoreelements.so
4760b000 4762b000 r-xp /usr/lib/gstreamer-0.10/libgstomx.so
47632000 47633000 rwxp /usr/lib/gstreamer-0.10/libgstomx.so
47633000 4763f000 r-xp /usr/lib/gstreamer-0.10/libgstencodebin.so
47646000 47647000 rwxp /usr/lib/gstreamer-0.10/libgstencodebin.so
47647000 477a5000 r-xp /usr/lib/gstreamer-0.10/libgstffmpeg.so
477ac000 477b5000 rwxp /usr/lib/gstreamer-0.10/libgstffmpeg.so
4788d000 47893000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
4789a000 4789b000 rwxp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
478a2000 478cb000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
478d2000 478d4000 rwxp /usr/lib/libgstaudio-0.10.so.0.25.0
478d4000 478ec000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
478f3000 478f5000 rwxp /usr/lib/libgstpbutils-0.10.so.0.25.0
478f5000 4790d000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
47914000 47915000 rwxp /usr/lib/libgstcontroller-0.10.so.0.30.0
47915000 4791a000 r-xp /usr/lib/gstreamer-0.10/libgstsecrecord.so
47921000 47922000 rwxp /usr/lib/gstreamer-0.10/libgstsecrecord.so
4792b000 47930000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
47937000 47938000 rwxp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
47940000 47978000 r-xp /usr/lib/libsaac.so
47978000 47979000 rwxp /usr/lib/libsaac.so
47979000 4797f000 r-xp /usr/lib/libscmn.so
47986000 47987000 rwxp /usr/lib/libscmn.so
47987000 47997000 r-xp /usr/lib/gstreamer-0.10/libgstalsa.so
4799e000 4799f000 rwxp /usr/lib/gstreamer-0.10/libgstalsa.so
4799f000 479aa000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
479b2000 479b3000 rwxp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
479b4000 479ec000 r-xp /usr/lib/libsamrnb.so
479f3000 47a0d000 rwxp /usr/lib/libsamrnb.so
47a0d000 47a27000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
47a2f000 47a30000 rwxp /usr/lib/gstreamer-0.10/libgstpulse.so
47a30000 47a33000 r-xp /usr/lib/gstreamer-0.10/libgstwavenc.so
47a3a000 47a3b000 rwxp /usr/lib/gstreamer-0.10/libgstwavenc.so
47a3c000 4823b000 rwxp [stack:1606]
4823c000 48a3b000 rwxp [stack:1607]
48a3b000 48e3c000 rwxs /dev/shm/pulse-shm-3064344500
48e3c000 4923d000 rwxs /dev/shm/pulse-shm-4175266729
4923e000 49a3d000 rwxp [stack:1608]
49a3e000 4a63d000 rwxp [stack:1609]
4a63e000 4ae3d000 rwxp [stack:1610]
4ae3e000 4b63d000 rwxp [stack:1611]
4b63e000 4be3d000 rwxp [stack:1612]
4c63e000 4d219000 rwxp [stack:1613]
be9b3000 be9d4000 rwxp [stack]
End of Maps Information

Callstack Information (PID:1561)
Call Stack Count: 12
 0: (0x402dd6a6) [/usr/lib/libevas.so.1] + 0x486a6
 1: (0x402dd909) [/usr/lib/libevas.so.1] + 0x48909
 2: evas_object_textblock_size_native_get + 0xcc (0x402e2455) [/usr/lib/libevas.so.1] + 0x4d455
 3: (0x40aada1d) [/usr/lib/libedje.so.1] + 0x15a1d
 4: (0x40aaf003) [/usr/lib/libedje.so.1] + 0x17003
 5: (0x40ab0861) [/usr/lib/libedje.so.1] + 0x18861
 6: (0x40ab2a37) [/usr/lib/libedje.so.1] + 0x1aa37
 7: edje_object_size_min_restricted_calc + 0x86 (0x40ae79e7) [/usr/lib/libedje.so.1] + 0x4f9e7
 8: (0x4019b23f) [/usr/lib/libelementary.so.1] + 0x5623f
 9: (0x401f6949) [/usr/lib/libelementary.so.1] + 0xb1949
10: elm_layout_text_set + 0x4a (0x401f5fbf) [/usr/lib/libelementary.so.1] + 0xb0fbf
11: record_start + 0x122 (0x40003273) [/opt/usr/apps/org.example.hap/bin/hap] + 0x3273
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
oc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:02.315+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:02.420+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:02.420+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:02.520+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:02.520+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:02.540+0900 I/efl-extension(  722): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 17:19:02.540+0900 I/efl-extension(  722): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45c95eb0, elm_box, time_stamp : 39039833
05-31 17:19:02.540+0900 I/wnotib  (  722): w-notification-board-broker-main.c: _wnotib_rotary_cb(568) > Pass rotary event to home.
05-31 17:19:02.545+0900 I/efl-extension( 2643): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 17:19:02.560+0900 W/W_HOME  (  722): home_navigation.c: _is_rightedge(188) > (0 360) not right edge: 0 0 0x49b19fe8 -> 360 0 0x45ce3630
05-31 17:19:02.560+0900 I/efl-extension(  722): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0x45c93930 : elm_scroller] rotary callabck is called.
05-31 17:19:02.565+0900 I/efl-extension(  722): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0x45c93930 : elm_scroller] block(2)
05-31 17:19:02.565+0900 I/efl-extension(  722): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0x45c93930 : elm_scroller] scroll_locked_x(0), scroll_locked_y(0)
05-31 17:19:02.565+0900 I/efl-extension(  722): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0x45c93930 : elm_scroller] content size (w, h)(4320, 360)
05-31 17:19:02.565+0900 I/efl-extension(  722): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0x45c93930 : elm_scroller] viewport size (w, h)(360, 360)
05-31 17:19:02.565+0900 I/efl-extension(  722): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0x45c93930 : elm_scroller] CurrentPage(0) DetentCount(1)
05-31 17:19:02.570+0900 I/efl-extension(  722): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93930 : elm_scroller] mx(3960), my(0), minx(0), miny(0), px(0), py(0)
05-31 17:19:02.570+0900 I/efl-extension(  722): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93930 : elm_scroller] mx(3960), my(0), minx(0), miny(0), px(0), py(0)
05-31 17:19:02.570+0900 I/efl-extension(  722): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93930 : elm_scroller] mx(3960), my(0), minx(0), miny(0), px(0), py(0)
05-31 17:19:02.570+0900 I/efl-extension(  722): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93930 : elm_scroller] mx(3960), my(0), minx(0), miny(0), px(0), py(0)
05-31 17:19:02.570+0900 I/efl-extension(  722): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0x45c93930 : elm_scroller] bring in 1 page
05-31 17:19:02.575+0900 W/W_HOME  (  722): event_manager.c: _home_scroll_cb(564) > scroll,start
05-31 17:19:02.575+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_hide(552) > 
05-31 17:19:02.575+0900 W/W_HOME  (  722): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
05-31 17:19:02.585+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-31 17:19:02.585+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-31 17:19:02.585+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(581) > 0
05-31 17:19:02.585+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(591) > select index:1
05-31 17:19:02.615+0900 W/WATCH_CORE(  752): appcore-watch.c: __widget_resume(1012) > widget_resume
05-31 17:19:02.615+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppResume(721) > 
05-31 17:19:02.615+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:02.615+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:02.620+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:02.620+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:02.620+0900 W/W_HOME  (  722): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
05-31 17:19:02.625+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-31 17:19:02.625+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-31 17:19:02.625+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(581) > 0
05-31 17:19:02.625+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(591) > select index:1
05-31 17:19:02.645+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-31 17:19:02.645+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-31 17:19:02.645+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(581) > 0
05-31 17:19:02.650+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(591) > select index:1
05-31 17:19:02.665+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-31 17:19:02.665+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-31 17:19:02.665+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(581) > 0
05-31 17:19:02.665+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(591) > select index:1
05-31 17:19:02.675+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-31 17:19:02.675+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-31 17:19:02.675+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(581) > 0
05-31 17:19:02.680+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(591) > select index:1
05-31 17:19:02.700+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-31 17:19:02.700+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-31 17:19:02.700+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(581) > 0
05-31 17:19:02.700+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(591) > select index:1
05-31 17:19:02.720+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:02.720+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:02.730+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-31 17:19:02.730+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-31 17:19:02.730+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(581) > 0
05-31 17:19:02.730+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(591) > select index:1
05-31 17:19:02.745+0900 W/W_HOME  (  722): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
05-31 17:19:02.745+0900 W/W_HOME  (  722): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 17:19:02.745+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-31 17:19:02.745+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-31 17:19:02.745+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(581) > 0
05-31 17:19:02.745+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(591) > select index:1
05-31 17:19:02.755+0900 W/GESTURE (  146): gesture.c: BackGestureSetProperty(4469) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
05-31 17:19:02.765+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-31 17:19:02.765+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-31 17:19:02.765+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(581) > 0
05-31 17:19:02.765+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(591) > select index:1
05-31 17:19:02.775+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-31 17:19:02.775+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-31 17:19:02.775+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(581) > 0
05-31 17:19:02.775+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(591) > select index:1
05-31 17:19:02.790+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-31 17:19:02.790+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-31 17:19:02.790+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(581) > 0
05-31 17:19:02.790+0900 W/W_HOME  (  722): noti_broker.c: _handler_indicator_select(591) > select index:1
05-31 17:19:02.810+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-31 17:19:02.810+0900 I/ELM_RPANEL(  722): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-31 17:19:02.810+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:02.810+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:02.815+0900 W/wnotib  (  722): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-31 17:19:02.815+0900 I/efl-extension(  722): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c93930 : elm_scroller] CurrentPage(1)
05-31 17:19:02.825+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:02.825+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:02.925+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:02.925+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:02.945+0900 W/W_HOME  (  722): event_manager.c: _home_scroll_cb(564) > scroll,done
05-31 17:19:03.010+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:03.010+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:03.025+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:03.025+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:03.130+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:03.130+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:03.210+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:03.210+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:03.230+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:03.230+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:03.315+0900 W/W_HOME  (  722): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
05-31 17:19:03.335+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:03.335+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:03.410+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:03.415+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:03.435+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:03.435+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:03.535+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:03.535+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:03.610+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:03.610+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:03.640+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:03.640+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:03.740+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:03.740+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:03.810+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:03.810+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:03.840+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:03.840+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:03.945+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:03.945+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:04.010+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:04.010+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:04.045+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:04.045+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:04.150+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:04.150+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:04.210+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:04.210+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:04.250+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:04.250+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:04.355+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:04.355+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:04.410+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:04.410+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:04.455+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:04.455+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:04.560+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:04.560+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:04.615+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:04.615+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:04.660+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:04.660+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:04.760+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:04.760+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:04.815+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:04.815+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:04.865+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:04.865+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:04.965+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:04.965+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:05.015+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:05.015+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:05.065+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:05.065+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:05.170+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:05.170+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:05.215+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:05.215+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:05.270+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:05.270+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:05.375+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:05.375+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:05.415+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:05.415+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:05.475+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:05.475+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:05.580+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:05.580+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:05.615+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:05.615+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:05.680+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:05.680+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:05.780+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:05.780+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:05.815+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:05.815+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:05.885+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:05.885+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:05.985+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:05.985+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:06.015+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:06.015+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:06.085+0900 E/RESOURCED( 1201): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:06.085+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-31 17:19:06.190+0900 E/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(312) > process launched, but cmdline not changed
05-31 17:19:06.190+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 0
05-31 17:19:06.215+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:06.215+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:06.220+0900 E/RESOURCED(  499): procfs.c: proc_get_oom_score_adj(124) > [proc_get_oom_score_adj,124] fopen /proc/1473/oom_score_adj failed
05-31 17:19:06.225+0900 E/RESOURCED(  499): proc-main.c: resourced_proc_status_change(860) > [resourced_proc_status_change,860] Empty pid or process not exists. 1473
05-31 17:19:06.250+0900 I/AUL_AMD (  498): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
05-31 17:19:06.280+0900 I/AUL_AMD (  498): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
05-31 17:19:06.280+0900 E/AUL_AMD (  498): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-31 17:19:06.280+0900 W/AUL_AMD (  498): amd_launch.c: _start_app(1702) > caller pid : 1558
05-31 17:19:06.305+0900 W/AUL_AMD (  498): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 2547
05-31 17:19:06.305+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: RESET State: PAUSED
05-31 17:19:06.305+0900 I/CAPI_APPFW_APPLICATION( 2547): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-31 17:19:06.330+0900 W/AUL_AMD (  498): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(2547), cmd(0)
05-31 17:19:06.330+0900 I/AUL_AMD (  498): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 1473
05-31 17:19:06.350+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-31 17:19:06.350+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(481) > [APP 2547] App already running, raise the window
05-31 17:19:06.410+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(485) > [APP 2547] Call the resume_cb
05-31 17:19:06.410+0900 E/E17     (  388): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04600002)
05-31 17:19:06.415+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:06.415+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:06.415+0900 I/CAPI_APPFW_APPLICATION( 2547): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 17:19:06.415+0900 W/AUL_AMD (  498): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 17:19:06.415+0900 W/AUL_AMD (  498): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-31 17:19:06.600+0900 W/W_HOME  (  722): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-31 17:19:06.600+0900 W/W_HOME  (  722): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 17:19:06.605+0900 W/W_HOME  (  722): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 17:19:06.605+0900 W/W_HOME  (  722): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 17:19:06.610+0900 W/W_HOME  (  722): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-31 17:19:06.615+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:06.615+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:06.625+0900 W/GESTURE (  146): gesture.c: BackGestureSetProperty(4474) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
05-31 17:19:06.645+0900 I/MALI    (  722): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-31 17:19:06.675+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: RESUME State: RUNNING
05-31 17:19:06.720+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 0
05-31 17:19:06.730+0900 I/AUL_AMD (  498): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-31 17:19:06.735+0900 W/W_HOME  (  722): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-31 17:19:06.735+0900 W/W_HOME  (  722): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-31 17:19:06.735+0900 W/W_HOME  (  722): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 17:19:06.735+0900 W/W_HOME  (  722): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-31 17:19:06.740+0900 I/AUL_AMD (  498): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-31 17:19:06.740+0900 E/AUL_AMD (  498): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-31 17:19:06.740+0900 W/AUL_AMD (  498): amd_launch.c: _start_app(1702) > caller pid : 699
05-31 17:19:06.750+0900 I/APP_CORE(  722): appcore-efl.c: __do_app(429) > [APP 722] Event: PAUSE State: RUNNING
05-31 17:19:06.750+0900 I/CAPI_APPFW_APPLICATION(  722): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-31 17:19:06.750+0900 W/W_HOME  (  722): main.c: _appcore_pause_cb(690) > appcore pause
05-31 17:19:06.750+0900 W/W_HOME  (  722): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-31 17:19:06.755+0900 W/W_HOME  (  722): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 17:19:06.755+0900 E/RESOURCED(  499): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-31 17:19:06.755+0900 E/RESOURCED(  499): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-31 17:19:06.755+0900 W/AUL_AMD (  498): amd_launch.c: _start_app(2080) > pad pid(-5)
05-31 17:19:06.765+0900 W/W_HOME  (  722): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 17:19:06.765+0900 W/W_HOME  (  722): main.c: home_pause(751) > clock/widget paused
05-31 17:19:06.770+0900 W/W_HOME  (  722): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 17:19:06.770+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 17:19:06.770+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 17:19:06.770+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 17:19:06.770+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 17:19:06.770+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-31 17:19:06.770+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-31 17:19:06.770+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 17:19:06.770+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 17:19:06.770+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 17:19:06.770+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 17:19:06.770+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 17:19:06.770+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-31 17:19:06.770+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-31 17:19:06.770+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-31 17:19:06.770+0900 I/MESSAGE_PORT(  453): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 17:19:06.770+0900 I/MESSAGE_PORT(  453): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-31 17:19:06.770+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-31 17:19:06.770+0900 I/MESSAGE_PORT(  453): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 17:19:06.775+0900 E/CAPI_APPFW_APP_CONTROL( 1056): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-31 17:19:06.775+0900 W/MUSIC_CONTROL_SERVICE( 1056): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1056]   [com.samsung.w-home]register msg port [false][0m
05-31 17:19:06.810+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:06.810+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:06.840+0900 I/wnotib  (  722): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-31 17:19:06.840+0900 E/wnotib  (  722): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-31 17:19:06.925+0900 I/efl-extension(  722): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 17:19:06.925+0900 I/efl-extension( 2643): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 17:19:07.010+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:07.010+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:07.190+0900 W/AUL_PAD ( 1201): launchpad.c: __launchpad_main_loop(607) > Candidate is not prepared, enter legacy logic
05-31 17:19:07.190+0900 W/AUL_PAD ( 1201): launchpad.c: __send_result_to_caller(272) > Check app launching
05-31 17:19:07.190+0900 W/AUL_AMD (  498): amd_launch.c: _start_app(2091) > Launch with legacy way : no launchpad
05-31 17:19:07.195+0900 W/AUL_AMD (  498): amd_launch.c: start_process(580) > child process: 1561
05-31 17:19:07.205+0900 E/RESOURCED( 1102): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-31 17:19:07.205+0900 E/AUL     ( 1102): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-31 17:19:07.205+0900 E/CAPI_APPFW_APP_MANAGER( 1102): app_manager.c: app_manager_error(78) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
05-31 17:19:07.210+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:07.210+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:07.245+0900 W/AUL_AMD (  498): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 1561
05-31 17:19:07.245+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:19:07.255+0900 W/WATCH_CORE(  752): appcore-watch.c: __widget_pause(1001) > widget_pause
05-31 17:19:07.255+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppPause(713) > 
05-31 17:19:07.255+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-31 17:19:07.255+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-31 17:19:07.255+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-31 17:19:07.255+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-31 17:19:07.255+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-31 17:19:07.255+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-31 17:19:07.260+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4712
05-31 17:19:07.260+0900 W/AUL_AMD (  498): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 17:19:07.260+0900 W/AUL_AMD (  498): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-31 17:19:07.260+0900 E/AUL     (  498): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-31 17:19:07.265+0900 E/AUL     (  498): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-31 17:19:07.265+0900 W/WATCH_CORE(  752): appcore-watch.c: __widget_resume(1012) > widget_resume
05-31 17:19:07.265+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppResume(721) > 
05-31 17:19:07.270+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:07.270+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:07.275+0900 I/APP_CORE(  722): appcore-efl.c: __do_app(429) > [APP 722] Event: MEM_FLUSH State: PAUSED
05-31 17:19:07.300+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:19:07.305+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1561
05-31 17:19:07.310+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 12
05-31 17:19:07.435+0900 I/efl-extension( 1561): efl_extension.c: eext_mod_init(40) > Init
05-31 17:19:07.455+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:07.455+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:07.475+0900 I/CAPI_APPFW_APPLICATION( 1561): app_main.c: ui_app_main(704) > app_efl_main
05-31 17:19:07.645+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:07.645+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:07.715+0900 I/CAPI_APPFW_APPLICATION( 1561): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-31 17:19:07.765+0900 I/AUL_PAD ( 1560): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-31 17:19:07.815+0900 E/TBM     ( 1561): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-31 17:19:07.835+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:07.835+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:08.000+0900 E/E17     (  388): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04800003)
05-31 17:19:08.015+0900 E/EFL     ( 1561): ecore_evas<1561> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-31 17:19:08.030+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:08.030+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:08.105+0900 I/efl-extension( 1561): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0x447341b8]'s widget[0x44474618] to elm_conformant widget[0x44421ba8]
05-31 17:19:08.225+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:08.225+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:08.245+0900 W/AUL_AMD (  498): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 17:19:08.245+0900 W/AUL_AMD (  498): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-31 17:19:08.265+0900 I/HAP     ( 1561): SUCCESSFULLY create sap agent
05-31 17:19:08.270+0900 I/HAP     ( 1561): connectivity type(1): bt
05-31 17:19:08.425+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:08.425+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:08.470+0900 I/HAP     ( 1561): agent is initialized
05-31 17:19:08.470+0900 I/HAP     ( 1561): agent initialized callback is over
05-31 17:19:08.470+0900 I/HAP     ( 1561): SAP >>> getRegisteredServiceAgent() >>> 0
05-31 17:19:08.620+0900 E/TIZEN_N_RECORDER( 1561): recorder.c: __convert_recorder_error_code(193) > [audio-channel] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:19:08.620+0900 E/TIZEN_N_RECORDER( 1561): recorder.c: __convert_recorder_error_code(193) > [audio-device] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:19:08.620+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:08.620+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:08.705+0900 I/APP_CORE( 1561): appcore-efl.c: __do_app(429) > [APP 1561] Event: RESET State: CREATED
05-31 17:19:08.705+0900 I/CAPI_APPFW_APPLICATION( 1561): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-31 17:19:08.765+0900 I/APP_CORE( 1561): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-31 17:19:08.765+0900 I/APP_CORE( 1561): appcore-efl.c: __do_app(474) > [APP 1561] Initial Launching, call the resume_cb
05-31 17:19:08.765+0900 I/CAPI_APPFW_APPLICATION( 1561): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 17:19:08.785+0900 W/APP_CORE( 1561): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4800003
05-31 17:19:08.790+0900 E/EFL     ( 1561): evas_main<1561> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=39045410 button=1 downs=1
05-31 17:19:08.790+0900 E/EFL     ( 1561): evas_main<1561> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=39045465 button=1 downs=0
05-31 17:19:08.790+0900 I/efl-extension( 1561): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x447341b8 = w: 0 h: 0  obj 0x44474618 w: 360 h: 360
05-31 17:19:08.800+0900 I/efl-extension( 1561): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-31 17:19:08.820+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:19:08.820+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:19:08.895+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: PAUSE State: RUNNING
05-31 17:19:08.895+0900 I/CAPI_APPFW_APPLICATION( 2547): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-31 17:19:08.905+0900 W/AUL_AMD (  498): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 17:19:08.905+0900 W/AUL_AMD (  498): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-31 17:19:08.940+0900 W/WATCH_CORE(  752): appcore-watch.c: __widget_pause(1001) > widget_pause
05-31 17:19:08.940+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppPause(713) > 
05-31 17:19:08.940+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-31 17:19:08.940+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-31 17:19:08.940+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-31 17:19:08.940+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-31 17:19:08.940+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-31 17:19:08.940+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-31 17:19:08.990+0900 I/HAP     ( 1561): Updating UI with data Connection Established
05-31 17:19:09.100+0900 I/APP_CORE( 1561): appcore-efl.c: __do_app(429) > [APP 1561] Event: RESUME State: RUNNING
05-31 17:19:09.300+0900 E/AUL     (  498): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-31 17:19:09.340+0900 I/MALI    ( 1561): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x4340fbc8] swap changed from async to sync
05-31 17:19:10.115+0900 E/EFL     ( 1561): evas_main<1561> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=39047405 button=1 downs=1
05-31 17:19:10.140+0900 E/EFL     ( 1561): evas_main<1561> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=39047433 button=1 downs=0
05-31 17:19:11.780+0900 I/APP_CORE(  722): appcore-efl.c: __do_app(429) > [APP 722] Event: MEM_FLUSH State: PAUSED
05-31 17:19:12.265+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:19:12.340+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1561
05-31 17:19:12.570+0900 E/EFL     ( 1561): evas_main<1561> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=39049853 button=1 downs=1
05-31 17:19:12.640+0900 E/EFL     ( 1561): evas_main<1561> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=39049933 button=1 downs=0
05-31 17:19:12.885+0900 I/aa      ( 1561): here = On
05-31 17:19:12.885+0900 I/aa      ( 1561): here2 = On
05-31 17:19:12.890+0900 E/TIZEN_N_RECORDER( 1561): recorder.c: __convert_recorder_error_code(193) > [recorder_set_filename] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:19:12.890+0900 E/TIZEN_N_RECORDER( 1561): recorder.c: __convert_recorder_error_code(193) > [file-format] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:19:12.890+0900 E/TIZEN_N_RECORDER( 1561): recorder.c: __convert_recorder_error_code(193) > [audio-encoder] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:19:13.030+0900 I/PRIVACY-MANAGER-CLIENT( 1561): PrivacyChecker.cpp: initialize(168) > Got lock. Starting initialize
05-31 17:19:13.030+0900 I/PRIVACY-MANAGER-CLIENT( 1561): PrivacyChecker.cpp: runSignalListenerThread(194) > Running g main loop for signal
05-31 17:19:13.030+0900 I/PRIVACY-MANAGER-CLIENT( 1561): PrivacyChecker.cpp: initializeDbus(220) > Starting initialize
05-31 17:19:13.090+0900 I/PRIVACY-MANAGER-CLIENT( 1561): PrivacyChecker.cpp: initializeDbus(235) > Initialized
05-31 17:19:13.090+0900 I/PRIVACY-MANAGER-CLIENT( 1561): PrivacyChecker.cpp: initialize(186) > Initialized
05-31 17:19:13.875+0900 E/TIZEN_N_RECORDER( 1561): recorder.c: __convert_recorder_error_code(193) > [recorder_start] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:19:13.880+0900 E/EFL     ( 1561): <1561> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:19:13.885+0900 E/EFL     ( 1561): <1561> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:19:13.905+0900 I/aa      ( 1561): chk1 = Off
05-31 17:19:13.920+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: MEM_FLUSH State: PAUSED
05-31 17:19:14.340+0900 W/CRASH_MANAGER( 1615): worker.c: worker_job(1199) > 1101561686170146468275
