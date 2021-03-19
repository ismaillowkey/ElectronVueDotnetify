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
electronize start
```

## Publish
```bash
electronize build /target win
```
output directory : bin\Desktop

read more
[Electron.NET](https://github.com/ElectronNET/Electron.NET)
