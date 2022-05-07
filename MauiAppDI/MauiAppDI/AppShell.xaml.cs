namespace MauiAppDI;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
        Routing.RegisterRoute(nameof(AnotherPage), typeof(AnotherPage));
    }
}
