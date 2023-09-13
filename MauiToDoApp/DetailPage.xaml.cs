using MauiToDoApp.ViewModels;

namespace MauiToDoApp;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}