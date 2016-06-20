S/W Version Information
Model: SM-R735S
Tizen-Version: 2.3.1.2
Build-Number: R735SKSU1AOKE
Build-Date: 2015.11.25 20:46:58

Crash Information
Process Name: hap
PID: 4435
Date: 2016-06-02 13:41:46+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x120

Register Information
r0   = 0x00000000, r1   = 0xb90ac278
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xb90ac2e0, r5   = 0xb903197c
r6   = 0xb90ac278, r7   = 0xb90678b0
r8   = 0x00000000, r9   = 0x00000000
r10  = 0xb90317b4, fp   = 0x00000003
ip   = 0x00000000, sp   = 0xbec5cc60
lr   = 0xb64c7861, pc   = 0xb64c511c
cpsr = 0x80000030

Memory Information
MemTotal:   407572 KB
MemFree:      9804 KB
Buffers:      3420 KB
Cached:      90756 KB
VmPeak:     235088 KB
VmSize:     229224 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       34948 KB
VmRSS:       34948 KB
VmData:     142976 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       70372 KB
VmPTE:         120 KB
VmSwap:       1432 KB

Threads Information
Threads: 15
PID = 4435 TID = 4435
4435 4436 4439 4440 4441 4445 4468 4611 4616 4631 4632 4633 4634 4635 4636 

Maps Information
a8c5e000 a945d000 rwxp [stack:4611]
a9c5d000 a9c61000 rwxs /dev/kgsl-3d0
a9c61000 a9c65000 rwxs /dev/kgsl-3d0
a9c71000 a9ccf000 rwxs /dev/kgsl-3d0
a9ccf000 a9d2d000 rwxs /dev/kgsl-3d0
a9d2d000 a9e53000 r-xp /usr/share/fallback_fonts/BreezeSansKorean-RegularCondensed.ttf
a9e54000 aa653000 rwxp [stack:4468]
aa654000 aae53000 rwxp [stack:4616]
aae54000 ab653000 rwxp [stack:4633]
aba54000 ac253000 rwxp [stack:4636]
ac254000 aca53000 rwxp [stack:4634]
ace2d000 ada2c000 rwxp [stack:4635]
ada2c000 ade2d000 rwxs /dev/shm/pulse-shm-768058440
ade2d000 ae22e000 rwxs /dev/shm/pulse-shm-3644223569
ae22e000 ae22f000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
ae236000 ae237000 rwxp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
ae237000 ae23a000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
ae241000 ae242000 rwxp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
ae242000 ae246000 rwxs /dev/kgsl-3d0
ae246000 ae24a000 rwxs /dev/kgsl-3d0
ae24a000 ae24e000 rwxs /dev/kgsl-3d0
ae24e000 ae252000 rwxs /dev/kgsl-3d0
ae256000 aea55000 rwxp [stack:4631]
aea55000 aea58000 r-xp /usr/lib/gstreamer-0.10/libgstwavenc.so
aea5f000 aea60000 rwxp /usr/lib/gstreamer-0.10/libgstwavenc.so
aea60000 aea7a000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
aea82000 aea83000 rwxp /usr/lib/gstreamer-0.10/libgstpulse.so
aea83000 aeabb000 r-xp /usr/lib/libsamrnb.so
aeac2000 aeadc000 rwxp /usr/lib/libsamrnb.so
aeade000 aeae9000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
aeaf1000 aeaf2000 rwxp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
aeaf2000 aeb02000 r-xp /usr/lib/gstreamer-0.10/libgstalsa.so
aeb09000 aeb0a000 rwxp /usr/lib/gstreamer-0.10/libgstalsa.so
aeb0a000 aeb10000 r-xp /usr/lib/libscmn.so
aeb17000 aeb18000 rwxp /usr/lib/libscmn.so
aeb18000 aeb50000 r-xp /usr/lib/libsaac.so
aeb50000 aeb51000 rwxp /usr/lib/libsaac.so
aeb5a000 aeb5f000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
aeb66000 aeb67000 rwxp /usr/lib/gstreamer-0.10/libgstsavsencamrnb.so
aeb67000 aeb6d000 r-xp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
aeb74000 aeb75000 rwxp /usr/lib/gstreamer-0.10/libgstsavsencaac.so
aeb75000 aeb8d000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
aeb94000 aeb95000 rwxp /usr/lib/libgstcontroller-0.10.so.0.30.0
aeb95000 aebad000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
aebb4000 aebb6000 rwxp /usr/lib/libgstpbutils-0.10.so.0.25.0
aebb6000 aebdf000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
aebe6000 aebe8000 rwxp /usr/lib/libgstaudio-0.10.so.0.25.0
aebe8000 aebed000 r-xp /usr/lib/gstreamer-0.10/libgstsecrecord.so
aebf4000 aebf5000 rwxp /usr/lib/gstreamer-0.10/libgstsecrecord.so
aebfe000 aed5c000 r-xp /usr/lib/gstreamer-0.10/libgstffmpeg.so
aed63000 aed6c000 rwxp /usr/lib/gstreamer-0.10/libgstffmpeg.so
aee44000 aee50000 r-xp /usr/lib/gstreamer-0.10/libgstencodebin.so
aee57000 aee58000 rwxp /usr/lib/gstreamer-0.10/libgstencodebin.so
aee58000 aee77000 r-xp /usr/lib/gstreamer-0.10/libgstomx.so
aee7f000 aee80000 rwxp /usr/lib/gstreamer-0.10/libgstomx.so
aee80000 aeeb4000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
aeebb000 aeebd000 rwxp /usr/lib/gstreamer-0.10/libgstcoreelements.so
aeebd000 aef44000 rwxs anon_inode:dmabuf
aef44000 aef4e000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.48
aef55000 aef56000 rwxp /usr/lib/libcapi-media-sound-manager.so.0.1.48
aef56000 aef57000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
aef5e000 aef5f000 rwxp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
aef5f000 aefe6000 rwxs anon_inode:dmabuf
aefe6000 af06d000 rwxs anon_inode:dmabuf
af06d000 af169000 rwxs /dev/kgsl-3d0
af169000 af16d000 rwxs /dev/kgsl-3d0
af16d000 af16e000 rwxs /dev/kgsl-3d0
af16e000 af16f000 rwxs /dev/kgsl-3d0
af16f000 af170000 rwxs /dev/kgsl-3d0
af170000 af171000 rwxs /dev/kgsl-3d0
af171000 af172000 rwxs /dev/kgsl-3d0
af172000 af1f9000 rwxs anon_inode:dmabuf
af1f9000 af280000 rwxs anon_inode:dmabuf
af281000 afa80000 rwxp [stack:4441]
afa81000 b0280000 rwxp [stack:4440]
b0281000 b0a80000 rwxp [stack:4439]
b0a80000 b0b0b000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
b0b0b000 b0b10000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
b0b17000 b0b18000 rwxp /usr/lib/gstreamer-0.10/libgstvolume.so
b0b18000 b0b1a000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
b0b21000 b0b22000 rwxp /usr/lib/libcapi-media-wav-player.so.0.1.10
b0b22000 b0b23000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b0b2a000 b0b2b000 rwxp /usr/lib/libmmfkeysound.so.0.0.0
b0b2b000 b0b32000 r-xp /usr/lib/libfeedback.so.0.1.4
b0b3a000 b0b3b000 rwxp /usr/lib/libfeedback.so.0.1.4
b0b3d000 b0b40000 r-xp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
b0b47000 b0b48000 rwxp /usr/lib/gstreamer-0.10/libgstavsysaudiosrc.so
b0b48000 b0b49000 r-xp /usr/lib/gstreamer-0.10/libgstapp.so
b0b50000 b0b51000 rwxp /usr/lib/gstreamer-0.10/libgstapp.so
b0b51000 b0b71000 rwxs /dev/kgsl-3d0
b0b71000 b0b75000 rwxs /dev/kgsl-3d0
b0b75000 b0b79000 rwxs /dev/kgsl-3d0
b0b79000 b0b99000 rwxs /dev/kgsl-3d0
b0b99000 b0bd9000 rwxs /dev/kgsl-3d0
b0bd9000 b0c00000 rwxs /dev/kgsl-3d0
b0d00000 b0d01000 rwxs /dev/kgsl-3d0
b0d01000 b0d02000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b0d09000 b0d0a000 rwxp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b0d0a000 b0d96000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
b0d96000 b0da5000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
b0da5000 b0da9000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
b0da9000 b0dac000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
b0dac000 b0db3000 r-xs /usr/lib/gconv/gconv-modules.cache
b0db4000 b1632000 rwxp [stack:4445]
b1632000 b1633000 rwxs /dev/kgsl-3d0
b1634000 b1e33000 rwxp [stack:4632]
b1e33000 b1e35000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b1e3c000 b1e3d000 rwxp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b1e3d000 b1e54000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b1e5c000 b1e61000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b1e61000 b201f000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
b201f000 b2021000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
b2021000 b2022000 rwxs /dev/kgsl-3d0
b2022000 b2023000 rwxs /dev/kgsl-3d0
b2023000 b2024000 rwxs /dev/kgsl-3d0
b2024000 b2025000 rwxs /dev/kgsl-3d0
b2025000 b2026000 rwxs /dev/kgsl-3d0
b2026000 b2027000 rwxs /dev/kgsl-3d0
b2027000 b2028000 rwxs /dev/kgsl-3d0
b2028000 b2029000 rwxs /dev/kgsl-3d0
b2029000 b202a000 rwxs /dev/kgsl-3d0
b202a000 b202b000 rwxs /dev/kgsl-3d0
b202b000 b202c000 rwxs /dev/kgsl-3d0
b202c000 b202d000 rwxs /dev/kgsl-3d0
b202d000 b202e000 rwxs /dev/kgsl-3d0
b202e000 b202f000 rwxs /dev/kgsl-3d0
b202f000 b2030000 rwxs /dev/kgsl-3d0
b2030000 b2031000 rwxs /dev/kgsl-3d0
b2031000 b2032000 rwxs /dev/kgsl-3d0
b2032000 b2033000 rwxs /dev/kgsl-3d0
b2033000 b2034000 rwxs /dev/kgsl-3d0
b2034000 b2035000 rwxs /dev/kgsl-3d0
b2035000 b2036000 rwxs /dev/kgsl-3d0
b2036000 b2037000 rwxs /dev/kgsl-3d0
b2037000 b2038000 rwxs /dev/kgsl-3d0
b2038000 b2039000 rwxs /dev/kgsl-3d0
b2039000 b203a000 rwxs /dev/kgsl-3d0
b203a000 b203b000 rwxs /dev/kgsl-3d0
b203b000 b203c000 rwxs /dev/kgsl-3d0
b203c000 b203d000 rwxs /dev/kgsl-3d0
b203d000 b203e000 rwxs /dev/kgsl-3d0
b203e000 b203f000 rwxs /dev/kgsl-3d0
b203f000 b2040000 rwxs /dev/kgsl-3d0
b2040000 b2041000 rwxs /dev/kgsl-3d0
b2041000 b2042000 rwxs /dev/kgsl-3d0
b2042000 b2043000 rwxs /dev/kgsl-3d0
b2043000 b2044000 rwxs /dev/kgsl-3d0
b2044000 b2045000 rwxs /dev/kgsl-3d0
b2045000 b2046000 rwxs /dev/kgsl-3d0
b2046000 b2047000 rwxs /dev/kgsl-3d0
b2047000 b2048000 rwxs /dev/kgsl-3d0
b2048000 b2049000 rwxs /dev/kgsl-3d0
b2049000 b204a000 rwxs /dev/kgsl-3d0
b204a000 b204b000 rwxs /dev/kgsl-3d0
b204b000 b204c000 rwxs /dev/kgsl-3d0
b204c000 b204d000 rwxs /dev/kgsl-3d0
b204d000 b204e000 rwxs /dev/kgsl-3d0
b204e000 b204f000 rwxs /dev/kgsl-3d0
b204f000 b2050000 rwxs /dev/kgsl-3d0
b2050000 b2051000 rwxs /dev/kgsl-3d0
b2051000 b2052000 rwxs /dev/kgsl-3d0
b2052000 b2053000 rwxs /dev/kgsl-3d0
b2053000 b2054000 rwxs /dev/kgsl-3d0
b2054000 b2055000 rwxs /dev/kgsl-3d0
b2055000 b2056000 rwxs /dev/kgsl-3d0
b2056000 b2057000 rwxs /dev/kgsl-3d0
b2057000 b2058000 rwxs /dev/kgsl-3d0
b2058000 b2059000 rwxs /dev/kgsl-3d0
b2059000 b205a000 rwxs /dev/kgsl-3d0
b205a000 b205b000 rwxs /dev/kgsl-3d0
b205b000 b205c000 rwxs /dev/kgsl-3d0
b205c000 b205d000 rwxs /dev/kgsl-3d0
b205d000 b205e000 rwxs /dev/kgsl-3d0
b205e000 b205f000 rwxs /dev/kgsl-3d0
b205f000 b2060000 rwxs /dev/kgsl-3d0
b2060000 b2061000 rwxs /dev/kgsl-3d0
b2061000 b2062000 rwxs /dev/kgsl-3d0
b2062000 b2063000 rwxs /dev/kgsl-3d0
b2063000 b2064000 rwxs /dev/kgsl-3d0
b2064000 b2065000 rwxs /dev/kgsl-3d0
b2065000 b2066000 rwxs /dev/kgsl-3d0
b2066000 b2067000 rwxs /dev/kgsl-3d0
b2067000 b2068000 rwxs /dev/kgsl-3d0
b2068000 b2069000 rwxs /dev/kgsl-3d0
b2069000 b206a000 rwxs /dev/kgsl-3d0
b206a000 b206b000 rwxs /dev/kgsl-3d0
b206b000 b206c000 rwxs /dev/kgsl-3d0
b206c000 b206d000 rwxs /dev/kgsl-3d0
b206d000 b206e000 rwxs /dev/kgsl-3d0
b206e000 b206f000 rwxs /dev/kgsl-3d0
b206f000 b2070000 rwxs /dev/kgsl-3d0
b2070000 b2071000 rwxs /dev/kgsl-3d0
b2071000 b2072000 rwxs /dev/kgsl-3d0
b2072000 b2073000 rwxs /dev/kgsl-3d0
b2073000 b2074000 rwxs /dev/kgsl-3d0
b2074000 b2075000 rwxs /dev/kgsl-3d0
b2075000 b2076000 rwxs /dev/kgsl-3d0
b2076000 b208b000 r-xs /opt/home/app/.cache/evas_gl_common_caches/Qualcomm::OpenGL
b208c000 b288b000 rwxp [stack:4436]
b288b000 b289b000 rwxs /dev/kgsl-3d0
b289b000 b31c7000 r-xp /usr/lib/libsc-a3xx.so
b31cf000 b3203000 rwxp /usr/lib/libsc-a3xx.so
b3414000 b3416000 r-xp /usr/lib/libgenlock.so
b341d000 b341e000 rwxp /usr/lib/libgenlock.so
b341e000 b341f000 rwxs /dev/kgsl-3d0
b341f000 b3420000 rwxs /dev/kgsl-3d0
b3420000 b3421000 rwxs /dev/kgsl-3d0
b3421000 b3425000 rwxs /dev/kgsl-3d0
b3426000 b3427000 rwxs /dev/kgsl-3d0
b3427000 b3428000 rwxs /dev/kgsl-3d0
b3428000 b3429000 rwxs /dev/kgsl-3d0
b3429000 b342a000 rwxs /dev/kgsl-3d0
b342a000 b342b000 rwxs /dev/kgsl-3d0
b342b000 b342c000 rwxs /dev/kgsl-3d0
b342c000 b342d000 rwxs /dev/kgsl-3d0
b342d000 b342e000 rwxs /dev/kgsl-3d0
b342e000 b342f000 rwxs /dev/kgsl-3d0
b342f000 b3430000 rwxs /dev/kgsl-3d0
b3430000 b3432000 rwxs /dev/kgsl-3d0
b3432000 b3434000 rwxs /dev/kgsl-3d0
b3434000 b3438000 r-xp /usr/lib/libxcb-xfixes.so.0.0.0
b343f000 b3440000 rwxp /usr/lib/libxcb-xfixes.so.0.0.0
b3440000 b3443000 r-xp /usr/lib/libxcb-dri2.so.0.0.0
b344a000 b344b000 rwxp /usr/lib/libxcb-dri2.so.0.0.0
b344b000 b344c000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b3453000 b3454000 rwxp /usr/lib/libX11-xcb.so.1.0.0
b3454000 b3457000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b345e000 b345f000 rwxp /usr/lib/libnative-buffer.so.0.1.0
b345f000 b3460000 rwxs /dev/kgsl-3d0
b3460000 b3464000 rwxs /dev/kgsl-3d0
b3464000 b3468000 rwxs /dev/kgsl-3d0
b3468000 b346d000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b3474000 b3475000 rwxp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b3475000 b35b0000 r-xp /usr/lib/egl/libGLESv2.so
b35b7000 b35eb000 rwxp /usr/lib/egl/libGLESv2.so
b35ec000 b35ee000 r-xp /usr/lib/libadreno_utils.so
b35f5000 b35f6000 rwxp /usr/lib/libadreno_utils.so
b35f8000 b361f000 r-xp /usr/lib/libgsl.so
b3626000 b3628000 rwxp /usr/lib/libgsl.so
b3628000 b3629000 rwxs /dev/kgsl-3d0
b3629000 b362a000 rwxs /dev/kgsl-3d0
b362a000 b362e000 rwxs /dev/kgsl-3d0
b362e000 b362f000 rwxs /dev/kgsl-3d0
b362f000 b3636000 r-xp /usr/lib/egl/eglsubX11.so
b363d000 b363e000 rwxp /usr/lib/egl/eglsubX11.so
b363e000 b3660000 r-xp /usr/lib/egl/libEGL.so
b3668000 b3669000 rwxp /usr/lib/egl/libEGL.so
b3669000 b36e0000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b36e8000 b36ea000 rwxp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b36f0000 b3822000 r-xp /usr/share/locale/locale-archive
b3822000 b3a22000 r-xp /usr/share/locale/locale-archive
b3a22000 b3a2c000 r-xp /lib/libnss_files-2.13.so
b3a33000 b3a34000 r-xp /lib/libnss_files-2.13.so
b3a34000 b3a35000 rwxp /lib/libnss_files-2.13.so
b3a35000 b3b04000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3b0b000 b3b1a000 rwxp /usr/lib/libscim-1.0.so.8.2.3
b3b1a000 b3b3e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b3b45000 b3b47000 rwxp /usr/lib/ecore/immodules/libisf-imf-module.so
b3b47000 b3c11000 r-xp /usr/lib/libCOREGL.so.4.0
b3c18000 b3c1a000 rwxp /usr/lib/libCOREGL.so.4.0
b3c29000 b3c2c000 r-xp /lib/libattr.so.1.1.0
b3c33000 b3c34000 rwxp /lib/libattr.so.1.1.0
b3c34000 b3c3d000 r-xp /usr/lib/libresourced.so.0.2.86
b3c44000 b3c45000 rwxp /usr/lib/libresourced.so.0.2.86
b3c45000 b3c46000 r-xp /usr/lib/librd-network.so.0.2.86
b3c4d000 b3c4e000 rwxp /usr/lib/librd-network.so.0.2.86
b3c4f000 b3c51000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b3c58000 b3c59000 rwxp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b3c59000 b3c60000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b3c68000 b3c69000 rwxp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b3c69000 b3c70000 r-xp /lib/libcrypt-2.13.so
b3c77000 b3c78000 r-xp /lib/libcrypt-2.13.so
b3c78000 b3c79000 rwxp /lib/libcrypt-2.13.so
b3ca0000 b3ca3000 r-xp /lib/libcap.so.2.21
b3caa000 b3cab000 rwxp /lib/libcap.so.2.21
b3cab000 b3cad000 r-xp /usr/lib/libiri.so
b3cb4000 b3cb5000 rwxp /usr/lib/libiri.so
b3cb6000 b3cd0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b3cd8000 b3cd9000 rwxp /usr/lib/libpkgmgr-client.so.0.1.68
b3cd9000 b3cf5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3cfd000 b3cfe000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
b3cfe000 b3d02000 r-xp /usr/lib/libogg.so.0.7.1
b3d09000 b3d0a000 rwxp /usr/lib/libogg.so.0.7.1
b3d0a000 b3d2c000 r-xp /usr/lib/libvorbis.so.0.4.3
b3d33000 b3d34000 rwxp /usr/lib/libvorbis.so.0.4.3
b3d35000 b3d40000 r-xp /usr/lib/libgpg-error.so.0.15.0
b3d47000 b3d48000 rwxp /usr/lib/libgpg-error.so.0.15.0
b3d48000 b3d76000 r-xp /usr/lib/libidn.so.11.5.44
b3d7d000 b3d7e000 rwxp /usr/lib/libidn.so.11.5.44
b3d7e000 b3d87000 r-xp /usr/lib/libcares.so.2.1.0
b3d8f000 b3d90000 rwxp /usr/lib/libcares.so.2.1.0
b3d90000 b3d92000 r-xp /usr/lib/libXau.so.6.0.0
b3d99000 b3d9a000 rwxp /usr/lib/libXau.so.6.0.0
b3d9b000 b3da3000 r-xp /usr/lib/libmdm-common.so.1.0.89
b3da3000 b3da4000 rwxp /usr/lib/libmdm-common.so.1.0.89
b3da4000 b3e38000 r-xp /usr/lib/libstdc++.so.6.0.16
b3e40000 b3e43000 r-xp /usr/lib/libstdc++.so.6.0.16
b3e43000 b3e45000 rwxp /usr/lib/libstdc++.so.6.0.16
b3e4b000 b3e50000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b3e57000 b3e58000 rwxp /usr/lib/libcsc-feature.so.0.0.0
b3e58000 b3e60000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
b3e67000 b3e68000 rwxp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
b3e69000 b3e6f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b3e76000 b3e77000 rwxp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b3e77000 b3e7e000 r-xp /usr/lib/libminizip.so.1.0.0
b3e85000 b3e86000 rwxp /usr/lib/libminizip.so.1.0.0
b3e86000 b402e000 r-xp /usr/lib/libcrypto.so.1.0.0
b402e000 b4043000 rwxp /usr/lib/libcrypto.so.1.0.0
b4047000 b4094000 r-xp /usr/lib/libssl.so.1.0.0
b409b000 b40a0000 rwxp /usr/lib/libssl.so.1.0.0
b40a0000 b40c6000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b40ce000 b40cf000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
b40d0000 b4113000 r-xp /usr/lib/libsndfile.so.1.0.25
b411a000 b411c000 rwxp /usr/lib/libsndfile.so.1.0.25
b4120000 b4168000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4168000 b4169000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4169000 b416e000 r-xp /usr/lib/libjson.so.0.0.1
b4175000 b4176000 rwxp /usr/lib/libjson.so.0.0.1
b4176000 b417e000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b4185000 b4186000 rwxp /usr/lib/lib_DNSe_NRSS_ver225.so
b418d000 b419d000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b419d000 b41a1000 rwxp /usr/lib/lib_SamsungRec_TizenV04014.so
b41be000 b573c000 r-xp /usr/lib/libicudata.so.51.1
b5743000 b5744000 rwxp /usr/lib/libicudata.so.51.1
b5745000 b5829000 r-xp /usr/lib/libicuuc.so.51.1
b5830000 b583a000 rwxp /usr/lib/libicuuc.so.51.1
b583e000 b597b000 r-xp /usr/lib/libicui18n.so.51.1
b5983000 b598b000 rwxp /usr/lib/libicui18n.so.51.1
b598b000 b5998000 r-xp /usr/lib/libail.so.0.1.0
b59a0000 b59a1000 rwxp /usr/lib/libail.so.0.1.0
b59a1000 b59a4000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b59ab000 b59ac000 rwxp /usr/lib/libsyspopup_caller.so.0.1.0
b59ac000 b5a0d000 r-xp /usr/lib/libasound.so.2.0.0
b5a14000 b5a17000 rwxp /usr/lib/libasound.so.2.0.0
b5a18000 b5a1b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b5a22000 b5a23000 rwxp /usr/lib/libpulse-simple.so.0.0.4
b5a23000 b5a28000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b5a2f000 b5a30000 rwxp /usr/lib/libascenario-0.2.so.0.0.0
b5a30000 b5a49000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b5a51000 b5a52000 rwxp /usr/lib/libavsysaudio.so.0.0.1
b5a52000 b5a56000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b5a5e000 b5a5f000 rwxp /usr/lib/libmmfsoundcommon.so.0.0.0
b5a5f000 b5aa0000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b5aa8000 b5aa9000 rwxp /usr/lib/libgstbase-0.10.so.0.30.0
b5aaa000 b5aac000 r-xp /usr/lib/libdri2.so.0.0.0
b5ab3000 b5ab4000 rwxp /usr/lib/libdri2.so.0.0.0
b5ab4000 b5abc000 r-xp /usr/lib/libdrm.so.2.4.0
b5ac3000 b5ac4000 rwxp /usr/lib/libdrm.so.2.4.0
b5ac4000 b5ac6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5acd000 b5ace000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b5ace000 b5ad0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ad8000 b5ad9000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b5ad9000 b5b55000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b5c000 b5b61000 rwxp /usr/lib/libgcrypt.so.20.0.3
b5b62000 b5b7a000 r-xp /usr/lib/liblzma.so.5.0.3
b5b81000 b5b82000 rwxp /usr/lib/liblzma.so.5.0.3
b5b82000 b5bc6000 r-xp /usr/lib/libcurl.so.4.3.0
b5bcd000 b5bcf000 rwxp /usr/lib/libcurl.so.4.3.0
b5bcf000 b5bd2000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b5bd9000 b5bda000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
b5bda000 b5bde000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b5be6000 b5be7000 rwxp /usr/lib/libecore_ipc.so.1.7.99
b5be8000 b5bed000 r-xp /usr/lib/libecore_fb.so.1.7.99
b5bf4000 b5bf6000 rwxp /usr/lib/libecore_fb.so.1.7.99
b5bf6000 b5c19000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c20000 b5c21000 rwxp /usr/lib/libjpeg.so.8.0.2
b5c31000 b5c47000 r-xp /lib/libexpat.so.1.5.2
b5c4f000 b5c51000 rwxp /lib/libexpat.so.1.5.2
b5c51000 b5c64000 r-xp /usr/lib/libxcb.so.1.1.0
b5c6c000 b5c6d000 rwxp /usr/lib/libxcb.so.1.1.0
b5c6d000 b5c73000 r-xp /usr/lib/libxcb-render.so.0.0.0
b5c7a000 b5c7b000 rwxp /usr/lib/libxcb-render.so.0.0.0
b5c7c000 b5c7d000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b5c85000 b5c86000 rwxp /usr/lib/libxcb-shm.so.0.0.0
b5c86000 b5c9e000 r-xp /usr/lib/libpng12.so.0.50.0
b5ca5000 b5ca6000 rwxp /usr/lib/libpng12.so.0.50.0
b5ca6000 b5ca9000 r-xp /usr/lib/libEGL.so.1.4
b5cb0000 b5cb1000 rwxp /usr/lib/libEGL.so.1.4
b5cb1000 b5cbf000 r-xp /usr/lib/libGLESv2.so.2.0
b5cc7000 b5cc8000 rwxp /usr/lib/libGLESv2.so.2.0
b5cc8000 b5cc9000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5cd0000 b5cd1000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
b5cd2000 b5ce9000 r-xp /usr/lib/liblua-5.1.so
b5cf1000 b5cf2000 rwxp /usr/lib/liblua-5.1.so
b5cf2000 b5cf9000 r-xp /usr/lib/libembryo.so.1.7.99
b5d00000 b5d01000 rwxp /usr/lib/libembryo.so.1.7.99
b5d01000 b5d0b000 r-xp /usr/lib/libXext.so.6.4.0
b5d13000 b5d14000 rwxp /usr/lib/libXext.so.6.4.0
b5d14000 b5d17000 r-xp /usr/lib/libXtst.so.6.1.0
b5d1f000 b5d20000 rwxp /usr/lib/libXtst.so.6.1.0
b5d20000 b5d26000 r-xp /usr/lib/libXrender.so.1.3.0
b5d2d000 b5d2e000 rwxp /usr/lib/libXrender.so.1.3.0
b5d2f000 b5d35000 r-xp /usr/lib/libXrandr.so.2.2.0
b5d3c000 b5d3d000 rwxp /usr/lib/libXrandr.so.2.2.0
b5d3d000 b5d3e000 r-xp /usr/lib/libXinerama.so.1.0.0
b5d46000 b5d47000 rwxp /usr/lib/libXinerama.so.1.0.0
b5d47000 b5d4a000 r-xp /usr/lib/libXfixes.so.3.1.0
b5d51000 b5d52000 rwxp /usr/lib/libXfixes.so.3.1.0
b5d52000 b5d54000 r-xp /usr/lib/libXgesture.so.7.0.0
b5d5b000 b5d5c000 rwxp /usr/lib/libXgesture.so.7.0.0
b5d5c000 b5d5e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5d65000 b5d66000 rwxp /usr/lib/libXcomposite.so.1.0.0
b5d66000 b5d68000 r-xp /usr/lib/libXdamage.so.1.1.0
b5d6f000 b5d70000 rwxp /usr/lib/libXdamage.so.1.1.0
b5d71000 b5d78000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d7f000 b5d80000 rwxp /usr/lib/libXcursor.so.1.0.2
b5d80000 b5d90000 r-xp /lib/libresolv-2.13.so
b5d90000 b5d91000 r-xp /lib/libresolv-2.13.so
b5d91000 b5d92000 rwxp /lib/libresolv-2.13.so
b5d94000 b5daa000 r-xp /lib/libz.so.1.2.5
b5db1000 b5db2000 rwxp /lib/libz.so.1.2.5
b5db2000 b5db7000 r-xp /usr/lib/libffi.so.5.0.10
b5dbe000 b5dbf000 rwxp /usr/lib/libffi.so.5.0.10
b5dbf000 b5dc0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5dc7000 b5dc8000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b5dc9000 b5dcb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5dd2000 b5dd3000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b5dd3000 b5e04000 r-xp /usr/lib/libmdm.so.1.1.85
b5e0b000 b5e0c000 rwxp /usr/lib/libmdm.so.1.1.85
b5e0c000 b5e13000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b5e1a000 b5e1b000 rwxp /usr/lib/libmmfcommon.so.0.0.0
b5e1b000 b5e25000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b5e2d000 b5e2e000 rwxp /usr/lib/libaudio-session-mgr.so.0.0.0
b5e31000 b5e4a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
b5e52000 b5e53000 rwxp /usr/lib/libprivacy-manager-client.so.0.0.7
b5e53000 b5e58000 r-xp /usr/lib/libstorage.so.0.1
b5e5f000 b5e60000 rwxp /usr/lib/libstorage.so.0.1
b5e61000 b5e66000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b5e6d000 b5e6e000 rwxp /usr/lib/libmmutil_imgp.so.0.0.0
b5e6e000 b5e70000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
b5e77000 b5e78000 rwxp /usr/lib/libcamsrcjpegenc.so.0.0.0
b5e78000 b5eb0000 r-xp /usr/lib/libpulse.so.0.16.2
b5eb0000 b5eb1000 rwxp /usr/lib/libpulse.so.0.16.2
b5eb1000 b5eb6000 r-xp /usr/lib/libmmfsession.so.0.0.0
b5ebd000 b5ebe000 rwxp /usr/lib/libmmfsession.so.0.0.0
b5ebe000 b5ed4000 r-xp /usr/lib/libmmfsound.so.0.1.0
b5edc000 b5edd000 rwxp /usr/lib/libmmfsound.so.0.1.0
b5ee7000 b5f08000 r-xp /usr/lib/libexif.so.12.3.3
b5f0f000 b5f1b000 rwxp /usr/lib/libexif.so.12.3.3
b5f1b000 b5f24000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b5f2b000 b5f2c000 rwxp /usr/lib/libgstapp-0.10.so.0.25.0
b5f2c000 b5f39000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b5f41000 b5f42000 rwxp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b5f42000 b5f49000 r-xp /usr/lib/libtbm.so.1.0.0
b5f50000 b5f51000 rwxp /usr/lib/libtbm.so.1.0.0
b5f51000 b5f56000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
b5f5d000 b5f5e000 rwxp /usr/lib/libcapi-media-tool.so.0.1.5
b5f5f000 b5f65000 r-xp /usr/lib/libecore_imf.so.1.7.99
b5f6c000 b5f6d000 rwxp /usr/lib/libecore_imf.so.1.7.99
b5f6d000 b5f70000 r-xp /usr/lib/libsmack.so.1.0.0
b5f77000 b5f78000 rwxp /usr/lib/libsmack.so.1.0.0
b5f78000 b5f7e000 r-xp /usr/lib/libappsvc.so.0.1.0
b5f85000 b5f86000 rwxp /usr/lib/libappsvc.so.0.1.0
b5f86000 b5ffb000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6002000 b6005000 rwxp /usr/lib/libsqlite3.so.0.8.6
b6005000 b601a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6021000 b6022000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b6023000 b6026000 r-xp /usr/lib/libproc-stat.so.0.2.86
b602d000 b602e000 rwxp /usr/lib/libproc-stat.so.0.2.86
b602e000 b606a000 r-xp /usr/lib/libsystemd.so.0.4.0
b6071000 b6072000 r-xp /usr/lib/libsystemd.so.0.4.0
b6072000 b6073000 rwxp /usr/lib/libsystemd.so.0.4.0
b6073000 b6078000 r-xp /usr/lib/libxdgmime.so.1.1.0
b607f000 b6080000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6080000 b6097000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b609e000 b609f000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b609f000 b60a2000 r-xp /usr/lib/libbundle.so.0.1.22
b60a9000 b60aa000 rwxp /usr/lib/libbundle.so.0.1.22
b60ab000 b60b3000 r-xp /usr/lib/libsap_client.so.0.0.0
b60ba000 b60bb000 rwxp /usr/lib/libsap_client.so.0.0.0
b60bb000 b6111000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6119000 b611e000 rwxp /usr/lib/libpixman-1.so.0.28.2
b611e000 b6174000 r-xp /usr/lib/libfreetype.so.6.11.3
b617c000 b6180000 rwxp /usr/lib/libfreetype.so.6.11.3
b6180000 b61bd000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b61c4000 b61c5000 rwxp /usr/lib/libharfbuzz.so.0.940.0
b61c6000 b61d9000 r-xp /usr/lib/libfribidi.so.0.3.1
b61e0000 b61e1000 rwxp /usr/lib/libfribidi.so.0.3.1
b61e2000 b61fc000 r-xp /usr/lib/libecore_con.so.1.7.99
b6203000 b6204000 rwxp /usr/lib/libecore_con.so.1.7.99
b6205000 b622f000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6237000 b6238000 rwxp /usr/lib/libdbus-1.so.3.8.12
b6238000 b6241000 r-xp /usr/lib/libedbus.so.1.7.99
b6248000 b6249000 rwxp /usr/lib/libedbus.so.1.7.99
b6249000 b625a000 r-xp /usr/lib/libecore_input.so.1.7.99
b6261000 b6262000 rwxp /usr/lib/libecore_input.so.1.7.99
b6262000 b6267000 r-xp /usr/lib/libecore_file.so.1.7.99
b626e000 b626f000 rwxp /usr/lib/libecore_file.so.1.7.99
b626f000 b6291000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6298000 b629a000 rwxp /usr/lib/libecore_evas.so.1.7.99
b629b000 b62b4000 r-xp /usr/lib/libeet.so.1.7.99
b62bc000 b62bd000 rwxp /usr/lib/libeet.so.1.7.99
b62c5000 b62ed000 r-xp /usr/lib/libfontconfig.so.1.8.0
b62ed000 b62ee000 rwxp /usr/lib/libfontconfig.so.1.8.0
b62ee000 b62f7000 r-xp /usr/lib/libXi.so.6.1.0
b62fe000 b62ff000 rwxp /usr/lib/libXi.so.6.1.0
b62ff000 b63e0000 r-xp /usr/lib/libX11.so.6.3.0
b63e7000 b63eb000 rwxp /usr/lib/libX11.so.6.3.0
b63eb000 b64a3000 r-xp /usr/lib/libcairo.so.2.11200.14
b64aa000 b64ad000 rwxp /usr/lib/libcairo.so.2.11200.14
b64af000 b650c000 r-xp /usr/lib/libedje.so.1.7.99
b6514000 b6516000 rwxp /usr/lib/libedje.so.1.7.99
b6516000 b6566000 r-xp /usr/lib/libecore_x.so.1.7.99
b6566000 b6568000 rwxp /usr/lib/libecore_x.so.1.7.99
b6568000 b656e000 r-xp /lib/librt-2.13.so
b6575000 b6576000 r-xp /lib/librt-2.13.so
b6576000 b6577000 rwxp /lib/librt-2.13.so
b6577000 b6643000 r-xp /usr/lib/libxml2.so.2.7.8
b664a000 b664f000 rwxp /usr/lib/libxml2.so.2.7.8
b6650000 b6652000 r-xp /usr/lib/libiniparser.so.0
b665a000 b665b000 rwxp /usr/lib/libiniparser.so.0
b665c000 b6690000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6697000 b6699000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b6699000 b676c000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6773000 b6777000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b6777000 b6847000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6847000 b6848000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6848000 b684c000 r-xp /usr/lib/libvconf.so.0.2.45
b6853000 b6854000 rwxp /usr/lib/libvconf.so.0.2.45
b6854000 b685a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b6862000 b6863000 rwxp /usr/lib/libcapi-base-common.so.0.1.8
b6864000 b68ff000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b6907000 b690a000 rwxp /usr/lib/libgstreamer-0.10.so.0.30.0
b690b000 b6964000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b696c000 b6972000 rwxp /usr/lib/libmmfcamcorder.so.0.0.0
b6972000 b6984000 r-xp /usr/lib/libcapi-media-camera.so.0.1.34
b698b000 b698c000 rwxp /usr/lib/libcapi-media-camera.so.0.1.34
b698c000 b6991000 r-xp /usr/lib/libappcore-common.so.1.1
b6998000 b6999000 rwxp /usr/lib/libappcore-common.so.1.1
b6999000 b699e000 r-xp /usr/lib/libappcore-efl.so.1.1
b69a5000 b69a6000 rwxp /usr/lib/libappcore-efl.so.1.1
b69a6000 b69ab000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b69b2000 b69b3000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b69b3000 b69c7000 r-xp /lib/libpthread-2.13.so
b69ce000 b69cf000 r-xp /lib/libpthread-2.13.so
b69cf000 b69d0000 rwxp /lib/libpthread-2.13.so
b69d2000 b69f4000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b69fb000 b69fc000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b69fc000 b6a08000 r-xp /usr/lib/libaul.so.0.1.0
b6a10000 b6a11000 rwxp /usr/lib/libaul.so.0.1.0
b6a12000 b6a1a000 r-xp /lib/libgcc_s-4.6.so.1
b6a1a000 b6a1b000 rwxp /lib/libgcc_s-4.6.so.1
b6a1b000 b6a1d000 r-xp /lib/libdl-2.13.so
b6a24000 b6a25000 r-xp /lib/libdl-2.13.so
b6a25000 b6a26000 rwxp /lib/libdl-2.13.so
b6a26000 b6a31000 r-xp /lib/libunwind.so.8.0.1
b6a38000 b6a39000 rwxp /lib/libunwind.so.8.0.1
b6a5e000 b6b79000 r-xp /lib/libc-2.13.so
b6b81000 b6b83000 r-xp /lib/libc-2.13.so
b6b83000 b6b84000 rwxp /lib/libc-2.13.so
b6b87000 b6bf0000 r-xp /lib/libm-2.13.so
b6bf7000 b6bf8000 r-xp /lib/libm-2.13.so
b6bf8000 b6bf9000 rwxp /lib/libm-2.13.so
b6bf9000 b6c06000 r-xp /usr/lib/libsap-client-stub-api.so.1.0.0
b6c0d000 b6c0e000 rwxp /usr/lib/libsap-client-stub-api.so.1.0.0
b6c0e000 b6c20000 r-xp /usr/lib/libtts.so
b6c27000 b6c28000 rwxp /usr/lib/libtts.so
b6c28000 b6cf7000 r-xp /usr/lib/libevas.so.1.7.99
b6cfe000 b6d08000 rwxp /usr/lib/libevas.so.1.7.99
b6d1b000 b6e55000 r-xp /usr/lib/libelementary.so.1.7.99
b6e5c000 b6e64000 rwxp /usr/lib/libelementary.so.1.7.99
b6e6b000 b6eac000 r-xp /usr/lib/libeina.so.1.7.99
b6eb3000 b6eb5000 rwxp /usr/lib/libeina.so.1.7.99
b6eb5000 b6ed6000 r-xp /usr/lib/libefl-extension.so.0.1.0
b6edd000 b6ede000 rwxp /usr/lib/libefl-extension.so.0.1.0
b6ede000 b6ef5000 r-xp /usr/lib/libecore.so.1.7.99
b6efd000 b6efe000 rwxp /usr/lib/libecore.so.1.7.99
b6f0c000 b6f0e000 r-xp /usr/lib/libdlog.so.0.0.0
b6f15000 b6f16000 rwxp /usr/lib/libdlog.so.0.0.0
b6f16000 b6f1b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6f22000 b6f23000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
b6f23000 b6f28000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b6f2f000 b6f30000 rwxp /usr/lib/libcapi-system-device.so.0.1.0
b6f30000 b6f38000 r-xp /usr/lib/libcapi-media-recorder.so.0.1.27
b6f3f000 b6f40000 rwxp /usr/lib/libcapi-media-recorder.so.0.1.27
b6f40000 b6f44000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b6f4b000 b6f4c000 rwxp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b6f4c000 b6f4e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6f56000 b6f57000 rwxp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6f57000 b6f59000 r-xs /dev/kgsl-3d0
b6f59000 b6f64000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b6f6c000 b6f6d000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b6f6d000 b6f71000 r-xp /usr/lib/libsys-assert.so
b6f79000 b6f7a000 rwxp /usr/lib/libsys-assert.so
b6f7a000 b6f97000 r-xp /lib/ld-2.13.so
b6f9e000 b6f9f000 r-xp /lib/ld-2.13.so
b6f9f000 b6fa0000 rwxp /lib/ld-2.13.so
b6fa0000 b6fa8000 r-xp /opt/usr/apps/org.example.hap/bin/hap
b6fa8000 b6fa9000 rwxp /opt/usr/apps/org.example.hap/bin/hap
b8c55000 b9141000 rwxp [heap]
bec3d000 bec5e000 rwxp [stack]
End of Maps Information

Callstack Information (PID:4435)
Call Stack Count: 13
 0: (0xb64c511c) [/usr/lib/libedje.so.1] + 0x1611c
 1: (0xb64c7861) [/usr/lib/libedje.so.1] + 0x18861
 2: (0xb64c9a37) [/usr/lib/libedje.so.1] + 0x1aa37
 3: (0xb6c5da0b) [/usr/lib/libevas.so.1] + 0x35a0b
 4: (0xb6c831b3) [/usr/lib/libevas.so.1] + 0x5b1b3
 5: (0xb6281071) [/usr/lib/libecore_evas.so.1] + 0x12071
 6: (0xb627e6ed) [/usr/lib/libecore_evas.so.1] + 0xf6ed
 7: (0xb6ee8f25) [/usr/lib/libecore.so.1] + 0xaf25
 8: (0xb6eea34f) [/usr/lib/libecore.so.1] + 0xc34f
 9: ecore_main_loop_begin + 0x30 (0xb6eea8b9) [/usr/lib/libecore.so.1] + 0xc8b9
10: appcore_efl_main + 0x20a (0xb699c4bf) [/usr/lib/libappcore-efl.so.1] + 0x34bf
11: ui_app_main + 0xb0 (0xb6f42421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
12: app_run + 0xea (0xb6fa2ef7) [/opt/usr/apps/org.example.hap/bin/hap] + 0x2ef7
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
_PREFERENCE( 1825): preference.c: preference_get_double(1214) > preference_get_double(1825) : inactive_10min_precaution_millisec error
06-02 13:40:59.219+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1825): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-02 13:40:59.219+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1825): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-02 13:40:59.219+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1825): preference.c: preference_get_double(1214) > preference_get_double(1825) : inactive_before_10min_precaution_millisec error
06-02 13:40:59.459+0900 I/aa      ( 4435): res = -26542062
06-02 13:40:59.459+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:40:59.459+0900 I/aa      ( 4435): res = -26542062
06-02 13:40:59.459+0900 I/aa      ( 4435): db hi = 0
06-02 13:40:59.459+0900 W/AUL_AMD (  904): amd_request.c: __request_handler(640) > __request_handler: 14
06-02 13:40:59.489+0900 W/AUL_AMD (  904): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4435
06-02 13:40:59.979+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:40:59.979+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:40:59.979+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:00.469+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:00.469+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:00.469+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:00.469+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:00.989+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:00.989+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:00.989+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:01.470+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:01.470+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:01.470+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:01.470+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:01.519+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:01.519+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:01.519+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:02.469+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:02.469+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:02.469+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:02.469+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:03.360+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:03.360+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:03.360+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:03.470+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:03.470+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:03.470+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:03.470+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:04.480+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:04.480+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:04.480+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:04.480+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:04.480+0900 W/AUL_AMD (  904): amd_request.c: __request_handler(640) > __request_handler: 14
06-02 13:41:04.510+0900 W/AUL_AMD (  904): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4435
06-02 13:41:05.090+0900 E/EFL     ( 4435): evas_main<4435> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=949752 button=1 downs=1
06-02 13:41:05.229+0900 E/EFL     ( 4435): evas_main<4435> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=949891 button=1 downs=0
06-02 13:41:05.409+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: __convert_recorder_error_code(193) > [recorder_set_filename] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 13:41:05.409+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: __convert_recorder_error_code(193) > [file-format] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 13:41:05.419+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: __convert_recorder_error_code(193) > [audio-encoder] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 13:41:05.479+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:05.479+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:05.479+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:05.479+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:05.949+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:05.949+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:05.949+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:06.059+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: __convert_recorder_error_code(193) > [recorder_start] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 13:41:06.059+0900 E/EFL     ( 4435): <4435> elm_main.c:1262 elm_object_disabled_set() safety check failed: obj == NULL
06-02 13:41:06.059+0900 E/EFL     ( 4435): <4435> elm_main.c:1262 elm_object_disabled_set() safety check failed: obj == NULL
06-02 13:41:06.069+0900 I/aa      ( 4435): chk = Off
06-02 13:41:06.479+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:06.479+0900 I/aa      ( 4435): res = 0
06-02 13:41:06.479+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:07.079+0900 I/aa      ( 4435): res = 0
06-02 13:41:07.079+0900 I/aa      ( 4435): res = 0
06-02 13:41:07.079+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:07.479+0900 I/aa      ( 4435): res = 0
06-02 13:41:07.479+0900 I/aa      ( 4435): res = 0
06-02 13:41:07.479+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:08.079+0900 I/aa      ( 4435): res = 0
06-02 13:41:08.079+0900 I/aa      ( 4435): res = 0
06-02 13:41:08.079+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:08.479+0900 I/aa      ( 4435): res = 0
06-02 13:41:08.479+0900 I/aa      ( 4435): res = 0
06-02 13:41:08.479+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:09.079+0900 I/aa      ( 4435): res = 0
06-02 13:41:09.079+0900 I/aa      ( 4435): res = 0
06-02 13:41:09.079+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:09.479+0900 W/AUL_AMD (  904): amd_request.c: __request_handler(640) > __request_handler: 14
06-02 13:41:09.499+0900 I/aa      ( 4435): res = 0
06-02 13:41:09.499+0900 I/aa      ( 4435): res = 0
06-02 13:41:09.499+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:09.509+0900 W/AUL_AMD (  904): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4435
06-02 13:41:10.079+0900 I/aa      ( 4435): res = 0
06-02 13:41:10.079+0900 I/aa      ( 4435): res = 0
06-02 13:41:10.079+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:10.269+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:10.269+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:10.269+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:10.499+0900 I/aa      ( 4435): res = 0
06-02 13:41:10.499+0900 I/aa      ( 4435): res = 0
06-02 13:41:10.499+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:11.079+0900 I/aa      ( 4435): res = 0
06-02 13:41:11.079+0900 I/aa      ( 4435): res = 0
06-02 13:41:11.079+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:11.499+0900 I/aa      ( 4435): res = 0
06-02 13:41:11.499+0900 I/aa      ( 4435): res = 0
06-02 13:41:11.499+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:12.079+0900 I/aa      ( 4435): res = 0
06-02 13:41:12.079+0900 I/aa      ( 4435): res = 0
06-02 13:41:12.079+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:12.499+0900 I/aa      ( 4435): res = 0
06-02 13:41:12.499+0900 I/aa      ( 4435): res = 0
06-02 13:41:12.499+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:13.079+0900 I/aa      ( 4435): res = 0
06-02 13:41:13.079+0900 I/aa      ( 4435): res = 0
06-02 13:41:13.079+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:13.499+0900 I/aa      ( 4435): res = 0
06-02 13:41:13.499+0900 I/aa      ( 4435): res = 0
06-02 13:41:13.499+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:14.089+0900 I/aa      ( 4435): res = 0
06-02 13:41:14.089+0900 I/aa      ( 4435): res = 0
06-02 13:41:14.089+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:14.479+0900 W/AUL_AMD (  904): amd_request.c: __request_handler(640) > __request_handler: 14
06-02 13:41:14.509+0900 I/aa      ( 4435): res = 0
06-02 13:41:14.509+0900 I/aa      ( 4435): res = 0
06-02 13:41:14.509+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:14.519+0900 W/AUL_AMD (  904): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4435
06-02 13:41:14.689+0900 E/EFL     ( 4435): evas_main<4435> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=959349 button=1 downs=1
06-02 13:41:14.789+0900 E/EFL     ( 4435): evas_main<4435> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=959457 button=1 downs=0
06-02 13:41:15.079+0900 I/aa      ( 4435): res = 0
06-02 13:41:15.079+0900 I/aa      ( 4435): res = 0
06-02 13:41:15.079+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:15.209+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: __convert_recorder_error_code(193) > [recorder_commit] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 13:41:15.229+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: __convert_recorder_error_code(193) > [recorder_unprepare] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 13:41:15.509+0900 I/aa      ( 4435): res = 0
06-02 13:41:15.509+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:15.509+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:15.509+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:15.559+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:15.559+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:15.569+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:16.080+0900 I/aa      ( 4435): res = 0
06-02 13:41:16.080+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:16.080+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:16.080+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:16.509+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:16.509+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:16.509+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:16.509+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:16.719+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:16.719+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:16.719+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:16.809+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:16.809+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:16.809+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:16.929+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:16.929+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:16.929+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:17.089+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:17.089+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:17.089+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:17.089+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:17.519+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:17.519+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:17.519+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:17.519+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:17.829+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:17.829+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:17.829+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:18.089+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:18.089+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:18.089+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:18.089+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:18.169+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:18.169+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:18.169+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:18.519+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:18.519+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:18.519+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:18.519+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:18.809+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:18.809+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:18.809+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:18.909+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:18.909+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:18.909+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:19.089+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:19.089+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:19.089+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:19.089+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:19.489+0900 W/AUL_AMD (  904): amd_request.c: __request_handler(640) > __request_handler: 14
06-02 13:41:19.509+0900 W/AUL_AMD (  904): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4435
06-02 13:41:19.519+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:19.519+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:19.519+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:19.519+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:19.559+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:19.559+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:19.559+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:19.679+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:19.679+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:19.679+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:19.779+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:19.779+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:19.789+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:19.859+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:19.859+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:19.859+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:20.089+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:20.089+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:20.089+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:20.089+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:20.389+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:20.389+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:20.389+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:20.519+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:20.519+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:20.519+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:20.519+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:20.569+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:20.569+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:20.569+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:20.789+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:20.789+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:20.789+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:21.099+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:21.099+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:21.099+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:21.099+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:21.529+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:21.529+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:21.529+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:21.529+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:22.099+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:22.099+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:22.099+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:22.099+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:22.529+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:22.529+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:22.529+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:22.529+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:22.719+0900 E/SHealth_Common( 1825): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
06-02 13:41:23.109+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:23.109+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:23.109+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:23.109+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:23.529+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:23.529+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:23.529+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:23.529+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:24.110+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:24.110+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:24.110+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:24.110+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:24.480+0900 W/AUL_AMD (  904): amd_request.c: __request_handler(640) > __request_handler: 14
06-02 13:41:24.510+0900 W/AUL_AMD (  904): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4435
06-02 13:41:24.539+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:24.539+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:24.539+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:24.539+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:25.109+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:25.109+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:25.109+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:25.109+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:25.540+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:25.540+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:25.540+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:25.540+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:25.679+0900 E/EFL     ( 4435): evas_main<4435> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=970345 button=1 downs=1
06-02 13:41:25.789+0900 E/EFL     ( 4435): evas_main<4435> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=970451 button=1 downs=0
06-02 13:41:26.019+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: __convert_recorder_error_code(193) > [recorder_set_filename] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 13:41:26.019+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: __convert_recorder_error_code(193) > [file-format] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 13:41:26.019+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: __convert_recorder_error_code(193) > [audio-encoder] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 13:41:26.119+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:26.119+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:26.119+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:26.119+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:26.539+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:26.539+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: recorder_get_audio_level(925) > [recorder_get_audio_level]RECORDER_ERROR_INVALID_STATE(0xfe6b0012) 
06-02 13:41:26.539+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:26.539+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:26.619+0900 E/TIZEN_N_RECORDER( 4435): recorder.c: __convert_recorder_error_code(193) > [recorder_start] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-02 13:41:26.619+0900 E/EFL     ( 4435): <4435> elm_main.c:1262 elm_object_disabled_set() safety check failed: obj == NULL
06-02 13:41:26.619+0900 E/EFL     ( 4435): <4435> elm_main.c:1262 elm_object_disabled_set() safety check failed: obj == NULL
06-02 13:41:27.119+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:27.119+0900 I/aa      ( 4435): res = 0
06-02 13:41:27.119+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:27.539+0900 I/aa      ( 4435): res = -26542062
06-02 13:41:27.539+0900 I/aa      ( 4435): res = 0
06-02 13:41:27.539+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:28.119+0900 I/aa      ( 4435): res = 0
06-02 13:41:28.119+0900 I/aa      ( 4435): res = 0
06-02 13:41:28.119+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:28.539+0900 I/aa      ( 4435): res = 0
06-02 13:41:28.539+0900 I/aa      ( 4435): res = 0
06-02 13:41:28.539+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:29.119+0900 I/aa      ( 4435): res = 0
06-02 13:41:29.119+0900 I/aa      ( 4435): res = 0
06-02 13:41:29.119+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:29.479+0900 W/AUL_AMD (  904): amd_request.c: __request_handler(640) > __request_handler: 14
06-02 13:41:29.509+0900 W/AUL_AMD (  904): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4435
06-02 13:41:29.539+0900 I/aa      ( 4435): res = 0
06-02 13:41:29.539+0900 I/aa      ( 4435): res = 0
06-02 13:41:29.539+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:30.119+0900 I/aa      ( 4435): res = 0
06-02 13:41:30.119+0900 I/aa      ( 4435): res = 0
06-02 13:41:30.119+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:30.539+0900 I/aa      ( 4435): res = 0
06-02 13:41:30.539+0900 I/aa      ( 4435): res = 0
06-02 13:41:30.539+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:31.019+0900 I/RESOURCED(  908): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
06-02 13:41:31.019+0900 I/RESOURCED(  908): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
06-02 13:41:31.119+0900 I/aa      ( 4435): res = 0
06-02 13:41:31.119+0900 I/aa      ( 4435): res = 0
06-02 13:41:31.119+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:31.549+0900 I/aa      ( 4435): res = 0
06-02 13:41:31.549+0900 I/aa      ( 4435): res = 0
06-02 13:41:31.549+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:32.129+0900 I/aa      ( 4435): res = 0
06-02 13:41:32.129+0900 I/aa      ( 4435): res = 0
06-02 13:41:32.129+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:32.549+0900 I/aa      ( 4435): res = 0
06-02 13:41:32.549+0900 I/aa      ( 4435): res = 0
06-02 13:41:32.549+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:33.129+0900 I/aa      ( 4435): res = 0
06-02 13:41:33.129+0900 I/aa      ( 4435): res = 0
06-02 13:41:33.129+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:33.549+0900 I/aa      ( 4435): res = 0
06-02 13:41:33.549+0900 I/aa      ( 4435): res = 0
06-02 13:41:33.549+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:34.129+0900 I/aa      ( 4435): res = 0
06-02 13:41:34.129+0900 I/aa      ( 4435): res = 0
06-02 13:41:34.129+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:34.479+0900 W/AUL_AMD (  904): amd_request.c: __request_handler(640) > __request_handler: 14
06-02 13:41:34.509+0900 W/AUL_AMD (  904): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4435
06-02 13:41:34.549+0900 I/aa      ( 4435): res = 0
06-02 13:41:34.549+0900 I/aa      ( 4435): res = 0
06-02 13:41:34.549+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:35.129+0900 I/aa      ( 4435): res = 0
06-02 13:41:35.129+0900 I/aa      ( 4435): res = 0
06-02 13:41:35.129+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:35.549+0900 I/aa      ( 4435): res = 0
06-02 13:41:35.549+0900 I/aa      ( 4435): res = 0
06-02 13:41:35.549+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:36.129+0900 I/aa      ( 4435): res = 0
06-02 13:41:36.129+0900 I/aa      ( 4435): res = 0
06-02 13:41:36.129+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:36.549+0900 I/aa      ( 4435): res = 0
06-02 13:41:36.549+0900 I/aa      ( 4435): res = 0
06-02 13:41:36.549+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:37.129+0900 I/aa      ( 4435): res = 0
06-02 13:41:37.129+0900 I/aa      ( 4435): res = 0
06-02 13:41:37.129+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:37.549+0900 I/aa      ( 4435): res = 0
06-02 13:41:37.549+0900 I/aa      ( 4435): res = 0
06-02 13:41:37.549+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:38.129+0900 I/aa      ( 4435): res = 0
06-02 13:41:38.129+0900 I/aa      ( 4435): res = 0
06-02 13:41:38.129+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:38.549+0900 I/aa      ( 4435): res = 0
06-02 13:41:38.549+0900 I/aa      ( 4435): res = 0
06-02 13:41:38.549+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:39.129+0900 I/aa      ( 4435): res = 0
06-02 13:41:39.129+0900 I/aa      ( 4435): res = 0
06-02 13:41:39.129+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:39.479+0900 W/AUL_AMD (  904): amd_request.c: __request_handler(640) > __request_handler: 14
06-02 13:41:39.509+0900 W/AUL_AMD (  904): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4435
06-02 13:41:39.559+0900 I/aa      ( 4435): res = 0
06-02 13:41:39.559+0900 I/aa      ( 4435): res = 0
06-02 13:41:39.559+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:40.139+0900 I/aa      ( 4435): res = 0
06-02 13:41:40.139+0900 I/aa      ( 4435): res = 0
06-02 13:41:40.139+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:40.289+0900 W/WATCH_CORE( 1278): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
06-02 13:41:40.289+0900 I/WATCH_CORE( 1278): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
06-02 13:41:40.299+0900 W/W_HOME  ( 1186): dbus.c: _dbus_message_recv_cb(204) > LCD off
06-02 13:41:40.299+0900 W/W_HOME  ( 1186): gesture.c: _manual_render_disable_timer_del(151) > timer del
06-02 13:41:40.299+0900 W/W_HOME  ( 1186): gesture.c: _manual_render_enable(133) > 1
06-02 13:41:40.299+0900 W/W_HOME  ( 1186): event_manager.c: _lcd_off_cb(699) > lcd state: 0
06-02 13:41:40.299+0900 W/W_HOME  ( 1186): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-02 13:41:40.299+0900 W/STARTER ( 1169): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [timeout]
06-02 13:41:40.299+0900 W/STARTER ( 1169): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
06-02 13:41:40.309+0900 E/STARTER ( 1169): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
06-02 13:41:40.309+0900 W/STARTER ( 1169): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
06-02 13:41:40.309+0900 W/STARTER ( 1169): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
06-02 13:41:40.309+0900 I/SCONTEXT-LIB( 1111): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
06-02 13:41:40.319+0900 W/WAKEUP-SERVICE( 1555): WakeupService.cpp: OnReceiveDisplayChanged(932) > [0;32mINFO: LCDOff receive data : -1226568948[0;m
06-02 13:41:40.319+0900 W/WAKEUP-SERVICE( 1555): WakeupService.cpp: OnReceiveDisplayChanged(933) > [0;32mINFO: WakeupServiceStop[0;m
06-02 13:41:40.319+0900 W/WAKEUP-SERVICE( 1555): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
06-02 13:41:40.319+0900 I/TIZEN_N_SOUND_MANAGER( 1555): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
06-02 13:41:40.329+0900 I/TIZEN_N_SOUND_MANAGER( 1555): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
06-02 13:41:40.329+0900 W/TIZEN_N_SOUND_MANAGER( 1555): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
06-02 13:41:40.329+0900 W/WAKEUP-SERVICE( 1555): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
06-02 13:41:40.329+0900 I/HIGEAR  ( 1555): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
06-02 13:41:40.549+0900 I/aa      ( 4435): res = 0
06-02 13:41:40.549+0900 I/aa      ( 4435): res = 0
06-02 13:41:40.549+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:40.629+0900 W/MUSIC_CONTROL_SERVICE( 1875): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1875]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
06-02 13:41:40.659+0900 W/STARTER ( 1169): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
06-02 13:41:40.659+0900 W/STARTER ( 1169): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
06-02 13:41:40.659+0900 W/STARTER ( 1169): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
06-02 13:41:40.659+0900 W/STARTER ( 1169): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[0]
06-02 13:41:40.669+0900 I/APP_CORE( 4435): appcore-efl.c: __do_app(429) > [APP 4435] Event: PAUSE State: RUNNING
06-02 13:41:40.669+0900 I/CAPI_APPFW_APPLICATION( 4435): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
06-02 13:41:40.719+0900 W/ALARM_MANAGER( 1169): alarm-lib.c: alarmmgr_add_alarm_withcb(1160) > trigger_at_time(20), start(2-6-2016, 13:42:01), repeat(1), interval(20), type(-1073741822)
06-02 13:41:40.799+0900 W/ALARM_MANAGER(  899): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1320790937, next duetime: 1464842521
06-02 13:41:40.799+0900 W/ALARM_MANAGER(  899): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(1320790937)
06-02 13:41:40.799+0900 W/ALARM_MANAGER(  899): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1464843869), due_time(1464842521)
06-02 13:41:40.799+0900 W/ALARM_MANAGER(  899): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-02 13:41:40.799+0900 W/ALARM_MANAGER(  899): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 2-6-2016, 04:42:01 (UTC).
06-02 13:41:40.799+0900 W/ALARM_MANAGER(  899): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-02 13:41:40.809+0900 I/SHealth_Common( 1825): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
06-02 13:41:40.809+0900 I/SHealth_Service( 1825): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
06-02 13:41:41.139+0900 I/aa      ( 4435): res = 0
06-02 13:41:41.139+0900 I/aa      ( 4435): res = 0
06-02 13:41:41.139+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:41.559+0900 I/aa      ( 4435): res = 0
06-02 13:41:41.559+0900 I/aa      ( 4435): res = 0
06-02 13:41:41.559+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:41.709+0900 W/wnotibp ( 2218): wnotiboard-popup-view.c: _wnotibp_event_lcd_on_cb(1414) > ::APP:: view state=0, 2, 0
06-02 13:41:41.719+0900 W/WATCH_CORE( 1278): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
06-02 13:41:41.719+0900 I/WATCH_CORE( 1278): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
06-02 13:41:41.719+0900 W/W_HOME  ( 1186): dbus.c: _dbus_message_recv_cb(186) > LCD on
06-02 13:41:41.719+0900 W/W_HOME  ( 1186): gesture.c: _manual_render_disable_timer_set(161) > timer set
06-02 13:41:41.719+0900 W/W_HOME  ( 1186): gesture.c: _manual_render_disable_timer_del(151) > timer del
06-02 13:41:41.719+0900 W/W_HOME  ( 1186): gesture.c: _apps_status_get(123) > apps status:0
06-02 13:41:41.719+0900 W/W_HOME  ( 1186): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:0 info->offtime:1450
06-02 13:41:41.719+0900 W/W_HOME  ( 1186): gesture.c: _manual_render_schedule(211) > schedule, manual render
06-02 13:41:41.719+0900 W/W_HOME  ( 1186): event_manager.c: _lcd_on_cb(691) > lcd state: 1
06-02 13:41:41.719+0900 W/W_HOME  ( 1186): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-02 13:41:41.719+0900 W/STARTER ( 1169): clock-mgr.c: _on_lcd_signal_receive_cb(1519) > [_on_lcd_signal_receive_cb:1519] _on_lcd_signal_receive_cb, 1519, Pre LCD on by [unknown] after screen off time [1450]ms
06-02 13:41:41.719+0900 W/STARTER ( 1169): clock-mgr.c: _pre_lcd_on(1245) > [_pre_lcd_on:1245] Will LCD ON as reserved app[(null)] alpm mode[0]
06-02 13:41:41.729+0900 I/SCONTEXT-LIB( 1111): scontext.c: context_add_changed_cb(211) > [SUCCESS] Set Changed CB: 42 (req_id=21)
06-02 13:41:41.739+0900 I/APP_CORE( 4435): appcore-efl.c: __do_app(429) > [APP 4435] Event: RESUME State: PAUSED
06-02 13:41:41.739+0900 I/CAPI_APPFW_APPLICATION( 4435): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
06-02 13:41:41.749+0900 W/ALARM_MANAGER(  899): alarm-manager.c: __alarm_remove_from_list(454) > [alarm-server]:Remove alarm id(1320790937)
06-02 13:41:41.749+0900 W/ALARM_MANAGER(  899): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-02 13:41:41.749+0900 W/ALARM_MANAGER(  899): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 2-6-2016, 05:04:29 (UTC).
06-02 13:41:41.749+0900 W/ALARM_MANAGER(  899): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-02 13:41:41.749+0900 W/ALARM_MANAGER(  899): alarm-manager.c: alarm_manager_alarm_delete(2219) > alarm_id[1320790937] is removed.
06-02 13:41:41.759+0900 W/WAKEUP-SERVICE( 1555): WakeupService.cpp: OnReceiveDisplayChanged(923) > [0;32mINFO: LCDOn receive data : -1226568948[0;m
06-02 13:41:41.759+0900 W/WAKEUP-SERVICE( 1555): WakeupService.cpp: OnReceiveDisplayChanged(924) > [0;32mINFO: WakeupServiceStart[0;m
06-02 13:41:41.759+0900 W/WAKEUP-SERVICE( 1555): WakeupService.cpp: WakeupServiceStart(357) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
06-02 13:41:41.769+0900 W/MUSIC_CONTROL_SERVICE( 1875): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1875]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
06-02 13:41:41.769+0900 I/SHealth_Common( 1825): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
06-02 13:41:41.769+0900 I/SHealth_Service( 1825): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
06-02 13:41:41.839+0900 W/STARTER ( 1169): clock-mgr.c: _on_lcd_signal_receive_cb(1530) > [_on_lcd_signal_receive_cb:1530] _on_lcd_signal_receive_cb, 1530, Post LCD on by [unknown]
06-02 13:41:41.839+0900 W/STARTER ( 1169): clock-mgr.c: _post_lcd_on(1291) > [_post_lcd_on:1291] LCD ON as reserved app[(null)] alpm mode[0]
06-02 13:41:41.879+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1825): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
06-02 13:41:41.879+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1825): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
06-02 13:41:41.879+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1825): preference.c: preference_get_double(1214) > preference_get_double(1825) : pedometer_inactive_period error
06-02 13:41:41.879+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1825): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-02 13:41:41.879+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1825): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-02 13:41:41.879+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1825): preference.c: preference_get_double(1214) > preference_get_double(1825) : inactive_10min_precaution_millisec error
06-02 13:41:41.889+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1825): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-02 13:41:41.889+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1825): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-02 13:41:41.889+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1825): preference.c: preference_get_double(1214) > preference_get_double(1825) : inactive_before_10min_precaution_millisec error
06-02 13:41:41.919+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:41.919+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:41.919+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:41.919+0900 W/W_HOME  ( 1186): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
06-02 13:41:41.919+0900 W/W_HOME  ( 1186): gesture.c: _manual_render_enable(133) > 0
06-02 13:41:41.959+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:41.959+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:41.959+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:42.129+0900 I/aa      ( 4435): res = 0
06-02 13:41:42.129+0900 I/aa      ( 4435): res = 0
06-02 13:41:42.129+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:42.559+0900 I/aa      ( 4435): res = 0
06-02 13:41:42.559+0900 I/aa      ( 4435): res = 0
06-02 13:41:42.559+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:43.139+0900 I/aa      ( 4435): res = 0
06-02 13:41:43.139+0900 I/aa      ( 4435): res = 0
06-02 13:41:43.139+0900 I/aa      ( 4435): db hi = -1225795104
06-02 13:41:43.309+0900 I/efl-extension( 1186): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:43.309+0900 I/efl-extension( 1278): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:43.319+0900 I/efl-extension( 1798): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-02 13:41:43.559+0900 I/aa      ( 4435): res = 0
06-02 13:41:43.559+0900 I/aa      ( 4435): res = 0
06-02 13:41:43.559+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:44.139+0900 I/aa      ( 4435): res = 0
06-02 13:41:44.139+0900 I/aa      ( 4435): res = 0
06-02 13:41:44.139+0900 I/aa      ( 4435): db hi = -14.554194
06-02 13:41:44.159+0900 I/HAP     ( 4435): Updating UI with data 주의 하세요!
06-02 13:41:44.159+0900 W/Adreno-EGL( 4435): <qeglDrvAPI_eglMakeCurrent:3102>: EGL_BAD_ACCESS
06-02 13:41:44.159+0900 E/EFL     ( 4435): evas-gl_x11<4435> evas_x_main.c:647 eng_window_use() eglMakeCurrent() failed!
06-02 13:41:44.439+0900 W/AUL_AMD (  904): amd_request.c: __request_handler(640) > __request_handler: 14
06-02 13:41:44.479+0900 W/AUL_AMD (  904): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4435
06-02 13:41:44.559+0900 I/aa      ( 4435): res = 0
06-02 13:41:44.559+0900 I/aa      ( 4435): res = 0
06-02 13:41:44.559+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:44.869+0900 E/WMS     (  901): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(19490) > wear_monitor_status update[0] = 1 -> 2
06-02 13:41:44.879+0900 E/WMS     (  901): wms_msg_broker.c: wms_msg_broker_send(1700) > 
06-02 13:41:44.879+0900 E/WMS     (  901): ==========
06-02 13:41:44.879+0900 E/WMS     (  901): ##WMS SEND : mgr_gear_wear_onoff_req
06-02 13:41:44.879+0900 E/WMS     (  901): ==========
06-02 13:41:44.879+0900 E/WMS     (  901): wms_msg_broker.c: wms_msg_broker_send(1716) > Data size: 52 MAX Buffer Size: 61440
06-02 13:41:44.969+0900 W/SHealth_Service( 1825): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
06-02 13:41:44.969+0900 E/SHealth_Service( 1825): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
06-02 13:41:45.019+0900 I/RESOURCED(  908): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 15 -> 14 1464842505 121
06-02 13:41:45.019+0900 I/RESOURCED(  908): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 14 1426 81 333
06-02 13:41:45.019+0900 I/RESOURCED(  908): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 14 0 0 20
06-02 13:41:45.019+0900 I/RESOURCED(  908): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 14 1420 81 331
06-02 13:41:45.019+0900 I/RESOURCED(  908): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 14 78 5 18
06-02 13:41:45.019+0900 I/RESOURCED(  908): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 14 71 8 17
06-02 13:41:45.559+0900 I/aa      ( 4435): res = 0
06-02 13:41:45.559+0900 I/aa      ( 4435): res = 0
06-02 13:41:45.559+0900 I/aa      ( 4435): db hi = 0
06-02 13:41:45.819+0900 E/EFL     ( 4435): evas_main<4435> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=990484 button=1 downs=1
06-02 13:41:45.879+0900 E/EFL     ( 4435): evas_main<4435> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=990547 button=1 downs=0
06-02 13:41:46.559+0900 I/aa      ( 4435): res = 0
06-02 13:41:46.559+0900 I/aa      ( 4435): res = 0
06-02 13:41:46.559+0900 I/aa      ( 4435): db hi = -12.746907
06-02 13:41:46.569+0900 I/HAP     ( 4435): Updating UI with data 주의 하세요!
06-02 13:41:46.609+0900 E/EFL     ( 4435): evas_main<4435> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=991274 button=1 downs=1
06-02 13:41:47.189+0900 W/AUL_AMD (  904): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-02 13:41:47.189+0900 W/AUL_AMD (  904): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
06-02 13:41:47.209+0900 I/APP_CORE( 4099): appcore-efl.c: __do_app(429) > [APP 4099] Event: RESUME State: PAUSED
06-02 13:41:47.209+0900 I/CAPI_APPFW_APPLICATION( 4099): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
06-02 13:41:47.239+0900 W/CRASH_MANAGER( 4660): worker.c: worker_job(1199) > 1104435686170146484250
