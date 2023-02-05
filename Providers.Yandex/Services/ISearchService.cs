using Providers.Contracts.Search;

namespace Providers.Yandex.Services;

public interface ISearchService
{
    public Task<SearchResponse> Search(SearchRequest searchRequest);
}