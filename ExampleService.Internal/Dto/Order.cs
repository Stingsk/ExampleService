using ExampleService.Internal.Dto.Enum;

namespace ExampleService.Internal.Dto;

public class Order
{
    /// <summary>
    /// Айди заказа
    /// </summary>
    public int OrderId { get; set; }
    /// <summary>
    /// Тариф
    /// </summary>
    public decimal Fare { get; set; }
    /// <summary>
    /// Чаевые
    /// </summary>
    public decimal Tips { get; set; }
    /// <summary>
    /// Статус маршрута
    /// </summary>
    public StatusRoute Status { get; set; }
}