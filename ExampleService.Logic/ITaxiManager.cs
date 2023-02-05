using ExampleService.Сontracts.Book;
using ExampleService.Сontracts.Search;

namespace ExampleService.Logic;

public interface ITaxiManager
{
    /// <summary>
    /// Поиск
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public Task<SearchResponse> Search(SearchRequest request);

    /// <summary>
    /// Бронирование
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public Task<BookResponse> Book(BookRequest request);

    /// <summary>
    /// Отмена бронирования
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public Task<BookCancelResponse> BookCancel(BookCancelRequest request);
}