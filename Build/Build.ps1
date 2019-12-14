[CmdletBinding(PositionalBinding=$false)]
Param(
  [string]$Version,
  [string][Alias('c')]$Configuration = "Debug",
  [string][Alias('v')]$verbosity = "minimal",
  [switch]$restore,
  [switch][Alias('b')]$build,
  [switch]$rebuild,
  [switch]$buildNative,
  [switch]$loc,
  [switch][Alias('t')]$test,
  [switch] $pack,
  [switch][Alias('bl')]$binaryLog,
  [switch] $dontVersion = $false,
  [string]$platform = $null,
  [switch] $help,
  [Parameter(ValueFromRemainingArguments=$true)][String[]]$properties
)

. $PSScriptRoot\tools.ps1

# break on errors
Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"
$PSDefaultParameterValues['*:ErrorAction'] = 'Stop'

$env:SKIP_PAUSE=1
$TfmConfiguration = "$Configuration\net461";

Push-Location $PSScriptRoot\..\

#$Solution = ".\GitExtensions.sln";


    # if ($build -eq $true -or $rebuild -eq $true) {
    #     if ($dontVersion -eq $false) {
    #         if ([string]::IsNullOrWhiteSpace($Version)) {
    #             throw "Version is required"
    #         }

    #         $python = "python";
    #         if ($env:APPVEYOR) {
    #             $python = "C:\Python35\python";
    #         }
    #         else {
    #             [string[]]$PythonPaths = & where.exe python
    #             if (!$PythonPaths) {
    #                 throw "[WARN] Python is not installed or not on PATH. Did you mean to run '-dontVersion'?"
    #             }

    #             $python = $PythonPaths[0]
    #         }

    #         Push-Location .\Setup
    #         Write-Host "[LOG] Setting version: $Version" -ForegroundColor Green
    #         & $python set_version_to.py -v $Version -t $Version
    #         Pop-Location
    #     }

    $bl = if ($binaryLog) { "/bl:" + (Join-Path $LogDir "build.binlog") } else { "" }
    $platformArg = if ($platform) { "/p:Platform=$platform" } else { "" }

    $toolsetBuildProj = Resolve-Path 'Build\tools\Build.proj'
    Write-Host $toolsetBuildProj
    #InitializeCustomToolset

    if ($buildNative) {
        MSBuild $toolsetBuildProj `
            $bl `
            /p:Platform=Win32 `
            /p:Configuration=$configuration `
            /p:RepoRoot=$RepoRoot `
            /p:Projects=$RepoRoot\GitExtSshAskPass\GitExtSshAskPass.sln `
            /p:Build=$buildNative `
            /p:Rebuild=$rebuild `
            @properties;

        # build shell extensions x86
        MSBuild $toolsetBuildProj `
            $bl `
            /p:Platform=Win32 `
            /p:Configuration=$configuration `
            /p:RepoRoot=$RepoRoot `
            /p:Projects=$RepoRoot\GitExtensionsShellEx\GitExtensionsShellEx.sln `
            /p:Build=$buildNative `
            /p:Rebuild=$rebuild `
            @properties;

        # build shell extensions x64
        MSBuild $toolsetBuildProj `
            $bl `
            /p:Platform=x64 `
            /p:Configuration=$configuration `
            /p:RepoRoot=$RepoRoot `
            /p:Projects=$RepoRoot\GitExtensionsShellEx\GitExtensionsShellEx.sln `
            /p:Build=$buildNative `
            /p:Rebuild=$rebuild `
            @properties;
    }

    MSBuild $toolsetBuildProj `
        $bl `
        $platformArg `
        /p:Configuration=$configuration `
        /p:RepoRoot=$RepoRoot `
        /p:Restore=$restore `
        /p:Build=$build `
        /p:Rebuild=$rebuild `
        /p:BuildNative=$buildNative `
        /p:Test=$test `
        /p:Pack=$pack `
        @properties
        # /p:IntegrationTest=$integrationTest `
        # /p:PerformanceTest=$performanceTest `
        #/p:Sign=$sign `
        #/p:Publish=$publish `
    
    # if ($restore) {
    #     Write-Host "[LOG] Restoring packages" -ForegroundColor Green
    #     .\.nuget\nuget.exe update -self
    #     .\.nuget\nuget.exe restore -Verbosity Quiet $Solution
    # }
try{

    if ($build -eq $true -or $rebuild -eq $true) {
        # if ($dontVersion -eq $false) {
        #     if ([string]::IsNullOrWhiteSpace($Version)) {
        #         throw "Version is required"
        #     }

        #     $python = "python";
        #     if ($env:APPVEYOR) {
        #         $python = "C:\Python35\python";
        #     }
        #     else {
        #         [string[]]$PythonPaths = & where.exe python
        #         if (!$PythonPaths) {
        #             throw "[WARN] Python is not installed or not on PATH. Did you mean to run '-dontVersion'?"
        #         }

        #         $python = $PythonPaths[0]
        #     }

        #     Push-Location .\Setup
        #     Write-Host "[LOG] Setting version: $Version" -ForegroundColor Green
        #     & $python set_version_to.py -v $Version -t $Version
        #     Pop-Location
        # }
        
        # Push-Location $PSScriptRoot\..\
        # Write-Host "[LOG] Performing a build" -ForegroundColor Green

        # $binLog = if ($binaryLog) { "/bl:" + (Join-Path ".\" "build.binlog") } else { "" }
        # $target = if ($rebuild -eq $true) { "Rebuild" } else { "Build" }

        # Write-Host "[LOG] ...building native" -ForegroundColor Green
        # & .\Setup\BuildGitExtNative.cmd $Configuration $target
        # if ($LASTEXITCODE -ne 0) {
        #     Write-Host "[ERROR] Build failed..." -ForegroundColor Red
        #     return -1
        # }
        
        # Write-Host "[LOG] ...building the solution" -ForegroundColor Green
        # & .\Setup\hMSBuild -notamd64 -no-cache -m $Solution /p:Configuration=$Configuration /t:$target /nologo /v:$verbosity $binLog
        # if ($LASTEXITCODE -ne 0) {
        #     Write-Host "[ERROR] Build failed..." -ForegroundColor Red

        #     if ($env:APPVEYOR) {
        #         Get-ChildItem *.binlog -Recurse | % { Push-AppveyorArtifact $_.FullName -FileName $_.Name }
        #     }

        #     return -2
        # }
    }

    if ($loc -eq $true) {
        Write-Host "[LOG] Updating translations" -ForegroundColor Green
        & .\Build\transifex\UpdateLocalEnglishTranslations.ps1 -TfmConfiguration $TfmConfiguration
    }

    if ($test -eq $true) {
        Write-Host "[LOG] Running tests" -ForegroundColor Green
        . .\Build\Run-Tests.ps1

        $result = Start-Tests 
        if ($result -ne 0) {
            Write-Host "[ERROR] Tests failed with exit code: $result..." -ForegroundColor Red
            return -3
        }
    }

    if ($pack -eq $true) {
        if ([string]::IsNullOrWhiteSpace($Version)) {
            throw "Version is required"
        }

        & .\Build\Prepare-Artifacts.ps1 -Configuration $Configuration -Version $Version -verbosity $verbosity -rebuild:$rebuild -binaryLog:$binaryLog
    }
}
catch {
    Write-Host $_.Exception -ForegroundColor Red
    return -1
}