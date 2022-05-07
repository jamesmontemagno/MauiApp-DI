using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppDI.Model;

namespace MauiAppDI.ViewModel;

public partial class MainViewModel : ObservableObject
{
    Monkey monkey;
    public MainViewModel()
    {
        monkey = new Monkey { Name = "Mooch" };
    }

    [ObservableProperty]
    int count;

    [ICommand]
    void IncrementCount()
    {
        Count += 10;
    }

    [ICommand]
    Task Navigate() => 
        Shell.Current.GoToAsync($"{nameof(DetailPage)}?Count={Count}",
            new Dictionary<string, object>
            {
                ["Monkey"] = monkey
            });
}