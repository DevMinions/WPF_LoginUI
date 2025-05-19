using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_LoginUI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //LoginModel loginModel;
        private LoginVM loginVM;

        public MainWindow()
        {
            InitializeComponent();
            //loginModel = new LoginModel();
            loginVM = new LoginVM();
            this.DataContext = loginVM;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string username = txtUsername.Text;
            //string password = txtPassword.Text;

            if (loginVM.LoginModel.Username == "wpf" && loginVM.LoginModel.Password == "666")
            {
                //MessageBox.Show("ok");
                Index index = new Index();
                index.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("输入的用户名或者密码不正确");
                loginVM.LoginModel.Username = "";
                loginVM.LoginModel.Password = "";
                loginVM.LoginModel = loginVM.LoginModel;
            }
        }
    }

    //public class LoginModel: INotifyPropertyChanged
    //{
    //    public event PropertyChangedEventHandler PropertyChanged;
    //    protected void OnPropertyChanged(string propertyName)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }
    //}
}
