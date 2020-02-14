using System.Threading.Tasks;
using cqrs_sample.Commands;
using cqrs_sample.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace cqrs_sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LoginController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public Task<LoginResult> Post(LoginCommand command)
        {
            var ret = _mediator.Send(command);
            return ret;
        }
    }
}
