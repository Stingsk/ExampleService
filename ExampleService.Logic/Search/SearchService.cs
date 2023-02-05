using ExampleService.Internal.DataService;
using ExampleService.Сontracts.Search;
using NLog;
using Providers.Contracts;
using Providers.IWay;
using Providers.Yandex;

namespace ExampleService.Logic.Search;

public class SearchService : ISearchService
{
    private readonly SearchResponseMapper _searchResponseMapper;
    private readonly SearchRequestMapper _searchRequestMapper;
    private readonly ILogger _logger;
    private readonly IDataService _dataService;

    public SearchService(SearchResponseMapper searchResponseMapper, SearchRequestMapper searchRequestMapper, ILogger logger, IDataService dataService)
    {
        _searchResponseMapper = searchResponseMapper;
        _searchRequestMapper = searchRequestMapper;
        _logger = logger;
        _dataService = dataService;
    }

    public async Task<SearchResponse> Search(SearchRequest searchRequest)
    {
        List <IProviderService> providerServices = GetProvidrForSearch();
        var searchRequestProvider = _searchRequestMapper.MapFrom(searchRequest);
        var searchResponseProviderTasks = providerServices.Select(r => r.Search(searchRequestProvider));
        var searchResponseProvides =  await Task.WhenAll(searchResponseProviderTasks);
        var searchResponse = _searchResponseMapper.MapFrom(searchResponseProvides);

        return searchResponse;
    }

    private List<IProviderService> GetProvidrForSearch()
    {
        //TODO: Провайдеры берутся готовые и создаются в DI
        return new List<IProviderService>()
        {
            new WayService(),
            new YandexProvider()
        };
    }
}