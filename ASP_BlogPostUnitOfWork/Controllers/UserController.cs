using Logic.Domain;
using Logic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_BlogPostUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _ofWork;
        public UserController(IUnitOfWork ofWork)
        {
            _ofWork = ofWork;

        }
        [HttpGet]
        public Task<List<Post>> GetAllPosts()
        {
            return _ofWork.PostRepository.GetAllAsync();
        }
        [HttpGet("FindPostName")]
        public Task<Post> FindPostName(string title)
        {
            return _ofWork.PostRepository.FindPostName(title);
        }

    }
}
