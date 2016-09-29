# Embed.ly client for .NET Standard / .NET Core

Asynchronous, ASP.NET Core client for embed.ly

## Getting Started
Install the [embedly-client](https://www.nuget.org/packages/embedly-client) library through [NuGet](https://nuget.org).

    Install-Package embedly-client

Usage:

```csharp
public IServiceProvider ConfigureServices(IServiceCollection services)
{
	...
	
	services.AddScoped<IEmbedlyService, EmbedlyService>();
	
	...
}
```

```csharp
	var content = await _embedlyService.LoadContent(url);

  if (content == null || content.Type == ResourceType.error)
      return null;
      
  ...
  
```

## Version 1.0.4
* Added support for multiple url extract
* Added .NET Framework 4.6

## Version 1.0.3
* Added support for embed.ly extract

## Version 1.0.2
* Added unit tests
* Fixed embedly service used for OEmbeds

## Version 1.0.1
* Removed unused nuget packages

## Version 1.0.0
* Created embedly client for AspNet Standard/Core



