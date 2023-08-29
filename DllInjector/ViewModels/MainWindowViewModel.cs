using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Microsoft.Win32;
using Prism.Commands;
using Prism.Mvvm;

namespace DllInjector.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {

        }

        #region Свойства

        private string _libraryPath = "";

        /// <summary>
        /// Содержит путь к библиотеке которую нужно инжектить.
        /// </summary>
        public string LibraryPath
        {
            get => _libraryPath;
            set => SetProperty(ref _libraryPath, value);
        }

        private string _title = "DLL Injector";

        /// <summary>
        /// Заголовок окна.
        /// </summary>
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private ObservableCollection<Process> _listProcess;

        /// <summary>
        /// Список найденых процессов.
        /// </summary>
        public ObservableCollection<Process> ListProcess
        {
            get { return _listProcess; }
            set { SetProperty(ref _listProcess, value); }
        }

        #endregion

        #region Команды

        #region Открытие окна поиска библиотеки
        private DelegateCommand _findLibrary;

        /// <summary>
        /// Открытие окна поиска библиотеки.
        /// </summary>
        public DelegateCommand FindLibrary            =>
            _findLibrary ??= new DelegateCommand(ExecuteFindLibrary);

        private void ExecuteFindLibrary()
        {
            var ofd = new OpenFileDialog();
            ofd.Filter="(.dll)|*.dll";
            ofd.Title="Find Library";

            bool? result = ofd.ShowDialog();

            if(result==true)
            {
                LibraryPath = ofd.FileName;
            }
        }
        #endregion

        #region Обновить список процессов

        private DelegateCommand _refreshListProcess;

        /// <summary>
        /// Обновить список процессов
        /// </summary>
        public DelegateCommand RefreshListProcess =>
            _refreshListProcess ??= new DelegateCommand(ExecuteRefreshListProcess);

        private void ExecuteRefreshListProcess()
        {

        }

        #endregion

        #region Inject Dll

        private DelegateCommand _injectDll;

        /// <summary>
        /// Inject Dll
        /// </summary>
        public DelegateCommand InjectDll =>
            _injectDll ??= new DelegateCommand(ExecuteInjectDll);

        private void ExecuteInjectDll()
        {

        }

        #endregion
        #endregion
    }
}
