using Embedly;
using Embedly.OEmbed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace embedly_tests
{
    public class EmbedlyTests : IClassFixture<EmbedlyClientFixture>
    {
        public readonly IEmbedlyService _embedlyService;
        public EmbedlyTests(EmbedlyClientFixture embedlyClient)
        {
            _embedlyService = embedlyClient._embedlyService;
        }


        [Fact]
        public async Task LoadRichContent()
        {
            var content = await _embedlyService.LoadContent("http://affordablepup.com");

            Assert.NotNull(content);
            Assert.True(content is EmbedRich);

            var rich = content as EmbedRich;

            Assert.Equal(ResourceType.link, content.Type);
            Assert.Equal("https://affordablepup.com/", rich.Url);
            Assert.Equal("https://affordablepup.com", rich.ProviderUrl);
            Assert.Equal("Affordablepup", rich.Provider);
            Assert.Equal("Puppies for sale in Ohio | Buy or adopt a puppy breed on Affordable Pup", rich.Title);
            Assert.Equal("Puppies for sale in Ohio - whether you want to adopt puppies or buy, search variety of AKC registered such as Yorkie, Maltese, Havanese, Cavalier, Pomeranian.", rich.Description);
            Assert.Equal("https://affordablepup.com/content/images/90-days-same-as-cash_banner.png", rich.ThumbnailUrl);
        }
    }
}
