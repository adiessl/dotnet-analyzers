# dotnet-analyzers

This repository contains four project files, each targeting a different .NET SDK.

All of them, however, are using the same `Program.cs` file as well as the same auxiliary classes to demonstrate a potential performance regression when it comes to the execution of analyzers during the build process.

In order to have reliable data, an analyzer is used that does not depend on the .NET version: [SerilogAnalyzer](https://www.nuget.org/packages/SerilogAnalyzer) (version 0.15.0.0)

To automate the testing process, the PowerShell script `Run-Tests.ps1` exists in this repository. It ensures each build is started from a clean slate, creates an appropriate `global.json` file for the project before then building it. The build produces a `.binlog` file that can be used to analyze the performance.

These are the times that the `SerilogAnalyzer` has taken according to the _Analyzer Summary_ in the [_MSBuild Structured Log Viewer_](https://msbuildlog.com/):

| SDK         | Run #1   | Run #2   | Run #3   |
|-------------|----------|----------|----------|
| .NET 8      | 0:34.684 | 0:48.367 | 0:43.041 |
| .NET 9      | 1:04.883 | 0:48.083 | 0:55.658 |
| .NET 10 RC1 | 1:22.098 | 1:25.574 | 1:40.713 |
| .NET 10 RC2 | 1:43.268 | 1:38.671 | 1:36.506 |

Even though the times are fluctuating somewhat from run to run, it is obvious that the analyzer takes a lot more time in newer .NET versions.
