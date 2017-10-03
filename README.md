# Logging Plugin for Xamarin
Logging Plugin for Xamarin provides a consistent, cross platform logging plugin for Xamarin.iOS, Xamarin.Android, and Xamarin.Forms.

## NuGet
[Xam.Plugins.Logging](https://www.nuget.org/packages/Xam.Plugins.Logging/) [![NuGet](https://img.shields.io/nuget/v/Xam.Plugins.Logging.svg?label=NuGet)](https://www.nuget.org/packages/Xam.Plugins.Logging/)

## How to use

From your portable, Android or iOS project simply call the static logging method corresponding to the desired severity.

```csharp
using Plugin.Logging;

Logging.Verbose("Verbose message");
Logging.Verbose("Verbose message", new System.Exception("Exception message"));

Logging.Debug("Debug message");
Logging.Debug("Debug message", new System.Exception("Exception message"));

Logging.Info("Info message");
Logging.Info("Info message", new System.Exception("Exception message"));

Logging.Warning("Warning message");
Logging.Warning("Warning message", new System.Exception("Exception message"));

Logging.Error("Error message");
Logging.Error("Error message", new System.Exception("Exception message"));

Logging.Fatal("Fatal message");
Logging.Fatal("Fatal message", new System.Exception("Exception message"));
```

## Android
Log messages will be written to [SharedPreferences](https://developer.android.com/reference/android/content/SharedPreferences.html) with the Tag set to the name of the calling method if no other sender is specified. To specify another sender add the sender parameter to the calls, e.g.

```csharp
using Plugin.Logging;

Logging.Verbose("Verbose message", "Sender name");
Logging.Verbose("Verbose message", new System.Exception("Exception message"), "Sender name");
```

## iOS
Log messages will be written to iOS [NSDefaults](https://developer.apple.com/documentation/foundation/userdefaults) with the format

```csharp
$"{severity}: {sender}: {message}: Exception: {exception.Message}"
```
