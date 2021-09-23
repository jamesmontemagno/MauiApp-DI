using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;
using System.Windows.Input;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public MainPage(CounterViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }

    public class CounterViewModel : BindableObject
    {

        ICommand clickedCommand;
        public ICommand ClickedCommand => clickedCommand ??= new Command(IncrementCount);

        private void IncrementCount()
        {
            Count+=10;
        }

        private int count = 0;
        public int Count
        {
            get => count;
            set
            {
                count = value;
                OnPropertyChanged();
            }
        }
    }
}
