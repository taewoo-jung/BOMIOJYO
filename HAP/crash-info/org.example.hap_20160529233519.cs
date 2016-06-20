S/W Version Information
Model: SM-R735S
Tizen-Version: 2.3.1.2
Build-Number: R735SKSU1AOKE
Build-Date: 2015.11.25 20:46:58

Crash Information
Process Name: hap
PID: 3184
Date: 2016-05-29 23:35:19+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00309581, r3   = 0x00000001
r4   = 0xb81fed50, r5   = 0xb6bf8b34
r6   = 0xbeba4dbc, r7   = 0x00000000
r8   = 0x00000002, r9   = 0xb6bce861
r10  = 0x00000000, fp   = 0xbeba4dd8
ip   = 0xb6bf8c4c, sp   = 0xbeba3db0
lr   = 0xb6be423d, pc   = 0xb6aa1dc4
cpsr = 0x20000010

Memory Information
MemTotal:   407572 KB
MemFree:      8904 KB
Buffers:      3216 KB
Cached:      84764 KB
VmPeak:      92556 KB
VmSize:      88436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25280 KB
VmRSS:       25280 KB
VmData:      45476 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       37892 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 3184 TID = 3184
3184 3185 3188 

Maps Information
b1c72000 b1c76000 rwxs /dev/kgsl-3d0
b1c76000 b1c7a000 rwxs /dev/kgsl-3d0
b1c7a000 b1c7e000 rwxs /dev/kgsl-3d0
b1c7e000 b1c7f000 rwxs /dev/kgsl-3d0
b1c7f000 b1c80000 rwxs /dev/kgsl-3d0
b1c80000 b1c81000 rwxs /dev/kgsl-3d0
b1c81000 b1c82000 rwxs /dev/kgsl-3d0
b1c82000 b1c83000 rwxs /dev/kgsl-3d0
b1c83000 b1c84000 rwxs /dev/kgsl-3d0
b1c84000 b1c85000 rwxs /dev/kgsl-3d0
b1c85000 b1c86000 rwxs /dev/kgsl-3d0
b1c86000 b1ce4000 rwxs /dev/kgsl-3d0
b1d6b000 b1e67000 rwxs /dev/kgsl-3d0
b1e67000 b1eee000 rwxs anon_inode:dmabuf
b1eee000 b1f75000 rwxs anon_inode:dmabuf
b1f76000 b2775000 rwxp [stack:3188]
b2775000 b2800000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
b2800000 b288c000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
b288c000 b288d000 rwxs /dev/kgsl-3d0
b288d000 b288e000 rwxs /dev/kgsl-3d0
b288e000 b288f000 rwxs /dev/kgsl-3d0
b288f000 b2890000 rwxs /dev/kgsl-3d0
b2890000 b2891000 rwxs /dev/kgsl-3d0
b2891000 b2892000 rwxs /dev/kgsl-3d0
b2892000 b2893000 rwxs /dev/kgsl-3d0
b2893000 b2894000 rwxs /dev/kgsl-3d0
b2894000 b2895000 rwxs /dev/kgsl-3d0
b2895000 b2896000 rwxs /dev/kgsl-3d0
b2896000 b28f4000 rwxs /dev/kgsl-3d0
b28f4000 b2914000 rwxs /dev/kgsl-3d0
b2914000 b2915000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b291c000 b291d000 rwxp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b291d000 b2921000 rwxs /dev/kgsl-3d0
b2921000 b2941000 rwxs /dev/kgsl-3d0
b2941000 b2981000 rwxs /dev/kgsl-3d0
b3300000 b3301000 rwxs /dev/kgsl-3d0
b3301000 b3305000 rwxs /dev/kgsl-3d0
b3305000 b3309000 rwxs /dev/kgsl-3d0
b3309000 b330a000 rwxs /dev/kgsl-3d0
b330a000 b330b000 rwxs /dev/kgsl-3d0
b330b000 b330c000 rwxs /dev/kgsl-3d0
b330c000 b330d000 rwxs /dev/kgsl-3d0
b330d000 b330e000 rwxs /dev/kgsl-3d0
b330e000 b330f000 rwxs /dev/kgsl-3d0
b330f000 b331e000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
b331e000 b3322000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
b3322000 b3325000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
b3325000 b3326000 rwxs /dev/kgsl-3d0
b3326000 b332d000 r-xs /usr/lib/gconv/gconv-modules.cache
b3b2d000 b3b2f000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3b36000 b3b37000 rwxp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3b37000 b3b4e000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3b56000 b3b5b000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3b5b000 b3d19000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
b3d19000 b3d1b000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
b3d1b000 b3d1c000 rwxs /dev/kgsl-3d0
b3d1c000 b3d1d000 rwxs /dev/kgsl-3d0
b3d1d000 b3d1e000 rwxs /dev/kgsl-3d0
b3d1e000 b3d1f000 rwxs /dev/kgsl-3d0
b3d1f000 b3d20000 rwxs /dev/kgsl-3d0
b3d20000 b3d21000 rwxs /dev/kgsl-3d0
b3d21000 b3d22000 rwxs /dev/kgsl-3d0
b3d22000 b3d23000 rwxs /dev/kgsl-3d0
b3d23000 b3d24000 rwxs /dev/kgsl-3d0
b3d24000 b3d25000 rwxs /dev/kgsl-3d0
b3d25000 b3d26000 rwxs /dev/kgsl-3d0
b3d26000 b3d27000 rwxs /dev/kgsl-3d0
b3d27000 b3d28000 rwxs /dev/kgsl-3d0
b3d28000 b3d29000 rwxs /dev/kgsl-3d0
b3d29000 b3d2a000 rwxs /dev/kgsl-3d0
b3d2a000 b3d2b000 rwxs /dev/kgsl-3d0
b3d2b000 b3d2c000 rwxs /dev/kgsl-3d0
b3d2c000 b3d2d000 rwxs /dev/kgsl-3d0
b3d2d000 b3d2e000 rwxs /dev/kgsl-3d0
b3d2e000 b3d2f000 rwxs /dev/kgsl-3d0
b3d2f000 b3d30000 rwxs /dev/kgsl-3d0
b3d30000 b3d31000 rwxs /dev/kgsl-3d0
b3d31000 b3d32000 rwxs /dev/kgsl-3d0
b3d32000 b3d33000 rwxs /dev/kgsl-3d0
b3d33000 b3d34000 rwxs /dev/kgsl-3d0
b3d34000 b3d35000 rwxs /dev/kgsl-3d0
b3d35000 b3d36000 rwxs /dev/kgsl-3d0
b3d36000 b3d37000 rwxs /dev/kgsl-3d0
b3d37000 b3d38000 rwxs /dev/kgsl-3d0
b3d38000 b3d39000 rwxs /dev/kgsl-3d0
b3d39000 b3d3a000 rwxs /dev/kgsl-3d0
b3d3a000 b3d3b000 rwxs /dev/kgsl-3d0
b3d3b000 b3d3c000 rwxs /dev/kgsl-3d0
b3d3c000 b3d3d000 rwxs /dev/kgsl-3d0
b3d3d000 b3d3e000 rwxs /dev/kgsl-3d0
b3d3e000 b3d3f000 rwxs /dev/kgsl-3d0
b3d3f000 b3d40000 rwxs /dev/kgsl-3d0
b3d40000 b3d41000 rwxs /dev/kgsl-3d0
b3d41000 b3d42000 rwxs /dev/kgsl-3d0
b3d42000 b3d43000 rwxs /dev/kgsl-3d0
b3d43000 b3d44000 rwxs /dev/kgsl-3d0
b3d44000 b3d45000 rwxs /dev/kgsl-3d0
b3d45000 b3d46000 rwxs /dev/kgsl-3d0
b3d46000 b3d47000 rwxs /dev/kgsl-3d0
b3d47000 b3d48000 rwxs /dev/kgsl-3d0
b3d48000 b3d49000 rwxs /dev/kgsl-3d0
b3d49000 b3d4a000 rwxs /dev/kgsl-3d0
b3d4a000 b3d4b000 rwxs /dev/kgsl-3d0
b3d4b000 b3d4c000 rwxs /dev/kgsl-3d0
b3d4c000 b3d4d000 rwxs /dev/kgsl-3d0
b3d4d000 b3d4e000 rwxs /dev/kgsl-3d0
b3d4e000 b3d4f000 rwxs /dev/kgsl-3d0
b3d4f000 b3d50000 rwxs /dev/kgsl-3d0
b3d50000 b3d51000 rwxs /dev/kgsl-3d0
b3d51000 b3d52000 rwxs /dev/kgsl-3d0
b3d52000 b3d53000 rwxs /dev/kgsl-3d0
b3d53000 b3d54000 rwxs /dev/kgsl-3d0
b3d54000 b3d55000 rwxs /dev/kgsl-3d0
b3d55000 b3d56000 rwxs /dev/kgsl-3d0
b3d56000 b3d57000 rwxs /dev/kgsl-3d0
b3d57000 b3d58000 rwxs /dev/kgsl-3d0
b3d58000 b3d59000 rwxs /dev/kgsl-3d0
b3d59000 b3d5a000 rwxs /dev/kgsl-3d0
b3d5a000 b3d5b000 rwxs /dev/kgsl-3d0
b3d5b000 b3d5c000 rwxs /dev/kgsl-3d0
b3d5c000 b3d5d000 rwxs /dev/kgsl-3d0
b3d5d000 b3d5e000 rwxs /dev/kgsl-3d0
b3d5e000 b3d5f000 rwxs /dev/kgsl-3d0
b3d5f000 b3d60000 rwxs /dev/kgsl-3d0
b3d60000 b3d61000 rwxs /dev/kgsl-3d0
b3d61000 b3d62000 rwxs /dev/kgsl-3d0
b3d62000 b3d63000 rwxs /dev/kgsl-3d0
b3d63000 b3d64000 rwxs /dev/kgsl-3d0
b3d64000 b3d79000 r-xs /opt/home/app/.cache/evas_gl_common_caches/Qualcomm::OpenGL
b3d79000 b3d7d000 rwxs /dev/kgsl-3d0
b3d7d000 b3d7e000 rwxs /dev/kgsl-3d0
b3d7f000 b457e000 rwxp [stack:3185]
b457e000 b457f000 rwxs /dev/kgsl-3d0
b457f000 b4580000 rwxs /dev/kgsl-3d0
b4580000 b4581000 rwxs /dev/kgsl-3d0
b4581000 b4582000 rwxs /dev/kgsl-3d0
b4582000 b4583000 rwxs /dev/kgsl-3d0
b4583000 b4584000 rwxs /dev/kgsl-3d0
b4584000 b4585000 rwxs /dev/kgsl-3d0
b4585000 b4595000 rwxs /dev/kgsl-3d0
b4595000 b4ec1000 r-xp /usr/lib/libsc-a3xx.so
b4ec9000 b4efd000 rwxp /usr/lib/libsc-a3xx.so
b510e000 b5110000 r-xp /usr/lib/libgenlock.so
b5117000 b5118000 rwxp /usr/lib/libgenlock.so
b5118000 b5119000 rwxs /dev/kgsl-3d0
b5119000 b511a000 rwxs /dev/kgsl-3d0
b511a000 b511b000 rwxs /dev/kgsl-3d0
b511b000 b511c000 rwxs /dev/kgsl-3d0
b511c000 b511d000 rwxs /dev/kgsl-3d0
b511d000 b511e000 rwxs /dev/kgsl-3d0
b511e000 b511f000 rwxs /dev/kgsl-3d0
b511f000 b5120000 rwxs /dev/kgsl-3d0
b5120000 b5121000 rwxs /dev/kgsl-3d0
b5121000 b5122000 rwxs /dev/kgsl-3d0
b5122000 b5123000 rwxs /dev/kgsl-3d0
b5123000 b5124000 rwxs /dev/kgsl-3d0
b5124000 b5125000 rwxs /dev/kgsl-3d0
b5125000 b5126000 rwxs /dev/kgsl-3d0
b5126000 b5127000 rwxs /dev/kgsl-3d0
b5127000 b5128000 rwxs /dev/kgsl-3d0
b5128000 b5129000 rwxs /dev/kgsl-3d0
b5129000 b512a000 rwxs /dev/kgsl-3d0
b512a000 b512c000 rwxs /dev/kgsl-3d0
b512c000 b512e000 rwxs /dev/kgsl-3d0
b512e000 b5130000 r-xp /usr/lib/libdri2.so.0.0.0
b5137000 b5138000 rwxp /usr/lib/libdri2.so.0.0.0
b5138000 b5140000 r-xp /usr/lib/libdrm.so.2.4.0
b5147000 b5148000 rwxp /usr/lib/libdrm.so.2.4.0
b5148000 b514c000 r-xp /usr/lib/libxcb-xfixes.so.0.0.0
b5153000 b5154000 rwxp /usr/lib/libxcb-xfixes.so.0.0.0
b5154000 b5157000 r-xp /usr/lib/libxcb-dri2.so.0.0.0
b515e000 b515f000 rwxp /usr/lib/libxcb-dri2.so.0.0.0
b515f000 b5160000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b5167000 b5168000 rwxp /usr/lib/libX11-xcb.so.1.0.0
b5168000 b516f000 r-xp /usr/lib/libtbm.so.1.0.0
b5176000 b5177000 rwxp /usr/lib/libtbm.so.1.0.0
b5177000 b517a000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b5181000 b5182000 rwxp /usr/lib/libnative-buffer.so.0.1.0
b5182000 b5183000 rwxs /dev/kgsl-3d0
b5183000 b5187000 rwxs /dev/kgsl-3d0
b5187000 b518b000 rwxs /dev/kgsl-3d0
b518b000 b5190000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b5197000 b5198000 rwxp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b5198000 b52d3000 r-xp /usr/lib/egl/libGLESv2.so
b52da000 b530e000 rwxp /usr/lib/egl/libGLESv2.so
b530f000 b5311000 r-xp /usr/lib/libadreno_utils.so
b5318000 b5319000 rwxp /usr/lib/libadreno_utils.so
b531b000 b5342000 r-xp /usr/lib/libgsl.so
b5349000 b534b000 rwxp /usr/lib/libgsl.so
b534b000 b534c000 rwxs /dev/kgsl-3d0
b534c000 b534d000 rwxs /dev/kgsl-3d0
b534d000 b5351000 rwxs /dev/kgsl-3d0
b5351000 b5352000 rwxs /dev/kgsl-3d0
b5352000 b5359000 r-xp /usr/lib/egl/eglsubX11.so
b5360000 b5361000 rwxp /usr/lib/egl/eglsubX11.so
b5361000 b5383000 r-xp /usr/lib/egl/libEGL.so
b538b000 b538c000 rwxp /usr/lib/egl/libEGL.so
b538c000 b5403000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b540b000 b540d000 rwxp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b5413000 b5545000 r-xp /usr/share/locale/locale-archive
b5545000 b5745000 r-xp /usr/share/locale/locale-archive
b5745000 b574f000 r-xp /lib/libnss_files-2.13.so
b5756000 b5757000 r-xp /lib/libnss_files-2.13.so
b5757000 b5758000 rwxp /lib/libnss_files-2.13.so
b5758000 b575b000 r-xp /lib/libattr.so.1.1.0
b5762000 b5763000 rwxp /lib/libattr.so.1.1.0
b5763000 b576a000 r-xp /lib/libcrypt-2.13.so
b5771000 b5772000 r-xp /lib/libcrypt-2.13.so
b5772000 b5773000 rwxp /lib/libcrypt-2.13.so
b579a000 b579d000 r-xp /lib/libcap.so.2.21
b57a4000 b57a5000 rwxp /lib/libcap.so.2.21
b57a5000 b57a7000 r-xp /usr/lib/libiri.so
b57ae000 b57af000 rwxp /usr/lib/libiri.so
b57af000 b57cb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b57d3000 b57d4000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
b57d4000 b57fa000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b5802000 b5803000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
b5803000 b5897000 r-xp /usr/lib/libstdc++.so.6.0.16
b589f000 b58a2000 r-xp /usr/lib/libstdc++.so.6.0.16
b58a2000 b58a4000 rwxp /usr/lib/libstdc++.so.6.0.16
b58aa000 b5979000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5980000 b598f000 rwxp /usr/lib/libscim-1.0.so.8.2.3
b598f000 b59b3000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b59ba000 b59bc000 rwxp /usr/lib/ecore/immodules/libisf-imf-module.so
b59bc000 b5a86000 r-xp /usr/lib/libCOREGL.so.4.0
b5a8d000 b5a8f000 rwxp /usr/lib/libCOREGL.so.4.0
b5a9b000 b5aa6000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5aad000 b5aae000 rwxp /usr/lib/libgpg-error.so.0.15.0
b5aaf000 b5c57000 r-xp /usr/lib/libcrypto.so.1.0.0
b5c57000 b5c6c000 rwxp /usr/lib/libcrypto.so.1.0.0
b5c70000 b5cbd000 r-xp /usr/lib/libssl.so.1.0.0
b5cc4000 b5cc9000 rwxp /usr/lib/libssl.so.1.0.0
b5cc9000 b5cf7000 r-xp /usr/lib/libidn.so.11.5.44
b5cfe000 b5cff000 rwxp /usr/lib/libidn.so.11.5.44
b5cff000 b5d08000 r-xp /usr/lib/libcares.so.2.1.0
b5d10000 b5d11000 rwxp /usr/lib/libcares.so.2.1.0
b5d11000 b5d13000 r-xp /usr/lib/libXau.so.6.0.0
b5d1a000 b5d1b000 rwxp /usr/lib/libXau.so.6.0.0
b5d1c000 b5d1e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5d25000 b5d26000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b5d26000 b5d28000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5d30000 b5d31000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b5d31000 b5dad000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5db4000 b5db9000 rwxp /usr/lib/libgcrypt.so.20.0.3
b5db9000 b5dd1000 r-xp /usr/lib/liblzma.so.5.0.3
b5dd8000 b5dd9000 rwxp /usr/lib/liblzma.so.5.0.3
b5dda000 b5de0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b5de8000 b5de9000 rwxp /usr/lib/libcapi-base-common.so.0.1.8
b5de9000 b5df9000 r-xp /lib/libresolv-2.13.so
b5df9000 b5dfa000 r-xp /lib/libresolv-2.13.so
b5dfa000 b5dfb000 rwxp /lib/libresolv-2.13.so
b5dfd000 b5dff000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5e06000 b5e07000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b5e07000 b5e0c000 r-xp /usr/lib/libffi.so.5.0.10
b5e13000 b5e14000 rwxp /usr/lib/libffi.so.5.0.10
b5e14000 b5e15000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5e1c000 b5e1d000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b5e1e000 b5e62000 r-xp /usr/lib/libcurl.so.4.3.0
b5e69000 b5e6b000 rwxp /usr/lib/libcurl.so.4.3.0
b5e6b000 b5e6e000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b5e75000 b5e76000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
b5e76000 b5e7a000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b5e82000 b5e83000 rwxp /usr/lib/libecore_ipc.so.1.7.99
b5e83000 b5e88000 r-xp /usr/lib/libecore_fb.so.1.7.99
b5e8f000 b5e91000 rwxp /usr/lib/libecore_fb.so.1.7.99
b5e92000 b5eb5000 r-xp /usr/lib/libjpeg.so.8.0.2
b5ebc000 b5ebd000 rwxp /usr/lib/libjpeg.so.8.0.2
b5ecd000 b5ee3000 r-xp /lib/libexpat.so.1.5.2
b5eeb000 b5eed000 rwxp /lib/libexpat.so.1.5.2
b5eed000 b5f00000 r-xp /usr/lib/libxcb.so.1.1.0
b5f08000 b5f09000 rwxp /usr/lib/libxcb.so.1.1.0
b5f09000 b5f0f000 r-xp /usr/lib/libxcb-render.so.0.0.0
b5f16000 b5f17000 rwxp /usr/lib/libxcb-render.so.0.0.0
b5f17000 b5f18000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b5f20000 b5f21000 rwxp /usr/lib/libxcb-shm.so.0.0.0
b5f22000 b5f3a000 r-xp /usr/lib/libpng12.so.0.50.0
b5f41000 b5f42000 rwxp /usr/lib/libpng12.so.0.50.0
b5f42000 b5f45000 r-xp /usr/lib/libEGL.so.1.4
b5f4c000 b5f4d000 rwxp /usr/lib/libEGL.so.1.4
b5f4d000 b5f5b000 r-xp /usr/lib/libGLESv2.so.2.0
b5f63000 b5f64000 rwxp /usr/lib/libGLESv2.so.2.0
b5f64000 b5f65000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5f6c000 b5f6d000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
b5f6d000 b5f84000 r-xp /usr/lib/liblua-5.1.so
b5f8c000 b5f8d000 rwxp /usr/lib/liblua-5.1.so
b5f8e000 b5f95000 r-xp /usr/lib/libembryo.so.1.7.99
b5f9c000 b5f9d000 rwxp /usr/lib/libembryo.so.1.7.99
b5f9d000 b5fa7000 r-xp /usr/lib/libXext.so.6.4.0
b5faf000 b5fb0000 rwxp /usr/lib/libXext.so.6.4.0
b5fb0000 b5fb3000 r-xp /usr/lib/libXtst.so.6.1.0
b5fbb000 b5fbc000 rwxp /usr/lib/libXtst.so.6.1.0
b5fbc000 b5fc2000 r-xp /usr/lib/libXrender.so.1.3.0
b5fc9000 b5fca000 rwxp /usr/lib/libXrender.so.1.3.0
b5fca000 b5fd0000 r-xp /usr/lib/libXrandr.so.2.2.0
b5fd7000 b5fd8000 rwxp /usr/lib/libXrandr.so.2.2.0
b5fd8000 b5fd9000 r-xp /usr/lib/libXinerama.so.1.0.0
b5fe1000 b5fe2000 rwxp /usr/lib/libXinerama.so.1.0.0
b5fe3000 b5fe6000 r-xp /usr/lib/libXfixes.so.3.1.0
b5fed000 b5fee000 rwxp /usr/lib/libXfixes.so.3.1.0
b5fee000 b5ff0000 r-xp /usr/lib/libXgesture.so.7.0.0
b5ff7000 b5ff8000 rwxp /usr/lib/libXgesture.so.7.0.0
b5ff8000 b5ffa000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6001000 b6002000 rwxp /usr/lib/libXcomposite.so.1.0.0
b6002000 b6004000 r-xp /usr/lib/libXdamage.so.1.1.0
b600b000 b600c000 rwxp /usr/lib/libXdamage.so.1.1.0
b600c000 b6013000 r-xp /usr/lib/libXcursor.so.1.0.2
b601a000 b601b000 rwxp /usr/lib/libXcursor.so.1.0.2
b601c000 b6032000 r-xp /lib/libz.so.1.2.5
b6039000 b603a000 rwxp /lib/libz.so.1.2.5
b603a000 b6040000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6047000 b6048000 rwxp /usr/lib/libecore_imf.so.1.7.99
b6048000 b604b000 r-xp /usr/lib/libsmack.so.1.0.0
b6052000 b6053000 rwxp /usr/lib/libsmack.so.1.0.0
b6053000 b6059000 r-xp /usr/lib/libappsvc.so.0.1.0
b6060000 b6061000 rwxp /usr/lib/libappsvc.so.0.1.0
b6061000 b60d6000 r-xp /usr/lib/libsqlite3.so.0.8.6
b60dd000 b60e0000 rwxp /usr/lib/libsqlite3.so.0.8.6
b60e1000 b60f6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b60fd000 b60fe000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b60fe000 b6101000 r-xp /usr/lib/libproc-stat.so.0.2.86
b6108000 b6109000 rwxp /usr/lib/libproc-stat.so.0.2.86
b6109000 b6145000 r-xp /usr/lib/libsystemd.so.0.4.0
b614c000 b614d000 r-xp /usr/lib/libsystemd.so.0.4.0
b614d000 b614e000 rwxp /usr/lib/libsystemd.so.0.4.0
b614e000 b6153000 r-xp /usr/lib/libxdgmime.so.1.1.0
b615a000 b615b000 rwxp /usr/lib/libxdgmime.so.1.1.0
b615b000 b6172000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6179000 b617a000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b617b000 b617e000 r-xp /usr/lib/libbundle.so.0.1.22
b6185000 b6186000 rwxp /usr/lib/libbundle.so.0.1.22
b6186000 b618e000 r-xp /usr/lib/libsap_client.so.0.0.0
b6195000 b6196000 rwxp /usr/lib/libsap_client.so.0.0.0
b6196000 b61ca000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b61d1000 b61d3000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b61d3000 b62a6000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b62ad000 b62b1000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b62b1000 b6381000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6381000 b6382000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6383000 b63d9000 r-xp /usr/lib/libpixman-1.so.0.28.2
b63e1000 b63e6000 rwxp /usr/lib/libpixman-1.so.0.28.2
b63e6000 b643c000 r-xp /usr/lib/libfreetype.so.6.11.3
b6444000 b6448000 rwxp /usr/lib/libfreetype.so.6.11.3
b6448000 b6485000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b648c000 b648d000 rwxp /usr/lib/libharfbuzz.so.0.940.0
b648e000 b64a1000 r-xp /usr/lib/libfribidi.so.0.3.1
b64a8000 b64a9000 rwxp /usr/lib/libfribidi.so.0.3.1
b64a9000 b64c3000 r-xp /usr/lib/libecore_con.so.1.7.99
b64ca000 b64cb000 rwxp /usr/lib/libecore_con.so.1.7.99
b64cd000 b64f7000 r-xp /usr/lib/libdbus-1.so.3.8.12
b64ff000 b6500000 rwxp /usr/lib/libdbus-1.so.3.8.12
b6500000 b6509000 r-xp /usr/lib/libedbus.so.1.7.99
b6510000 b6511000 rwxp /usr/lib/libedbus.so.1.7.99
b6511000 b6515000 r-xp /usr/lib/libvconf.so.0.2.45
b651c000 b651d000 rwxp /usr/lib/libvconf.so.0.2.45
b651d000 b652e000 r-xp /usr/lib/libecore_input.so.1.7.99
b6535000 b6536000 rwxp /usr/lib/libecore_input.so.1.7.99
b6536000 b653b000 r-xp /usr/lib/libecore_file.so.1.7.99
b6542000 b6543000 rwxp /usr/lib/libecore_file.so.1.7.99
b6543000 b6565000 r-xp /usr/lib/libecore_evas.so.1.7.99
b656c000 b656e000 rwxp /usr/lib/libecore_evas.so.1.7.99
b656f000 b6588000 r-xp /usr/lib/libeet.so.1.7.99
b6590000 b6591000 rwxp /usr/lib/libeet.so.1.7.99
b6599000 b659f000 r-xp /lib/librt-2.13.so
b65a6000 b65a7000 r-xp /lib/librt-2.13.so
b65a7000 b65a8000 rwxp /lib/librt-2.13.so
b65a8000 b65d0000 r-xp /usr/lib/libfontconfig.so.1.8.0
b65d0000 b65d1000 rwxp /usr/lib/libfontconfig.so.1.8.0
b65d1000 b65da000 r-xp /usr/lib/libXi.so.6.1.0
b65e1000 b65e2000 rwxp /usr/lib/libXi.so.6.1.0
b65e2000 b66c3000 r-xp /usr/lib/libX11.so.6.3.0
b66ca000 b66ce000 rwxp /usr/lib/libX11.so.6.3.0
b66cf000 b6787000 r-xp /usr/lib/libcairo.so.2.11200.14
b678e000 b6791000 rwxp /usr/lib/libcairo.so.2.11200.14
b6792000 b67ef000 r-xp /usr/lib/libedje.so.1.7.99
b67f7000 b67f9000 rwxp /usr/lib/libedje.so.1.7.99
b67f9000 b6810000 r-xp /usr/lib/libecore.so.1.7.99
b6818000 b6819000 rwxp /usr/lib/libecore.so.1.7.99
b6827000 b6877000 r-xp /usr/lib/libecore_x.so.1.7.99
b6877000 b6879000 rwxp /usr/lib/libecore_x.so.1.7.99
b6879000 b6945000 r-xp /usr/lib/libxml2.so.2.7.8
b694c000 b6951000 rwxp /usr/lib/libxml2.so.2.7.8
b6952000 b6954000 r-xp /usr/lib/libiniparser.so.0
b695c000 b695d000 rwxp /usr/lib/libiniparser.so.0
b695d000 b6962000 r-xp /usr/lib/libappcore-common.so.1.1
b6969000 b696a000 rwxp /usr/lib/libappcore-common.so.1.1
b696a000 b696f000 r-xp /usr/lib/libappcore-efl.so.1.1
b6976000 b6977000 rwxp /usr/lib/libappcore-efl.so.1.1
b6977000 b697c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b6983000 b6984000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b6984000 b6998000 r-xp /lib/libpthread-2.13.so
b699f000 b69a0000 r-xp /lib/libpthread-2.13.so
b69a0000 b69a1000 rwxp /lib/libpthread-2.13.so
b69a3000 b69c5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b69cc000 b69cd000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b69cd000 b69d9000 r-xp /usr/lib/libaul.so.0.1.0
b69e1000 b69e2000 rwxp /usr/lib/libaul.so.0.1.0
b69e3000 b69eb000 r-xp /lib/libgcc_s-4.6.so.1
b69eb000 b69ec000 rwxp /lib/libgcc_s-4.6.so.1
b69ec000 b69ee000 r-xp /lib/libdl-2.13.so
b69f5000 b69f6000 r-xp /lib/libdl-2.13.so
b69f6000 b69f7000 rwxp /lib/libdl-2.13.so
b69f7000 b6a02000 r-xp /lib/libunwind.so.8.0.1
b6a09000 b6a0a000 rwxp /lib/libunwind.so.8.0.1
b6a2f000 b6b4a000 r-xp /lib/libc-2.13.so
b6b52000 b6b54000 r-xp /lib/libc-2.13.so
b6b54000 b6b55000 rwxp /lib/libc-2.13.so
b6b58000 b6bc1000 r-xp /lib/libm-2.13.so
b6bc8000 b6bc9000 r-xp /lib/libm-2.13.so
b6bc9000 b6bca000 rwxp /lib/libm-2.13.so
b6bca000 b6bd7000 r-xp /usr/lib/libsap-client-stub-api.so.1.0.0
b6bde000 b6bdf000 rwxp /usr/lib/libsap-client-stub-api.so.1.0.0
b6bdf000 b6bf1000 r-xp /usr/lib/libtts.so
b6bf8000 b6bf9000 rwxp /usr/lib/libtts.so
b6bf9000 b6cc8000 r-xp /usr/lib/libevas.so.1.7.99
b6ccf000 b6cd9000 rwxp /usr/lib/libevas.so.1.7.99
b6cec000 b6e26000 r-xp /usr/lib/libelementary.so.1.7.99
b6e2d000 b6e35000 rwxp /usr/lib/libelementary.so.1.7.99
b6e3c000 b6e7d000 r-xp /usr/lib/libeina.so.1.7.99
b6e84000 b6e86000 rwxp /usr/lib/libeina.so.1.7.99
b6e86000 b6ea7000 r-xp /usr/lib/libefl-extension.so.0.1.0
b6eae000 b6eaf000 rwxp /usr/lib/libefl-extension.so.0.1.0
b6eaf000 b6eb1000 r-xp /usr/lib/libdlog.so.0.0.0
b6eb8000 b6eb9000 rwxp /usr/lib/libdlog.so.0.0.0
b6eb9000 b6ebe000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6ec5000 b6ec6000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
b6ec6000 b6eca000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b6ed1000 b6ed2000 rwxp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b6ed2000 b6ed4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6edc000 b6edd000 rwxp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6edd000 b6edf000 r-xs /dev/kgsl-3d0
b6edf000 b6eea000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b6ef2000 b6ef3000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b6ef3000 b6ef7000 r-xp /usr/lib/libsys-assert.so
b6eff000 b6f00000 rwxp /usr/lib/libsys-assert.so
b6f00000 b6f1d000 r-xp /lib/ld-2.13.so
b6f24000 b6f25000 r-xp /lib/ld-2.13.so
b6f25000 b6f26000 rwxp /lib/ld-2.13.so
b6f26000 b6f2c000 r-xp /opt/usr/apps/org.example.hap/bin/hap
b6f34000 b6f35000 rwxp /opt/usr/apps/org.example.hap/bin/hap
b81c1000 b85fc000 rwxp [heap]
beb85000 beba6000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3184)
Call Stack Count: 1
 0: strlen + 0x4 (0xb6aa1dc4) [/lib/libc.so.6] + 0x72dc4
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
m_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), hold(0) freeze(0)
05-29 23:35:12.129+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] obj(b768b2d8), type(elm_scroller)
05-29 23:35:12.129+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3354 _elm_scroll_post_event_move() [DDO] hold_parent(0)
05-29 23:35:12.129+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3617 _elm_scroll_hold_animator() [DDO] obj(b768b2d8), locked_x(0)
05-29 23:35:12.159+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3965 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), block(2)
05-29 23:35:12.159+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), ev->cur.canvas.x(101) ev->cur.canvas.y(193)
05-29 23:35:12.159+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(b768b2d8), hold(0) freeze(0)
05-29 23:35:12.159+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] obj(b768b2d8), type(elm_scroller)
05-29 23:35:12.159+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3354 _elm_scroll_post_event_move() [DDO] hold_parent(0)
05-29 23:35:12.159+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3617 _elm_scroll_hold_animator() [DDO] obj(b768b2d8), locked_x(0)
05-29 23:35:12.179+0900 W/W_HOME  ( 1177): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
05-29 23:35:12.179+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3617 _elm_scroll_hold_animator() [DDO] obj(b768b2d8), locked_x(0)
05-29 23:35:12.199+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:12.199+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:12.209+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3617 _elm_scroll_hold_animator() [DDO] obj(b768b2d8), locked_x(0)
05-29 23:35:12.219+0900 E/EFL     ( 1177): elementary<1177> elm_interface_scrollable.c:3617 _elm_scroll_hold_animator() [DDO] obj(b768b2d8), locked_x(0)
05-29 23:35:12.239+0900 E/EFL     ( 1177): evas_main<1177> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=0 button=1 downs=0
05-29 23:35:12.349+0900 W/wnotib  ( 1177): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
05-29 23:35:12.399+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:12.399+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:12.419+0900 I/GESTURE (  244): gesture.c: GestureHandleMTSyncEvent(3243) > [GestureHandleMTSyncEvent] Rotary finished. But touch events are still dropped until SYNC_END.
05-29 23:35:12.509+0900 W/W_HOME  ( 1177): event_manager.c: _home_scroll_cb(564) > scroll,done
05-29 23:35:12.599+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:12.599+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:12.799+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:12.799+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:12.859+0900 W/W_HOME  ( 1177): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
05-29 23:35:12.959+0900 I/watchface-viewer( 1755): viewer-part-resource.cpp: SetUpdateImage(1825) > new mThread[0xb9039038]
05-29 23:35:12.999+0900 I/watchface-viewer( 1755): viewer-part-resource.cpp: ThreadCallback(1952) > thread[0xb9039038]
05-29 23:35:12.999+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:12.999+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:13.019+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 11 -> 11 1464532513 71
05-29 23:35:13.019+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 11 0 0 0
05-29 23:35:13.019+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 11 0 0 0
05-29 23:35:13.019+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 11 0 0 0
05-29 23:35:13.019+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 11 0 0 0
05-29 23:35:13.019+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 11 0 0 0
05-29 23:35:13.019+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 11 0 0 0
05-29 23:35:13.019+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 11 0 0 16
05-29 23:35:13.019+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 11 0 0 0
05-29 23:35:13.019+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 11 0 0 0
05-29 23:35:13.019+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 11 0 0 0
05-29 23:35:13.049+0900 I/watchface-viewer( 1755): viewer-part-resource.cpp: ThreadNotifyCallback(2014) > thread[0xb9039038]
05-29 23:35:13.049+0900 I/watchface-viewer( 1755): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
05-29 23:35:13.059+0900 I/watchface-viewer( 1755): viewer-part-resource.cpp: ThreadEndCallback(2050) > thread[0xb9039038]
05-29 23:35:13.089+0900 W/W_HOME  ( 1177): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
05-29 23:35:13.089+0900 W/W_HOME  ( 1177): dbox.c: _dbus_rotation_cb(1348) > angle changed:0
05-29 23:35:13.199+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:13.199+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:13.239+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 0
05-29 23:35:13.259+0900 I/AUL_AMD (  957): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/popup-launcher, ret : 0
05-29 23:35:13.269+0900 I/AUL_AMD (  957): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/dbus-daemon, ret : 0
05-29 23:35:13.269+0900 E/AUL_AMD (  957): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
05-29 23:35:13.269+0900 W/AUL_AMD (  957): amd_launch.c: _start_app(1659) > caller pid : 3167
05-29 23:35:13.289+0900 E/RESOURCED(  958): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 23:35:13.289+0900 W/AUL_AMD (  957): amd_launch.c: _start_app(2026) > pad pid(-5)
05-29 23:35:13.289+0900 W/AUL_PAD ( 1674): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
05-29 23:35:13.289+0900 W/AUL_PAD ( 1674): launchpad.c: __send_result_to_caller(265) > Check app launching
05-29 23:35:13.299+0900 W/W_INDICATOR( 1139): windicator_battery.c: _battery_charger_status_changed_cb(140) > [_battery_charger_status_changed_cb:140] Show Moment View to display TA status(unconnected)
05-29 23:35:13.299+0900 E/W_INDICATOR( 1139): windicator_moment_view.c: windicator_moment_view_show(555) > [windicator_moment_view_show:555] Show Moment View : dynamic_layout(0xb77ced00), type(1)
05-29 23:35:13.309+0900 E/E17     (  628): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x01a00011)
05-29 23:35:13.329+0900 W/APP_CORE( 1139): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1a00011
05-29 23:35:13.339+0900 W/W_HOME  ( 1177): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-29 23:35:13.339+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:35:13.339+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:35:13.349+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:35:13.349+0900 W/W_HOME  ( 1177): main.c: _ecore_x_message_cb(1233) > main_info.is_win_on_top: 0
05-29 23:35:13.349+0900 I/GESTURE (  244): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
05-29 23:35:13.399+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:13.399+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:13.419+0900 I/APP_CORE( 1139): appcore-efl.c: __do_app(429) > [APP 1139] Event: RESUME State: PAUSED
05-29 23:35:13.419+0900 I/CAPI_APPFW_APPLICATION( 1139): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-29 23:35:13.479+0900 I/efl-extension( 2860): efl_extension.c: eext_mod_init(40) > Init
05-29 23:35:13.479+0900 I/UXT     ( 2860): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-29 23:35:13.539+0900 I/Adreno-EGL( 2860): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
05-29 23:35:13.539+0900 I/Adreno-EGL( 2860): OpenGL ES Shader Compiler Version: E031.24.00.16
05-29 23:35:13.539+0900 I/Adreno-EGL( 2860): Build Date: 09/02/15 Wed
05-29 23:35:13.539+0900 I/Adreno-EGL( 2860): Local Branch: 
05-29 23:35:13.539+0900 I/Adreno-EGL( 2860): Remote Branch: 
05-29 23:35:13.539+0900 I/Adreno-EGL( 2860): Local Patches: 
05-29 23:35:13.539+0900 I/Adreno-EGL( 2860): Reconstruct Branch: 
05-29 23:35:13.589+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:13.589+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:13.599+0900 E/RESOURCED(  958): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.system-syspopup
05-29 23:35:13.719+0900 I/Adreno-EGL( 2860): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
05-29 23:35:13.719+0900 I/Adreno-EGL( 2860): OpenGL ES Shader Compiler Version: E031.24.00.16
05-29 23:35:13.719+0900 I/Adreno-EGL( 2860): Build Date: 09/02/15 Wed
05-29 23:35:13.719+0900 I/Adreno-EGL( 2860): Local Branch: 
05-29 23:35:13.719+0900 I/Adreno-EGL( 2860): Remote Branch: 
05-29 23:35:13.719+0900 I/Adreno-EGL( 2860): Local Patches: 
05-29 23:35:13.719+0900 I/Adreno-EGL( 2860): Reconstruct Branch: 
05-29 23:35:13.749+0900 I/Adreno-EGL( 2860): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
05-29 23:35:13.749+0900 I/Adreno-EGL( 2860): OpenGL ES Shader Compiler Version: E031.24.00.16
05-29 23:35:13.749+0900 I/Adreno-EGL( 2860): Build Date: 09/02/15 Wed
05-29 23:35:13.749+0900 I/Adreno-EGL( 2860): Local Branch: 
05-29 23:35:13.749+0900 I/Adreno-EGL( 2860): Remote Branch: 
05-29 23:35:13.749+0900 I/Adreno-EGL( 2860): Local Patches: 
05-29 23:35:13.749+0900 I/Adreno-EGL( 2860): Reconstruct Branch: 
05-29 23:35:13.789+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:13.789+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:13.799+0900 I/APP_CORE( 2860): appcore-efl.c: __do_app(429) > [APP 2860] Event: RESET State: CREATED
05-29 23:35:13.879+0900 E/E17     (  628): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05c00009)
05-29 23:35:13.979+0900 I/efl-extension( 2860): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0xb166c6b0 = w: 0 h: 0  obj 0xb16525e8 w: 360 h: 360
05-29 23:35:13.979+0900 I/efl-extension( 2860): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 23:35:13.979+0900 I/efl-extension( 2860): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-29 23:35:13.979+0900 I/efl-extension( 2860): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-29 23:35:13.979+0900 I/efl-extension( 2860): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-29 23:35:13.979+0900 I/efl-extension( 2860): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-29 23:35:13.989+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:13.989+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:14.119+0900 I/efl-extension( 2860): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb91aec70, elm_scroller, _activated_obj : 0x0, activated : 1
05-29 23:35:14.179+0900 I/APP_CORE( 2860): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 23:35:14.179+0900 I/APP_CORE( 2860): appcore-efl.c: __do_app(474) > [APP 2860] Initial Launching, call the resume_cb
05-29 23:35:14.189+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:14.189+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:14.199+0900 W/APP_CORE( 2860): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5c00009
05-29 23:35:14.309+0900 W/AUL_AMD (  957): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 23:35:14.309+0900 W/AUL_AMD (  957): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
05-29 23:35:14.389+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:14.389+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:14.589+0900 I/APP_CORE( 2860): appcore-efl.c: __do_app(429) > [APP 2860] Event: RESUME State: RUNNING
05-29 23:35:14.589+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:14.589+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:14.759+0900 I/TIZEN_N_SOUND_MANAGER( 3174): sound_manager.c: sound_manager_set_session_type(155) > >> enter : type=2
05-29 23:35:14.759+0900 I/TIZEN_N_SOUND_MANAGER( 3174): sound_manager.c: sound_manager_set_session_type(220) > << leave : type=2, ret=0x0
05-29 23:35:14.759+0900 W/TIZEN_N_SOUND_MANAGER( 3174): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_set_session_type] ERROR_NONE (0x00000000)
05-29 23:35:14.759+0900 I/CAPI_MEDIA_WAV_PLAYER( 3174): wav_player.c: wav_player_start(41) > path(/usr/share/feedback/sound/System/Low_Battery.ogg), type(1), cb(0xb6f01c09)
05-29 23:35:14.779+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 23:35:14.789+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:14.789+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:14.789+0900 W/AUL_AMD (  957): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2860
05-29 23:35:14.799+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 12
05-29 23:35:14.899+0900 E/CAPI_MEDIA_WAV_PLAYER( 3174): wav_player_private.c: __convert_wav_player_error_code(59) > [wav_player_start] ERROR_NONE(0x00000000)
05-29 23:35:14.989+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:14.989+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:15.189+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:15.189+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:15.299+0900 E/W_INDICATOR( 1139): windicator_moment_view.c: windicator_moment_view_hide(611) > [windicator_moment_view_hide:611] Hide Moment View : dynamic_layout(0xb77ced00),Type(1)
05-29 23:35:15.299+0900 E/W_INDICATOR( 1139): windicator_connection.c: windi_connection_pause(1598) > [windi_connection_pause:1598] Failed to deregister noti event : TAPI_PROP_MODEL_POWER
05-29 23:35:15.309+0900 E/W_INDICATOR( 1139): windicator_util.c: windi_x_input_event_unregister(225) > [windi_x_input_event_unregister:225] not registered
05-29 23:35:15.399+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:15.399+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:15.439+0900 W/APP_CORE( 1139): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:1a00011
05-29 23:35:15.439+0900 I/APP_CORE( 1139): appcore-efl.c: __do_app(429) > [APP 1139] Event: PAUSE State: RUNNING
05-29 23:35:15.439+0900 I/CAPI_APPFW_APPLICATION( 1139): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 23:35:15.499+0900 I/AUL_PAD ( 3176): launchpad_loader.c: main(600) > [candidate] elm init, returned: 1
05-29 23:35:15.579+0900 I/CAPI_MEDIA_WAV_PLAYER( 3174): wav_player_private.c: __internal_complete_cb(70) > user callback(0xb6f01c09) will be called
05-29 23:35:15.579+0900 I/TIZEN_N_SOUND_MANAGER( 3174): sound_manager.c: sound_manager_set_session_type(155) > >> enter : type=0
05-29 23:35:15.589+0900 I/TIZEN_N_SOUND_MANAGER( 3174): sound_manager.c: sound_manager_set_session_type(220) > << leave : type=0, ret=0x0
05-29 23:35:15.589+0900 W/TIZEN_N_SOUND_MANAGER( 3174): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_set_session_type] ERROR_NONE (0x00000000)
05-29 23:35:15.599+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:15.599+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:15.599+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 23:35:15.609+0900 W/AUL_AMD (  957): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 23:35:15.619+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 26
05-29 23:35:15.629+0900 I/AUL_AMD (  957): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
05-29 23:35:15.639+0900 I/AUL_AMD (  957): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
05-29 23:35:15.639+0900 E/AUL_AMD (  957): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
05-29 23:35:15.639+0900 W/AUL_AMD (  957): amd_launch.c: _start_app(1659) > caller pid : 949
05-29 23:35:15.659+0900 W/AUL_AMD (  957): amd_launch.c: _start_app(2026) > pad pid(-5)
05-29 23:35:15.659+0900 E/RESOURCED(  958): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-29 23:35:15.659+0900 W/AUL_PAD ( 1674): launchpad.c: __launchpad_main_loop(526) > Candidate is not prepared, enter legacy logic
05-29 23:35:15.659+0900 W/AUL_PAD ( 1674): launchpad.c: __send_result_to_caller(265) > Check app launching
05-29 23:35:15.659+0900 W/AUL_AMD (  957): amd_launch.c: _start_app(2037) > Launch with legacy way : no launchpad
05-29 23:35:15.659+0900 E/RESOURCED(  958): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 23:35:15.659+0900 W/AUL_AMD (  957): amd_launch.c: start_process(573) > child process: 3184
05-29 23:35:15.709+0900 W/AUL_AMD (  957): amd_launch.c: __send_app_launch_signal(376) > send launch signal done: 3184
05-29 23:35:15.759+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 23:35:15.769+0900 W/AUL_AMD (  957): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3184
05-29 23:35:15.769+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 12
05-29 23:35:15.789+0900 I/efl-extension( 3184): efl_extension.c: eext_mod_init(40) > Init
05-29 23:35:15.799+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:15.799+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:15.819+0900 I/CAPI_APPFW_APPLICATION( 3184): app_main.c: ui_app_main(704) > app_efl_main
05-29 23:35:15.999+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:15.999+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:16.199+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:16.199+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:16.389+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:16.389+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:16.489+0900 I/CAPI_APPFW_APPLICATION( 3184): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-29 23:35:16.589+0900 I/Adreno-EGL( 3184): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
05-29 23:35:16.589+0900 I/Adreno-EGL( 3184): OpenGL ES Shader Compiler Version: E031.24.00.16
05-29 23:35:16.589+0900 I/Adreno-EGL( 3184): Build Date: 09/02/15 Wed
05-29 23:35:16.589+0900 I/Adreno-EGL( 3184): Local Branch: 
05-29 23:35:16.589+0900 I/Adreno-EGL( 3184): Remote Branch: 
05-29 23:35:16.589+0900 I/Adreno-EGL( 3184): Local Patches: 
05-29 23:35:16.589+0900 I/Adreno-EGL( 3184): Reconstruct Branch: 
05-29 23:35:16.589+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:16.589+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:16.719+0900 W/AUL_AMD (  957): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 23:35:16.719+0900 W/AUL_AMD (  957): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
05-29 23:35:16.789+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:16.789+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:16.859+0900 E/E17     (  628): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x06000003)
05-29 23:35:16.879+0900 E/EFL     ( 3184): ecore_evas<3184> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-29 23:35:16.959+0900 I/efl-extension( 3184): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0xb84a9520]'s widget[0xb848ac30] to elm_conformant widget[0xb83fbfa8]
05-29 23:35:16.989+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:16.989+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:17.009+0900 I/TIZEN_N_SOUND_MANAGER( 3174): sound_manager.c: __sound_manager_finalize(831) > <ENTER>
05-29 23:35:17.009+0900 I/TIZEN_N_SOUND_MANAGER( 3174): sound_manager.c: __sound_manager_finalize(837) > <LEAVE>
05-29 23:35:17.119+0900 I/HAP     ( 3184): SUCCESSFULLY create sap agent
05-29 23:35:17.119+0900 I/HAP     ( 3184): connectivity type(1): bt
05-29 23:35:17.189+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:17.189+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:17.289+0900 I/HAP     ( 3184): agent is initialized
05-29 23:35:17.289+0900 I/HAP     ( 3184): agent initialized callback is over
05-29 23:35:17.289+0900 I/HAP     ( 3184): SAP >>> getRegisteredServiceAgent() >>> 0
05-29 23:35:17.389+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:17.389+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:17.399+0900 I/APP_CORE( 3184): appcore-efl.c: __do_app(429) > [APP 3184] Event: RESET State: CREATED
05-29 23:35:17.399+0900 I/CAPI_APPFW_APPLICATION( 3184): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 23:35:17.429+0900 I/APP_CORE( 3184): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 23:35:17.429+0900 I/APP_CORE( 3184): appcore-efl.c: __do_app(474) > [APP 3184] Initial Launching, call the resume_cb
05-29 23:35:17.429+0900 I/CAPI_APPFW_APPLICATION( 3184): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 23:35:17.439+0900 W/APP_CORE( 3184): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6000003
05-29 23:35:17.439+0900 I/efl-extension( 3184): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0xb84a9520 = w: 0 h: 0  obj 0xb848ac30 w: 360 h: 360
05-29 23:35:17.449+0900 I/efl-extension( 3184): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 23:35:17.519+0900 W/W_HOME  ( 1177): event_manager.c: _window_visibility_cb(448) > Window [0x2800003] is now visible(1)
05-29 23:35:17.519+0900 W/W_HOME  ( 1177): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-29 23:35:17.519+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:35:17.519+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(333) > appcore paused manually
05-29 23:35:17.519+0900 W/W_HOME  ( 1177): main.c: home_appcore_pause(719) > Home Appcore Paused
05-29 23:35:17.519+0900 W/W_HOME  ( 1177): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-29 23:35:17.519+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:35:17.519+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:35:17.519+0900 W/W_HOME  ( 1177): main.c: home_pause(762) > clock/widget paused
05-29 23:35:17.519+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:35:17.519+0900 I/APP_CORE( 3184): appcore-efl.c: __do_app(429) > [APP 3184] Event: RESUME State: RUNNING
05-29 23:35:17.519+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 23:35:17.519+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 23:35:17.519+0900 I/MESSAGE_PORT(  866): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 23:35:17.519+0900 I/MESSAGE_PORT(  866): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-29 23:35:17.519+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-29 23:35:17.519+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 23:35:17.519+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-29 23:35:17.519+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 23:35:17.519+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 23:35:17.519+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 23:35:17.519+0900 I/MESSAGE_PORT(  866): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 23:35:17.519+0900 I/MESSAGE_PORT(  866): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-29 23:35:17.519+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-29 23:35:17.519+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 23:35:17.519+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-29 23:35:17.519+0900 I/MESSAGE_PORT(  866): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-29 23:35:17.519+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-29 23:35:17.519+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 23:35:17.519+0900 W/W_HOME  ( 1177): main.c: _window_visibility_cb(1200) > Window [0x2800003] is now visible(1)
05-29 23:35:17.529+0900 I/APP_CORE( 1177): appcore-efl.c: __do_app(429) > [APP 1177] Event: PAUSE State: RUNNING
05-29 23:35:17.529+0900 I/CAPI_APPFW_APPLICATION( 1177): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 23:35:17.529+0900 W/W_HOME  ( 1177): main.c: _appcore_pause_cb(692) > appcore pause
05-29 23:35:17.529+0900 E/W_HOME  ( 1177): main.c: _pause_cb(670) > paused already
05-29 23:35:17.529+0900 W/AUL_AMD (  957): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 23:35:17.529+0900 W/AUL_AMD (  957): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
05-29 23:35:17.549+0900 E/CAPI_APPFW_APP_CONTROL( 1615): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-29 23:35:17.549+0900 W/MUSIC_CONTROL_SERVICE( 1615): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1615]   value = [false][0m
05-29 23:35:17.619+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:35:17.619+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:35:17.659+0900 I/wnotib  ( 1177): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-29 23:35:17.659+0900 E/wnotib  ( 1177): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 23:35:17.669+0900 W/WATCH_CORE( 1755): appcore-watch.c: __widget_pause(1001) > widget_pause
05-29 23:35:17.669+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppPause(717) > 
05-29 23:35:17.669+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:35:17.669+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:35:17.669+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:35:17.669+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:35:17.669+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:35:17.669+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:35:17.739+0900 E/EFL     ( 2860): evas_main<2860> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1062124 button=1 downs=1
05-29 23:35:17.739+0900 I/HAP     ( 3184): Updating UI with data Connection Established
05-29 23:35:17.909+0900 E/EFL     ( 2860): evas_main<2860> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1062309 button=1 downs=0
05-29 23:35:18.029+0900 I/APP_CORE( 1177): appcore-efl.c: __do_app(429) > [APP 1177] Event: MEM_FLUSH State: PAUSED
05-29 23:35:18.359+0900 E/EFL     ( 2860): evas_main<2860> evas_events.c:1009 evas_event_feed_mouse_down() ButtonEvent:down time=1062761 button=1 downs=1
05-29 23:35:18.419+0900 I/watchface-viewer( 1755): viewer-data-provider.cpp: AddPendingChanges(1053) > added [32] to pending list
05-29 23:35:18.419+0900 I/watchface-viewer( 1755): viewer-data-provider.cpp: AddPendingChanges(1053) > added [34] to pending list
05-29 23:35:18.469+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 11 -> 11 1464532518 5
05-29 23:35:18.469+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 11 0 0 0
05-29 23:35:18.469+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 11 0 0 17
05-29 23:35:18.469+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 11 0 0 0
05-29 23:35:18.469+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 11 0 0 0
05-29 23:35:18.469+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 11 0 0 0
05-29 23:35:18.479+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 11 0 0 0
05-29 23:35:18.479+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 11 0 0 0
05-29 23:35:18.479+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 11 0 0 0
05-29 23:35:18.479+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 11 0 0 0
05-29 23:35:18.479+0900 I/RESOURCED(  958): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 11 0 0 0
05-29 23:35:18.489+0900 I/AUL_AMD (  957): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
05-29 23:35:18.509+0900 I/AUL_AMD (  957): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
05-29 23:35:18.509+0900 E/AUL_AMD (  957): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
05-29 23:35:18.509+0900 W/AUL_AMD (  957): amd_launch.c: _start_app(1659) > caller pid : 957
05-29 23:35:18.509+0900 I/efl-extension( 2860): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb91aec70, elm_scroller, _activated_obj : 0xb91aec70, activated : 0
05-29 23:35:18.559+0900 I/efl-extension( 2860): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0xb91aec70, obj: 0xb91aec70
05-29 23:35:18.559+0900 I/efl-extension( 2860): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-29 23:35:18.559+0900 I/efl-extension( 2860): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-29 23:35:18.559+0900 I/efl-extension( 2860): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-29 23:35:18.559+0900 I/efl-extension( 2860): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 23:35:18.559+0900 I/efl-extension( 2860): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 23:35:18.559+0900 I/efl-extension( 2860): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0xb166c6b0 is freed
05-29 23:35:18.559+0900 I/efl-extension( 2860): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 23:35:18.559+0900 I/efl-extension( 2860): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xb91aec70, elm_scroller, func : 0xb5750249
05-29 23:35:18.559+0900 I/efl-extension( 2860): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 23:35:18.559+0900 I/efl-extension( 2860): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 23:35:18.559+0900 I/efl-extension( 2860): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xb16525e8, elm_image, func : 0xb5750249
05-29 23:35:18.559+0900 I/efl-extension( 2860): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 23:35:18.559+0900 I/efl-extension( 2860): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(841) > [0xb91aec70 : elm_scroller] rotary callabck is deleted
05-29 23:35:18.569+0900 E/EFL     ( 2860): evas_main<2860> evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=1062859 button=1 downs=0
05-29 23:35:18.589+0900 E/RESOURCED(  958): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > [resourced_dbus_system_hash_drop_busname,324] Does not exist in busname hash: :1.271
05-29 23:35:18.599+0900 E/APP_CORE( 2860): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-29 23:35:18.599+0900 I/APP_CORE( 2860): appcore-efl.c: __after_loop(1086) > Legacy lifecycle: 0
05-29 23:35:18.599+0900 I/APP_CORE( 2860): appcore-efl.c: __after_loop(1088) > [APP 2860] PAUSE before termination
05-29 23:35:18.619+0900 W/W_HOME  ( 1177): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
05-29 23:35:18.619+0900 W/W_HOME  ( 1177): dbox.c: _dbus_rotation_cb(1351) > invalid angle, skipped:0
05-29 23:35:18.679+0900 W/AUL_AMD (  957): amd_launch.c: start_process(573) > child process: 3197
05-29 23:35:18.699+0900 W/W_INDICATOR( 1139): windicator_battery.c: _battery_charger_status_changed_cb(145) > [_battery_charger_status_changed_cb:145] TA connected or abnormal
05-29 23:35:18.699+0900 W/W_INDICATOR( 1139): windicator_battery.c: _battery_charger_status_changed_cb(161) > [_battery_charger_status_changed_cb:161] Show Moment View to display charging animation
05-29 23:35:18.739+0900 E/W_INDICATOR( 1139): windicator_moment_view.c: windicator_moment_view_show(555) > [windicator_moment_view_show:555] Show Moment View : dynamic_layout(0xb77ced00), type(1)
05-29 23:35:18.749+0900 E/E17     (  628): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x01a00011)
05-29 23:35:18.759+0900 W/AUL_AMD (  957): amd_launch.c: __send_app_launch_signal(376) > send launch signal done: 3197
05-29 23:35:18.769+0900 I/AUL_AMD (  957): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
05-29 23:35:18.769+0900 E/RESOURCED(  958): proc-main.c: proc_add_app_list(272) > [proc_add_app_list,272] not found previous pai : com.samsung.w-gallery.consumer
05-29 23:35:18.769+0900 E/RESOURCED(  958): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-gallery
05-29 23:35:18.779+0900 I/AUL_AMD (  957): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
05-29 23:35:18.779+0900 E/AUL_AMD (  957): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
05-29 23:35:18.779+0900 W/AUL_AMD (  957): amd_launch.c: _start_app(1659) > caller pid : 957
05-29 23:35:18.809+0900 W/AUL_AMD (  957): amd_launch.c: start_process(573) > child process: 3198
05-29 23:35:18.809+0900 W/W_HOME  ( 1177): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
05-29 23:35:18.819+0900 W/W_HOME  ( 1177): dbox.c: _dbus_rotation_cb(1348) > angle changed:90
05-29 23:35:18.859+0900 W/APP_CORE( 1139): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1a00011
05-29 23:35:18.939+0900 I/RESOURCED(  958): timer-slack.c: control_timer_state(109) > [control_timer_state,109] move to service timer slack cgroup : pid (3197), ret (0)
05-29 23:35:18.959+0900 W/AUL_AMD (  957): amd_launch.c: __send_app_launch_signal(376) > send launch signal done: 3198
05-29 23:35:18.959+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 22
05-29 23:35:18.959+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(884) > app status : 4
05-29 23:35:18.959+0900 E/RESOURCED(  958): proc-main.c: proc_add_app_list(272) > [proc_add_app_list,272] not found previous pai : com.samsung.w-music-transfer.consumer
05-29 23:35:18.969+0900 I/APP_CORE( 1139): appcore-efl.c: __do_app(429) > [APP 1139] Event: RESUME State: PAUSED
05-29 23:35:18.969+0900 I/CAPI_APPFW_APPLICATION( 1139): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-29 23:35:18.969+0900 I/UXT     ( 2860): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 23:35:18.999+0900 I/RESOURCED(  958): timer-slack.c: control_timer_state(109) > [control_timer_state,109] move to service timer slack cgroup : pid (3198), ret (0)
05-29 23:35:19.049+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 23:35:19.069+0900 W/AUL_AMD (  957): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3197
05-29 23:35:19.069+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 12
05-29 23:35:19.099+0900 I/TIZEN_N_SOUND_MANAGER( 3190): sound_manager.c: sound_manager_set_session_type(155) > >> enter : type=2
05-29 23:35:19.099+0900 I/TIZEN_N_SOUND_MANAGER( 3190): sound_manager.c: sound_manager_set_session_type(220) > << leave : type=2, ret=0x0
05-29 23:35:19.099+0900 W/TIZEN_N_SOUND_MANAGER( 3190): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_set_session_type] ERROR_NONE (0x00000000)
05-29 23:35:19.099+0900 I/CAPI_MEDIA_WAV_PLAYER( 3190): wav_player.c: wav_player_start(41) > path(/usr/share/feedback/sound/System/Charger_connection.ogg), type(1), cb(0xb6e99c09)
05-29 23:35:19.119+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 23:35:19.129+0900 W/AUL_AMD (  957): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3198
05-29 23:35:19.139+0900 I/HAP     ( 3184): routes length: 1
05-29 23:35:19.139+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 12
05-29 23:35:19.149+0900 I/tag     ( 3184): get_tts_state state = 1
05-29 23:35:19.169+0900 I/tag     ( 3184): get_tts_state state = 1
05-29 23:35:19.229+0900 E/CAPI_MEDIA_WAV_PLAYER( 3190): wav_player_private.c: __convert_wav_player_error_code(59) > [wav_player_start] ERROR_NONE(0x00000000)
05-29 23:35:19.329+0900 I/efl-extension( 2860): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-29 23:35:19.369+0900 W/WG-CONSUMER( 3197): [34m[F:AlarmSvc.cpp     L:   80][_HIGH]CAlarmSvc::CAlarmSvc()[0m
05-29 23:35:19.369+0900 W/WG-CONSUMER( 3197): [34m[F:TransferCtrl.cpp L:   81][_HIGH]CTransferCtrl::CTransferCtrl()[0m
05-29 23:35:19.369+0900 W/WG-CONSUMER( 3197): [34m[F:SAPClient.cpp    L:   79][_HIGH][TX]CSAPClient::BindPeer(). ASP=/app/gallery/receiver SPF=SAGalleryReceiverService nChannel=4444[0m
05-29 23:35:19.369+0900 W/WG-CONSUMER( 3197): [34m[F:PeerList.cpp     L:  159][_HIGH][TX]CPeerList::CPeerList(0xb8849844)[0m
05-29 23:35:19.369+0900 W/WG-CONSUMER( 3197): [34m[F:SAPProxy.cpp     L:   48][_HIGH]Creating SAP Proxy Object. 0xb8849880[0m
05-29 23:35:19.369+0900 W/WG-CONSUMER( 3197): [34m[F:ConnectionInfo.c L:   75][_HIGH][TX]Bind(). ASP=/app/gallery/receiver SPF=SAGalleryReceiverService Role=Consumer Channel=4444[0m
05-29 23:35:19.369+0900 W/WG-CONSUMER( 3197): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_NULL->SM_STATE_INITIATE[0m
05-29 23:35:19.369+0900 W/WG-CONSUMER( 3197): [34m[F:ReceiverCtrl.cpp L:   61][_HIGH]CReceiverCtrl::CReceiverCtrl()[0m
05-29 23:35:19.369+0900 W/WG-CONSUMER( 3197): [34m[F:AutoTransfer.cpp L:  104][_HIGH]Set Event Handler. 0xb6ff1d3c[0m
05-29 23:35:19.369+0900 W/WG-CONSUMER( 3197): [34m[F:SAPClient.cpp    L:   79][_HIGH][RX]CSAPClient::BindPeer(). ASP=/app/gallery/transfer SPF=SAGalleryTransferService nChannel=4444[0m
05-29 23:35:19.369+0900 W/WG-CONSUMER( 3197): [34m[F:PeerList.cpp     L:  159][_HIGH][RX]CPeerList::CPeerList(0xb884b9d4)[0m
05-29 23:35:19.369+0900 W/WG-CONSUMER( 3197): [34m[F:ConnectionInfo.c L:   75][_HIGH][RX]Bind(). ASP=/app/gallery/transfer SPF=SAGalleryTransferService Role=Consumer Channel=4444[0m
05-29 23:35:19.369+0900 W/WG-CONSUMER( 3197): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_NULL->SM_STATE_INITIATE[0m
05-29 23:35:19.369+0900 W/WG-CONSUMER( 3197): [34m[F:consumer-app.cpp L:   96][_HIGH]Gallery file consumer SVC is started[0m
05-29 23:35:19.369+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 3197): media_content.c: media_content_connect(860) > [32m[3197]ref count : 0
05-29 23:35:19.369+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 3197): media_content.c: media_content_connect(892) > [32m[3197]ref count changed to: 1
05-29 23:35:19.369+0900 W/WG-CONSUMER( 3197): [34m[F:TransferCtrl.cpp L:  115][_HIGH][TX]Connect to Peer[0m
05-29 23:35:19.399+0900 W/MUSIC_TRANSFER( 3198): mt-service.c: main(92) > [33m[TID:3198]   service start[0m
05-29 23:35:19.399+0900 W/MUSIC_TRANSFER( 3198): mt-service.c: _service_app_create(32) > [33m[TID:3198]   [0m
05-29 23:35:19.439+0900 W/WG-CONSUMER( 3197): [34m[F:UserNotification L:  181][_HIGH]WIPC Service Created[0m
05-29 23:35:19.439+0900 W/WG-CONSUMER( 3197): [34m[F:SAPClient.cpp    L:   95][_HIGH][TX]CSAPClient::Connect()[0m
05-29 23:35:19.439+0900 W/WG-CONSUMER( 3197): [34m[F:ConnectionInfo.c L:  122][_HIGH][TX]CConnection::Connect() State:SM_STATE_INITIATE[0m
05-29 23:35:19.439+0900 W/WG-CONSUMER( 3197): [34m[F:SAPProxy.cpp     L:  129][_HIGH]CSAPProxy::Connect. Size=0 pConnection=0xb884a878[0m
05-29 23:35:19.439+0900 W/WG-CONSUMER( 3197): [34m[F:SAPProxy.cpp     L:  323][_HIGH]Device Connected. Cur type=BT|[0m
05-29 23:35:19.439+0900 W/WG-CONSUMER( 3197): [34m[F:SAPProxy.cpp     L:  168][_HIGH]Device connected. WMS=1 BT=1 [0m
05-29 23:35:19.439+0900 W/WG-CONSUMER( 3197): [34m[F:ConnectionInfo.c L:  583][_HIGH][TX]advance. CurState=SM_STATE_INITIATE(2)[0m
05-29 23:35:19.439+0900 W/WG-CONSUMER( 3197): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_INITIATE->SM_STATE_REGISTERING[0m
05-29 23:35:19.519+0900 I/WECONN  (  924): technology.c: __get_state(83) > W_SERVICE_TYPE_SAP
05-29 23:35:19.549+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 3198): media_content.c: media_content_connect(860) > [32m[3198]ref count : 0
05-29 23:35:19.549+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 3198): media_content.c: media_content_connect(892) > [32m[3198]ref count changed to: 1
05-29 23:35:19.619+0900 I/AUL_AMD (  957): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2860
05-29 23:35:19.719+0900 W/CRASH_MANAGER( 3209): worker.c: worker_job(1199) > 1103184686170146453251
