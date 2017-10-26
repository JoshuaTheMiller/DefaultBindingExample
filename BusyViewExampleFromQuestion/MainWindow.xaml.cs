using System.Windows;

namespace BusyViewExampleFromQuestion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainWindowViewModel dataContext;

        public MainWindow(MainWindowViewModel dataContext)
        {
            this.DataContext = dataContext;

            InitializeComponent();
        }
    }
}
