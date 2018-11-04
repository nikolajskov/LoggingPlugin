# Logging Plugin for Xamarin
Logging Plugin for Xamarin provides a consistent, cross platform logging plugin for Xamarin.iOS, Xamarin.Android and Xamarin.Forms.

## NuGet
[Xam.Plugins.Logging](https://www.nuget.org/packages/Xam.Plugins.Logging/) [![NuGet](https://img.shields.io/nuget/v/Xam.Plugins.Logging.svg?label=NuGet)](https://www.nuget.org/packages/Xam.Plugins.Logging/)

## How to use

From your Xamarin.Android, Xamarin.iOS or shared .NET Standard project simply call the static logging method corresponding to the desired severity.

```csharp
using Plugin.Logging;

Logging.Verbose("Verbose message");
Logging.Verbose("Verbose message", "Tag");

Logging.Debug("Debug message");
Logging.Debug("Debug message", "Tag"));

Logging.Info("Info message");
Logging.Info("Info message", "Tag");

Logging.Warning("Warning message");
Logging.Warning("Warning message", "Tag");
Logging.Warning("Warning message", new System.Exception("Exception message"));
Logging.Warning("Warning message", "Tag", new System.Exception("Exception message"));

Logging.Error("Error message");
Logging.Error("Error message", "Tag");
Logging.Error("Error message", new System.Exception("Exception message"));
Logging.Error("Error message", "Tag", new System.Exception("Exception message"));
```

## Android
Log messages will be written using the [Android.Util.Log](https://developer.xamarin.com/api/type/Android.Util.Log/) class.
The plugin can optionally be initialized by calling the static Init() method where a general tag and severity filtering can be supplied.

```csharp
using Plugin.Logging;

Logging.Init("AndroidTag");

Logging.Verbose("Verbose message"); // Using the general 'AndroidTag'
Logging.Verbose("Verbose message", "Some other Tag"); // Using specific tag
```

## iOS
Log messages will be written to the Apple System Log facility using [NSLog](https://developer.apple.com/documentation/foundation/1395275-nslog) with the format

```csharp
$"{tag}: {severity}: {message}\n{exception.Message}"
```

The plugin can optionally be initialized by calling the static Init() method where a general tag and severity filtering can be supplied.

```csharp
Logging.Init("iOSTag");

Logging.Verbose("Verbose message"); // Using the general 'AndroidTag'
Logging.Verbose("Verbose message", "Some other Tag"); // Using specific tag
```
