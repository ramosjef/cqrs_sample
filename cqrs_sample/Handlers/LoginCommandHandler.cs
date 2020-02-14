using cqrs_sample.Commands;
using cqrs_sample.Results;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace cqrs_sample.Handlers
{
    public class LoginCommandHandler :
        IRequestHandler<LoginCommand, LoginResult>
    {
        private readonly ILogger<LoginCommandHandler> _logger;

        public LoginCommandHandler(ILogger<LoginCommandHandler> logger)
        {
            _logger = logger;
        }

        public Task<LoginResult> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Teste");

            return Task.FromResult(new LoginResult() { Success = true });
        }
    }
}
