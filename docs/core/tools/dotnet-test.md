---
title: dotnet test command
description: The dotnet test command is used to execute unit tests in a given project.
ms.date: 04/29/2020
---
# dotnet test

**This article applies to:** ✔️ .NET Core 2.1 SDK and later versions

## Name

`dotnet test` - .NET test driver used to execute unit tests.

## Synopsis

```dotnetcli
dotnet test [<PROJECT> | <SOLUTION> | <DIRECTORY> | <DLL>]
    [-a|--test-adapter-path <PATH_TO_ADAPTER>] [--blame]
    [-c|--configuration <CONFIGURATION>]
    [--collect <DATA_COLLECTOR_FRIENDLY_NAME>]
    [-d|--diag <PATH_TO_DIAGNOSTICS_FILE>] [-f|--framework <FRAMEWORK>]
    [--filter <EXPRESSION>] [--interactive]
    [-l|--logger <LOGGER_URI/FRIENDLY_NAME>] [--no-build]
    [--nologo] [--no-restore] [-o|--output <OUTPUT_DIRECTORY>]
    [-r|--results-directory <PATH>] [--runtime <RUNTIME_IDENTIFIER>]
    [-s|--settings <SETTINGS_FILE>] [-t|--list-tests]
    [-v|--verbosity <LEVEL>] [[--] <RunSettings arguments>]

dotnet test -h|--help
```

## Description

The `dotnet test` command is used to execute unit tests in a given solution. The `dotnet test` command builds the solution and runs a test host application for each test project in the solution. The test host executes tests in the given project using a test framework, for example: MSTest, NUnit, or xUnit, and reports the success or failure of each test. If all tests are successful, the test runner returns 0 as an exit code; otherwise if any test fails, it returns 1.

For multi-targeted projects, tests are run for each targeted framework. The test host and the unit test framework are packaged as NuGet packages and are restored as ordinary dependencies for the project.

Test projects specify the test runner using an ordinary `<PackageReference>` element, as seen in the following sample project file:

[!code-xml[XUnit Basic Template](../../../samples/snippets/csharp/xunit-test/xunit-test.csproj)]

Where `Microsoft.NET.Test.Sdk` is the test host, `xunit` is the test framework. And `xunit.runner.visualstudio` is a test adapter, which allows the xUnit framework to work with the test host.

### Implicit restore

[!INCLUDE[dotnet restore note](~/includes/dotnet-restore-note.md)]

## Arguments

- **`PROJECT | SOLUTION | DIRECTORY | DLL`**

  - Path to the test project.
  - Path to the solution. 
  - Path to a directory that contains a project or a solution.
  - Path to a test project *.dll* file.

  If not specified, it searches for a project or a solution in the current directory.

## Options

- **`-a|--test-adapter-path <PATH_TO_ADAPTER>`**

  Path to a directory to be searched for additional test adapters. Only *.dll* files with suffix `.TestAdapter.dll` are inspected. If not specified, the directory of the test *.dll* is searched.

- **`--blame`**

  Runs the tests in blame mode. This option is helpful in isolating problematic tests that cause the test host to crash. When a crash is detected, it creates an sequence file in `TestResults/<Guid>/<Guid>_Sequence.xml` that captures the order of tests that were run before the crash.

- **`-c|--configuration <CONFIGURATION>`**

  Defines the build configuration. The default value is `Debug`, but your project's configuration could override this default SDK setting.

- **`--collect <DATA_COLLECTOR_FRIENDLY_NAME>`**

  Enables data collector for the test run. For more information, see [Monitor and analyze test run](https://aka.ms/vstest-collect).

- **`-d|--diag <PATH_TO_DIAGNOSTICS_FILE>`**

  Enables diagnostic mode for the test platform and writes diagnostic messages to the specified file, and files next to it, based on the process that is logging the messages, such as `*.host_<date>.txt` for test host log, and `*.datacollector_<date>.txt` for data collector log.

- **`-f|--framework <FRAMEWORK>`**

  Forces the use of dotnet or .NET Framework test host for the test binaries. This only determines which type of host to use. The actual framework version to be used is determined by the runtimeconfig.json of the test project. When not specified [TargetFramework assembly attribute](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.versioning.targetframeworkattribute) is used to determine the the type of host. When that attribute is stripped from the dll, .NET Framework host is used.

- **`--filter <EXPRESSION>`**

  Filters out tests in the current project using the given expression. For more information, see the [Filter option details](#filter-option-details) section. For more information and examples on how to use selective unit test filtering, see [Running selective unit tests](../testing/selective-unit-tests.md).

- **`-h|--help`**

  Prints out a short help for the command.

- **`--interactive`**

  Allows the command to stop and wait for user input or action. For example, to complete authentication. Available since .NET Core 3.0 SDK.

- **`-l|--logger <LOGGER_URI/FRIENDLY_NAME>`**

  Specifies a logger for test results. Unlike MSBuild, dotnet test doesn't accept abbreviations: instead of `-l "console;v=d"` use `-l "console;verbosity=detailed"`.

- **`--no-build`**

  Doesn't build the test project before running it. It also implicitly sets the - `--no-restore` flag.

- **`--nologo`**

  Run tests without displaying the Microsoft TestPlatform banner. Available since .NET Core 3.0 SDK.

- **`--no-restore`**

  Doesn't execute an implicit restore when running the command.

- **`-o|--output <OUTPUT_DIRECTORY>`**

  Directory in which to find the binaries to run. If not specified, the default path is `./bin/<configuration>/<framework>/`.  For projects with multiple target frameworks (via the `TargetFrameworks` property), you also need to define `--framework` when you specify this option. `dotnet test` always run tests from the output directory. You can use <xref:System.AppDomain.BaseDirectory%2A?displayProperty=nameWithType> to consume test assets in the output directory.

- **`-r|--results-directory <PATH>`**

  The directory where the test results are going to be placed. If the specified directory doesn't exist, it's created. The default is `TestResults` in the directory that contains the project file.

- **`--runtime <RUNTIME_IDENTIFIER>`**

  The target runtime to test for.

- **`-s|--settings <SETTINGS_FILE>`**

  The `.runsettings` file to use for running the tests. Note that the `TargetPlatform` element (x86|x64) has no effect for `dotnet test`. To run tests that target x86, install the x86 version of .NET Core. The bitness of the *dotnet.exe* that is on the path is what will be used for running tests. For more information, see the following resources:

  - [Configure unit tests by using a `.runsettings` file.](/visualstudio/test/configure-unit-tests-by-using-a-dot-runsettings-file)
  - [Configure a test run](https://github.com/Microsoft/vstest-docs/blob/master/docs/configure.md)

- **`-t|--list-tests`**

  List all of the discovered tests in the current project.

- **`-v|--verbosity <LEVEL>`**

  Sets the verbosity level of the command. Allowed values are `q[uiet]`, `m[inimal]`, `n[ormal]`, `d[etailed]`, and `diag[nostic]`. The default is `minimal`. For more information, see <xref:Microsoft.Build.Framework.LoggerVerbosity>.

- **`RunSettings`** arguments

 Inline `RunSettings` are passed as the last arguments on the command line after after "-- " (note the space after --). Inline `RunSettings` are specified as `[name]=[value]` pairs. A space is used to separate multiple `[name]=[value]` pairs.

  Example: `dotnet test -- MSTest.DeploymentEnabled=false MSTest.MapInconclusiveToFailed=True`

  For more information, see [Passing RunSettings arguments through command line](https://github.com/Microsoft/vstest-docs/blob/master/docs/RunSettingsArguments.md).

## Examples

- Run the tests in the project in the current directory:

  ```dotnetcli
  dotnet test
  ```

- Run the tests in the `test1` project:

  ```dotnetcli
  dotnet test ~/projects/test1/test1.csproj
  ```

- Run the tests in the project in the current directory, and generate a test results file in the trx format:

  ```dotnetcli
  dotnet test --logger trx
  ```

- Run the tests in the project in the current directory, and log with detailed verbosity to the console:

  ```dotnetcli
  dotnet test --logger "console;verbosity=detailed"
  ```
  
  - Run the tests in the project in the current directory, and report tests that were in progress when test host crashed:

  ```dotnetcli
  dotnet test --blame
  ```

## Filter option details

`--filter <EXPRESSION>`

`<Expression>` has the format `<property><operator><value>[|&<Expression>]`.

`<property>` is an attribute of the `Test Case`. The following are the properties supported by popular unit test frameworks:

| Test Framework | Supported properties                                                                                      |
| -------------- | --------------------------------------------------------------------------------------------------------- |
| MSTest         | <ul><li>FullyQualifiedName</li><li>Name</li><li>ClassName</li><li>Priority</li><li>TestCategory</li></ul> |
| xUnit          | <ul><li>FullyQualifiedName</li><li>DisplayName</li><li>Traits</li></ul>                                   |

The `<operator>` describes the relationship between the property and the value:

| Operator | Function        |
| :------: | --------------- |
| `=`      | Exact match     |
| `!=`     | Not exact match |
| `~`      | Contains        |
| `!~`     | Not contains    |

`<value>` is a string. All the lookups are case insensitive.

An expression without an `<operator>` is automatically considered as a `contains` on `FullyQualifiedName` property (for example, `dotnet test --filter xyz` is same as `dotnet test --filter FullyQualifiedName~xyz`).

Expressions can be joined with conditional operators:

| Operator            | Function |
| ------------------- | -------- |
| <code>&#124;</code> | OR       |
| `&`                 | AND      |

You can enclose expressions in parenthesis when using conditional operators (for example, `(Name~TestMethod1) | (Name~TestMethod2)`).

For more information and examples on how to use selective unit test filtering, see [Running selective unit tests](../testing/selective-unit-tests.md).

## See also

- [Frameworks and Targets](../../standard/frameworks.md)
- [.NET Core Runtime IDentifier (RID) catalog](../rid-catalog.md)
- [Passing runsettings arguments through commandline](https://github.com/Microsoft/vstest-docs/blob/master/docs/RunSettingsArguments.md)
