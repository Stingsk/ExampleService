using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Providers.Yandex.Dto;

namespace Providers.Yandex.Client;

public class YandexClient : IYandexClient
{
    private readonly ILogger _logger;
    private readonly IHttpClientFactory _clientFactory;
    public YandexClient(ILogger logger,
        IHttpClientFactory clientFactory)
    {
        _logger = logger;
        _clientFactory = clientFactory;
    }

    public async Task<Token> Login(AuthData request)
    {
        return await Post<Token, AuthData>(request);
    }

    public async Task<List<SearchResponse>> Search(SearchRequest request)
    {
        return await Post<List<SearchResponse>, SearchRequest>(request);
    }

    public async Task<BookResponse> Book(BookRequest request)
    {
        return await Post<BookResponse, BookRequest>(request);
    }

    public async Task<BookCancelResponse> BookCancel(BookCancelRequest request)
    {
        return await Post<BookCancelResponse, BookCancelRequest>(request);
    }

    private async Task<TResponse> Post<TResponse, TRequest>(TRequest request)
    {
        var requestJson = JsonConvert.SerializeObject(request);
        _logger.LogInformation("Тело запроса:{NewLine}{RequestJson}", System.Environment.NewLine, (requestJson));
        var client = _clientFactory.CreateClient("Yandex");
        HttpContent httpContent = new StringContent(requestJson);
        var response = await client.PostAsync("https://yandx.ru/taxi", httpContent).ConfigureAwait(false);

        var responseData = await response.Content.ReadAsStringAsync();
        _logger.LogInformation("Тело ответа:{NewLine}{ResponseData}", System.Environment.NewLine, (responseData));

        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException(responseData);
        }

        var responseDeserialized = JsonConvert.DeserializeObject<TResponse>(responseData);

        return responseDeserialized;
    }
}