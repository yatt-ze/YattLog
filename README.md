# YattLog
 Simple and lightweight logging framework
 I got tired of setting up the usual logging frameworks so this is just a simple way to log to a file or the console

## Features  
-  **Simple:** Easily log messages with a straightforward library. 
- **Lightweight:** Provides only the bare necessities to log to a file or the console.

## Getting Started
Simply include the compiled DLL in your project
```csharp
Logger Log = new Logger();
Log.Debug("This is a debug log");
Log.Info("This is a info log");
Log.Warn("This is a warn log");
Log.Error("This is a error log");
Log.Fatal("This is a fatal log");
```
Too see how to change the target and level please see the examples
