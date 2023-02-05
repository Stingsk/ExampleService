using Providers.Contracts;
using Providers.Contracts.Book;
using Providers.Contracts.Search;

namespace Providers.IWay;

public class WayService : IProviderService
{
    public Task<SearchResponse> Search(SearchRequest request)
    {
        throw new NotImplementedException();
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