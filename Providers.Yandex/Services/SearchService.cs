using Providers.Yandex.Client;
using Providers.Yandex.Dto;
using Providers.Yandex.Mappers;
using SearchRequest = Providers.Contracts.Search.SearchRequest;
using SearchResponse = Providers.Contracts.Search.SearchResponse;

namespace Providers.Yandex.Services;

public class SearchService : ISearchService
{
    private readonly SearchRequestMapper _searchRequestMapper;
    private readonly SearchResponseMapper _searchResponseMapper;
    private readonly IYandexClient _client;
    private readonly AuthData _authData;
    public SearchService(SearchRequestMapper searchRequestMapper,
        SearchResponseMapper searchResponseMapper,
        IYandexClient client,
        AuthData authData)
    {
        _searchRequestMapper = searchRequestMapper;
        _searchResponseMapper = searchResponseMapper;
        _client = client;
        _authData = authData;
    }

    public async Task<SearchResponse> Search(SearchRequest searchRequest)
    {
        var token = await _client.Login(_authData);
        var searchRequestYandex = _searchRequestMapper.MapFrom(searchRequest);
        searchRequestYandex.Token = token;
        var searchResponseYandex = await _client.Search(searchRequestYandex);

        return _searchResponseMapper.MapFrom(searchResponseYandex);
    }
}