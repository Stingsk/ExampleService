
using Providers.Contracts.Search;

namespace Providers.Yandex.Mappers;

public class SearchResponseMapper
{
    public SearchResponse MapFrom(List<Providers.Yandex.Dto.SearchResponse> searchResponse)
    {
        return new SearchResponse();
    }
}