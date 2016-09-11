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

## Version 1.0.0
* Created embedly client for AspNet Standard/Core



