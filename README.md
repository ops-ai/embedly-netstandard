# Embed.ly client for .NET Standard / .NET Core

Asynchronous, ASP.NET Core client for embed.ly

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=ops-ai_embedly-standard&metric=alert_status)](https://sonarcloud.io/dashboard?id=ops-ai_embedly-standard)
[![Build Status](https://opsai.visualstudio.com/BeyondAuth/_apis/build/status/ops-ai.embedly-netstandard?branchName=develop)](https://opsai.visualstudio.com/BeyondAuth/_build/latest?definitionId=8&branchName=develop)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=ops-ai_embedly-standard&metric=vulnerabilities)](https://sonarcloud.io/dashboard?id=ops-ai_embedly-standard)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=ops-ai_embedly-standard&metric=coverage)](https://sonarcloud.io/dashboard?id=ops-ai_embedly-standard)
![CodeQL](https://github.com/ops-ai/embedly-netstandard/workflows/CodeQL/badge.svg)

[![NuGet Status](https://img.shields.io/nuget/v/embedly-client.svg?style=flat)](https://www.nuget.org/packages/embedly-client/)
[![NuGet Count](https://img.shields.io/nuget/dt/embedly-client.svg)](https://www.nuget.org/packages/embedly-client/)

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

## Version 1.0.5
* Replaced UrlEncoder.Default.Encode with Uri.EscapeDataString

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



