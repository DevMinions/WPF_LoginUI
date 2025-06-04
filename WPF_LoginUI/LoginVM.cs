using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_LoginUI
{
    public class LoginVM : DependencyObject, INotifyPropertyChanged
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

        //public string Password
        //{
        //    get { return _loginModel.Password; }
        //    set
        //    {
        //        _loginModel.Password = value;
        //        OnPropertyChanged("Password");
        //    }
        //}

        void LoginFunc()
        {
            Console.WriteLine(_loginModel.Username);
            Console.WriteLine(_loginModel.Password);
            if (Username == "wpf" && MyPasswordVM == "456")
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
                MyPasswordVM = "";
            }
            //MyPasswordVM = DateTime.Now.ToString("HH:MM:ss.ffff");
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


        public string MyPasswordVM
        {
            get { return (string)GetValue(MyPasswordVMProperty); }
            set { SetValue(MyPasswordVMProperty, value); }

        }

        // Using a DependencyProperty as the backing store for MyPasswordVM.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPasswordVMProperty =
            DependencyProperty.Register("MyPasswordVM", typeof(string), typeof(LoginVM));


    }
}
