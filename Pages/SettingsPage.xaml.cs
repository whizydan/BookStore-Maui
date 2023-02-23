namespace BookStore.Pages;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}

    private void light_Clicked(object sender, EventArgs e)
    {
        //set theme to light mode
        Application.Current.UserAppTheme = AppTheme.Light;
    }

    private void EnterLight(object sender, EventArgs e)
    {
        //set theme to dark mode
        Application.Current.UserAppTheme = AppTheme.Dark;
    }
}