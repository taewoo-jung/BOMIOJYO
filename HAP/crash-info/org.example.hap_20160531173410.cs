S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.5
Build-Number: R732XXU2CPC5
Build-Date: 2016.03.21 17:05:24

Crash Information
Process Name: hap
PID: 2927
Date: 2016-05-31 17:34:10+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x120

Register Information
r0   = 0x00000000, r1   = 0x45014960
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x450149c8, r5   = 0x4638594c
r6   = 0x45014960, r7   = 0x46390200
r8   = 0x00000000, r9   = 0x00000000
r10  = 0x46385794, fp   = 0x00000003
ip   = 0x00000000, sp   = 0xbe861c60
lr   = 0x40ab0861, pc   = 0x40aae11c
cpsr = 0x80000030

Memory Information
MemTotal:   491012 KB
MemFree:     22456 KB
Buffers:     13248 KB
Cached:     100720 KB
VmPeak:     217664 KB
VmSize:     214820 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       30580 KB
VmRSS:       30576 KB
VmData:     139292 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       60428 KB
VmPTE:         106 KB
VmSwap:          0 KB

Threads Information
Threads: 16
PID = 2927 TID = 2927
2927 2935 2936 2940 2941 2942 2967 2968 2979 2980 2981 2982 2983 2984 2987 3011 

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
43b6e000 43b71000 rwxp [stack:2936]
43b71000 43b75000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43b7c000 43b7d000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43b7d000 43b81000 rwxs /dev/mali
43b82000 43b84000 r-xp /usr/lib/libdri2.so.0.0.0
43b8b000 43b8c000 rwxp /usr/lib/libdri2.so.0.0.0
43b8c000 43b8f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43b96000 43b97000 rwxp /usr/lib/libnative-buffer.so.0.1.0
43b98000 44397000 rwxp [stack:2935]
44397000 4439f000 rwxs /dev/mali
4439f000 443a7000 rwxs /dev/mali
443a7000 443ab000 rwxs /dev/mali
443ab000 443bb000 rwxs /dev/mali
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
447a3000 44fa2000 rwxp [stack:2968]
44fa2000 44fa9000 r-xs /usr/lib/gconv/gconv-modules.cache
44fa9000 44fac000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44fac000 44fb0000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44fb0000 44fbf000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
44fbf000 44fc0000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44fc7000 44fc8000 rwxp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44fc8000 44ff4000 rwxs /dev/mali
44ff8000 44ffc000 rwxs /dev/mali
44ffc000 45000000 rwxs /dev/mali
45101000 45900000 rwxp [stack:2967]
45900000 45903000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
4590a000 4590b000 rwxp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
4590b000 4590c000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
45913000 45914000 rwxp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
45914000 45924000 rwxs /dev/mali
45924000 45934000 rwxs /dev/mali
45950000 45974000 rwxs /dev/mali
45974000 45998000 rwxs /dev/mali
45998000 459bc000 rwxs /dev/mali
459bc000 459c0000 rwxs /dev/mali
459d0000 459d1000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
459d8000 459d9000 rwxp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
459d9000 459da000 r-xp /usr/lib/gstreamer-0.10/libgstapp.so
459e1000 459e2000 rwxp /usr/lib/gstreamer-0.10/libgstapp.so
459e2000 459e5000 r-xp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
459ec000 459ed000 rwxp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
459f5000 45a81000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
45a81000 45b0c000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
45b0d000 4640c000 rwxp [stack:2940]
4640d000 46c0c000 rwxp [stack:2941]
46c0d000 4740c000 rwxp [stack:2942]
4740c000 4748e000 rwxs /dev/dri/card0
4748e000 4758e000 rwxs /dev/mali
4768e000 47695000 r-xp /usr/lib/libfeedback.so.0.1.4
4769d000 4769e000 rwxp /usr/lib/libfeedback.so.0.1.4
4769e000 4769f000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
476a6000 476a7000 rwxp /usr/lib/libmmfkeysound.so.0.0.0
476a7000 476a9000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
476b0000 476b1000 rwxp /usr/lib/libcapi-media-wav-player.so.0.1.10
476b1000 476bb000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
476c2000 476c3000 rwxp /usr/lib/libcapi-media-sound-manager.so.0.1.49
476c3000 476f7000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
476fe000 47700000 rwxp /usr/lib/gstreamer-0.10/libgstcoreelements.so
47700000 47720000 r-xp /usr/lib/gstreamer-0.10/libgstomx.so
47727000 47728000 rwxp /usr/lib/gstreamer-0.10/libgstomx.so
47728000 47734000 r-xp /usr/lib/gstreamer-0.10/libgstencodebin.so
4773b000 4773c000 rwxp /usr/lib/gstreamer-0.10/libgstencodebin.so
4773c000 4789a000 r-xp /usr/lib/gstreamer-0.10/libgstffmpeg.so
478a1000 478aa000 rwxp /usr/lib/gstreamer-0.10/libgstffmpeg.so
47982000 47987000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
4798e000 4798f000 rwxp /usr/lib/gstreamer-0.10/libgstvolume.so
47997000 479c0000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
479c7000 479c9000 rwxp /usr/lib/libgstaudio-0.10.so.0.25.0
479c9000 479e1000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
479e8000 479ea000 rwxp /usr/lib/libgstpbutils-0.10.so.0.25.0
479ea000 479f0000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
479f7000 479f8000 rwxp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
479ff000 47a17000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
47a1e000 47a1f000 rwxp /usr/lib/libgstcontroller-0.10.so.0.30.0
47a1f000 47a24000 r-xp /usr/lib/gstreamer-0.10/libgstsecrecord.so
47a2b000 47a2c000 rwxp /usr/lib/gstreamer-0.10/libgstsecrecord.so
47a35000 47a3a000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
47a41000 47a42000 rwxp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
47a4a000 47a82000 r-xp /usr/lib/libsaac.so
47a82000 47a83000 rwxp /usr/lib/libsaac.so
47a83000 47a89000 r-xp /usr/lib/libscmn.so
47a90000 47a91000 rwxp /usr/lib/libscmn.so
47a91000 47aa1000 r-xp /usr/lib/gstreamer-0.10/libgstalsa.so
47aa8000 47aa9000 rwxp /usr/lib/gstreamer-0.10/libgstalsa.so
47aa9000 47ab4000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
47abc000 47abd000 rwxp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
47abe000 47af6000 r-xp /usr/lib/libsamrnb.so
47afd000 47b17000 rwxp /usr/lib/libsamrnb.so
47b17000 47b31000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
47b39000 47b3a000 rwxp /usr/lib/gstreamer-0.10/libgstpulse.so
47b3a000 47b3d000 r-xp /usr/lib/gstreamer-0.10/libgstwavenc.so
47b44000 47b45000 rwxp /usr/lib/gstreamer-0.10/libgstwavenc.so
47b46000 48345000 rwxp [stack:2979]
48346000 48b45000 rwxp [stack:2980]
48b45000 48f46000 rwxs /dev/shm/pulse-shm-3642567087
48f46000 49347000 rwxs /dev/shm/pulse-shm-2786378404
49348000 49b47000 rwxp [stack:2981]
49b48000 4a747000 rwxp [stack:2982]
4a748000 4af47000 rwxp [stack:2983]
4af48000 4b747000 rwxp [stack:2984]
4b748000 4bf47000 rwxp [stack:3011]
4bf48000 4c747000 rwxp [stack:2987]
4cf47000 4d06d000 r-xp /usr/share/fallback_fonts/BreezeSansKorean-RegularCondensed.ttf
4d06d000 4d0ad000 rwxs /dev/mali
be842000 be863000 rwxp [stack]
End of Maps Information

Callstack Information (PID:2927)
Call Stack Count: 13
 0: (0x40aae11c) [/usr/lib/libedje.so.1] + 0x1611c
 1: (0x40ab0861) [/usr/lib/libedje.so.1] + 0x18861
 2: (0x40ab2a37) [/usr/lib/libedje.so.1] + 0x1aa37
 3: (0x402cab2f) [/usr/lib/libevas.so.1] + 0x35b2f
 4: (0x402f02e3) [/usr/lib/libevas.so.1] + 0x5b2e3
 5: (0x40d24071) [/usr/lib/libecore_evas.so.1] + 0x12071
 6: (0x40d216ed) [/usr/lib/libecore_evas.so.1] + 0xf6ed
 7: (0x400aef25) [/usr/lib/libecore.so.1] + 0xaf25
 8: (0x400b034f) [/usr/lib/libecore.so.1] + 0xc34f
 9: ecore_main_loop_begin + 0x30 (0x400b08b9) [/usr/lib/libecore.so.1] + 0xc8b9
10: appcore_efl_main + 0x20e (0x4060d503) [/usr/lib/libappcore-efl.so.1] + 0x3503
11: ui_app_main + 0xb0 (0x40066421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
12: app_run + 0xea (0x40002e47) [/opt/usr/apps/org.example.hap/bin/hap] + 0x2e47
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
0900 W/AUL_AMD (  498): amd_launch.c: _start_app(1702) > caller pid : 699
05-31 17:33:27.135+0900 W/AUL_AMD (  498): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 2927
05-31 17:33:27.140+0900 E/AUL     (  498): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-31 17:33:27.140+0900 I/APP_CORE( 2927): appcore-efl.c: __do_app(429) > [APP 2927] Event: RESET State: RUNNING
05-31 17:33:27.140+0900 I/CAPI_APPFW_APPLICATION( 2927): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-31 17:33:27.140+0900 I/APP_CORE( 2927): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-31 17:33:27.140+0900 I/APP_CORE( 2927): appcore-efl.c: __do_app(481) > [APP 2927] App already running, raise the window
05-31 17:33:27.145+0900 W/AUL_AMD (  498): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(2927), cmd(0)
05-31 17:33:27.180+0900 E/E17     (  388): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04800003)
05-31 17:33:28.140+0900 W/AUL_AMD (  498): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 17:33:28.140+0900 W/AUL_AMD (  498): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-31 17:33:30.655+0900 I/APP_CORE( 2547): appcore-efl.c: __do_app(429) > [APP 2547] Event: MEM_FLUSH State: PAUSED
05-31 17:33:31.240+0900 E/EFL     ( 2927): evas_main<2927> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=39908530 button=1 downs=1
05-31 17:33:31.315+0900 E/EFL     ( 2927): evas_main<2927> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=39908611 button=1 downs=0
05-31 17:33:31.560+0900 E/TIZEN_N_RECORDER( 2927): recorder.c: __convert_recorder_error_code(193) > [recorder_set_filename] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:33:31.560+0900 E/TIZEN_N_RECORDER( 2927): recorder.c: __convert_recorder_error_code(193) > [file-format] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:33:31.565+0900 E/TIZEN_N_RECORDER( 2927): recorder.c: __convert_recorder_error_code(193) > [audio-encoder] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:33:31.685+0900 I/PRIVACY-MANAGER-CLIENT( 2927): PrivacyChecker.cpp: initialize(168) > Got lock. Starting initialize
05-31 17:33:31.685+0900 I/PRIVACY-MANAGER-CLIENT( 2927): PrivacyChecker.cpp: runSignalListenerThread(194) > Running g main loop for signal
05-31 17:33:31.685+0900 I/PRIVACY-MANAGER-CLIENT( 2927): PrivacyChecker.cpp: initializeDbus(220) > Starting initialize
05-31 17:33:31.735+0900 I/PRIVACY-MANAGER-CLIENT( 2927): PrivacyChecker.cpp: initializeDbus(235) > Initialized
05-31 17:33:31.735+0900 I/PRIVACY-MANAGER-CLIENT( 2927): PrivacyChecker.cpp: initialize(186) > Initialized
05-31 17:33:32.355+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:33:32.360+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2927
05-31 17:33:32.555+0900 E/TIZEN_N_RECORDER( 2927): recorder.c: __convert_recorder_error_code(193) > [recorder_start] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 17:33:32.555+0900 E/EFL     ( 2927): <2927> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:33:32.555+0900 E/EFL     ( 2927): <2927> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:33:32.620+0900 I/aa      ( 2927): chk = Off
05-31 17:33:33.625+0900 I/aa      ( 2927): res = 0
05-31 17:33:33.625+0900 I/aa      ( 2927): res = 0
05-31 17:33:33.630+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:34.635+0900 I/aa      ( 2927): res = 0
05-31 17:33:34.635+0900 I/aa      ( 2927): res = 0
05-31 17:33:34.635+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:35.635+0900 I/aa      ( 2927): res = 0
05-31 17:33:35.635+0900 I/aa      ( 2927): res = 0
05-31 17:33:35.635+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:36.640+0900 I/aa      ( 2927): res = 0
05-31 17:33:36.640+0900 I/aa      ( 2927): res = 0
05-31 17:33:36.640+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:37.165+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:33:37.235+0900 E/EFL     ( 2927): evas_main<2927> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=39914525 button=1 downs=1
05-31 17:33:37.260+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2927
05-31 17:33:37.320+0900 E/EFL     ( 2927): evas_main<2927> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=39914596 button=1 downs=0
05-31 17:33:37.640+0900 I/aa      ( 2927): res = 0
05-31 17:33:37.640+0900 I/aa      ( 2927): res = 0
05-31 17:33:37.640+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:38.640+0900 I/aa      ( 2927): res = 0
05-31 17:33:38.640+0900 I/aa      ( 2927): res = 0
05-31 17:33:38.640+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:39.640+0900 I/aa      ( 2927): res = 0
05-31 17:33:39.640+0900 I/aa      ( 2927): res = 0
05-31 17:33:39.640+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:40.580+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:33:40.580+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:33:40.580+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(517569962)
05-31 17:33:40.580+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:33:40.580+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 15:00:00 (UTC).
05-31 17:33:40.580+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:33:40.580+0900 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[517569962] is removed.
05-31 17:33:40.610+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:33:40.615+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:33:40.645+0900 I/aa      ( 2927): res = 0
05-31 17:33:40.645+0900 I/aa      ( 2927): res = 0
05-31 17:33:40.645+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:40.655+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:33:40.690+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:33:40.725+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:33:40.750+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:33:40.750+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-31 17:33:40.750+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-31 17:33:40.785+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:33:40.815+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:33:40.815+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464683624, Tue May 31 17:33:44 2016
05-31 17:33:40.815+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 525340366, next duetime: 1464683624
05-31 17:33:40.815+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(525340366)
05-31 17:33:40.815+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464706800), due_time(1464683624)
05-31 17:33:40.815+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:33:40.815+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 08:33:44 (UTC).
05-31 17:33:40.820+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:33:40.830+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:33:40.835+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:33:40.835+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(525340366)
05-31 17:33:40.835+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:33:40.835+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 15:00:00 (UTC).
05-31 17:33:40.835+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:33:40.835+0900 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[525340366] is removed.
05-31 17:33:40.855+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:33:40.865+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:33:40.885+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:33:40.905+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:33:40.920+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:33:40.935+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:33:40.935+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-31 17:33:40.940+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-31 17:33:40.955+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:33:40.965+0900 I/AUL     (  494): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-31 17:33:40.970+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464726820, Wed Jun  1 05:33:40 2016
05-31 17:33:40.970+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 525340366, next duetime: 1464726820
05-31 17:33:40.970+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(525340366)
05-31 17:33:40.970+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464706800), due_time(1464726820)
05-31 17:33:40.970+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:33:40.970+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 15:00:00 (UTC).
05-31 17:33:40.970+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:33:41.645+0900 I/aa      ( 2927): res = 0
05-31 17:33:41.645+0900 I/aa      ( 2927): res = 0
05-31 17:33:41.645+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:42.255+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:33:42.280+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2927
05-31 17:33:42.645+0900 I/aa      ( 2927): res = 0
05-31 17:33:42.645+0900 I/aa      ( 2927): res = 0
05-31 17:33:42.645+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:42.740+0900 I/RESOURCED(  499): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-31 17:33:42.740+0900 I/RESOURCED(  499): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-31 17:33:42.815+0900 I/RESOURCED(  499): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
05-31 17:33:43.645+0900 I/aa      ( 2927): res = 0
05-31 17:33:43.645+0900 I/aa      ( 2927): res = 0
05-31 17:33:43.645+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:44.650+0900 I/aa      ( 2927): res = 0
05-31 17:33:44.650+0900 I/aa      ( 2927): res = 0
05-31 17:33:44.650+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:45.655+0900 I/aa      ( 2927): res = 0
05-31 17:33:45.655+0900 I/aa      ( 2927): res = 0
05-31 17:33:45.700+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:45.930+0900 E/EFL     ( 2927): evas_main<2927> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=39923221 button=1 downs=1
05-31 17:33:46.020+0900 E/EFL     ( 2927): evas_main<2927> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=39923304 button=1 downs=0
05-31 17:33:46.260+0900 E/TIZEN_N_RECORDER( 2927): recorder.c: recorder_set_filename(953) > invalid state 5
05-31 17:33:46.260+0900 E/TIZEN_N_RECORDER( 2927): recorder.c: _recorder_check_and_set_attribute(417) > invalid state 5
05-31 17:33:46.265+0900 E/TIZEN_N_RECORDER( 2927): recorder.c: _recorder_check_and_set_attribute(417) > invalid state 5
05-31 17:33:46.280+0900 E/TIZEN_N_RECORDER( 2927): recorder.c: recorder_prepare(736) > [recorder_prepare] mm_camcorder_realize fail
05-31 17:33:46.280+0900 E/TIZEN_N_RECORDER( 2927): recorder.c: __convert_recorder_error_code(193) > [recorder_prepare] INVALID_STATE(0xfe6b0012) : core frameworks error code(0x80000817)
05-31 17:33:46.285+0900 E/TIZEN_N_RECORDER( 2927): recorder.c: __convert_recorder_error_code(193) > [recorder_start] INVALID_STATE(0xfe6b0012) : core frameworks error code(0x80000817)
05-31 17:33:46.285+0900 E/EFL     ( 2927): <2927> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:33:46.290+0900 E/EFL     ( 2927): <2927> elm_main.c:1268 elm_object_disabled_set() safety check failed: obj == NULL
05-31 17:33:46.320+0900 I/aa      ( 2927): chk = Off
05-31 17:33:46.700+0900 I/aa      ( 2927): res = 0
05-31 17:33:46.700+0900 I/aa      ( 2927): res = 0
05-31 17:33:46.700+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:47.185+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:33:47.265+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2927
05-31 17:33:47.325+0900 I/aa      ( 2927): res = 0
05-31 17:33:47.325+0900 I/aa      ( 2927): res = 0
05-31 17:33:47.325+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:47.700+0900 I/aa      ( 2927): res = 0
05-31 17:33:47.700+0900 I/aa      ( 2927): res = 0
05-31 17:33:47.700+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:48.330+0900 I/aa      ( 2927): res = 0
05-31 17:33:48.330+0900 I/aa      ( 2927): res = 0
05-31 17:33:48.330+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:48.705+0900 I/aa      ( 2927): res = 0
05-31 17:33:48.705+0900 I/aa      ( 2927): res = 0
05-31 17:33:48.730+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:49.330+0900 I/aa      ( 2927): res = 0
05-31 17:33:49.330+0900 I/aa      ( 2927): res = 0
05-31 17:33:49.330+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:49.730+0900 I/aa      ( 2927): res = 0
05-31 17:33:49.730+0900 I/aa      ( 2927): res = 0
05-31 17:33:49.730+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:49.810+0900 E/EFL     ( 2927): evas_main<2927> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=39927105 button=1 downs=1
05-31 17:33:49.870+0900 E/EFL     ( 2927): evas_main<2927> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=39927165 button=1 downs=0
05-31 17:33:50.335+0900 I/aa      ( 2927): res = 0
05-31 17:33:50.335+0900 I/aa      ( 2927): res = 0
05-31 17:33:50.335+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:50.730+0900 I/aa      ( 2927): res = 0
05-31 17:33:50.730+0900 I/aa      ( 2927): res = 0
05-31 17:33:50.730+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:51.335+0900 I/aa      ( 2927): res = 0
05-31 17:33:51.335+0900 I/aa      ( 2927): res = 0
05-31 17:33:51.335+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:51.740+0900 I/aa      ( 2927): res = 0
05-31 17:33:51.745+0900 I/aa      ( 2927): res = 0
05-31 17:33:51.745+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:52.250+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:33:52.330+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2927
05-31 17:33:52.335+0900 I/aa      ( 2927): res = 0
05-31 17:33:52.335+0900 I/aa      ( 2927): res = 0
05-31 17:33:52.335+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:52.750+0900 I/aa      ( 2927): res = 0
05-31 17:33:52.750+0900 I/aa      ( 2927): res = 0
05-31 17:33:52.750+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:53.335+0900 E/WMS     (  496): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-31 17:33:53.340+0900 I/aa      ( 2927): res = 0
05-31 17:33:53.340+0900 I/aa      ( 2927): res = 0
05-31 17:33:53.340+0900 I/aa      ( 2927): db hi = -4.471332
05-31 17:33:53.375+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-31 17:33:53.375+0900 E/WMS     (  496): ==========
05-31 17:33:53.375+0900 E/WMS     (  496): ##WMS SEND : mgr_gear_wear_onoff_req
05-31 17:33:53.375+0900 E/WMS     (  496): ==========
05-31 17:33:53.375+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-31 17:33:53.450+0900 I/HAP     ( 2927): Updating UI with data 주의 하세요!
05-31 17:33:53.450+0900 E/EFL     ( 2927): evas-gl_x11<2927> evas_x_main.c:644 eng_window_use() eglMakeCurrent() failed!
05-31 17:33:53.470+0900 W/SHealth_Service( 1102): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
05-31 17:33:53.470+0900 E/SHealth_Service( 1102): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-31 17:33:53.750+0900 I/aa      ( 2927): res = 0
05-31 17:33:53.750+0900 I/aa      ( 2927): res = 0
05-31 17:33:53.750+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:54.750+0900 I/aa      ( 2927): res = 0
05-31 17:33:54.755+0900 I/aa      ( 2927): res = 0
05-31 17:33:54.755+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:55.755+0900 I/aa      ( 2927): res = 0
05-31 17:33:55.755+0900 I/aa      ( 2927): res = 0
05-31 17:33:55.755+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:56.575+0900 I/aa      ( 2927): db hi = 0
05-31 17:33:56.755+0900 I/aa      ( 2927): res = 0
05-31 17:33:56.755+0900 I/aa      ( 2927): res = 0
05-31 17:33:56.755+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:57.250+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:33:57.340+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2927
05-31 17:33:57.575+0900 I/aa      ( 2927): res = 0
05-31 17:33:57.580+0900 I/aa      ( 2927): res = 0
05-31 17:33:57.600+0900 I/aa      ( 2927): db hi = 0
05-31 17:33:57.760+0900 I/aa      ( 2927): res = 0
05-31 17:33:57.760+0900 I/aa      ( 2927): res = 0
05-31 17:33:57.760+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:58.600+0900 I/aa      ( 2927): res = 0
05-31 17:33:58.600+0900 I/aa      ( 2927): res = 0
05-31 17:33:58.600+0900 I/aa      ( 2927): db hi = 0
05-31 17:33:58.670+0900 E/WMS     (  496): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 2 -> 1
05-31 17:33:58.685+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-31 17:33:58.685+0900 E/WMS     (  496): ==========
05-31 17:33:58.685+0900 E/WMS     (  496): ##WMS SEND : mgr_gear_wear_onoff_req
05-31 17:33:58.685+0900 E/WMS     (  496): ==========
05-31 17:33:58.695+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-31 17:33:58.730+0900 W/SHealth_Service( 1102): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1007[0;m
05-31 17:33:58.730+0900 E/SHealth_Service( 1102): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-31 17:33:58.760+0900 I/aa      ( 2927): res = 0
05-31 17:33:58.760+0900 I/aa      ( 2927): res = 0
05-31 17:33:58.760+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:33:59.605+0900 I/aa      ( 2927): res = 0
05-31 17:33:59.605+0900 I/aa      ( 2927): res = 0
05-31 17:33:59.610+0900 I/aa      ( 2927): db hi = 0
05-31 17:33:59.760+0900 I/aa      ( 2927): res = 0
05-31 17:33:59.765+0900 I/aa      ( 2927): res = 0
05-31 17:33:59.765+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:34:00.155+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-31 17:34:00.165+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-31 17:34:00.165+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : pedometer_inactive_period error
05-31 17:34:00.165+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-31 17:34:00.170+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-31 17:34:00.170+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : inactive_10min_precaution_millisec error
05-31 17:34:00.175+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-31 17:34:00.175+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-31 17:34:00.185+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : inactive_before_10min_precaution_millisec error
05-31 17:34:00.615+0900 I/aa      ( 2927): res = 0
05-31 17:34:00.615+0900 I/aa      ( 2927): res = 0
05-31 17:34:00.615+0900 I/aa      ( 2927): db hi = 0
05-31 17:34:00.770+0900 I/aa      ( 2927): res = 0
05-31 17:34:00.770+0900 I/aa      ( 2927): res = 0
05-31 17:34:00.785+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:34:01.615+0900 I/aa      ( 2927): res = 0
05-31 17:34:01.615+0900 I/aa      ( 2927): res = 0
05-31 17:34:01.615+0900 I/aa      ( 2927): db hi = 0
05-31 17:34:01.785+0900 I/aa      ( 2927): res = 0
05-31 17:34:01.785+0900 I/aa      ( 2927): res = 0
05-31 17:34:01.785+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:34:02.255+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:34:02.340+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2927
05-31 17:34:02.625+0900 I/aa      ( 2927): res = 0
05-31 17:34:02.625+0900 I/aa      ( 2927): res = 0
05-31 17:34:02.625+0900 I/aa      ( 2927): db hi = 0
05-31 17:34:02.785+0900 I/aa      ( 2927): res = 0
05-31 17:34:02.800+0900 I/aa      ( 2927): res = 0
05-31 17:34:02.800+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:34:03.625+0900 I/aa      ( 2927): res = 0
05-31 17:34:03.625+0900 I/aa      ( 2927): res = 0
05-31 17:34:03.625+0900 I/aa      ( 2927): db hi = 0
05-31 17:34:03.800+0900 I/aa      ( 2927): res = 0
05-31 17:34:03.800+0900 I/aa      ( 2927): res = 0
05-31 17:34:03.800+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:34:04.475+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-31 17:34:04.480+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
05-31 17:34:04.480+0900 W/STARTER (  697): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-31 17:34:04.480+0900 W/W_HOME  (  722): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-31 17:34:04.480+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-31 17:34:04.480+0900 W/W_HOME  (  722): gesture.c: _manual_render_enable(133) > 1
05-31 17:34:04.480+0900 W/W_HOME  (  722): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-31 17:34:04.480+0900 W/W_HOME  (  722): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 17:34:04.480+0900 E/STARTER (  697): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-31 17:34:04.480+0900 W/STARTER (  697): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-31 17:34:04.485+0900 W/STARTER (  697): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-31 17:34:04.495+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-31 17:34:04.495+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-31 17:34:04.500+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-31 17:34:04.510+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-31 17:34:04.515+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-31 17:34:04.515+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 17:34:04.515+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-31 17:34:04.520+0900 I/HIGEAR  ( 1080): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-31 17:34:04.540+0900 I/watchface-viewer(  752): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
05-31 17:34:04.545+0900 W/MUSIC_CONTROL_SERVICE( 1056): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1056]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-31 17:34:04.545+0900 I/SHealth_Common( 1102): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-31 17:34:04.550+0900 I/SHealth_Service( 1102): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-31 17:34:04.565+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
05-31 17:34:04.565+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-31 17:34:04.565+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-31 17:34:04.565+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-31 17:34:04.570+0900 I/APP_CORE( 2927): appcore-efl.c: __do_app(429) > [APP 2927] Event: PAUSE State: RUNNING
05-31 17:34:04.570+0900 I/CAPI_APPFW_APPLICATION( 2927): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-31 17:34:04.595+0900 E/ALARM_MANAGER(  697): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(31-5-2016, 17:34:25), repeat(1), interval(20), type(-1073741822)
05-31 17:34:04.605+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:34:04.605+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:34:04.635+0900 I/aa      ( 2927): res = 0
05-31 17:34:04.635+0900 I/aa      ( 2927): res = 0
05-31 17:34:04.635+0900 I/aa      ( 2927): db hi = 0
05-31 17:34:04.685+0900 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 739166929, next duetime: 1464683665
05-31 17:34:04.685+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(739166929)
05-31 17:34:04.685+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464706800), due_time(1464683665)
05-31 17:34:04.690+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:34:04.690+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 08:34:25 (UTC).
05-31 17:34:04.690+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:34:04.800+0900 I/aa      ( 2927): res = 0
05-31 17:34:04.800+0900 I/aa      ( 2927): res = 0
05-31 17:34:04.800+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:34:05.635+0900 I/aa      ( 2927): res = 0
05-31 17:34:05.635+0900 I/aa      ( 2927): res = 0
05-31 17:34:05.655+0900 I/aa      ( 2927): db hi = 0
05-31 17:34:05.800+0900 I/aa      ( 2927): res = 0
05-31 17:34:05.800+0900 I/aa      ( 2927): res = 0
05-31 17:34:05.800+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:34:06.670+0900 I/aa      ( 2927): res = 0
05-31 17:34:06.670+0900 I/aa      ( 2927): res = 0
05-31 17:34:06.670+0900 I/aa      ( 2927): db hi = 0
05-31 17:34:06.805+0900 I/aa      ( 2927): res = 0
05-31 17:34:06.805+0900 I/aa      ( 2927): res = 0
05-31 17:34:06.805+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:34:07.160+0900 W/AUL_AMD (  498): amd_request.c: __request_handler(646) > __request_handler: 14
05-31 17:34:07.265+0900 W/AUL_AMD (  498): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2927
05-31 17:34:07.670+0900 I/aa      ( 2927): res = 0
05-31 17:34:07.670+0900 I/aa      ( 2927): res = 0
05-31 17:34:07.670+0900 I/aa      ( 2927): db hi = 0
05-31 17:34:07.805+0900 I/aa      ( 2927): res = 0
05-31 17:34:07.805+0900 I/aa      ( 2927): res = 0
05-31 17:34:07.805+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:34:08.675+0900 I/aa      ( 2927): res = 0
05-31 17:34:08.675+0900 I/aa      ( 2927): res = 0
05-31 17:34:08.675+0900 I/aa      ( 2927): db hi = 0
05-31 17:34:08.740+0900 E/WMS     (  496): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-31 17:34:08.745+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-31 17:34:08.745+0900 E/WMS     (  496): ==========
05-31 17:34:08.745+0900 E/WMS     (  496): ##WMS SEND : mgr_gear_wear_onoff_req
05-31 17:34:08.745+0900 E/WMS     (  496): ==========
05-31 17:34:08.745+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-31 17:34:08.810+0900 I/aa      ( 2927): res = 0
05-31 17:34:08.810+0900 I/aa      ( 2927): res = 0
05-31 17:34:08.810+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:34:09.575+0900 I/APP_CORE( 2927): appcore-efl.c: __do_app(429) > [APP 2927] Event: MEM_FLUSH State: PAUSED
05-31 17:34:09.675+0900 I/aa      ( 2927): res = 0
05-31 17:34:09.675+0900 I/aa      ( 2927): res = 0
05-31 17:34:09.675+0900 I/aa      ( 2927): db hi = -14.902522
05-31 17:34:09.740+0900 I/HAP     ( 2927): Updating UI with data 주의 하세요!
05-31 17:34:09.810+0900 I/aa      ( 2927): res = 0
05-31 17:34:09.810+0900 I/aa      ( 2927): res = 0
05-31 17:34:09.810+0900 I/aa      ( 2927): db hi = 1074543072
05-31 17:34:09.930+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-31 17:34:09.930+0900 W/W_HOME  (  722): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-31 17:34:09.930+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-31 17:34:09.930+0900 W/W_HOME  (  722): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-31 17:34:09.930+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:34:09.930+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:34:09.930+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-31 17:34:09.930+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-31 17:34:09.930+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-31 17:34:09.930+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-31 17:34:10.005+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
05-31 17:34:10.005+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1149) > Call the time_tick_cb
05-31 17:34:10.005+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:34:10.005+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:34:10.005+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-31 17:34:10.010+0900 W/W_HOME  (  722): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-31 17:34:10.010+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_set(161) > timer set
05-31 17:34:10.010+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-31 17:34:10.010+0900 W/W_HOME  (  722): gesture.c: _apps_status_get(123) > apps status:0
05-31 17:34:10.010+0900 W/W_HOME  (  722): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:0 info->offtime:5620
05-31 17:34:10.010+0900 W/W_HOME  (  722): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-31 17:34:10.010+0900 W/W_HOME  (  722): event_manager.c: _lcd_on_cb(691) > lcd state: 1
05-31 17:34:10.010+0900 W/W_HOME  (  722): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 17:34:10.010+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [gesture] after screen off time [5620]ms
05-31 17:34:10.010+0900 W/STARTER (  697): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
05-31 17:34:10.030+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-31 17:34:10.030+0900 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-31 17:34:10.030+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(739166929)
05-31 17:34:10.035+0900 I/APP_CORE( 2927): appcore-efl.c: __do_app(429) > [APP 2927] Event: RESUME State: PAUSED
05-31 17:34:10.035+0900 I/CAPI_APPFW_APPLICATION( 2927): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 17:34:10.035+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 17:34:10.035+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 31-5-2016, 15:00:00 (UTC).
05-31 17:34:10.035+0900 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 17:34:10.035+0900 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[739166929] is removed.
05-31 17:34:10.050+0900 W/MUSIC_CONTROL_SERVICE( 1056): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1056]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
05-31 17:34:10.050+0900 I/watchface-viewer(  752): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
05-31 17:34:10.055+0900 I/SHealth_Common( 1102): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
05-31 17:34:10.060+0900 I/SHealth_Service( 1102): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-31 17:34:10.065+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_set_param(1248) > [SVOICE] set param [keyword length] : 0
05-31 17:34:10.070+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-31 17:34:10.075+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Enable start
05-31 17:34:10.090+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-31 17:34:10.090+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 17:34:10.090+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
05-31 17:34:10.090+0900 I/HIGEAR  ( 1080): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
05-31 17:34:10.090+0900 W/STARTER (  697): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [gesture]
05-31 17:34:10.090+0900 W/STARTER (  697): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
05-31 17:34:10.090+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : 1075153676[0;m
05-31 17:34:10.090+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
05-31 17:34:10.095+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-31 17:34:10.100+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_set_param(1248) > [SVOICE] set param [keyword length] : 0
05-31 17:34:10.110+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-31 17:34:10.110+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Enable start
05-31 17:34:10.115+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-31 17:34:10.115+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 17:34:10.115+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
05-31 17:34:10.115+0900 I/HIGEAR  ( 1080): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
05-31 17:34:10.140+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-31 17:34:10.140+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-31 17:34:10.140+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : pedometer_inactive_period error
05-31 17:34:10.140+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-31 17:34:10.140+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-31 17:34:10.140+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : inactive_10min_precaution_millisec error
05-31 17:34:10.140+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-31 17:34:10.140+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-31 17:34:10.140+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1102): preference.c: preference_get_double(1214) > preference_get_double(1102) : inactive_before_10min_precaution_millisec error
05-31 17:34:10.140+0900 W/SHealth_Service( 1102): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
05-31 17:34:10.140+0900 E/SHealth_Service( 1102): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-31 17:34:10.210+0900 W/W_HOME  (  722): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
05-31 17:34:10.210+0900 W/W_HOME  (  722): gesture.c: _manual_render_enable(133) > 0
05-31 17:34:10.285+0900 E/WMS     (  496): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 2 -> 1
05-31 17:34:10.290+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-31 17:34:10.290+0900 E/WMS     (  496): ==========
05-31 17:34:10.290+0900 E/WMS     (  496): ##WMS SEND : mgr_gear_wear_onoff_req
05-31 17:34:10.290+0900 E/WMS     (  496): ==========
05-31 17:34:10.290+0900 E/WMS     (  496): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-31 17:34:10.330+0900 W/SHealth_Service( 1102): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1007[0;m
05-31 17:34:10.335+0900 E/SHealth_Service( 1102): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-31 17:34:10.810+0900 I/aa      ( 2927): res = 0
05-31 17:34:10.810+0900 I/aa      ( 2927): res = 0
05-31 17:34:10.810+0900 I/aa      ( 2927): db hi = -10.943951
05-31 17:34:10.905+0900 I/HAP     ( 2927): Updating UI with data 주의 하세요!
05-31 17:34:10.930+0900 E/EFL     ( 2927): evas-gl_x11<2927> evas_x_main.c:644 eng_window_use() eglMakeCurrent() failed!
05-31 17:34:10.945+0900 E/EFL     ( 2927): edje<2927> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "focus_bg". Already calculating XY [03] axes. Need to calculate XY [03] axes
05-31 17:34:10.955+0900 E/EFL     ( 2927): edje<2927> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "bg". Already calculating XY [03] axes. Need to calculate X [01] axes
05-31 17:34:10.955+0900 E/EFL     ( 2927): edje<2927> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "bg". Already calculating XY [03] axes. Need to calculate X [01] axes
05-31 17:34:10.960+0900 E/EFL     ( 2927): edje<2927> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "shadow_bottom". Already calculating X [01] axes. Need to calculate XY [03] axes
05-31 17:34:10.965+0900 E/EFL     ( 2927): edje<2927> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "elm.swallow.content". Already calculating X [01] axes. Need to calculate XY [03] axes
05-31 17:34:10.965+0900 E/EFL     ( 2927): edje<2927> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "bg". Already calculating XY [03] axes. Need to calculate X [01] axes
05-31 17:34:10.980+0900 E/EFL     ( 2927): edje<2927> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "elm.bg.title". Already calculating XY [03] axes. Need to calculate X [01] axes
05-31 17:34:10.980+0900 E/EFL     ( 2927): edje<2927> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "text_title_down_padding". Already calculating X [01] axes. Need to calculate XY [03] axes
05-31 17:34:10.980+0900 E/EFL     ( 2927): edje<2927> edje_calc.c:3312 _edje_part_recalc() Circular dependency when calculating part "base". Already calculating X [01] axes. Need to calculate XY [03] axes
05-31 17:34:11.250+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-31 17:34:11.250+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-31 17:34:11.250+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-31 17:34:11.250+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-31 17:34:11.250+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-31 17:34:11.250+0900 W/W_HOME  (  722): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-31 17:34:11.265+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-31 17:34:11.265+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-31 17:34:11.265+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-31 17:34:11.265+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_set_param(1248) > [SVOICE] set param [keyword length] : 0
05-31 17:34:11.290+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-31 17:34:11.315+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Enable start
05-31 17:34:11.320+0900 I/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-31 17:34:11.320+0900 W/TIZEN_N_SOUND_MANAGER( 1080): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 17:34:11.320+0900 W/WAKEUP-SERVICE( 1080): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
05-31 17:34:11.320+0900 I/HIGEAR  ( 1080): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
05-31 17:34:11.375+0900 W/CRASH_MANAGER( 3034): worker.c: worker_job(1199) > 1102927686170146468365
