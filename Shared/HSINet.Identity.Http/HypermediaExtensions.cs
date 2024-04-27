namespace HSINet.Identity.Http;

public static class HypermediaExtensions
{
    public static LinkCollection AddLink(this Hypermedia hypermedia, ILink link)
    {
        return (hypermedia.Links ??= []).Add(link); 
    }

    public static MetaCollection AddMeta(this Hypermedia hypermedia, IMeta meta)
    {
        return (hypermedia.Meta ??= []).Add(meta);
    }
}
