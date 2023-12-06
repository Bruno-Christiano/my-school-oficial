using my_school.MVVM.ViewModel.UserViewModel;
using System.Windows.Controls;

namespace my_school.MVVM.View.User.CreateUserView
{
    /// <summary>
    /// Interação lógica para CreateUserView.xam
    /// </summary>
    public partial class CreateUserView : UserControl
    {
        public CreateUserView()
        {
            InitializeComponent();
            DataContext = new UserViewModel();
        }

    }
}
