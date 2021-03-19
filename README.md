# Summary
Electron.NET with Vue 2.x Typescript+dotnetify and Asp net core 5

## Installation
```bash
cd ElectronVueDotnetify
cd ClientApp
npm install
```

## Debug
```bash
dotnet tool update ElectronNET.CLI -g
electronize init
```

## Develop Electron.NET apps using a file watcher

The file watcher is included with version 8.31.1 of Electron.NET. For example, a file change can trigger compilation, test execution, or deployment. The Electron.NET window will automatically refresh and new code changes will be visible more quickly. The following Electron.NET CLI command is required:

```
electronize start /watch
```

### Note
> Only the first electronize start is slow. The next will go on faster.

## Publish
```bash
electronize build /target win
```

### Output Folder
> bin\Desktop

read more
[Electron.NET](https://github.com/ElectronNET/Electron.NET)
