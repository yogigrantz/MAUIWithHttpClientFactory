namespace MAUIMultiPage;

public class PageCollection
{
    private static IHttpClientFactory _httpClientFactory;

    public PageCollection(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public Func<object> CreateMainPage = () =>
    {
        return new MainPage(_httpClientFactory);
    };

    public Func<object> CreateSpecialOpsPage = () =>
    {
        return new SpecialOps(_httpClientFactory);
    };

}
