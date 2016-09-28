using Embedly.OEmbed;
using EmbedlyClient.Extract;
using System.Threading.Tasks;

namespace Embedly
{
    public interface IEmbedlyService
    {
        Task<IEmbedContent> LoadContent(string url);

        Task<EmbedExtract> ExtractContent(string url);
    }
}
