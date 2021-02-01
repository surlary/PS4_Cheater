# PS4_Cheater

PS4 Cheater is homebrew APP to find game cheat codes, and it is based on [ps4debug](https://github.com/jogolden/ps4debug).

This is a work in progress.

|  FW  | Status          | Comment
|------|-----------------|--------------------
| 5.05 | Minimal testing | 5.05 `ps4debug.bin`
| 6.72 | Untested        | 6.72 `ps4debug.bin`
| 7.02 | Untested        | 7.02 `ps4debug.bin`

## Building

Open `PS4_Cheater.sln` with Visual Studio and build.

**Note:**
- `payloads` directory will be copied to the `debug`/`release` directory as a post-build step.
- If using `ps4debug` `payloads` directory on its own, be sure to grab `libdebug.dll`.
  - Need both for the speedfix.


## Acknowledgements & Thanks!
- Countless contributors to `jkpatch`, `ps4-ksdk`, `ps4-payload-sdk`, `ps4debug` and `PS4_Cheater`.
- [DeathRGH](https://github.com/DeathRGH) for the speedfix tweak for ps4debug.
- [Al-Azif](https://github.com/Al-Azif) for his [ps4-exploit-host](https://github.com/Al-Azif/ps4-exploit-host) - Very useful for local testing.

---
Discord chat site: https://discord.gg/PwBwUKf.
Please join us!

