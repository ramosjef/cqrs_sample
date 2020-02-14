using cqrs_sample.Results;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace cqrs_sample.Commands
{
    public class LoginCommand : IRequest<LoginResult>
    {
        [Required]
        public string UserName { get; private set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; private set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; private set; }
    }
}
