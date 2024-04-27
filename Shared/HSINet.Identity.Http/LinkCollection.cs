using System.Collections;
using System.Collections.Concurrent;

namespace HSINet.Identity.Http;

public class LinkCollection : IEnumerable<ILink>
{
    private readonly ConcurrentDictionary<string, ILink> _links;

    public LinkCollection()
    {
        _links = new ConcurrentDictionary<string, ILink>();
    }

    public LinkCollection Add(ILink link)
    {
        _links.TryAdd(link.Name 
            ?? throw new NullReferenceException("Link must have a name"), link);
        return this;
    }

    public LinkCollection Remove(ILink link)
    {
        _links.TryRemove(link.Name 
            ?? throw new NullReferenceException("Link must have a name"), out _);
        return this;
    }

    public IEnumerator<ILink> GetEnumerator()
    {
        return _links.Values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}