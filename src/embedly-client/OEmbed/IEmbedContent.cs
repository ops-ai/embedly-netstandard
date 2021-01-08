namespace Embedly.OEmbed
{
    /// <summary>
    /// Represents an oEmbed result
    /// </summary>
    public interface IEmbedContent
    {
        string Id { get; set; }

        ResourceType Type { get; }
    }
}