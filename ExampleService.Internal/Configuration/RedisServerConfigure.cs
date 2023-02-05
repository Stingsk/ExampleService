namespace ExampleService.Internal.Configuration;

public class RedisServerConfigure
{
    /// <summary>
    /// Url
    /// </summary>
    public string Url { get; set; }
    /// <summary>
    /// CacheDatabase
    /// </summary>
    public int CacheDatabase { get; set; }
    /// <summary>
    /// Password
    /// </summary>
    public string Password { get; set; }
    /// <summary>
    /// Время кэширования
    /// </summary>
    public TimeSpan CacheTime { get; set; }
    /// <summary>
    /// Таймаут
    /// </summary>
    public TimeSpan? Timeout { get; set; }
}