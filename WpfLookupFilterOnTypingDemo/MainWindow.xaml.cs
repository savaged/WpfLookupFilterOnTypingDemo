using System;
using System.Windows;
using WpfLookupFilterOnTypingDemo.ViewModels;

namespace WpfLookupFilterOnTypingDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void OnSourceInitialized(object sender, EventArgs e)
        {
            var vm = DataContext as MainViewModel;
            await vm?.LoadAsync();
        }
    }
}
