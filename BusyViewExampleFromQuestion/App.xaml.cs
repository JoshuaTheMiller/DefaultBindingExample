using System.Windows;

namespace BusyViewExampleFromQuestion
{
    public partial class App : Application
    {
        public App()
        {
            var viewModel = new MainWindowViewModel();
            var view = new MainWindow(viewModel);

            view.Show();
        }
    }
}
