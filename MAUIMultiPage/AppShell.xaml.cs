namespace MAUIMultiPage;

public partial class AppShell : Shell
{
	public AppShell(PageCollection pc)
	{
		InitializeComponent();

		homepage.ContentTemplate = new DataTemplate(pc.CreateMainPage);
		specialOpsPage.ContentTemplate = new DataTemplate(pc.CreateSpecialOpsPage);
	}
}
