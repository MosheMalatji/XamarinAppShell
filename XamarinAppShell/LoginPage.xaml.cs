namespace XamarinAppShell;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private void BtnLogin_Clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("MainPage");
	}

    protected override bool OnBackButtonPressed()
    {
        return true;
    }
}