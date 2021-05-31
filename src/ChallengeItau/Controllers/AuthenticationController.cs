using Microsoft.AspNetCore.Mvc;

namespace ChallengeItau.Controllers
{
    [ApiController]
    [Route("[authentication]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _service;

        public AuthenticationController(IAuthenticationService service)
        {
            this._service = service;
        }


        [Route("authentication/passwordValidation")]
        [HttpPost]

    }
}
