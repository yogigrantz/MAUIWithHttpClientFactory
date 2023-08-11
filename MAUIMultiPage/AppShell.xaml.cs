using System.Net.Http;

namespace MAUIMultiPage;

public partial class AppShell : Shell
{
	public AppShell(IHttpClientFactory httpClientFactory)
	{
		InitializeComponent();

		homepage.ContentTemplate = new DataTemplate(() => new MainPage(httpClientFactory));
		specialOpsPage.ContentTemplate = new DataTemplate(() => new SpecialOps(httpClientFactory));
	}
}
