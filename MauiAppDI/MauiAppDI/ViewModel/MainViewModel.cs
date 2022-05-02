using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiAppDI.ViewModel;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    int count;

    [ICommand]
    void IncrementCount()
    {
        Count += 10;
    }

    [ICommand]
    async Task Navigate() =>
        await AppShell.Current.GoToAsync(nameof(DetailPage));
}