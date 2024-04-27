using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;

namespace HSINet.Identity.Http;

public class MetaCollection : IReadOnlyDictionary<string, IMeta>
{
    private readonly ConcurrentDictionary<string, IMeta> _dataStore;

    public IEnumerable<string> Keys => _dataStore.Keys;
    public IEnumerable<IMeta> Values => _dataStore.Values;
    public int Count => _dataStore.Count;

    public IMeta this[string key] { get => _dataStore[key]; }

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

    public bool ContainsKey(string key)
    {
        return _dataStore.ContainsKey(key);
    }

    public bool TryGetValue(string key, [MaybeNullWhen(false)] out IMeta value)
    {
        return _dataStore.TryGetValue(key, out value);
    }

    IEnumerator<KeyValuePair<string, IMeta>> IEnumerable<KeyValuePair<string, IMeta>>.GetEnumerator()
    {
        return _dataStore.GetEnumerator();
    }

    public IEnumerator GetEnumerator()
    {
        return GetEnumerator();
    }
}