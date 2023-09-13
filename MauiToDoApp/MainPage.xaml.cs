using MauiToDoApp.ViewModels;

namespace MauiToDoApp;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

