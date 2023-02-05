
using ExampleService.Internal.Configuration;
using StackExchange.Redis;
using StackExchange.Redis.Extensions.Core.Configuration;
using StackExchange.Redis.Extensions.Core.Implementations;
namespace ExampleService.Internal.Cache;

public class RedisCacheProvider : ICacheProvider
{
    private readonly IConfigurationReader _configuration;
    private static readonly string _prefix = "b2brequestroutingservice_";
    private readonly IDatabase _db;

    /// <summary>
    /// Initializes a new instance of the <see cref="MemoryCacheProvider"/> class.
    /// </summary>
    /// <param name="configuration"></param>
    /// <summary>
    /// Initializes a new instance of the <see cref="MemoryCacheProvider"/> class.
    /// </summary>
    /// <param name="configuration"></param>
    public RedisCacheProvider(IConfigurationReader configuration)
    {
        _configuration = configuration;
        var connStringParts = _configuration.RedisServerConfigureConfig.Url.Split(':', 2);
        var port = 6379;

        if (connStringParts.Length == 2)
        {
            int.TryParse(connStringParts[1], out port);
        }

        var connectTimeout = _configuration?.RedisServerConfigureConfig?.Timeout?.TotalMilliseconds ?? 60000.0;
        var options = new ConfigurationOptions
        {
            ConnectTimeout = (int) connectTimeout,
            SyncTimeout = 10000,
            AbortOnConnectFail = false,

            EndPoints  = { {connStringParts[0], port } },
            Password = _configuration?.RedisServerConfigureConfig?.Password,
        };
        options.ClientName = "ExampleService";
        options.AllowAdmin = true;
        var conn = ConnectionMultiplexer.Connect(options);
        _db = conn.GetDatabase();
    }

    public async Task<string> Get(string cacheKey)
    {
        var result = await _db.StringGetAsync(_prefix + cacheKey);
        return result.HasValue ? result : default(string);
    }

    public async Task<bool> Set(string value, string key)
    {
        return await _db.StringSetAsync(key: _prefix + key, value: value, _configuration.RedisServerConfigureConfig.CacheTime);
    }

    public async Task<bool> KeyExists(string key)
    {
        return await _db.KeyExistsAsync(_prefix + key);
    }

    public Task KeyDelete(string key)
    {
        _db.KeyDeleteAsync(_prefix + key);
        return Task.CompletedTask;
    }
}