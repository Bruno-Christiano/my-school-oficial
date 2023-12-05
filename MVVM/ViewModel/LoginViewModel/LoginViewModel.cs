﻿using FluentValidation.Results;
using my_school.MVVM.Model.Auth;
using my_school.MVVM.View;
using my_school.MVVM.View.Home;
using my_school.Resources.Validators;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace my_school.MVVM.ViewModel.LoginViewModel
{
  internal  class LoginViewModel: ReactiveObject
    {
        public Auth _auth;
        private LoginValidator _loginValidator;
        public ICommand LoginCommand { get; }

        public static string _colorError = "#FF0000";
       
        Color colorError = (Color)ColorConverter.ConvertFromString(_colorError);

        private static string _colorDefault = "#BEBEBE";

       readonly Color colorDefault = (Color)ColorConverter.ConvertFromString(_colorDefault);
        public string LabelText => "Usuário:";


        public LoginViewModel()
        {
            _auth = new Auth();
            LoginCommand = new RelayCommand(() => Login(_auth));
            _loginValidator = new LoginValidator();
            UserNameBorderError = new SolidColorBrush(colorDefault);
            UserPasswordBorderError = new SolidColorBrush(colorDefault);
      
        }

        public string UserName
        {
            get => _auth.UserName;
            set
            {
                if (_auth.UserName != value)
                {
                    _auth.UserName = value;
                    //validação séra feito dinamica, quando o usuário digitar
                    ValidateForm("UserName");
                    this.RaisePropertyChanged(nameof(UserName));
                }
            }
        }

        public string Password
        {
            get => _auth.Password;
            set
            {
                {
                    if (_auth.Password != value)
                    {
                        _auth.Password = value;
                        ValidateForm("Password");
                        this.RaisePropertyChanged(nameof(Password));
                    }
                }
            }
        }


        public string UserNameError
        {
            get => _auth.UserNameError;
            set
            {
                _auth.UserNameError = value;
                this.RaisePropertyChanged(nameof(UserNameError));
            }
        }

        public string UserPasswordError
        {
            get => _auth.UserPasswordError;
            set
            {
                _auth.UserPasswordError = value;
                this.RaisePropertyChanged(nameof(UserPasswordError));
            }
        }

        private SolidColorBrush _userNameBorderError;
        public SolidColorBrush UserNameBorderError
        {
            get => _userNameBorderError;
            set
            {
                _userNameBorderError = value;
                this.RaisePropertyChanged(nameof(UserNameBorderError));
            }
        }

        private SolidColorBrush _userPasswordBorderError;
        public SolidColorBrush UserPasswordBorderError
        {
            get => _userPasswordBorderError;
            set
            {
                _userPasswordBorderError = value;
                this.RaisePropertyChanged(nameof(UserPasswordBorderError));
            }
        }

        private static void GoToHomePage(Auth auth)
        {
            var homeViewModel = new HomeViewModel.HomeViewModel()
            { Auth = auth };
            var homeView = new HomeView { DataContext = homeViewModel };
            homeView.Show();
            //CloseLogin();
        }



        private void ShowValidationErrors(IEnumerable<ValidationFailure> errors)
        {
            foreach (var failure in errors)
            {
                switch (failure.PropertyName)
                {
                    case "UserName":
                        UserNameError = failure.ErrorMessage;
                        UserNameBorderError = new SolidColorBrush(colorError);
                        break;
                    case "Password":
                        UserPasswordError = failure.ErrorMessage;
                        UserPasswordBorderError = new SolidColorBrush(colorError);
                        break;
                }
            }
        }



        private void ShowAuthenticationError()
        {
            //var messageBox = new MessageBox(
            //    "Usuário inválido",
            //    "Acesso negado", MessageBoxIcon.Error)
            //{
            //    HorizontalButtonsPanelAlignment = HorizontalAlignment.Center
            //};

            //var result = messageBox.Show(
            //    new MessageBoxButton<MessageBoxResult>("Fechar",
            //        MessageBoxResult.Yes, SpecialButtonRole.IsDefault));
        }


        private static void CloseLogin()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window is LoginView loginView)
                {
                    loginView.Close();
                    break;
                }
            }
        }

        internal void ValidateForm(string? fieldName = null)
        {
            var loginValidator = _loginValidator.Validate(new Auth
            { UserName = UserName, Password = Password });
            // a validação do form acontece por qque vai ser chamdado a qualquer momento.
            switch (fieldName)
            {
                case "UserName":
                    UserNameError = string.Empty;
                    UserNameBorderError = new SolidColorBrush(colorDefault);
                    break;
                case "Password":
                    UserPasswordError = string.Empty;
                    UserPasswordBorderError = new SolidColorBrush(colorDefault);
                    break;
                default:
                    UserNameError = string.Empty;
                    UserPasswordError = string.Empty;
                    break;
            }


            if (!loginValidator.IsValid)
            {
                foreach (var failure in loginValidator.Errors)
                {
                    switch (failure.PropertyName)
                    {
                        case "UserName" when fieldName == "UserName":
                            UserNameError = failure.ErrorMessage;
                            UserNameBorderError = new SolidColorBrush(colorError);
                            break;
                        case "Password" when fieldName == "Password":
                            UserPasswordError = failure.ErrorMessage;
                            UserPasswordBorderError =
                                new SolidColorBrush(colorError);
                            break;
                    }
                }
            }
        }


        private void Login(Auth auth)
        {
            //using var dbContext = new ApplicationDbContext();
            //var authService = new AuthService(dbContext);
  
            string userName = auth.UserName;
            string password = auth.Password;

            var loginValidator = _loginValidator.Validate(new Auth
            { UserName = userName, Password = password });

            //if (loginValidator.IsValid)
            //{
            //    if (authService.AuthenticateUser(userName, password))
            //    {
            //        GoToHomePage(auth);
            //    }
            //    else
            //    {
            //        ShowAuthenticationError();
            //    }
            //}
            //else
            //{
            //    ShowValidationErrors(loginValidator.Errors);
            //}
        }

    }

   


}
