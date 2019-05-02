using System.Windows;
using WpfLookupFilterOnTypingDemo.ViewModels;

namespace WpfLookupFilterOnTypingDemo
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var view = new MainWindow
            {
                DataContext = new MainViewModel()
            };
            view.Show();
        }
    }
}
