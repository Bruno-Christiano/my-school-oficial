
using my_school.MVVM.Model.Auth;
using ReactiveUI;
using System.Windows.Controls;
using System.Windows.Input;

namespace my_school.MVVM.ViewModel.HomeViewModel;

internal class HomeViewModel : ReactiveObject
{
    private Auth _auth;
  
    public ICommand OpenWindowUserCommand { get; }
    
    private UserControl _createUserView;
    
    public HomeViewModel()
    {
        OpenWindowUserCommand =
            new RelayCommand(() => OpenWindowRegisterUser());
    }


    public Auth Auth
    {
        get => _auth;
        set
        {
            if (_auth != value)
            {
                _auth = value;
                this.RaisePropertyChanged(nameof(Auth));
            }
        }
    }
    
    
    public UserControl CreateUserView
    {
        get => _createUserView;
        set => this.RaiseAndSetIfChanged(ref _createUserView, value);
    }

    public void OpenWindowRegisterUser()
    {
       /* var userRegistrationView = new CreateUserView(); */// Substitua esta linha com sua lógica de criação do UserRegistrationView
        //CreateUserView = userRegistrationView;
        
    }


  
}