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
        private LoginModel _loginModel;

		public LoginModel LoginModel
        {
			get {
				if (_loginModel == null)
					_loginModel = new LoginModel();
				return _loginModel; 
			}
			set { 
                _loginModel = value; 
                OnPropertyChanged("LoginModel");
            }
		}
	}
}
