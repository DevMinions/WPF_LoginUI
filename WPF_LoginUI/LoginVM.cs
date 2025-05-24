using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_LoginUI
{
    public class LoginVM : INotifyPropertyChanged
    {
        private MainWindow _main;
        public LoginVM(MainWindow main)
        {
            _main = main;
        }

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

        void LoginFunc()
        {
            if (Username == "wpf" && Password == "666")
            {
                //MessageBox.Show("ok");
                Index index = new Index();
                index.Show();

                _main.Hide();
            }
            else
            {
                MessageBox.Show("输入的用户名或者密码不正确");
                Username = "";
                Password = "";
            }
        }

        bool CanLoginExecute()
        {
            return true;
        }

        public ICommand LoginAction
        {
            get
            {
                return new RelayCommond(LoginFunc, CanLoginExecute);
            }
        }
    }
}
