using Providers.Yandex.Dto;
using BookCancelRequest = Providers.Yandex.Dto.BookCancelRequest;
using BookRequest = Providers.Yandex.Dto.BookRequest;
using SearchRequest = Providers.Yandex.Dto.SearchRequest;

namespace Providers.Yandex.Client;

public interface IYandexClient
{
    /// <summary>
    /// Поиск
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public Task<Token> Login(AuthData request);

    /// <summary>
    /// Поиск
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public Task<List<SearchResponse>> Search(SearchRequest request);

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