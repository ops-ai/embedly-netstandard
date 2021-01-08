using Embedly.OEmbed;
using EmbedlyClient.Extract;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Embedly
{
    public class EmbedlyService : IEmbedlyService
    {
        private readonly ILogger _logger;
        private readonly IConfigurationRoot _configuration;
        private readonly string _apiKey;
        private readonly string _apiVersion;
        private readonly int _maxWidth;
        private readonly int _maxHeight;

        public EmbedlyService(ILoggerFactory loggerFactory, IConfigurationRoot configuration)
        {
            _logger = loggerFactory.CreateLogger<EmbedlyService>();
            _configuration = configuration;
            _apiKey = _configuration["Embedly:apiKey"];
            _apiVersion = _configuration["Embedly:apiVersion"];
            _maxWidth = 580;
            _maxHeight = 403;
        }

        private string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        public async Task<IEmbedContent> LoadContent(string url)
        {
            using (var client = new HttpClient())
            {
                var payload = await(await client.GetAsync($"https://api.embed.ly/{_apiVersion}/oembed?key={_apiKey}&format=json&maxwidth={_maxWidth}&maxheight={_maxHeight}&url={Uri.EscapeDataString(url)}")).Content.ReadAsStringAsync();

                var obj = JsonConvert.DeserializeObject<Response>(payload);
                switch (obj.Type)
                {
                    case ResourceType.image:
                    case ResourceType.photo:
                        return JsonConvert.DeserializeObject<EmbedPhoto>(payload);
                    case ResourceType.video:
                        return JsonConvert.DeserializeObject<EmbedVideo>(payload);
                    case ResourceType.link:
                    case ResourceType.html:
                    case ResourceType.rss:
                    case ResourceType.xml:
                    case ResourceType.atom:
                    case ResourceType.json:
                    case ResourceType.ppt:
                    case ResourceType.audio:
                        return JsonConvert.DeserializeObject<EmbedRich>(payload);
                    default:
                        return JsonConvert.DeserializeObject<EmbedError>(payload);
                }
            }
        }

        public async Task<EmbedExtract> ExtractContent(string url)
        {
            var jsonSettings = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Populate
            };

            using (var client = new HttpClient())
            {
                var payload = await (await client.GetAsync($"https://api.embed.ly/{_apiVersion}/extract?key={_apiKey}&format=json&maxwidth={_maxWidth}&maxheight={_maxHeight}&url={Uri.EscapeDataString(url)}")).Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<EmbedExtract>(payload, jsonSettings);
            }
        }

        // Has to be used carefully, doesn't work with LexisNexis urls
        public async Task<List<EmbedExtract>> ExtractContent(string[] urls)
        {
            if (urls.Length > 10)
                throw new ArgumentException("The number of urls cannot exceed 10");

            var urlList = urls.Aggregate("", (acc, next) =>
            {
                if (string.IsNullOrWhiteSpace(next))
                    return acc;

                return (acc == "")
                    ? Uri.EscapeDataString(next)
                    : acc + "," + Uri.EscapeDataString(next);
            }); ;

            var jsonSettings = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Populate
            };

            using (var client = new HttpClient())
            {
                var payload = await (await client.GetAsync($"https://api.embed.ly/{_apiVersion}/extract?key={_apiKey}&format=json&maxwidth={_maxWidth}&maxheight={_maxHeight}&urls={urlList}")).Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<EmbedExtract>>(payload, jsonSettings);
            }
        }
    }
}
