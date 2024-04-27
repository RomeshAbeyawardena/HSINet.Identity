using System.Text.Json.Serialization;

namespace HSINet.Identity.Http;

public class Hypermedia
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public MetaCollection? Meta { get; internal set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public LinkCollection? Links { get; internal set; }
}
