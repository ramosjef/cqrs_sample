using cqrs_sample.Commands;
using FluentValidation;

namespace cqrs_sample.Validators
{
    public class LoginValidator : AbstractValidator<LoginCommand>
    {
        public LoginValidator()
        {
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.UserName).NotNull().EmailAddress();
        }
    }
}
