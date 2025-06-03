using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace testi.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private readonly MainWindowViewModel _mainWindowViewModel;

        private string _username = "Gast";

        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        public IRelayCommand LoginCommand { get; }

        public LoginViewModel(MainWindowViewModel mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;
            LoginCommand = new RelayCommand(OnLogin);
        }

        private void OnLogin()
        {
            // Beispiel-Login-Check

            _mainWindowViewModel.ShowHomeView(Username);
        }
    }
}
