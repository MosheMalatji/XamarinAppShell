namespace XamarinAppShell;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private async void BtnLogin_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("MainPage");
	}

    protected override bool OnBackButtonPressed()
    {
        return true;
    }
}