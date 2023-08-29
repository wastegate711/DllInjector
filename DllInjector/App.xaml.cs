using System.Windows;
using DllInjector.ViewModels;
using DllInjector.Views;
using Prism.Ioc;

namespace DllInjector
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<MainWindow>();
            containerRegistry.RegisterSingleton<MainWindowViewModel>();
        }
    }
}
