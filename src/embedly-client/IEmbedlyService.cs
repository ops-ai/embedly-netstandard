using System.Threading.Tasks;

namespace Embedly
{
    public interface IEmbedlyService
    {
        Task<OEmbed.IEmbedContent> LoadContent(string url);
    }
}
