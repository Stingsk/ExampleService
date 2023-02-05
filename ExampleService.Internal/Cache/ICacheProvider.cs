namespace ExampleService.Internal.Cache;

/// <summary>
/// итерфейс для доступа к кешу
/// </summary>
public interface ICacheProvider
{
    Task<string> Get(string cacheKey);
    Task<bool> Set(string value, string key);
    Task<bool> KeyExists(string key);
    Task KeyDelete(string key);
}