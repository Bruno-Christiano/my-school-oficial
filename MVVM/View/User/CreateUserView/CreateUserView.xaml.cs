using System;
using System.Collections.Generic;
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
using my_school.MVVM.ViewModel.UserViewModel;

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
