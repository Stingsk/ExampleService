using System.Net;

namespace Providers.Yandex.Client;

public class YandexClientFactory  : IHttpClientFactory
{
    private HttpClient _client;
    public HttpClient CreateClient(string name)
    {
        if (_client == null)
        {
            var uri = new Uri("https://yandex.ru/Taxi");
            var cred = new NetworkCredential("UserName", "Password");
            var credentialsCache = new CredentialCache { { uri, "NTLM",  cred} };
            var handler = new HttpClientHandler
            {
                MaxConnectionsPerServer = int.MaxValue , Credentials = credentialsCache, PreAuthenticate = true, AutomaticDecompression = DecompressionMethods.All,
            };
            _client = new HttpClient(handler) { BaseAddress = uri, Timeout = new TimeSpan(0, 0, 60) };
        }

        return _client;
    }
}