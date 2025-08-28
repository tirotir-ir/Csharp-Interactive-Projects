# C# Interactive Projects — Console + WinForms (40)

A curated set of **40 real C# projects** (20 Console + 20 WinForms), each in its own folder with `.csproj` and `.sln`,
plus a slick **web dashboard** (`index.html`) with code viewer, **step-by-step guides**, and optional **screenshots**.

## Highlights
- ✅ 20 Console apps (`net8.0`)
- ✅ 20 WinForms apps (`net8.0-windows`, `<UseWindowsForms>true</UseWindowsForms>`)
- ✅ Per-project guide + code viewer
- ✅ Screenshot auto-capture script (Windows)
- ✅ GitHub Pages ready (open `index.html`)

## Quick Start
```bash
# Clone
git clone https://github.com/YOUR_USER/CSharp-Interactive-Projects.git
cd CSharp-Interactive-Projects

# Run any project
cd winforms/Project05_StopwatchTimer
dotnet run
```

## Real Screenshots (Windows)
To generate **real screenshots** of every project automatically on Windows:

```powershell
# From repo root, in PowerShell 5+ or Windows Terminal
.\scripts\capture_screenshots.ps1
```

This will:
- Build all projects (Debug).
- Launch each **WinForms** and **Console** app briefly.
- Capture window screenshots to `images/ProjectXX_Name.png`.
- Close the app after capture.

> Tip: While the script runs, let the windows come to the front for a second.

## Dashboard
Open `index.html` in your browser (or enable GitHub Pages) to browse projects. If an image exists in `images/`, it is shown next to the project entry.

## Structure
```
projects/   # 20 Console apps
winforms/   # 20 WinForms apps
images/     # Real screenshots (auto-populated by script)
scripts/    # Helper scripts (screenshot capture, solution generation)
index.html  # Dashboard (code + guide + images)
README.md
LICENSE
```

## .NET Targets
- Console: `net8.0`
- WinForms: `net8.0-windows` with `<UseWindowsForms>true</UseWindowsForms>`
- SDK: `Microsoft.NET.Sdk` (no NETSDK1137 warning)

## License
MIT — see [LICENSE](LICENSE).

---

*Made by tirotir.ir for educators and learners. Contributions welcome!*
