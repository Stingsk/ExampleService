using ExampleService.Internal.Dto;

namespace ExampleService.Internal.DataService;

/// <summary>
/// Клиент сервиса работы с данными 
/// </summary>

public interface IDataService
{
    /// <summary>
    /// Сохранить данные для заказа
    /// </summary>
    /// <param name="order">заказ</param>
    Task<string> SaveOrder(Order order);

    /// <summary>
    /// Получить заказ
    /// </summary>
    /// <param name="orderId">Ключ поиска данных</param>
    /// <returns>Данные order</returns>
    Task<Order> GetOrder(string orderId);

    /// <summary>
    /// Сохранить данные пассажира
    /// </summary>
    /// <param name="passengerInfo">Пассажир</param>
    Task SavePassengerInfo(PassengerInfo passengerInfo);

    /// <summary>
    /// Получить всех пассажиров заказа
    /// </summary>
    /// <param name="orderId">Ключ поиска данных</param>
    /// <returns>Данные order</returns>
    Task<List<PassengerInfo>> GetPassengerInfos(string orderId);

    /// <summary>
    /// Сохранить поездку для заказа
    /// </summary>
    /// <param name="routeInfo">Поездка</param>
    Task SaveOrder(RouteInfo routeInfo);

    /// <summary>
    /// Получить заказ
    /// </summary>
    /// <param name="orderId">Ключ поиска данных</param>
    /// <returns>Все поездки заказа</returns>
    Task<List<RouteInfo>> GetRouteInfos(string orderId);
}