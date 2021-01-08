using Embedly;
using Embedly.OEmbed;
using System.Threading.Tasks;
using Xunit;

namespace Embedly_client.Tests
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
            var content = await _embedlyService.LoadContent("https://premierpups.com");

            Assert.NotNull(content);
            Assert.True(content is EmbedRich);

            var rich = content as EmbedRich;

            Assert.Equal(ResourceType.link, content.Type);
            Assert.Equal("https://premierpups.com", rich.Url);
            Assert.Equal("https://premierpups.com", rich.ProviderUrl);
            Assert.Equal("Premierpups", rich.Provider);
            Assert.Equal("Small breed puppies for sale | Teacup Pups for sale in Ohio - Premier Pups", rich.Title);
            Assert.Equal("Welcome! Premier Pups mindfully selects puppies from reputable breeders in Ohio and provides their customers the most adorable small breed puppies. We are located in Johnstown, Ohio, about 20 minutes northeast of Columbus. We have the most adorable small breed puppies for sale in Ohio and nearby states: Yorkie, Morkie, Maltese, Havanese, Cavalier King, Pomeranian, Cavachon, Cavapoo, Yorkie Poo, Cavalier King Charles Spaniel.", rich.Description);
            Assert.Equal("https://premierpups.com/Content/images/logo.gif", rich.ThumbnailUrl);
        }
    }
}
