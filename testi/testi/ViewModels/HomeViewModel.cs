using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testi.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public string Username { get; }

        public HomeViewModel(string username)
        {
            Username = username;
        }
    }
}
