using Embedly;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace embedly_tests
{

    public class EmbedlyClientFixture : IDisposable
    {
        public readonly ILoggerFactory _loggerFactory;
        public readonly IEmbedlyService _embedlyService;
        public IConfigurationRoot Configuration { get; set; }

        public EmbedlyClientFixture()
        {
            _loggerFactory = new LoggerFactory();

            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.Test.json", true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();

            _embedlyService = new EmbedlyService(_loggerFactory, Configuration);
        }

        public void Dispose()
        {

        }
    }
}
