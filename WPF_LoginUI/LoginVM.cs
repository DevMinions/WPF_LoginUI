using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LoginUI
{
    public class LoginVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private LoginModel _loginModel = new LoginModel();

        public string Username
        {
            get { return _loginModel.Username; }
            set
            {
                _loginModel.Username = value;
                OnPropertyChanged("Username");
            }
        }

        public string Password
        {
            get { return _loginModel.Password; }
            set
            {
                _loginModel.Password = value;
                OnPropertyChanged("Password");
            }
        }

    }
}
