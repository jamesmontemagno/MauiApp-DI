using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppDI.Model;

namespace MauiAppDI.ViewModel;

[QueryProperty(nameof(Count), nameof(Count))]
[QueryProperty(nameof(Monkey), nameof(Monkey))]
public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    Monkey monkey;

    [ObservableProperty]
    int count;

    IConnectivity connectivity;

    public DetailViewModel(IConnectivity connectivity)
    {
        this.connectivity = connectivity;

    }

    [RelayCommand]
    async Task CheckInternet()
    {
        var hasInternet = connectivity?.NetworkAccess == NetworkAccess.Internet;

        await App.Current.MainPage.DisplayAlert("Has Internet", hasInternet ? "YES!" : "NO!", "OK");
    }

    [RelayCommand]
    Task Back() => Shell.Current.GoToAsync("..");

    [RelayCommand]
    Task GoToAnother() => 
        Shell.Current.GoToAsync($"../{nameof(AnotherPage)}");
}