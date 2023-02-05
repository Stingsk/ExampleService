namespace Providers.Contracts.Search;

public class SearchRequest
{
    /// <summary>
    /// Адрес откуда
    /// </summary>
    public string AdressFrom { get; set; }
    /// <summary>
    /// Адрес куда
    /// </summary>
    public string AdressTo { get; set; }
    /// <summary>
    /// Класс поездки
    /// </summary>
    public string ServiceClass { get; set; }
    /// <summary>
    /// Дата и время отправления
    /// </summary>
    public DateTime OriginDate { get; set; }
}