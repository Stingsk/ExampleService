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

    public async Task<string> SaveOrder(Order order)
    {
        var orderId = order.OrderId.ToString();
        string value = JsonConvert.SerializeObject(order, SerializerSettings);
        await _client.Set(value, orderId);

        return orderId;
    }

    public async Task<Order> GetOrder(string orderId)
    {
        var value = await _client.Get(orderId);
        var order = JsonConvert.DeserializeObject<Order>(value, SerializerSettings);
        return await Task.FromResult(order) ?? Task.FromResult<>(null);
    }

    public async Task<string> SavePassengerInfo(PassengerInfo passengerInfo)
    {
        var passengerId = passengerInfo.PassengerId.ToString();
        string value = JsonConvert.SerializeObject(passengerInfo, SerializerSettings);
        await _client.Set(value, passengerId);

        return passengerId;
    }

    public async Task<List<PassengerInfo>> GetPassengerInfos(string orderId)
    {
        var value = await _client.Get(orderId);
        var passengerInfos = JsonConvert.DeserializeObject<List<PassengerInfo>>(value, SerializerSettings);
        return await Task.FromResult(passengerInfos) ?? Task.FromResult<>(null);
    }

    public async Task<string> SaveRouteInfo(RouteInfo routeInfo)
    {
        var routeId = routeInfo.RouteId.ToString();
        string value = JsonConvert.SerializeObject(routeInfo, SerializerSettings);
        await _client.Set(value, routeId);

        return routeId;
    }

    public async Task<List<RouteInfo>> GetRouteInfos(string orderId)
    {
        var value = await _client.Get(orderId);
        var routeInfos = JsonConvert.DeserializeObject<List<RouteInfo>>(value, SerializerSettings);
        return await Task.FromResult(routeInfos) ?? Task.FromResult<>(null);
    }
}
