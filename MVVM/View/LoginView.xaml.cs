using my_school.MVVM.ViewModel.LoginViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace my_school.MVVM.View
{
    /// <summary>
    /// Lógica interna para LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
             DataContext = new LoginViewModel();

        }


        private void PasswordChanged( object sender, RoutedEventArgs e)
        {
            //atualzia o valor na viewModel forma mais simples para "passwordBox".
            var passwordBox = sender as PasswordBox;
            
            if (DataContext is LoginViewModel loginViewModel)
            {
                loginViewModel.Password = passwordBox?.Password;
                loginViewModel.ValidateForm("Password");
            }

            
        }

    }
}
