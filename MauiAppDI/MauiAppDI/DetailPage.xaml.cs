using MauiAppDI.Helpers;
using MauiAppDI.ViewModel;

namespace MauiAppDI;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}