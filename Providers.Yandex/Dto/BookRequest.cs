namespace Providers.Yandex.Dto;

public class BookRequest
{
    public string FirstName { get; set; }
    /// <summary>
    /// Фамилия
    /// </summary>
    public string LastName { get; set; }
    /// <summary>
    /// Отчество и/или мидлимя
    /// </summary>
    public string MiddleName { get; set; }
    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateTime DayOfBirth { get; set; }
    /// <summary>
    /// Номер документа
    /// </summary>
    public string DocumentNumber { get; set; }
    /// <summary>
    /// Выбранный вариант
    /// </summary>
    public string VariantId { get; set; }
}