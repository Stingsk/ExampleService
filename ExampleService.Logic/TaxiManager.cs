using ExampleService.Logic.Search;
using ExampleService.Сontracts.Book;
using ExampleService.Сontracts.Search;

namespace ExampleService.Logic;

public class TaxiManager : ITaxiManager
{
    private readonly ISearchService _searchService;
    public TaxiManager(ISearchService searchService)
    {
        _searchService = searchService;
    }
    public async Task<SearchResponse> Search(SearchRequest request)
    {
        return await _searchService.Search(request);
    }

    public async Task<BookResponse> Book(BookRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<BookCancelResponse> BookCancel(BookCancelRequest request)
    {
        throw new NotImplementedException();
    }
}