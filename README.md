# Cuculus

## BOM

- Windows 10/11
- .NET 9
- PowerShell Core 7.5
- Visual Studio Code

## Stepts

### Artifacts

```powrshell
dotnet build --configuration Release --use-current-runtime --self-contained --artifacts-path ./artifacts/
```

### Windows Service

```powershell
sc.exe create ".NET Cuculus Service" binpath= "C:\Workspaces\DotNet9\Cuculus\artifacts\bin\Cuculus.WebApi\release\Cuculus.WebApi.exe"
```

## Links

- [Artifacts](https://learn.microsoft.com/en-us/dotnet/core/sdk/artifacts-output)
- [Windows Servic](https://learn.microsoft.com/en-us/dotnet/core/extensions/windows-service)
