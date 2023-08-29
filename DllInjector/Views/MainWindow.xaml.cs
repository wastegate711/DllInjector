using System.Windows;
using DllInjector.ViewModels;
using Prism.Ioc;

namespace DllInjector.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IContainerProvider containerProvider)
        {
            InitializeComponent();
            DataContext = containerProvider.Resolve<MainWindowViewModel>();
        }
    }
}
