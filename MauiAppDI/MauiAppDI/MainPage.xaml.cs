using MauiAppDI.Helpers;
using MauiAppDI.ViewModel;

namespace MauiAppDI;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

