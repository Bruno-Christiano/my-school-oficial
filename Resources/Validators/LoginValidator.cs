using FluentValidation;
using my_school.MVVM.Model.Auth;


namespace my_school.Resources.Validators
{
    internal class LoginValidator : AbstractValidator<Auth>
    {

        public LoginValidator()
        {
            int caracters = 4;
            RuleFor(auth => auth.UserName)
                .NotEmpty().WithMessage("Campo Obrigatório!")
                .DependentRules(() =>
                {
                    RuleFor(auth => auth.UserName)
                        .MinimumLength(caracters).WithMessage("Mínimo 4 caracteres");
                });

            RuleFor((auth => auth.Password)).NotEmpty().WithMessage("Campo Obrigatório!");
        }
    }
}
