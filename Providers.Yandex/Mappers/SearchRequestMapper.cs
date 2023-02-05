
using Providers.Yandex.Dto;

namespace Providers.Yandex.Mappers;

public class SearchRequestMapper
{
    public SearchRequest MapFrom(Providers.Contracts.Search.SearchRequest searchRequest)
    {
        return new SearchRequest()
        {
            AdressFrom = searchRequest.AdressFrom,
            AdressTo = searchRequest.AdressTo,
            OriginDate = searchRequest.OriginDate,
            ServiceClass = searchRequest.ServiceClass
        };
    }
}