using XamarinAppShell.ViewModels;

namespace MauiApp1;

public partial class SPops : CommunityToolkit.Maui.Views.Popup
{
	public SPops()
	{
		InitializeComponent();
	}
	private void btnCancel_Clicked(object sender, EventArgs e)
	{
		Close();
    }

	private void btnSave_Clicked(object sender, EventArgs e)
	{
		PopupViewModel vm = new PopupViewModel();

		string field1 = F1.Text;
		Close(field1);
    }
}