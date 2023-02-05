using ExampleService.Logic;
using ExampleService.Сontracts.Book;
using ExampleService.Сontracts.Search;
using Microsoft.AspNetCore.Mvc;

namespace ExampleService.Controllers;

/// <summary>
/// Поиск вариантов
/// </summary>
[ApiController]
[Produces("application/json")]
[Route("[controller]/[action]")]
public class TaxiController: ControllerBase
{
    private readonly ITaxiManager _taxiManager;
    public TaxiController(ITaxiManager taxiManager)
    {
        _taxiManager = taxiManager;
    }
    /// <summary>
    /// Поска вариантов поездки
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<ActionResult<SearchResponse>> Search(SearchRequest request)
    {
        return await _taxiManager.Search(request);
    }

    /// <summary>
    /// Бронирование
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<ActionResult<BookResponse>> Book(BookRequest request)
    {
        return await _taxiManager.Book(request);
    }

    /// <summary>
    /// Отмена бронирования
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<ActionResult<BookCancelResponse>> BookCancel(BookCancelRequest request)
    {
        return await _taxiManager.BookCancel(request);
    }
}