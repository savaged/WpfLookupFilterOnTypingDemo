using System.Windows;
using WpfLookupFilterOnTypingDemo.Services;
using WpfLookupFilterOnTypingDemo.ViewModels;

namespace WpfLookupFilterOnTypingDemo
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var lookupService = new LookupService();
            var modelService = new SampleModelService(
                lookupService);

            var viewModel = new MainViewModel(
                modelService,
                lookupService);

            var view = new MainWindow
            {
                DataContext = viewModel
            };
            view.Show();
        }
    }
}
