using Embedly.OEmbed;
using EmbedlyClient.Extract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Embedly
{
    public interface IEmbedlyService
    {
        Task<IEmbedContent> LoadContent(string url);

        Task<EmbedExtract> ExtractContent(string url);

        Task<List<EmbedExtract>> ExtractContent(string[] urls);
    }
}
