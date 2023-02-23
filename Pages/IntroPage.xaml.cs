namespace BookStore.Pages;


public partial class IntroPage : ContentPage
{
	public IntroPage()
	{
		InitializeComponent();
		this.BindingContext = new ViewModel.IntroScreenViewModel();
	}
}