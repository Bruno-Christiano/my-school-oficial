using my_school.MVVM.ViewModel.HomeViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using my_school.MVVM.View.User.CreateUserView;
using NavigationService = my_school.Services.NavigationService;

namespace my_school.MVVM.View.Home
{
    /// <summary>
    /// Lógica interna para HomeView.xaml
    /// </summary>
    public partial class HomeView : Window
    {
        private readonly NavigationService _navigationService;
        private CreateUserView _createUserView;
        public HomeView()
        {
            InitializeComponent();
             _navigationService = new NavigationService(MainContent);
            // this._createUserView = new CreateUserView(_navigationService);
            _navigationService.NavigateContentHome();
            // DataContext = _createUserView;

        }
        
        private void GoToRegisterUser(object sender, RoutedEventArgs e)
        {

            if (DataContext is HomeViewModel homeViewModel)
            {
                homeViewModel.GoToRegisterUser();
            }
           
        }
      
    }
}
