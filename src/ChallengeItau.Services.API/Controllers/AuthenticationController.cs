using ChallengeItau.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Mime;

namespace ChallengeItau.Services.API.Controllers
{
    [ApiController]
    [AllowAnonymous]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _service;

        public AuthenticationController(ILogger<AuthenticationController> logger, IAuthenticationService service)
        {
            this._service = service;
        }

        [Route("authentication/validatePassword")]
        [HttpPost]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public bool ValidatePassword(string password)
        {
            return this._service.IsValid(password);
        }
    }
}
