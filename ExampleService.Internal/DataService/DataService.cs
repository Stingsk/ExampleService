using ExampleService.Internal.Cache;
using ExampleService.Internal.Configuration;
using ExampleService.Internal.Dto;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ExampleService.Internal.DataService;

/// <inheritdoc />
public class DataService : IDataService
{
    private static readonly JsonSerializerSettings SerializerSettings = JsonSettings.GetJsonSerializerSettings();
    private readonly ICacheProvider _client;
    private readonly ILogger _logger;

    public DataService(ICacheProvider client, ILogger logger)
    {
        _client = client;
        _logger = logger;
    }

    public Task<string> SaveOrder(Order order)
    {
        throw new NotImplementedException();
    }

    public Task<Order> GetOrder(string orderId)
    {
        throw new NotImplementedException();
    }

    public Task SavePassengerInfo(PassengerInfo passengerInfo)
    {
        throw new NotImplementedException();
    }

    public Task<List<PassengerInfo>> GetPassengerInfos(string orderId)
    {
        throw new NotImplementedException();
    }

    public Task SaveOrder(RouteInfo routeInfo)
    {
        throw new NotImplementedException();
    }

    public Task<List<RouteInfo>> GetRouteInfos(string orderId)
    {
        throw new NotImplementedException();
    }
}
