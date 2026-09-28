# ConfigLoader

VB.NET WinForms harness for reading hierarchical application settings from `AppConfig.xml`. Form1 builds a `Config.Configuration` key (company / solution / project / version / section / user / setting) and calls `Config.GetSettingValue` against an XML document shaped like Company, Solution, Project, Version, Section, User, Setting. Aimed at testing a small XML config helper before wiring it into larger apps.

**Source last updated:** 2008-09-02  
**Language:** VB.NET  
**Target:** .NET Framework 3.5  
**Output:** WinForms executable

## Solution structure

| Project | Language | Type | Purpose |
| --- | --- | --- | --- |
| `ConfigLoader` | VB.NET | WinForms exe | Loads `AppConfig.xml` via `Config` and prints a sample setting |

## How to open

Open `ConfigLoader.sln` in Visual Studio. `Config.vb` is supplied as `Config.vb.example` in this tree if the live file is redacted.

## Requirements

- Visual Studio 2008 to 2017
- .NET Framework 3.5

## Attribution and provenance

Working copy from my Historical Dev folder. Default Visual Studio template assembly title `WindowsApplication1` remains in `My Project/AssemblyInfo.vb`.

## License

MIT. See `LICENSE`.
