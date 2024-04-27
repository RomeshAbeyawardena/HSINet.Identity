using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;

namespace HSINet.Identity.Http;

public class LinkCollection : IReadOnlyDictionary<string, ILink>
{
    private readonly ConcurrentDictionary<string, ILink> _links;

    public IEnumerable<string> Keys => _links.Keys;
    public IEnumerable<ILink> Values => _links.Values;
    public int Count => _links.Count;

    public ILink this[string key] { get => _links[key]; }

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

    public bool ContainsKey(string key)
    {
        return _links.ContainsKey(key);
    }

    public bool TryGetValue(string key, [MaybeNullWhen(false)] out ILink value)
    {
        return _links.TryGetValue(key, out value);
    }

    IEnumerator<KeyValuePair<string, ILink>> IEnumerable<KeyValuePair<string, ILink>>.GetEnumerator()
    {
        return _links.GetEnumerator();
    }

    public IEnumerator GetEnumerator()
    {
        return GetEnumerator();
    }
}