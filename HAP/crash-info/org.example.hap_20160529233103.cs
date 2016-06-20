S/W Version Information
Model: SM-R735S
Tizen-Version: 2.3.1.2
Build-Number: R735SKSU1AOKE
Build-Date: 2015.11.25 20:46:58

Crash Information
Process Name: hap
PID: 2869
Date: 2016-05-29 23:31:03+0900
Executable File Path: /opt/usr/apps/org.example.hap/bin/hap
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x002bc709, r3   = 0x00000001
r4   = 0xb7f7e4a8, r5   = 0xb6c22b34
r6   = 0xbe892c3c, r7   = 0x00000000
r8   = 0x00000002, r9   = 0xb6bf8861
r10  = 0x00000000, fp   = 0xbe892c58
ip   = 0xb6c22c4c, sp   = 0xbe891c30
lr   = 0xb6c0e23d, pc   = 0xb6acbdc4
cpsr = 0x20000010

Memory Information
MemTotal:   407572 KB
MemFree:     11008 KB
Buffers:      4308 KB
Cached:      90144 KB
VmPeak:      91308 KB
VmSize:      87172 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23564 KB
VmRSS:       23564 KB
VmData:      44216 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       37824 KB
VmPTE:          72 KB
VmSwap:        712 KB

Threads Information
Threads: 3
PID = 2869 TID = 2869
2869 2873 2876 

Maps Information
b1c76000 b1d72000 rwxs /dev/kgsl-3d0
b1d72000 b1dd0000 rwxs /dev/kgsl-3d0
b1e67000 b1e6b000 rwxs /dev/kgsl-3d0
b1e6b000 b1e6c000 rwxs /dev/kgsl-3d0
b1e6c000 b1e6d000 rwxs /dev/kgsl-3d0
b1e6d000 b1e6e000 rwxs /dev/kgsl-3d0
b1e6e000 b1e6f000 rwxs /dev/kgsl-3d0
b1e6f000 b1e70000 rwxs /dev/kgsl-3d0
b1e70000 b1e71000 rwxs /dev/kgsl-3d0
b1e71000 b1e72000 rwxs /dev/kgsl-3d0
b1ef0000 b1ef1000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
b1ef8000 b1ef9000 rwxp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
b1ef9000 b1f80000 rwxs anon_inode:dmabuf
b1f81000 b2780000 rwxp [stack:2876]
b2780000 b280b000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
b2811000 b2898000 rwxs anon_inode:dmabuf
b2898000 b289c000 rwxs /dev/kgsl-3d0
b289c000 b28a0000 rwxs /dev/kgsl-3d0
b28a0000 b28c0000 rwxs /dev/kgsl-3d0
b28c0000 b2900000 rwxs /dev/kgsl-3d0
b2a03000 b2a06000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b2a0d000 b2a0e000 rwxp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b2a0e000 b2a2e000 rwxs /dev/kgsl-3d0
b2a2e000 b2aba000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
b2aba000 b2ac9000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
b2ac9000 b2acd000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
b2acd000 b2ad0000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
b2ad0000 b2ad7000 r-xs /usr/lib/gconv/gconv-modules.cache
b32e2000 b32e6000 rwxs /dev/kgsl-3d0
b32e6000 b32ea000 rwxs /dev/kgsl-3d0
b32ea000 b32ee000 rwxs /dev/kgsl-3d0
b32ee000 b32f2000 rwxs /dev/kgsl-3d0
b32f2000 b32f3000 rwxs /dev/kgsl-3d0
b32f3000 b32f4000 rwxs /dev/kgsl-3d0
b32f4000 b32f5000 rwxs /dev/kgsl-3d0
b32f5000 b32f6000 rwxs /dev/kgsl-3d0
b32f6000 b32f7000 rwxs /dev/kgsl-3d0
b32f7000 b32f8000 rwxs /dev/kgsl-3d0
b32f8000 b32f9000 rwxs /dev/kgsl-3d0
b32f9000 b3357000 rwxs /dev/kgsl-3d0
b3b57000 b3b59000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3b60000 b3b61000 rwxp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3b61000 b3b78000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3b80000 b3b85000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3b85000 b3d43000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
b3d43000 b3d45000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
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
b3d64000 b3d65000 rwxs /dev/kgsl-3d0
b3d65000 b3d66000 rwxs /dev/kgsl-3d0
b3d66000 b3d67000 rwxs /dev/kgsl-3d0
b3d67000 b3d68000 rwxs /dev/kgsl-3d0
b3d68000 b3d69000 rwxs /dev/kgsl-3d0
b3d69000 b3d6a000 rwxs /dev/kgsl-3d0
b3d6a000 b3d6b000 rwxs /dev/kgsl-3d0
b3d6b000 b3d6c000 rwxs /dev/kgsl-3d0
b3d6c000 b3d6d000 rwxs /dev/kgsl-3d0
b3d6d000 b3d6e000 rwxs /dev/kgsl-3d0
b3d6e000 b3d6f000 rwxs /dev/kgsl-3d0
b3d6f000 b3d70000 rwxs /dev/kgsl-3d0
b3d70000 b3d71000 rwxs /dev/kgsl-3d0
b3d71000 b3d72000 rwxs /dev/kgsl-3d0
b3d72000 b3d73000 rwxs /dev/kgsl-3d0
b3d73000 b3d74000 rwxs /dev/kgsl-3d0
b3d74000 b3d75000 rwxs /dev/kgsl-3d0
b3d75000 b3d76000 rwxs /dev/kgsl-3d0
b3d76000 b3d77000 rwxs /dev/kgsl-3d0
b3d77000 b3d78000 rwxs /dev/kgsl-3d0
b3d78000 b3d79000 rwxs /dev/kgsl-3d0
b3d79000 b3d7a000 rwxs /dev/kgsl-3d0
b3d7a000 b3d7b000 rwxs /dev/kgsl-3d0
b3d7b000 b3d7c000 rwxs /dev/kgsl-3d0
b3d7c000 b3d7d000 rwxs /dev/kgsl-3d0
b3d7d000 b3d7e000 rwxs /dev/kgsl-3d0
b3d7e000 b3d7f000 rwxs /dev/kgsl-3d0
b3d7f000 b3d80000 rwxs /dev/kgsl-3d0
b3d80000 b3d81000 rwxs /dev/kgsl-3d0
b3d81000 b3d82000 rwxs /dev/kgsl-3d0
b3d82000 b3d83000 rwxs /dev/kgsl-3d0
b3d83000 b3d84000 rwxs /dev/kgsl-3d0
b3d84000 b3d85000 rwxs /dev/kgsl-3d0
b3d85000 b3d86000 rwxs /dev/kgsl-3d0
b3d86000 b3d87000 rwxs /dev/kgsl-3d0
b3d87000 b3d88000 rwxs /dev/kgsl-3d0
b3d88000 b3d89000 rwxs /dev/kgsl-3d0
b3d89000 b3d8a000 rwxs /dev/kgsl-3d0
b3d8a000 b3d8b000 rwxs /dev/kgsl-3d0
b3d8b000 b3d8c000 rwxs /dev/kgsl-3d0
b3d8c000 b3d8d000 rwxs /dev/kgsl-3d0
b3d8d000 b3d8e000 rwxs /dev/kgsl-3d0
b3d8e000 b3d8f000 rwxs /dev/kgsl-3d0
b3d8f000 b3d90000 rwxs /dev/kgsl-3d0
b3d90000 b3d91000 rwxs /dev/kgsl-3d0
b3d91000 b3d92000 rwxs /dev/kgsl-3d0
b3d92000 b3d93000 rwxs /dev/kgsl-3d0
b3d93000 b3d94000 rwxs /dev/kgsl-3d0
b3d94000 b3d95000 rwxs /dev/kgsl-3d0
b3d95000 b3d96000 rwxs /dev/kgsl-3d0
b3d96000 b3d97000 rwxs /dev/kgsl-3d0
b3d97000 b3d98000 rwxs /dev/kgsl-3d0
b3d98000 b3d99000 rwxs /dev/kgsl-3d0
b3d99000 b3d9a000 rwxs /dev/kgsl-3d0
b3d9a000 b3d9b000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3da2000 b3da3000 rwxp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3da3000 b3da7000 rwxs /dev/kgsl-3d0
b3da7000 b3da8000 rwxs /dev/kgsl-3d0
b3da9000 b45a8000 rwxp [stack:2873]
b45a8000 b45a9000 rwxs /dev/kgsl-3d0
b45a9000 b45aa000 rwxs /dev/kgsl-3d0
b45aa000 b45ab000 rwxs /dev/kgsl-3d0
b45ab000 b45ac000 rwxs /dev/kgsl-3d0
b45ac000 b45ad000 rwxs /dev/kgsl-3d0
b45ad000 b45ae000 rwxs /dev/kgsl-3d0
b45ae000 b45af000 rwxs /dev/kgsl-3d0
b45af000 b45bf000 rwxs /dev/kgsl-3d0
b45bf000 b4eeb000 r-xp /usr/lib/libsc-a3xx.so
b4ef3000 b4f27000 rwxp /usr/lib/libsc-a3xx.so
b5138000 b513a000 r-xp /usr/lib/libgenlock.so
b5141000 b5142000 rwxp /usr/lib/libgenlock.so
b5142000 b5143000 rwxs /dev/kgsl-3d0
b5143000 b5144000 rwxs /dev/kgsl-3d0
b5144000 b5145000 rwxs /dev/kgsl-3d0
b5145000 b5146000 rwxs /dev/kgsl-3d0
b5146000 b5147000 rwxs /dev/kgsl-3d0
b5147000 b5148000 rwxs /dev/kgsl-3d0
b5148000 b5149000 rwxs /dev/kgsl-3d0
b5149000 b514a000 rwxs /dev/kgsl-3d0
b514a000 b514b000 rwxs /dev/kgsl-3d0
b514b000 b514c000 rwxs /dev/kgsl-3d0
b514c000 b514d000 rwxs /dev/kgsl-3d0
b514d000 b514e000 rwxs /dev/kgsl-3d0
b514e000 b514f000 rwxs /dev/kgsl-3d0
b514f000 b5150000 rwxs /dev/kgsl-3d0
b5150000 b5151000 rwxs /dev/kgsl-3d0
b5151000 b5152000 rwxs /dev/kgsl-3d0
b5152000 b5153000 rwxs /dev/kgsl-3d0
b5153000 b5154000 rwxs /dev/kgsl-3d0
b5154000 b5156000 rwxs /dev/kgsl-3d0
b5156000 b5158000 rwxs /dev/kgsl-3d0
b5158000 b515a000 r-xp /usr/lib/libdri2.so.0.0.0
b5161000 b5162000 rwxp /usr/lib/libdri2.so.0.0.0
b5162000 b516a000 r-xp /usr/lib/libdrm.so.2.4.0
b5171000 b5172000 rwxp /usr/lib/libdrm.so.2.4.0
b5172000 b5176000 r-xp /usr/lib/libxcb-xfixes.so.0.0.0
b517d000 b517e000 rwxp /usr/lib/libxcb-xfixes.so.0.0.0
b517e000 b5181000 r-xp /usr/lib/libxcb-dri2.so.0.0.0
b5188000 b5189000 rwxp /usr/lib/libxcb-dri2.so.0.0.0
b5189000 b518a000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b5191000 b5192000 rwxp /usr/lib/libX11-xcb.so.1.0.0
b5192000 b5199000 r-xp /usr/lib/libtbm.so.1.0.0
b51a0000 b51a1000 rwxp /usr/lib/libtbm.so.1.0.0
b51a1000 b51a4000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b51ab000 b51ac000 rwxp /usr/lib/libnative-buffer.so.0.1.0
b51ac000 b51ad000 rwxs /dev/kgsl-3d0
b51ad000 b51b1000 rwxs /dev/kgsl-3d0
b51b1000 b51b5000 rwxs /dev/kgsl-3d0
b51b5000 b51ba000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b51c1000 b51c2000 rwxp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b51c2000 b52fd000 r-xp /usr/lib/egl/libGLESv2.so
b5304000 b5338000 rwxp /usr/lib/egl/libGLESv2.so
b5339000 b533b000 r-xp /usr/lib/libadreno_utils.so
b5342000 b5343000 rwxp /usr/lib/libadreno_utils.so
b5345000 b536c000 r-xp /usr/lib/libgsl.so
b5373000 b5375000 rwxp /usr/lib/libgsl.so
b5375000 b5376000 rwxs /dev/kgsl-3d0
b5376000 b5377000 rwxs /dev/kgsl-3d0
b5377000 b537b000 rwxs /dev/kgsl-3d0
b537b000 b537c000 rwxs /dev/kgsl-3d0
b537c000 b5383000 r-xp /usr/lib/egl/eglsubX11.so
b538a000 b538b000 rwxp /usr/lib/egl/eglsubX11.so
b538b000 b53ad000 r-xp /usr/lib/egl/libEGL.so
b53b5000 b53b6000 rwxp /usr/lib/egl/libEGL.so
b53b6000 b542d000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b5435000 b5437000 rwxp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b543d000 b556f000 r-xp /usr/share/locale/locale-archive
b556f000 b576f000 r-xp /usr/share/locale/locale-archive
b576f000 b5779000 r-xp /lib/libnss_files-2.13.so
b5780000 b5781000 r-xp /lib/libnss_files-2.13.so
b5781000 b5782000 rwxp /lib/libnss_files-2.13.so
b5782000 b5785000 r-xp /lib/libattr.so.1.1.0
b578c000 b578d000 rwxp /lib/libattr.so.1.1.0
b578d000 b5794000 r-xp /lib/libcrypt-2.13.so
b579b000 b579c000 r-xp /lib/libcrypt-2.13.so
b579c000 b579d000 rwxp /lib/libcrypt-2.13.so
b57c4000 b57c7000 r-xp /lib/libcap.so.2.21
b57ce000 b57cf000 rwxp /lib/libcap.so.2.21
b57cf000 b57d1000 r-xp /usr/lib/libiri.so
b57d8000 b57d9000 rwxp /usr/lib/libiri.so
b57d9000 b57f5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b57fd000 b57fe000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
b57fe000 b5824000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b582c000 b582d000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
b582d000 b58c1000 r-xp /usr/lib/libstdc++.so.6.0.16
b58c9000 b58cc000 r-xp /usr/lib/libstdc++.so.6.0.16
b58cc000 b58ce000 rwxp /usr/lib/libstdc++.so.6.0.16
b58d4000 b59a3000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b59aa000 b59b9000 rwxp /usr/lib/libscim-1.0.so.8.2.3
b59b9000 b59dd000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b59e4000 b59e6000 rwxp /usr/lib/ecore/immodules/libisf-imf-module.so
b59e6000 b5ab0000 r-xp /usr/lib/libCOREGL.so.4.0
b5ab7000 b5ab9000 rwxp /usr/lib/libCOREGL.so.4.0
b5ac5000 b5ad0000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5ad7000 b5ad8000 rwxp /usr/lib/libgpg-error.so.0.15.0
b5ad9000 b5c81000 r-xp /usr/lib/libcrypto.so.1.0.0
b5c81000 b5c96000 rwxp /usr/lib/libcrypto.so.1.0.0
b5c9a000 b5ce7000 r-xp /usr/lib/libssl.so.1.0.0
b5cee000 b5cf3000 rwxp /usr/lib/libssl.so.1.0.0
b5cf3000 b5d21000 r-xp /usr/lib/libidn.so.11.5.44
b5d28000 b5d29000 rwxp /usr/lib/libidn.so.11.5.44
b5d29000 b5d32000 r-xp /usr/lib/libcares.so.2.1.0
b5d3a000 b5d3b000 rwxp /usr/lib/libcares.so.2.1.0
b5d3b000 b5d3d000 r-xp /usr/lib/libXau.so.6.0.0
b5d44000 b5d45000 rwxp /usr/lib/libXau.so.6.0.0
b5d46000 b5d48000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5d4f000 b5d50000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b5d50000 b5d52000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5d5a000 b5d5b000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b5d5b000 b5dd7000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5dde000 b5de3000 rwxp /usr/lib/libgcrypt.so.20.0.3
b5de3000 b5dfb000 r-xp /usr/lib/liblzma.so.5.0.3
b5e02000 b5e03000 rwxp /usr/lib/liblzma.so.5.0.3
b5e04000 b5e0a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b5e12000 b5e13000 rwxp /usr/lib/libcapi-base-common.so.0.1.8
b5e13000 b5e23000 r-xp /lib/libresolv-2.13.so
b5e23000 b5e24000 r-xp /lib/libresolv-2.13.so
b5e24000 b5e25000 rwxp /lib/libresolv-2.13.so
b5e27000 b5e29000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5e30000 b5e31000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b5e31000 b5e36000 r-xp /usr/lib/libffi.so.5.0.10
b5e3d000 b5e3e000 rwxp /usr/lib/libffi.so.5.0.10
b5e3e000 b5e3f000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5e46000 b5e47000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b5e48000 b5e8c000 r-xp /usr/lib/libcurl.so.4.3.0
b5e93000 b5e95000 rwxp /usr/lib/libcurl.so.4.3.0
b5e95000 b5e98000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b5e9f000 b5ea0000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
b5ea0000 b5ea4000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b5eac000 b5ead000 rwxp /usr/lib/libecore_ipc.so.1.7.99
b5ead000 b5eb2000 r-xp /usr/lib/libecore_fb.so.1.7.99
b5eb9000 b5ebb000 rwxp /usr/lib/libecore_fb.so.1.7.99
b5ebc000 b5edf000 r-xp /usr/lib/libjpeg.so.8.0.2
b5ee6000 b5ee7000 rwxp /usr/lib/libjpeg.so.8.0.2
b5ef7000 b5f0d000 r-xp /lib/libexpat.so.1.5.2
b5f15000 b5f17000 rwxp /lib/libexpat.so.1.5.2
b5f17000 b5f2a000 r-xp /usr/lib/libxcb.so.1.1.0
b5f32000 b5f33000 rwxp /usr/lib/libxcb.so.1.1.0
b5f33000 b5f39000 r-xp /usr/lib/libxcb-render.so.0.0.0
b5f40000 b5f41000 rwxp /usr/lib/libxcb-render.so.0.0.0
b5f41000 b5f42000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b5f4a000 b5f4b000 rwxp /usr/lib/libxcb-shm.so.0.0.0
b5f4c000 b5f64000 r-xp /usr/lib/libpng12.so.0.50.0
b5f6b000 b5f6c000 rwxp /usr/lib/libpng12.so.0.50.0
b5f6c000 b5f6f000 r-xp /usr/lib/libEGL.so.1.4
b5f76000 b5f77000 rwxp /usr/lib/libEGL.so.1.4
b5f77000 b5f85000 r-xp /usr/lib/libGLESv2.so.2.0
b5f8d000 b5f8e000 rwxp /usr/lib/libGLESv2.so.2.0
b5f8e000 b5f8f000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5f96000 b5f97000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
b5f97000 b5fae000 r-xp /usr/lib/liblua-5.1.so
b5fb6000 b5fb7000 rwxp /usr/lib/liblua-5.1.so
b5fb8000 b5fbf000 r-xp /usr/lib/libembryo.so.1.7.99
b5fc6000 b5fc7000 rwxp /usr/lib/libembryo.so.1.7.99
b5fc7000 b5fd1000 r-xp /usr/lib/libXext.so.6.4.0
b5fd9000 b5fda000 rwxp /usr/lib/libXext.so.6.4.0
b5fda000 b5fdd000 r-xp /usr/lib/libXtst.so.6.1.0
b5fe5000 b5fe6000 rwxp /usr/lib/libXtst.so.6.1.0
b5fe6000 b5fec000 r-xp /usr/lib/libXrender.so.1.3.0
b5ff3000 b5ff4000 rwxp /usr/lib/libXrender.so.1.3.0
b5ff4000 b5ffa000 r-xp /usr/lib/libXrandr.so.2.2.0
b6001000 b6002000 rwxp /usr/lib/libXrandr.so.2.2.0
b6002000 b6003000 r-xp /usr/lib/libXinerama.so.1.0.0
b600b000 b600c000 rwxp /usr/lib/libXinerama.so.1.0.0
b600d000 b6010000 r-xp /usr/lib/libXfixes.so.3.1.0
b6017000 b6018000 rwxp /usr/lib/libXfixes.so.3.1.0
b6018000 b601a000 r-xp /usr/lib/libXgesture.so.7.0.0
b6021000 b6022000 rwxp /usr/lib/libXgesture.so.7.0.0
b6022000 b6024000 r-xp /usr/lib/libXcomposite.so.1.0.0
b602b000 b602c000 rwxp /usr/lib/libXcomposite.so.1.0.0
b602c000 b602e000 r-xp /usr/lib/libXdamage.so.1.1.0
b6035000 b6036000 rwxp /usr/lib/libXdamage.so.1.1.0
b6036000 b603d000 r-xp /usr/lib/libXcursor.so.1.0.2
b6044000 b6045000 rwxp /usr/lib/libXcursor.so.1.0.2
b6046000 b605c000 r-xp /lib/libz.so.1.2.5
b6063000 b6064000 rwxp /lib/libz.so.1.2.5
b6064000 b606a000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6071000 b6072000 rwxp /usr/lib/libecore_imf.so.1.7.99
b6072000 b6075000 r-xp /usr/lib/libsmack.so.1.0.0
b607c000 b607d000 rwxp /usr/lib/libsmack.so.1.0.0
b607d000 b6083000 r-xp /usr/lib/libappsvc.so.0.1.0
b608a000 b608b000 rwxp /usr/lib/libappsvc.so.0.1.0
b608b000 b6100000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6107000 b610a000 rwxp /usr/lib/libsqlite3.so.0.8.6
b610b000 b6120000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6127000 b6128000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b6128000 b612b000 r-xp /usr/lib/libproc-stat.so.0.2.86
b6132000 b6133000 rwxp /usr/lib/libproc-stat.so.0.2.86
b6133000 b616f000 r-xp /usr/lib/libsystemd.so.0.4.0
b6176000 b6177000 r-xp /usr/lib/libsystemd.so.0.4.0
b6177000 b6178000 rwxp /usr/lib/libsystemd.so.0.4.0
b6178000 b617d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6184000 b6185000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6185000 b619c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b61a3000 b61a4000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b61a5000 b61a8000 r-xp /usr/lib/libbundle.so.0.1.22
b61af000 b61b0000 rwxp /usr/lib/libbundle.so.0.1.22
b61b0000 b61b8000 r-xp /usr/lib/libsap_client.so.0.0.0
b61bf000 b61c0000 rwxp /usr/lib/libsap_client.so.0.0.0
b61c0000 b61f4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b61fb000 b61fd000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b61fd000 b62d0000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b62d7000 b62db000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b62db000 b63ab000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b63ab000 b63ac000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b63ad000 b6403000 r-xp /usr/lib/libpixman-1.so.0.28.2
b640b000 b6410000 rwxp /usr/lib/libpixman-1.so.0.28.2
b6410000 b6466000 r-xp /usr/lib/libfreetype.so.6.11.3
b646e000 b6472000 rwxp /usr/lib/libfreetype.so.6.11.3
b6472000 b64af000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b64b6000 b64b7000 rwxp /usr/lib/libharfbuzz.so.0.940.0
b64b8000 b64cb000 r-xp /usr/lib/libfribidi.so.0.3.1
b64d2000 b64d3000 rwxp /usr/lib/libfribidi.so.0.3.1
b64d3000 b64ed000 r-xp /usr/lib/libecore_con.so.1.7.99
b64f4000 b64f5000 rwxp /usr/lib/libecore_con.so.1.7.99
b64f7000 b6521000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6529000 b652a000 rwxp /usr/lib/libdbus-1.so.3.8.12
b652a000 b6533000 r-xp /usr/lib/libedbus.so.1.7.99
b653a000 b653b000 rwxp /usr/lib/libedbus.so.1.7.99
b653b000 b653f000 r-xp /usr/lib/libvconf.so.0.2.45
b6546000 b6547000 rwxp /usr/lib/libvconf.so.0.2.45
b6547000 b6558000 r-xp /usr/lib/libecore_input.so.1.7.99
b655f000 b6560000 rwxp /usr/lib/libecore_input.so.1.7.99
b6560000 b6565000 r-xp /usr/lib/libecore_file.so.1.7.99
b656c000 b656d000 rwxp /usr/lib/libecore_file.so.1.7.99
b656d000 b658f000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6596000 b6598000 rwxp /usr/lib/libecore_evas.so.1.7.99
b6599000 b65b2000 r-xp /usr/lib/libeet.so.1.7.99
b65ba000 b65bb000 rwxp /usr/lib/libeet.so.1.7.99
b65c3000 b65c9000 r-xp /lib/librt-2.13.so
b65d0000 b65d1000 r-xp /lib/librt-2.13.so
b65d1000 b65d2000 rwxp /lib/librt-2.13.so
b65d2000 b65fa000 r-xp /usr/lib/libfontconfig.so.1.8.0
b65fa000 b65fb000 rwxp /usr/lib/libfontconfig.so.1.8.0
b65fb000 b6604000 r-xp /usr/lib/libXi.so.6.1.0
b660b000 b660c000 rwxp /usr/lib/libXi.so.6.1.0
b660c000 b66ed000 r-xp /usr/lib/libX11.so.6.3.0
b66f4000 b66f8000 rwxp /usr/lib/libX11.so.6.3.0
b66f9000 b67b1000 r-xp /usr/lib/libcairo.so.2.11200.14
b67b8000 b67bb000 rwxp /usr/lib/libcairo.so.2.11200.14
b67bc000 b6819000 r-xp /usr/lib/libedje.so.1.7.99
b6821000 b6823000 rwxp /usr/lib/libedje.so.1.7.99
b6823000 b683a000 r-xp /usr/lib/libecore.so.1.7.99
b6842000 b6843000 rwxp /usr/lib/libecore.so.1.7.99
b6851000 b68a1000 r-xp /usr/lib/libecore_x.so.1.7.99
b68a1000 b68a3000 rwxp /usr/lib/libecore_x.so.1.7.99
b68a3000 b696f000 r-xp /usr/lib/libxml2.so.2.7.8
b6976000 b697b000 rwxp /usr/lib/libxml2.so.2.7.8
b697c000 b697e000 r-xp /usr/lib/libiniparser.so.0
b6986000 b6987000 rwxp /usr/lib/libiniparser.so.0
b6987000 b698c000 r-xp /usr/lib/libappcore-common.so.1.1
b6993000 b6994000 rwxp /usr/lib/libappcore-common.so.1.1
b6994000 b6999000 r-xp /usr/lib/libappcore-efl.so.1.1
b69a0000 b69a1000 rwxp /usr/lib/libappcore-efl.so.1.1
b69a1000 b69a6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b69ad000 b69ae000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b69ae000 b69c2000 r-xp /lib/libpthread-2.13.so
b69c9000 b69ca000 r-xp /lib/libpthread-2.13.so
b69ca000 b69cb000 rwxp /lib/libpthread-2.13.so
b69cd000 b69ef000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b69f6000 b69f7000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b69f7000 b6a03000 r-xp /usr/lib/libaul.so.0.1.0
b6a0b000 b6a0c000 rwxp /usr/lib/libaul.so.0.1.0
b6a0d000 b6a15000 r-xp /lib/libgcc_s-4.6.so.1
b6a15000 b6a16000 rwxp /lib/libgcc_s-4.6.so.1
b6a16000 b6a18000 r-xp /lib/libdl-2.13.so
b6a1f000 b6a20000 r-xp /lib/libdl-2.13.so
b6a20000 b6a21000 rwxp /lib/libdl-2.13.so
b6a21000 b6a2c000 r-xp /lib/libunwind.so.8.0.1
b6a33000 b6a34000 rwxp /lib/libunwind.so.8.0.1
b6a59000 b6b74000 r-xp /lib/libc-2.13.so
b6b7c000 b6b7e000 r-xp /lib/libc-2.13.so
b6b7e000 b6b7f000 rwxp /lib/libc-2.13.so
b6b82000 b6beb000 r-xp /lib/libm-2.13.so
b6bf2000 b6bf3000 r-xp /lib/libm-2.13.so
b6bf3000 b6bf4000 rwxp /lib/libm-2.13.so
b6bf4000 b6c01000 r-xp /usr/lib/libsap-client-stub-api.so.1.0.0
b6c08000 b6c09000 rwxp /usr/lib/libsap-client-stub-api.so.1.0.0
b6c09000 b6c1b000 r-xp /usr/lib/libtts.so
b6c22000 b6c23000 rwxp /usr/lib/libtts.so
b6c23000 b6cf2000 r-xp /usr/lib/libevas.so.1.7.99
b6cf9000 b6d03000 rwxp /usr/lib/libevas.so.1.7.99
b6d16000 b6e50000 r-xp /usr/lib/libelementary.so.1.7.99
b6e57000 b6e5f000 rwxp /usr/lib/libelementary.so.1.7.99
b6e66000 b6ea7000 r-xp /usr/lib/libeina.so.1.7.99
b6eae000 b6eb0000 rwxp /usr/lib/libeina.so.1.7.99
b6eb0000 b6ed1000 r-xp /usr/lib/libefl-extension.so.0.1.0
b6ed8000 b6ed9000 rwxp /usr/lib/libefl-extension.so.0.1.0
b6ed9000 b6edb000 r-xp /usr/lib/libdlog.so.0.0.0
b6ee2000 b6ee3000 rwxp /usr/lib/libdlog.so.0.0.0
b6ee3000 b6ee8000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6eef000 b6ef0000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
b6ef0000 b6ef4000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b6efb000 b6efc000 rwxp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b6efc000 b6efe000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6f06000 b6f07000 rwxp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6f07000 b6f09000 r-xs /dev/kgsl-3d0
b6f09000 b6f14000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b6f1c000 b6f1d000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b6f1d000 b6f21000 r-xp /usr/lib/libsys-assert.so
b6f29000 b6f2a000 rwxp /usr/lib/libsys-assert.so
b6f2a000 b6f47000 r-xp /lib/ld-2.13.so
b6f4e000 b6f4f000 r-xp /lib/ld-2.13.so
b6f4f000 b6f50000 rwxp /lib/ld-2.13.so
b6f50000 b6f56000 r-xp /opt/usr/apps/org.example.hap/bin/hap
b6f5e000 b6f5f000 rwxp /opt/usr/apps/org.example.hap/bin/hap
b7c96000 b8005000 rwxp [heap]
be873000 be894000 rwxp [stack]
b7c96000 b8005000 rwxp [heap]
be873000 be894000 rwxp [stack]
End of Maps Information

Callstack Information (PID:2869)
Call Stack Count: 1
 0: strlen + 0x4 (0xb6acbdc4) [/lib/libc.so.6] + 0x72dc4
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
evas_events.c:1275 evas_event_feed_mouse_up() ButtonEvent:up time=782124 button=1 downs=0
05-29 23:30:38.169+0900 I/APP_CORE( 2538): appcore-efl.c: __do_app(429) > [APP 2538] Event: RESUME State: RUNNING
05-29 23:30:38.189+0900 I/APP_CORE( 1177): appcore-efl.c: __do_app(429) > [APP 1177] Event: PAUSE State: RUNNING
05-29 23:30:38.189+0900 I/CAPI_APPFW_APPLICATION( 1177): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 23:30:38.189+0900 W/W_HOME  ( 1177): main.c: _appcore_pause_cb(692) > appcore pause
05-29 23:30:38.189+0900 W/W_HOME  ( 1177): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-29 23:30:38.189+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:30:38.189+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:30:38.189+0900 W/W_HOME  ( 1177): main.c: home_pause(762) > clock/widget paused
05-29 23:30:38.189+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:30:38.189+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 23:30:38.189+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 23:30:38.199+0900 I/MESSAGE_PORT(  866): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 23:30:38.199+0900 I/MESSAGE_PORT(  866): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-29 23:30:38.199+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-29 23:30:38.199+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 23:30:38.199+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-29 23:30:38.199+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 23:30:38.199+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-29 23:30:38.199+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-29 23:30:38.199+0900 I/MESSAGE_PORT(  866): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-29 23:30:38.199+0900 I/MESSAGE_PORT(  866): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-29 23:30:38.199+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-29 23:30:38.199+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-29 23:30:38.199+0900 I/MESSAGE_PORT(  866): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-29 23:30:38.199+0900 I/MESSAGE_PORT(  866): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-29 23:30:38.199+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-29 23:30:38.199+0900 I/MESSAGE_PORT(  866): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-29 23:30:38.209+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:30:38.209+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:30:38.319+0900 E/WIDGET_VIEWER( 2538): client.c: make_direct_connection(2077) > [SECURE_LOG] Failed to create a connection
05-29 23:30:38.339+0900 E/WIDGET_VIEWER( 2538): widget.c: widget_viewer_has_glance_bar(1900) > [SECURE_LOG] Handler is not valid
05-29 23:30:38.409+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:30:38.409+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:30:38.559+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 0
05-29 23:30:38.569+0900 I/AUL_AMD (  957): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 23:30:38.589+0900 I/AUL_AMD (  957): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-29 23:30:38.589+0900 E/AUL_AMD (  957): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
05-29 23:30:38.589+0900 W/AUL_AMD (  957): amd_launch.c: _start_app(1659) > caller pid : 1140
05-29 23:30:38.599+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:30:38.599+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:30:38.619+0900 I/wnotib  ( 1177): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-29 23:30:38.619+0900 E/wnotib  ( 1177): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 23:30:38.649+0900 E/RESOURCED(  958): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.hap, table num : 1
05-29 23:30:38.649+0900 E/RESOURCED(  958): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 23:30:38.659+0900 W/AUL_AMD (  957): amd_launch.c: _start_app(2026) > pad pid(-5)
05-29 23:30:38.659+0900 W/AUL_PAD ( 1674): launchpad.c: __launchpad_main_loop(526) > Candidate is not prepared, enter legacy logic
05-29 23:30:38.659+0900 W/AUL_PAD ( 1674): launchpad.c: __send_result_to_caller(265) > Check app launching
05-29 23:30:38.659+0900 W/AUL_AMD (  957): amd_launch.c: _start_app(2037) > Launch with legacy way : no launchpad
05-29 23:30:38.659+0900 W/AUL_AMD (  957): amd_launch.c: start_process(573) > child process: 2869
05-29 23:30:38.659+0900 E/CAPI_APPFW_APP_CONTROL( 1615): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-29 23:30:38.659+0900 W/MUSIC_CONTROL_SERVICE( 1615): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1615]   value = [false][0m
05-29 23:30:38.709+0900 W/AUL_AMD (  957): amd_launch.c: __send_app_launch_signal(376) > send launch signal done: 2869
05-29 23:30:38.719+0900 E/SHealth_Common( 1563): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-29 23:30:38.719+0900 I/APP_CORE( 1177): appcore-efl.c: __do_app(429) > [APP 1177] Event: MEM_FLUSH State: PAUSED
05-29 23:30:38.729+0900 E/RESOURCED(  958): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.hap
05-29 23:30:38.729+0900 W/WATCH_CORE( 1755): appcore-watch.c: __widget_pause(1001) > widget_pause
05-29 23:30:38.729+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppPause(717) > 
05-29 23:30:38.729+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:30:38.729+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:30:38.729+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:30:38.729+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:30:38.729+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:30:38.729+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:30:38.729+0900 W/WATCH_CORE( 1755): appcore-watch.c: __widget_resume(1012) > widget_resume
05-29 23:30:38.739+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppResume(725) > 
05-29 23:30:38.739+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:30:38.739+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:30:38.839+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 23:30:38.859+0900 W/AUL_AMD (  957): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2538
05-29 23:30:38.859+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 12
05-29 23:30:38.859+0900 I/efl-extension( 2869): efl_extension.c: eext_mod_init(40) > Init
05-29 23:30:38.889+0900 I/CAPI_APPFW_APPLICATION( 2869): app_main.c: ui_app_main(704) > app_efl_main
05-29 23:30:38.909+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:30:38.909+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:30:38.909+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 23:30:38.929+0900 W/AUL_AMD (  957): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2869
05-29 23:30:38.929+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 12
05-29 23:30:39.079+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:30:39.079+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:30:39.199+0900 I/CAPI_APPFW_APPLICATION( 2869): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-29 23:30:39.259+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:30:39.259+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:30:39.309+0900 I/Adreno-EGL( 2869): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
05-29 23:30:39.309+0900 I/Adreno-EGL( 2869): OpenGL ES Shader Compiler Version: E031.24.00.16
05-29 23:30:39.309+0900 I/Adreno-EGL( 2869): Build Date: 09/02/15 Wed
05-29 23:30:39.309+0900 I/Adreno-EGL( 2869): Local Branch: 
05-29 23:30:39.309+0900 I/Adreno-EGL( 2869): Remote Branch: 
05-29 23:30:39.309+0900 I/Adreno-EGL( 2869): Local Patches: 
05-29 23:30:39.309+0900 I/Adreno-EGL( 2869): Reconstruct Branch: 
05-29 23:30:39.419+0900 I/AUL_PAD ( 2860): launchpad_loader.c: main(600) > [candidate] elm init, returned: 1
05-29 23:30:39.449+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:30:39.449+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:30:39.539+0900 E/E17     (  628): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05a00003)
05-29 23:30:39.629+0900 E/EFL     ( 2869): ecore_evas<2869> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-29 23:30:39.639+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:30:39.639+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:30:39.689+0900 I/efl-extension( 2869): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0xb7f89580]'s widget[0xb7f60680] to elm_conformant widget[0xb7ed11a8]
05-29 23:30:39.709+0900 W/AUL_AMD (  957): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 23:30:39.709+0900 W/AUL_AMD (  957): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
05-29 23:30:39.829+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:30:39.829+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:30:39.859+0900 I/HAP     ( 2869): SUCCESSFULLY create sap agent
05-29 23:30:39.859+0900 I/HAP     ( 2869): connectivity type(1): bt
05-29 23:30:40.019+0900 I/HAP     ( 2869): agent is initialized
05-29 23:30:40.019+0900 I/HAP     ( 2869): agent initialized callback is over
05-29 23:30:40.019+0900 I/HAP     ( 2869): SAP >>> getRegisteredServiceAgent() >>> 0
05-29 23:30:40.019+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:30:40.019+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:30:40.129+0900 I/APP_CORE( 2869): appcore-efl.c: __do_app(429) > [APP 2869] Event: RESET State: CREATED
05-29 23:30:40.129+0900 I/CAPI_APPFW_APPLICATION( 2869): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-29 23:30:40.159+0900 I/APP_CORE( 2869): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 23:30:40.159+0900 I/APP_CORE( 2869): appcore-efl.c: __do_app(474) > [APP 2869] Initial Launching, call the resume_cb
05-29 23:30:40.159+0900 I/CAPI_APPFW_APPLICATION( 2869): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 23:30:40.159+0900 W/APP_CORE( 2869): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5a00003
05-29 23:30:40.179+0900 I/efl-extension( 2869): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0xb7f89580 = w: 0 h: 0  obj 0xb7f60680 w: 360 h: 360
05-29 23:30:40.179+0900 I/efl-extension( 2869): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 23:30:40.219+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:30:40.219+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:30:40.299+0900 I/APP_CORE( 2538): appcore-efl.c: __do_app(429) > [APP 2538] Event: PAUSE State: RUNNING
05-29 23:30:40.299+0900 I/CAPI_APPFW_APPLICATION( 2538): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 23:30:40.309+0900 W/WATCH_CORE( 1755): appcore-watch.c: __widget_pause(1001) > widget_pause
05-29 23:30:40.309+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppPause(717) > 
05-29 23:30:40.309+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:30:40.309+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:30:40.309+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:30:40.309+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:30:40.309+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:30:40.309+0900 E/watchface-viewer( 1755): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
05-29 23:30:40.319+0900 W/AUL_AMD (  957): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 23:30:40.319+0900 W/AUL_AMD (  957): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
05-29 23:30:40.319+0900 I/APP_CORE( 2869): appcore-efl.c: __do_app(429) > [APP 2869] Event: RESUME State: RUNNING
05-29 23:30:40.669+0900 I/TIZEN_N_SOUND_MANAGER( 2878): sound_manager.c: sound_manager_set_session_type(155) > >> enter : type=0
05-29 23:30:40.789+0900 I/TIZEN_N_SOUND_MANAGER( 2878): sound_manager.c: sound_manager_set_session_type(220) > << leave : type=0, ret=0x0
05-29 23:30:40.789+0900 W/TIZEN_N_SOUND_MANAGER( 2878): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_set_session_type] ERROR_NONE (0x00000000)
05-29 23:30:40.789+0900 I/TIZEN_N_SOUND_MANAGER( 2878): sound_manager.c: sound_manager_set_media_session_option(279) > >> enter : option for starting=1, for during play=0
05-29 23:30:40.789+0900 I/TIZEN_N_SOUND_MANAGER( 2878): sound_manager.c: sound_manager_set_media_session_option(346) > << leave : updated
05-29 23:30:40.789+0900 W/TIZEN_N_SOUND_MANAGER( 2878): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_set_media_session_option] ERROR_NONE (0x00000000)
05-29 23:30:40.969+0900 I/TIZEN_N_AUDIO_IO( 2878): audio_io_private.c: audio_out_create_private(381) > mm_sound_pcm_play_open() success
05-29 23:30:40.969+0900 I/TIZEN_N_AUDIO_IO( 2878): audio_io_private.c: audio_out_create_private(395) > mm_sound_pcm_set_message_callback() success
05-29 23:30:40.969+0900 I/TIZEN_N_AUDIO_IO( 2878): audio_io.c: audio_out_set_interrupted_cb(473) > [audio_out_set_interrupted_cb] current interrupted cb (0xb6f0c08d) / data ((nil))
05-29 23:30:41.289+0900 I/RESOURCED(  958): swap.c: swap_send_signal(594) > [swap_send_signal,594] send signal to swap thread
05-29 23:30:42.349+0900 I/APP_CORE( 1139): appcore-efl.c: __do_app(429) > [APP 1139] Event: MEM_FLUSH State: PAUSED
05-29 23:30:43.229+0900 I/APP_CORE( 1177): appcore-efl.c: __do_app(429) > [APP 1177] Event: MEM_FLUSH State: PAUSED
05-29 23:30:43.739+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 23:30:43.769+0900 W/AUL_AMD (  957): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2869
05-29 23:30:45.809+0900 I/APP_CORE( 2538): appcore-efl.c: __do_app(429) > [APP 2538] Event: MEM_FLUSH State: PAUSED
05-29 23:30:47.779+0900 W/WG-CONSUMER( 2551): [34m[F:consumer-app.cpp L:  242][_HIGH]Checking consumer's state.[0m
05-29 23:30:47.779+0900 W/WG-CONSUMER( 2551): [34m[F:SAPProxy.cpp     L:  323][_HIGH]Device Connected. Cur type=BT|[0m
05-29 23:30:47.779+0900 W/WG-CONSUMER( 2551): [34m[F:SAPProxy.cpp     L:  168][_HIGH]Device connected. WMS=1 BT=1 [0m
05-29 23:30:47.779+0900 W/WG-CONSUMER( 2551): [34m[F:consumer-app.cpp L:  251][_HIGH]Transfer can be exit[0m
05-29 23:30:47.779+0900 W/WG-CONSUMER( 2551): [34m[F:SAPProxy.cpp     L:  323][_HIGH]Device Connected. Cur type=BT|[0m
05-29 23:30:47.779+0900 W/WG-CONSUMER( 2551): [34m[F:SAPProxy.cpp     L:  168][_HIGH]Device connected. WMS=1 BT=1 [0m
05-29 23:30:47.779+0900 W/WG-CONSUMER( 2551): [34m[F:consumer-app.cpp L:  256][_HIGH]Receiver can be exit[0m
05-29 23:30:47.779+0900 W/WG-CONSUMER( 2551): [34m[F:consumer-app.cpp L:  259][_HIGH]Exit Condition. Tx=1 Rx=1[0m
05-29 23:30:47.779+0900 I/CAPI_APPFW_APPLICATION( 2551): service_app_main.c: service_app_exit(441) > service_app_exit
05-29 23:30:47.779+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 22
05-29 23:30:47.779+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(884) > app status : 4
05-29 23:30:47.779+0900 W/WG-CONSUMER( 2551): [34m[F:consumer-app.cpp L:  127][_HIGH]Gallery consumer SVC is terminated[0m
05-29 23:30:47.779+0900 W/WG-CONSUMER( 2551): [34m[F:TransferCtrl.cpp L:  125][_HIGH][TX]Disconnect to Peer[0m
05-29 23:30:47.779+0900 W/WG-CONSUMER( 2551): [34m[F:ConnectionInfo.c L:  154][_HIGH][TX]CConnection::Disconnect()[0m
05-29 23:30:47.779+0900 W/WG-CONSUMER( 2551): [34m[F:ConnectionInfo.c L:  635][_HIGH][TX]SAPManager(0xb890a878) Disconnect(155)[0m
05-29 23:30:47.789+0900 W/WG-CONSUMER( 2551): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_REGISTER_AGENT LocalAgentID=6255 ServiceHandle=0 ChannelID=4444[0m
05-29 23:30:47.789+0900 W/WG-CONSUMER( 2551): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
05-29 23:30:47.789+0900 W/WG-CONSUMER( 2551): [34m[F:ConnectionInfo.c L:  173][_HIGH]Deregister service agent. nAgentID_(6255)[0m
05-29 23:30:47.839+0900 W/WG-CONSUMER( 2551): [32m[F:SAPProxy.cpp     L:  485][_WARN]De-Register agent Confirmed. wStatusCode:[0], uwLocalAgentId : [6255][0m
05-29 23:30:47.839+0900 W/WG-CONSUMER( 2551): [32m[F:ConnectionInfo.c L:  789][_WARN][TX]De-Register agent Confirmed. wStatusCode:[0], uwLocalAgentId:[6255][0m
05-29 23:30:47.839+0900 W/WG-CONSUMER( 2551): [34m[F:PeerList.cpp     L:  171][_HIGH][TX]Clear PeerList. Count=0 pConnected=(nil)[0m
05-29 23:30:47.839+0900 W/WG-CONSUMER( 2551): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_REGISTER_AGENT->SM_STATE_INITIATE[0m
05-29 23:30:47.869+0900 W/WG-CONSUMER( 2551): [34m[F:UserNotification L:  203][_HIGH]WIPC Service Delete[0m
05-29 23:30:47.869+0900 W/WG-CONSUMER( 2551): [34m[F:ReceiverCtrl.cpp L:  487][_HIGH][RX]Disconnect to Peer[0m
05-29 23:30:47.869+0900 W/WG-CONSUMER( 2551): [34m[F:ConnectionInfo.c L:  154][_HIGH][RX]CConnection::Disconnect()[0m
05-29 23:30:47.869+0900 W/WG-CONSUMER( 2551): [34m[F:ConnectionInfo.c L:  635][_HIGH][RX]SAPManager(0xb890b928) Disconnect(155)[0m
05-29 23:30:47.869+0900 W/WG-CONSUMER( 2551): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_REGISTER_AGENT LocalAgentID=6256 ServiceHandle=0 ChannelID=4444[0m
05-29 23:30:47.869+0900 W/WG-CONSUMER( 2551): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
05-29 23:30:47.869+0900 W/WG-CONSUMER( 2551): [34m[F:ConnectionInfo.c L:  173][_HIGH]Deregister service agent. nAgentID_(6256)[0m
05-29 23:30:47.909+0900 W/WG-CONSUMER( 2551): [32m[F:SAPProxy.cpp     L:  485][_WARN]De-Register agent Confirmed. wStatusCode:[0], uwLocalAgentId : [6256][0m
05-29 23:30:47.909+0900 W/WG-CONSUMER( 2551): [32m[F:ConnectionInfo.c L:  789][_WARN][RX]De-Register agent Confirmed. wStatusCode:[0], uwLocalAgentId:[6256][0m
05-29 23:30:47.909+0900 W/WG-CONSUMER( 2551): [34m[F:PeerList.cpp     L:  171][_HIGH][RX]Clear PeerList. Count=0 pConnected=(nil)[0m
05-29 23:30:47.909+0900 W/WG-CONSUMER( 2551): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_REGISTER_AGENT->SM_STATE_INITIATE[0m
05-29 23:30:47.909+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 2551): media_content.c: media_content_disconnect(948) > [32m[2551]ref count changed to: 0
05-29 23:30:48.029+0900 E/WG-CONSUMER( 2551): [31m[F:consumer-app.cpp L:  328][ERROR]Terminate main. nRet=0[0m
05-29 23:30:48.029+0900 W/WG-CONSUMER( 2551): [34m[F:ReceiverCtrl.cpp L:   72][_HIGH]CReceiverCtrl::~CReceiverCtrl()[0m
05-29 23:30:48.029+0900 W/WG-CONSUMER( 2551): [34m[F:PeerList.cpp     L:  163][_HIGH][RX]CPeerList::~CPeerList(0xb890b9d4)[0m
05-29 23:30:48.029+0900 W/WG-CONSUMER( 2551): [34m[F:TransferCtrl.cpp L:   87][_HIGH]CTransferCtrl::~CTransferCtrl()[0m
05-29 23:30:48.029+0900 W/WG-CONSUMER( 2551): [34m[F:AlarmSvc.cpp     L:   86][_HIGH]CAlarmSvc::~CAlarmSvc() hAlarm:0x00000000[0m
05-29 23:30:48.029+0900 W/WG-CONSUMER( 2551): [34m[F:PeerList.cpp     L:  163][_HIGH][TX]CPeerList::~CPeerList(0xb8909844)[0m
05-29 23:30:48.109+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 23
05-29 23:30:48.109+0900 W/AUL_AMD (  957): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
05-29 23:30:48.109+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(917) > pkg_status: installed, dead pid: 2551
05-29 23:30:48.109+0900 W/AUL_AMD (  957): amd_request.c: __send_app_termination_signal(507) > send dead signal done
05-29 23:30:48.109+0900 I/AUL_AMD (  957): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2551
05-29 23:30:48.779+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 23:30:48.799+0900 W/AUL_AMD (  957): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2869
05-29 23:30:49.799+0900 W/AUL_AMD (  957): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-29 23:30:51.749+0900 I/RESOURCED(  958): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 23:30:51.749+0900 I/RESOURCED(  958): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 23:30:52.199+0900 W/WATCH_CORE( 1755): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-29 23:30:52.219+0900 W/W_HOME  ( 1177): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-29 23:30:52.219+0900 W/W_HOME  ( 1177): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 23:30:52.219+0900 W/W_HOME  ( 1177): gesture.c: _manual_render_enable(133) > 1
05-29 23:30:52.219+0900 W/W_HOME  ( 1177): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-29 23:30:52.219+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:30:52.219+0900 W/STARTER ( 1138): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [timeout]
05-29 23:30:52.219+0900 W/STARTER ( 1138): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
05-29 23:30:52.219+0900 E/STARTER ( 1138): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-29 23:30:52.219+0900 W/STARTER ( 1138): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
05-29 23:30:52.219+0900 W/STARTER ( 1138): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
05-29 23:30:52.219+0900 I/SCONTEXT-LIB( 1134): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
05-29 23:30:52.239+0900 W/WAKEUP-SERVICE( 1607): WakeupService.cpp: OnReceiveDisplayChanged(932) > [0;32mINFO: LCDOff receive data : -1227130100[0;m
05-29 23:30:52.239+0900 W/WAKEUP-SERVICE( 1607): WakeupService.cpp: OnReceiveDisplayChanged(933) > [0;32mINFO: WakeupServiceStop[0;m
05-29 23:30:52.239+0900 W/WAKEUP-SERVICE( 1607): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-29 23:30:52.239+0900 I/TIZEN_N_SOUND_MANAGER( 1607): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
05-29 23:30:52.259+0900 I/TIZEN_N_SOUND_MANAGER( 1607): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-29 23:30:52.259+0900 W/TIZEN_N_SOUND_MANAGER( 1607): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-29 23:30:52.259+0900 W/WAKEUP-SERVICE( 1607): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
05-29 23:30:52.259+0900 I/HIGEAR  ( 1607): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
05-29 23:30:52.509+0900 I/SHealth_Common( 1563): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-29 23:30:52.509+0900 I/SHealth_Service( 1563): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
05-29 23:30:52.509+0900 W/MUSIC_CONTROL_SERVICE( 1615): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1615]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-29 23:30:52.519+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 0
05-29 23:30:52.529+0900 E/AUL_AMD (  957): amd_request.c: __request_handler(649) > launch request has been denied by smack
05-29 23:30:52.529+0900 E/CAPI_APPFW_APP_CONTROL( 1141): app_control.c: app_control_error(140) > [app_control_send_launch_request] UNKNOWN(0xfffffff3)
05-29 23:30:52.529+0900 E/MEDIA_SERVER( 1141): media-server-main.c: _ms_vp_vconf_cb(290) > LAUNCH VP_CHAPTER_SVC
05-29 23:30:52.559+0900 W/STARTER ( 1138): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
05-29 23:30:52.559+0900 W/STARTER ( 1138): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
05-29 23:30:52.559+0900 W/STARTER ( 1138): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
05-29 23:30:52.559+0900 W/STARTER ( 1138): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[0]
05-29 23:30:52.569+0900 I/APP_CORE( 2869): appcore-efl.c: __do_app(429) > [APP 2869] Event: PAUSE State: RUNNING
05-29 23:30:52.569+0900 I/CAPI_APPFW_APPLICATION( 2869): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 23:30:52.629+0900 W/ALARM_MANAGER( 1138): alarm-lib.c: alarmmgr_add_alarm_withcb(1160) > trigger_at_time(20), start(29-5-2016, 23:31:13), repeat(1), interval(20), type(-1073741822)
05-29 23:30:52.729+0900 W/ALARM_MANAGER(  952): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 52833890, next duetime: 1464532273
05-29 23:30:52.729+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(52833890)
05-29 23:30:52.729+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1464534000), due_time(1464532273)
05-29 23:30:52.729+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 23:30:52.729+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 29-5-2016, 14:31:13 (UTC).
05-29 23:30:52.729+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 23:30:53.759+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 23:30:53.779+0900 W/AUL_AMD (  957): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2869
05-29 23:30:57.740+0900 I/APP_CORE( 2869): appcore-efl.c: __do_app(429) > [APP 2869] Event: MEM_FLUSH State: PAUSED
05-29 23:30:58.840+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 23:30:58.860+0900 W/AUL_AMD (  957): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2869
05-29 23:30:59.829+0900 I/HAP     ( 2869): Updating UI with data Connection Established
05-29 23:31:00.289+0900 I/RESOURCED(  958): vmpressure-lowmem-handler.c: change_lowmem_state(1093) > [change_lowmem_state,1093] [LOW MEM STATE] mem swap ==> mem normal
05-29 23:31:00.289+0900 I/RESOURCED(  958): vmpressure-lowmem-handler.c: adjust_dynamic_threshold(321) > [adjust_dynamic_threshold,321] dynamic_threshold is changed from 50 to 50, cur_mem_state = mem normal, victim_memcg = 5
05-29 23:31:00.329+0900 W/WATCH_CORE( 1755): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 1, state: 3
05-29 23:31:00.329+0900 I/WATCH_CORE( 1755): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-29 23:31:00.329+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:31:00.329+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:31:00.329+0900 I/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(756) > set force update!!
05-29 23:31:00.339+0900 W/W_HOME  ( 1177): dbus.c: _dbus_message_recv_cb(173) > gesture:movement
05-29 23:31:00.339+0900 W/W_HOME  ( 1177): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-29 23:31:00.359+0900 W/WATCH_CORE( 1755): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
05-29 23:31:00.359+0900 I/WATCH_CORE( 1755): appcore-watch.c: __signal_lcd_status_handler(1149) > Call the time_tick_cb
05-29 23:31:00.359+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:31:00.359+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:31:00.359+0900 I/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(756) > set force update!!
05-29 23:31:00.369+0900 W/W_HOME  ( 1177): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-29 23:31:00.369+0900 W/W_HOME  ( 1177): gesture.c: _manual_render_disable_timer_set(161) > timer set
05-29 23:31:00.369+0900 W/W_HOME  ( 1177): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 23:31:00.369+0900 W/W_HOME  ( 1177): gesture.c: _apps_status_get(123) > apps status:0
05-29 23:31:00.369+0900 W/W_HOME  ( 1177): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:0 info->offtime:8164
05-29 23:31:00.369+0900 W/W_HOME  ( 1177): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-29 23:31:00.369+0900 W/W_HOME  ( 1177): event_manager.c: _lcd_on_cb(691) > lcd state: 1
05-29 23:31:00.369+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:31:00.369+0900 I/SCONTEXT-LIB( 1134): scontext.c: context_add_changed_cb(211) > [SUCCESS] Set Changed CB: 42 (req_id=15)
05-29 23:31:00.379+0900 W/STARTER ( 1138): clock-mgr.c: _on_lcd_signal_receive_cb(1519) > [_on_lcd_signal_receive_cb:1519] _on_lcd_signal_receive_cb, 1519, Pre LCD on by [gesture] after screen off time [8164]ms
05-29 23:31:00.379+0900 W/STARTER ( 1138): clock-mgr.c: _pre_lcd_on(1245) > [_pre_lcd_on:1245] Will LCD ON as reserved app[(null)] alpm mode[0]
05-29 23:31:00.389+0900 W/W_HOME  ( 1177): gesture.c: _widget_updated_cb(190) > widget updated
05-29 23:31:00.389+0900 W/W_HOME  ( 1177): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 23:31:00.389+0900 W/W_HOME  ( 1177): gesture.c: _manual_render(176) > 
05-29 23:31:00.409+0900 I/APP_CORE( 2869): appcore-efl.c: __do_app(429) > [APP 2869] Event: RESUME State: PAUSED
05-29 23:31:00.409+0900 I/CAPI_APPFW_APPLICATION( 2869): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 23:31:00.449+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __alarm_remove_from_list(454) > [alarm-server]:Remove alarm id(52833890)
05-29 23:31:00.449+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 23:31:00.449+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 29-5-2016, 15:00:00 (UTC).
05-29 23:31:00.449+0900 W/ALARM_MANAGER(  952): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 23:31:00.449+0900 W/ALARM_MANAGER(  952): alarm-manager.c: alarm_manager_alarm_delete(2219) > alarm_id[52833890] is removed.
05-29 23:31:00.459+0900 W/WAKEUP-SERVICE( 1607): WakeupService.cpp: OnReceiveDisplayChanged(923) > [0;32mINFO: LCDOn receive data : -1227130100[0;m
05-29 23:31:00.459+0900 W/WAKEUP-SERVICE( 1607): WakeupService.cpp: OnReceiveDisplayChanged(924) > [0;32mINFO: WakeupServiceStart[0;m
05-29 23:31:00.459+0900 W/WAKEUP-SERVICE( 1607): WakeupService.cpp: WakeupServiceStart(357) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-29 23:31:00.469+0900 W/W_HOME  ( 1177): gesture.c: _manual_render(176) > 
05-29 23:31:00.489+0900 W/W_INDICATOR( 1139): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(265) > [_windicator_dbus_lcd_changed_cb:265] Show Moment View cause of LCD ON
05-29 23:31:00.489+0900 E/W_INDICATOR( 1139): windicator_moment_view.c: windicator_moment_view_show(555) > [windicator_moment_view_show:555] Show Moment View : dynamic_layout(0xb77ced00), type(1)
05-29 23:31:00.509+0900 W/W_HOME  ( 1177): gesture.c: _manual_render_enable(133) > 0
05-29 23:31:00.639+0900 W/STARTER ( 1138): clock-mgr.c: _on_lcd_signal_receive_cb(1530) > [_on_lcd_signal_receive_cb:1530] _on_lcd_signal_receive_cb, 1530, Post LCD on by [gesture]
05-29 23:31:00.639+0900 W/STARTER ( 1138): clock-mgr.c: _post_lcd_on(1291) > [_post_lcd_on:1291] LCD ON as reserved app[(null)] alpm mode[0]
05-29 23:31:00.649+0900 E/E17     (  628): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x01a00011)
05-29 23:31:00.709+0900 W/APP_CORE( 1139): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1a00011
05-29 23:31:00.749+0900 I/APP_CORE( 1139): appcore-efl.c: __do_app(429) > [APP 1139] Event: RESUME State: PAUSED
05-29 23:31:00.749+0900 I/CAPI_APPFW_APPLICATION( 1139): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-29 23:31:00.749+0900 I/SHealth_Common( 1563): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
05-29 23:31:00.749+0900 I/SHealth_Service( 1563): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
05-29 23:31:00.759+0900 W/MUSIC_CONTROL_SERVICE( 1615): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1615]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
05-29 23:31:00.809+0900 E/SHealth_Common( 1563): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-29 23:31:02.509+0900 E/W_INDICATOR( 1139): windicator_moment_view.c: windicator_moment_view_hide(611) > [windicator_moment_view_hide:611] Hide Moment View : dynamic_layout(0xb77ced00),Type(1)
05-29 23:31:02.509+0900 E/W_INDICATOR( 1139): windicator_connection.c: windi_connection_pause(1598) > [windi_connection_pause:1598] Failed to deregister noti event : TAPI_PROP_MODEL_POWER
05-29 23:31:02.569+0900 E/W_INDICATOR( 1139): windicator_util.c: windi_x_input_event_unregister(225) > [windi_x_input_event_unregister:225] not registered
05-29 23:31:02.619+0900 W/APP_CORE( 1139): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:1a00011
05-29 23:31:02.619+0900 I/APP_CORE( 1139): appcore-efl.c: __do_app(429) > [APP 1139] Event: PAUSE State: RUNNING
05-29 23:31:02.619+0900 I/CAPI_APPFW_APPLICATION( 1139): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 23:31:03.189+0900 I/HAP     ( 2869): routes length: 1
05-29 23:31:03.209+0900 I/tag     ( 2869): get_tts_state state = 1
05-29 23:31:03.219+0900 I/tag     ( 2869): get_tts_state state = 1
05-29 23:31:03.369+0900 W/STARTER ( 1138): hw_key.c: _key_press_cb(1200) > [_key_press_cb:1200] POWER Key is pressed
05-29 23:31:03.369+0900 W/STARTER ( 1138): hw_key.c: _key_press_cb(1203) > [_key_press_cb:1203] LCD state : 1
05-29 23:31:03.369+0900 W/STARTER ( 1138): hw_key.c: _key_press_cb(1210) > [_key_press_cb:1210] PM state : 1
05-29 23:31:03.369+0900 W/STARTER ( 1138): hw_key.c: _key_press_cb(1224) > [_key_press_cb:1224] powerkey count : 1
05-29 23:31:03.529+0900 W/STARTER ( 1138): hw_key.c: _key_release_cb(1124) > [_key_release_cb:1124] POWER Key is released
05-29 23:31:03.539+0900 W/AUL_AMD (  957): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 23:31:03.539+0900 W/AUL_AMD (  957): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
05-29 23:31:03.709+0900 I/APP_CORE( 2538): appcore-efl.c: __do_app(429) > [APP 2538] Event: RESUME State: PAUSED
05-29 23:31:03.709+0900 I/CAPI_APPFW_APPLICATION( 2538): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 23:31:03.729+0900 W/WATCH_CORE( 1755): appcore-watch.c: __widget_resume(1012) > widget_resume
05-29 23:31:03.729+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppResume(725) > 
05-29 23:31:03.729+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:31:03.729+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:31:03.739+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 14
05-29 23:31:03.749+0900 W/AUL_AMD (  957): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 23:31:03.749+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 4
05-29 23:31:03.749+0900 E/AUL_AMD (  957): amd_request.c: __app_process_by_pid(193) > pid(2869) is dead. cmd(4) is canceled
05-29 23:31:03.779+0900 W/STARTER ( 1138): hw_key.c: _powerkey_timer_cb(806) > [_powerkey_timer_cb:806] _powerkey_timer_cb, powerkey count[1]
05-29 23:31:03.779+0900 W/STARTER ( 1138): hw_key.c: _powerkey_timer_cb(961) > [_powerkey_timer_cb:961] clock visibility[0] pressed lcd status[1], current lcd status[1] pressed pm state[1]
05-29 23:31:03.779+0900 E/STARTER ( 1138): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-29 23:31:03.779+0900 W/AUL_AMD (  957): amd_request.c: __request_handler(640) > __request_handler: 0
05-29 23:31:03.789+0900 W/AUL_AMD (  957): amd_launch.c: _start_app(1659) > caller pid : 1138
05-29 23:31:03.799+0900 W/AUL_AMD (  957): amd_launch.c: __nofork_processing(1138) > __nofork_processing, cmd: 0, pid: 1177
05-29 23:31:03.799+0900 I/APP_CORE( 1177): appcore-efl.c: __do_app(429) > [APP 1177] Event: RESET State: PAUSED
05-29 23:31:03.799+0900 I/CAPI_APPFW_APPLICATION( 1177): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-29 23:31:03.799+0900 W/W_HOME  ( 1177): main.c: _app_control(1737) > Service value : powerkey
05-29 23:31:03.799+0900 I/wnotib  ( 1177): w-notification-board-broker-main.c: _wnotib_view_event_handler(1182) > Home view event: 0x40001
05-29 23:31:03.799+0900 E/wnotib  ( 1177): w-notification-board-action-drawer.c: wnotib_action_drawer_popup_shown(4518) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 23:31:03.799+0900 E/wnotib  ( 1177): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 23:31:03.799+0900 W/W_HOME  ( 1177): noti_broker.c: _noti_broker_home_cb(786) > continue the home key execution
05-29 23:31:03.799+0900 E/W_HOME  ( 1177): cs_broker.c: _cs_broker_home_cb(256) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
05-29 23:31:03.799+0900 E/W_HOME  ( 1177): move.c: move_back_to_home_no_anim(270) > home is already on position
05-29 23:31:03.799+0900 I/APP_CORE( 1177): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
05-29 23:31:03.799+0900 W/W_HOME  ( 1177): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
05-29 23:31:03.799+0900 W/W_HOME  ( 1177): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-29 23:31:03.799+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:31:03.799+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:31:03.799+0900 W/W_HOME  ( 1177): main.c: home_resume(731) > journal_appcore_app_fully_loaded called
05-29 23:31:03.799+0900 W/W_HOME  ( 1177): main.c: home_resume(735) > clock/widget resumed
05-29 23:31:03.799+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:31:03.799+0900 W/AUL_AMD (  957): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(1177), cmd(0)
05-29 23:31:03.829+0900 E/E17     (  628): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x02800003)
05-29 23:31:03.899+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:31:03.899+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:31:03.909+0900 W/PROCESSMGR(  628): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-29 23:31:04.059+0900 W/W_HOME  ( 1177): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-29 23:31:04.059+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:31:04.059+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:31:04.059+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:31:04.059+0900 W/W_HOME  ( 1177): main.c: _ecore_x_message_cb(1233) > main_info.is_win_on_top: 1
05-29 23:31:04.069+0900 I/GESTURE (  244): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
05-29 23:31:04.079+0900 W/AUL_AMD (  957): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 23:31:04.079+0900 W/AUL_AMD (  957): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
05-29 23:31:04.079+0900 W/WATCH_CORE( 1755): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-29 23:31:04.079+0900 I/WATCH_CORE( 1755): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-29 23:31:04.079+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:31:04.079+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:31:04.079+0900 I/CAPI_WATCH_APPLICATION( 1755): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 23:31:04.079+0900 E/watchface-loader( 1755): watchface-loader.cpp: OnAppTimeTick(744) > 
05-29 23:31:04.099+0900 W/W_HOME  ( 1177): event_manager.c: _window_visibility_cb(448) > Window [0x2800003] is now visible(0)
05-29 23:31:04.099+0900 W/W_HOME  ( 1177): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-29 23:31:04.099+0900 W/W_HOME  ( 1177): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 23:31:04.099+0900 W/W_HOME  ( 1177): main.c: _window_visibility_cb(1200) > Window [0x2800003] is now visible(0)
05-29 23:31:04.099+0900 I/APP_CORE( 1177): appcore-efl.c: __do_app(429) > [APP 1177] Event: RESUME State: RUNNING
05-29 23:31:04.109+0900 I/wnotib  ( 1177): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-29 23:31:04.109+0900 E/wnotib  ( 1177): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 23:31:04.109+0900 W/wnotib  ( 1177): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
05-29 23:31:04.149+0900 E/WIDGET_SDK( 2538): main.c: update_message(428) > [SECURE_LOG] Create aborted
05-29 23:31:04.149+0900 I/APP_CORE( 2538): appcore-efl.c: __do_app(429) > [APP 2538] Event: PAUSE State: RUNNING
05-29 23:31:04.149+0900 I/CAPI_APPFW_APPLICATION( 2538): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 23:31:04.199+0900 W/CRASH_MANAGER( 2898): worker.c: worker_job(1199) > 1102869686170146453226
