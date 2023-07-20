namespace MAUIMultiPage;

public partial class SpecialOps : ContentPage
{
    private readonly IHttpClientFactory _httpClientFactory;

    public SpecialOps(IHttpClientFactory httpClientFactory)
	{
		InitializeComponent();
        this._httpClientFactory = httpClientFactory;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var httpClient = _httpClientFactory.CreateClient();
        var result = await httpClient.GetAsync("https://dummy.restapiexample.com/api/v1/employees");
        txtResult.Text = await result.Content.ReadAsStringAsync();
    }
}