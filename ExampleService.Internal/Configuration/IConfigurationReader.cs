namespace ExampleService.Internal.Configuration;

/// <summary>
/// Интерфейс настроек
/// </summary>
public class IConfigurationReader
{
    internal RedisServerConfigure RedisServerConfigureConfig { get; set; }

    /// <summary>
    /// Таймаут запроса
    /// </summary>
    public int TimeoutInSecond { get; set; }
}