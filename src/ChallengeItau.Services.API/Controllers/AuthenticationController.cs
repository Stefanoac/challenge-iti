using ChallengeItau.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ChallengeItau.Services.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _service;

        public AuthenticationController(ILogger<AuthenticationController> logger, IAuthenticationService service)
        {
            this._service = service;
        }

        [Route("authentication/validatePassword")]
        [HttpPost]
        public bool ValidatePassword(string password)
        {
            return this._service.IsValid(password);
        }
    }
}
