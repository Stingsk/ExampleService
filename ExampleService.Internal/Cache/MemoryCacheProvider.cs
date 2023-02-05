using ExampleService.Internal.Configuration;
using Microsoft.Extensions.Caching.Memory;

namespace ExampleService.Internal.Cache;

/// <summary>
/// Реализация для MemoryCache
/// </summary>
/// <seealso cref="ICacheProvider" />
public class MemoryCacheProvider : ICacheProvider
{
    
    private readonly IConfigurationReader _configuration;
    private static readonly MemoryCache Cache = new MemoryCache(new MemoryCacheOptions { });

    /// <summary>
    /// Initializes a new instance of the <see cref="MemoryCacheProvider"/> class.
    /// </summary>
    /// <param name="configuration"></param>
    public MemoryCacheProvider(IConfigurationReader configuration)
    {
        _configuration = configuration;
    }

    public Task<string> Get(string cacheKey)
    {
        if (Cache.TryGetValue(cacheKey, out string result))
        {
            return Task.FromResult(result);
        }

        return default;
    }


    public Task<bool> Set(string value, string key)
    {
        Cache.Set(key, value);

        return Task.FromResult<bool>(true);
    }

    public Task<bool> KeyExists(string key)
    {
        var item = Cache.Get(key);

        return Task.FromResult(item != null);
    }

    public Task KeyDelete(string key)
    {
        Cache.Remove(key);

        return Task.CompletedTask;
    }
}