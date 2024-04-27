using System.Collections;
using System.Collections.Concurrent;

namespace HSINet.Identity.Http;

public class MetaCollection : IEnumerable<IMeta>
{
    private readonly ConcurrentDictionary<string, IMeta> _dataStore;

    public MetaCollection()
    {
        _dataStore = new ConcurrentDictionary<string, IMeta>();
    }

    public MetaCollection Add(IMeta meta)
    {
        _dataStore.TryAdd(meta.Name 
            ?? throw new NullReferenceException("Name is required"), meta);
        return this;
    }

    public MetaCollection Remove(string key)
    {
        _dataStore.TryRemove(key, out _);
        return this;
    }

    public IMeta? Get(string key)
    {
        _dataStore.TryGetValue(key, out var meta);
        return meta;
    }

    public IEnumerator<IMeta> GetEnumerator()
    {
        return _dataStore.Values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}