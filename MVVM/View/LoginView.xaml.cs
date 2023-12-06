using my_school.MVVM.ViewModel.LoginViewModel;
using System.Windows;
using System.Windows.Controls;

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


        private void PasswordChanged(object sender, RoutedEventArgs e)
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
