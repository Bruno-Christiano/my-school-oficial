using System.Windows;
using System.Windows.Controls;
using my_school.MVVM.View.User.CreateUserView;
using my_school.Services;

namespace my_school.MVVM.View.ContentHome;

public partial class ContentHomeView : UserControl
{
	private readonly NavigationService _navigationService;
	public ContentHomeView(NavigationService navigationService)
	{
		InitializeComponent();
		 this._navigationService = navigationService;

	}

	private void GoToRegisterUser(object sender, RoutedEventArgs e)
	{
		this._navigationService.NavigateToRegisterUser();
	}
}