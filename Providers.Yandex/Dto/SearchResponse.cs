namespace Providers.Yandex.Dto;

public class SearchResponse
{
    /// <summary>
    /// Стоимость
    /// </summary>
    public Decimal Fare;
    /// <summary>
    /// Время ожидания
    /// </summary>
    public TimeSpan WaiteTime;
    /// <summary>
    /// Дата и время отправления
    /// </summary>
    public DateTime OriginDate { get; set; }
    /// <summary>
    /// Информация об автомобиле
    /// </summary>
    public string CarInfo;
    /// <summary>
    /// Информация о водителе
    /// </summary>
    public string DriverInfo;
    /// <summary>
    /// Айди варианта
    /// </summary>
    public string VariantId;
}