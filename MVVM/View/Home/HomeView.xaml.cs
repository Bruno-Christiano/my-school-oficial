using my_school.MVVM.ViewModel.HomeViewModel;
using System.Windows;

namespace my_school.MVVM.View.Home
{
    /// <summary>
    /// Lógica interna para HomeView.xaml
    /// </summary>
    public partial class HomeView : Window
    {
        public HomeView()
        {
            InitializeComponent();
            DataContext = new HomeViewModel();

        }
    }
}
