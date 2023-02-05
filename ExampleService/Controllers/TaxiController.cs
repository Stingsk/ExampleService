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
    /// <summary>
    /// Поска вариантов поездки
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<ActionResult<SearchResponse>> Search(SearchRequest request)
    {
        return new ActionResult<SearchResponse>(new SearchResponse());
    }

    /// <summary>
    /// Бронирование
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<ActionResult<BookResponse>> Book(BookRequest request)
    {
        return new ActionResult<BookResponse>(new BookResponse());
    }

    /// <summary>
    /// Отмена бронирования
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<ActionResult<BookCancelResponse>> BookCancel(BookCancelRequest request)
    {
        return new ActionResult<BookCancelResponse>(new BookCancelResponse());
    }
}