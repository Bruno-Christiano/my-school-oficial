using System;
using System.Windows.Controls;
using my_school.MVVM.View.ContentHome;
using my_school.MVVM.View.Home;
using my_school.MVVM.View.User.CreateUserView;

namespace my_school.Services;

public class NavigationService
{
	private ContentControl mainContent;
	public NavigationService(ContentControl mainContent)
	{
		this.mainContent = mainContent;
	}
	
	
	public void NavigateContentHome()
	{
		mainContent.Content = new ContentHomeView(this);
	}
	
	public void NavigateToRegisterUser()
	{
		mainContent.Content = new CreateUserView(this);
	}
	
	
	// encontrar um forma de aplicar as navegações mudando apenas o params?
	// public void NavigateTo(UserControl userControl)
	// {
	// 	mainContent.Content = userControl;
	// }
	
}