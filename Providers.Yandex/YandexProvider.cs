using Microsoft.Extensions.Logging;
using Providers.Contracts;
using Providers.Contracts.Book;
using Providers.Contracts.Search;
using Providers.Yandex.Services;

namespace Providers.Yandex;

public class YandexProvider : IProviderService
{
    private readonly ISearchService _searchService;
    private readonly ILogger _logger;

    public YandexProvider(ISearchService searchService, ILogger logger)
    {
        _searchService = searchService;
        _logger = logger;
    }

    public YandexProvider()
    {
        throw new NotImplementedException();
    }

    public async Task<SearchResponse> Search(SearchRequest request)
    {
        return await _searchService.Search(request);
    }

    public Task<BookResponse> Book(BookRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<BookCancelResponse> BookCancel(BookCancelRequest request)
    {
        throw new NotImplementedException();
    }
}