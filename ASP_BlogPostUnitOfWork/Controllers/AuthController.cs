using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ASP_BlogPostUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUnitOfWork _ofWork;
        public AuthController(IUnitOfWork ofWork)
        {
            _ofWork = ofWork;

        }
        [Route("Login")]
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
          var user = _ofWork.AccountRepository.AuthenticateUser(email, password);          
            if (user != null)
            {
                //Generate JWT
            }
            return Unauthorized();
        }

    

    }
}
