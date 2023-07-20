namespace MAUIMultiPage;

public partial class App : Application
{
	public App(PageCollection pc)
	{
		InitializeComponent();

		MainPage = new AppShell(pc);
	}
}
