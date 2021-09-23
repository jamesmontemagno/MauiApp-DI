using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App(MainPage page)
        {
            InitializeComponent();

            MainPage = page;
        }
    }
}
