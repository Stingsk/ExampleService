namespace Providers.Yandex.Dto;

public class BookResponse
{
    /// <summary>
    /// Стоимость
    /// </summary>
    public Decimal Fare{ get; set; }
    /// <summary>
    /// Время ожидания
    /// </summary>
    public TimeSpan WaiteTime{ get; set; }
    /// <summary>
    /// Дата и время отправления
    /// </summary>
    public DateTime OriginDate { get; set; }
    /// <summary>
    /// Информация об автомобиле
    /// </summary>
    public string CarInfo{ get; set; }
    /// <summary>
    /// Информация о водителе
    /// </summary>
    public string DriverInfo { get; set; }
    /// <summary>
    /// Статус бронирования
    /// </summary>
    public string StatusBook{ get; set; }
}