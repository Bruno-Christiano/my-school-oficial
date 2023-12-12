
using my_school.MVVM.Model.Auth;
using ReactiveUI;
using System.Windows.Controls;
using System.Windows.Input;
using my_school.Services;

namespace my_school.MVVM.ViewModel.HomeViewModel;

internal class HomeViewModel : ReactiveObject
{
    private Auth _auth;
    public ICommand GoToRegisterUserCommand { get; }

    private UserControl _createUserView;
    private NavigationService _navigationService;

    public HomeViewModel()
    {
        GoToRegisterUserCommand =
            new RelayCommand(() => GoToRegisterUser());
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

    
    public void GoToRegisterUser()
    {
        this._navigationService.NavigateToRegisterUser();
    }
    

}