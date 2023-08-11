namespace MAUIMultiPage;

public partial class MainPage : ContentPage
{
    private readonly IHttpClientFactory _httpClientFactory;
    int count = 0;

	public MainPage(IHttpClientFactory httpClientFactory)
	{
		InitializeComponent();
        this._httpClientFactory = httpClientFactory;
    }

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);


        var httpClient = _httpClientFactory.CreateClient();
        var result = await httpClient.GetAsync("https://dummy.restapiexample.com/api/v1/employees");
        txtResult.Text = await result.Content.ReadAsStringAsync();
    }
}

