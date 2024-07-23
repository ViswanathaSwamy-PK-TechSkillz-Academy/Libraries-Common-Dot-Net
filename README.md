# .NET 8 and Above Common Libraries

This repository contains the .NET libraries

## 1. Create and Publish NuGet packages to Local Folder using dotnet CLI and PowerShell

### 1.1. Create required Variables using PowerShell Windows Terminal

```powershell
$localpackagesfolder="D:\Packages\TSA"
$localpackagesourcename="Local-Packages-TSA"
```

### 1.2. Publishing the packages to local folder using PowerShell Windows Terminal

> 1. Navigate to the folder where the `HeaderFooter`.csproj file is present.
> 1. In this case, it is the `D:\TSA\Libraries-Common-Dot-Net\src\HeaderFooter` folder where the `HeaderFooter`.csproj file is present.
> 1. Update the `Version`, and `AssemblyVersion` in the `HeaderFooter`.csproj file.
> 1. Run the following `dotnet` commands.

```xml
<PropertyGroup>
    <Version>1.0.1</Version>
    <AssemblyVersion>1.1</AssemblyVersion>
</PropertyGroup>
```

```powershell
dotnet clean
dotnet build
dotnet pack -o $localpackagesfolder
```

![Publish Packages Locally](documentation/images/Publish_Packages_Locally.PNG)

## 2. Add the Local NuGet package folder as Package Source

### 2.1. Adding local packages folder as NuGet source using PowerShell Windows Terminal

> 1. Run the following `dotnet` commands.

```powershell
dotnet nuget list source
dotnet nuget add source $localpackagesfolder -n $localpackagesourcename
dotnet nuget remove source $localpackagesourcename
```

### 2.2. Verify local packages folder is added as NuGet source

> 1. Run the following `dotnet` commands, to ensure that `$localpackagesourcename` is added as NuGet package source.
> 1. Run the following `dotnet nuget remove source $localpackagesourcename` command, to remove NuGet package source.

```powershell
dotnet nuget list source
```

![Local NuGet Packages Source |150x150](documentation/images/Local_Nuget_Packages_Source.PNG)

## 3. Create and Publish NuGet packages to GitHub Packages using dotnet CLI and PowerShell

### 3.1. Creating required Variables using PowerShell Windows Terminal

To be done

### 3.2. Publishing the packages to GitHub Packages using PowerShell Windows Terminal

![DotNet Nuger Package published in GitHub](documentation/images/Publish_Packages_To_GitHub.PNG)

![DotNet Nuger Package published in GitHub](documentation/images/DotNet_Package_In_GitHub.PNG)
