namespace ExampleService.Internal.Dto;

public class PassengerInfo
{
    /// <summary>
    /// Айди заказа
    /// </summary>
    public int OrderId { get; set; }
    /// <summary>
    /// Айди пассажира
    /// </summary>
    public int PassengerId { get; set; }
    /// <summary>
    /// Имя
    /// </summary>
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
}