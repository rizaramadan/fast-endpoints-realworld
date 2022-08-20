namespace src.WebApi.Users.Login;

using FluentValidation;

public class LoginValidator : Validator<LoginRequest>
{
    public LoginValidator()
    {
        RuleFor(x => x.User)
            .NotNull()
            .WithMessage("User is required");

        RuleFor(x => x.User.Email)
            .NotEmpty()
            .WithMessage("Email required")
            .EmailAddress()
            .WithMessage("Email format must be valid");

        RuleFor(x => x.User.Password)
            .NotEmpty()
            .WithMessage("password is required");
    }
}