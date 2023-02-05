using ExampleService.Сontracts.Search;

namespace ExampleService.Logic.Search;

public interface ISearchService
{
    public Task<SearchResponse> Search(SearchRequest searchRequest);
}