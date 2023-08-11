namespace MAUIMultiPage;

public partial class App : Application
{
	public App(IHttpClientFactory httpClientFactory)
	{
		InitializeComponent();

		MainPage = new AppShell(httpClientFactory);
	}
}
