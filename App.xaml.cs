using my_school.MVVM.View;
using my_school.MVVM.View.Home;
using System.Windows;

namespace my_school
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
           // LoginView mainWindow = new LoginView();
              HomeView mainWindow = new HomeView();

            mainWindow.Width = 1366;
            mainWindow.Height = 768;
            mainWindow.Show();
            
        }
    }
}
