namespace PagesDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var navigationPage = new NavigationPage(new MainPage());
		navigationPage.BarTextColor = Colors.Yellow;

		MainPage = navigationPage;
	}
}
