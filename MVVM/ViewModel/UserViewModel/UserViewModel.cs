using my_school.MVVM.Model.User;
using ReactiveUI;
using System.Collections.Generic;
using System.Windows.Input;

namespace my_school.MVVM.ViewModel.UserViewModel;

internal class UserViewModel : ReactiveObject
{
    private User _user;
    private string _selectedRole;
    public ICommand RegisterUserCommand { get; }

    public UserViewModel()
    {
        _user = new User()
        {
            Password = "",
            Role = "",
            UserName = ""
        };
        //RegisterUserCommand = new
        //    RelayCommand(() => RegisterUser(_user));
    }

    public List<string> Roles { get; } = new List<string>
    {
        "Informe a função",
        "Operador",
        "Gestor"
    };

    public List<User> Users { get; } = new List<User>
    {
       new User{UserName = "Bruno",Role = "ADM", Email = "",Password = "",},
       new User{UserName = "Bruno",Role = "ADM", Email = "",Password = "",},
       new User{UserName = "Bruno",Role = "ADM", Email = "",Password = "",},
       new User{UserName = "Bruno",Role = "ADM", Email = "",Password = "",},
       new User{UserName = "Bruno",Role = "ADM", Email = "",Password = "",},
       new User{UserName = "Bruno",Role = "ADM", Email = "",Password = "",},
       new User{UserName = "Bruno",Role = "ADM", Email = "",Password = "",},
       new User{UserName = "Bruno",Role = "ADM", Email = "",Password = "",},
       new User{UserName = "Bruno",Role = "ADM", Email = "",Password = "",},
       new User{UserName = "Bruno",Role = "ADM", Email = "",Password = "",},
       new User{UserName = "Bruno",Role = "ADM", Email = "",Password = "",}, 
       new User{UserName = "Bruno",Role = "ADM", Email = "",Password = "",},
       new User{UserName = "Bruno",Role = "ADM", Email = "",Password = "",},
        
        
    };
    
    public User User
    {
        get => _user;
        set
        {
            if (_user != value)
            {
                _user = value;
                this.RaisePropertyChanged(nameof(User));
            }
        }
    }


    //private static async Task<User> RegisterUser(User user)
    //{
    //    try
    //    {
    //        await using var dbContext = new ApplicationDbContext();
    //        var userService = new UserService(dbContext);
    //        user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
    //        await userService.SaveUser(user);

    //        var messageBox = new MessageBox(
    //            "Usuário criado com sucesso!",
    //            "Sucesso", MessageBoxIcon.Information )
    //        {
    //            HorizontalButtonsPanelAlignment = HorizontalAlignment.Center
    //        };

    //        var result = messageBox.Show(
    //            new MessageBoxButton<MessageBoxResult>("Fechar",
    //                MessageBoxResult.Yes, SpecialButtonRole.IsDefault));

    //        return user;
    //    }
    //    catch (Exception e)
    //    {
    //        Debug.WriteLine(e);
    //        throw;
    //    }
    //}
}