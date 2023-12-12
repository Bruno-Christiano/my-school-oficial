using System.Collections.Generic;
using System.Windows;
using my_school.MVVM.ViewModel.UserViewModel;
using System.Windows.Controls;
using my_school.MVVM.View.Home;
using my_school.Services;

namespace my_school.MVVM.View.User.CreateUserView
{
    /// <summary>
    /// Interação lógica para CreateUserView.xam
    /// </summary>
    public partial class CreateUserView : UserControl
    {
        private readonly NavigationService _navigationService;
        public CreateUserView(NavigationService navigationService)
        {
            InitializeComponent();
            this._navigationService = navigationService;
            DataContext = new UserViewModel();
            //
            // // Crie uma lista de itens
            // List<Model.User.User> itens = new List<Model.User.User>
            // {
            //     new Model.User.User() { UserName = "João",Password = ""},
            // };
            //
            // // Atribua a lista à propriedade ItemsSource do DataGrid
            // meuDataGrid.ItemsSource = itens;
        }

        public void GoToHome(object sender, RoutedEventArgs e)
        {
             _navigationService.NavigateContentHome();
        }
        
    }
}
