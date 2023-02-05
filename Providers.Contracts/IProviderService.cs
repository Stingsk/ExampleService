using Providers.Contracts.Book;
using Providers.Contracts.Search;

namespace Providers.Contracts;

public interface IProviderService
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