using ExampleService.Internal.Dto.Enum;

namespace ExampleService.Internal.Dto;

[Serializable]
public class RouteInfo
{
    /// <summary>
    /// Айди заказа
    /// </summary>
    public int OrderId { get; set; }
    /// <summary>
    /// Айди маршрута
    /// </summary>
    public int RouteId { get; set; }
    /// <summary>
    /// Отчка отправления
    /// </summary>
    public string OriginPoint { get; set; }
    /// <summary>
    /// Точка прибытия
    /// </summary>
    public string DestinationPoint { get; set; }
    /// <summary>
    /// Дата и время отправления
    /// </summary>
    public DateTime OriginDate { get; set; }
    /// <summary>
    /// Дата и время прибытия
    /// </summary>
    public DateTime DestinationDate { get; set; }
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