using Prism.Mvvm;

namespace InjectTestDll.ViewModels;

public class MainWindowViewModel : BindableBase
{
    public MainWindowViewModel()
    {
        
    }

    private string _title = "Test DLL";

    /// <summary>
    /// Заголовок окна.
    /// </summary>
    public string Tile
    {
        get => _title;
        set => SetProperty(ref _title, value);
    }
}