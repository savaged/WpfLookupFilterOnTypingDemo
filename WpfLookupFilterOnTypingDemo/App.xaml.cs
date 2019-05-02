using System.Windows;
using WpfLookupFilterOnTypingDemo.ViewModels;

namespace WpfLookupFilterOnTypingDemo
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var mainView = new MainWindow
            {
                DataContext = new MainViewModel()
            };
            mainView.Show();
        }
    }
}
