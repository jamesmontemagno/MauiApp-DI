using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiAppDI.ViewModel;

public partial class DetailViewModel : ObservableObject
{

    IConnectivity connectivity;

    public DetailViewModel(IConnectivity connectivity)
    {
        this.connectivity = connectivity;
    }

    [ICommand]
    async Task CheckInternet()
    {
        var hasInternet = connectivity?.NetworkAccess == NetworkAccess.Internet;

        await App.Current.MainPage.DisplayAlert("Has Internet", hasInternet ? "YES!" : "NO!", "OK");
    }
}