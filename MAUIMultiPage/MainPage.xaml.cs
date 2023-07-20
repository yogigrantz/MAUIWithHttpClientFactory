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

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

