using CommunityToolkit.Mvvm.ComponentModel;

namespace testi.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private ObservableObject _currentViewModel;

        public ObservableObject CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }

        public MainWindowViewModel()
        {
            CurrentViewModel = new LoginViewModel(this);
        }

        public void ShowHomeView(string username)
        {
            CurrentViewModel = new HomeViewModel(username);
        }
    }
}
