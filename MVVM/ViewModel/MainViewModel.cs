using Todo.Core;

namespace Todo.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCmd { get; set; }
        public RelayCommand AboutMeViewCmd { get; set; }
        public RelayCommand AgendaViewCmd { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public AboutMeViewModel AboutMeVM { get; set; }
        public AgendaViewModel AgendaVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            AboutMeVM = new AboutMeViewModel();
            AgendaVM = new AgendaViewModel();
            CurrentView = HomeVM;

            HomeViewCmd = new RelayCommand(o => { CurrentView = (HomeVM); });
            AboutMeViewCmd = new RelayCommand(o => { CurrentView = (AboutMeVM); });
            AgendaViewCmd = new RelayCommand(o => { CurrentView = (AgendaVM); });
        }
    }
}
