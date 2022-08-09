using XamarinAppShell.Helpers;

namespace XamarinAppShell;

public partial class MainPage : ContentPage
{
	int count = 0;
	MessageHelper toast = new MessageHelper();

	public MainPage()
	{
		InitializeComponent();
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
	private void BtnLogOut_Clicked(object sender, EventArgs e)
	{
		Routing.RegisterRoute("LoginPage", typeof(LoginPage));
		Shell.Current.GoToAsync("LoginPage");
	}
	private async void ToastButton_Clicked(object sender, EventArgs e)
	{
		await toast.GenerateToast("Hello World");
	}
}

