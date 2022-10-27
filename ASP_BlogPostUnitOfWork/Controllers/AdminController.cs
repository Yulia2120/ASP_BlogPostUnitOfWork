using Logic.Domain;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ASP_BlogPostUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        private readonly IUnitOfWork _ofWork;
        public AdminController(IUnitOfWork ofWork)
        {
            _ofWork = ofWork;

        }

        [HttpGet]
        public Task<List<Post>> GetAllPost()
        {
            return _ofWork.PostRepository.GetAllAsync();
        }

        [HttpGet("id")]
        public Task<Post> GetPostId(int? id)
        {
           return _ofWork.PostRepository.GetByIdAsync(id);

        }

        [HttpPost]
        public Task<bool> AddPost(Post entity)
        {
            return _ofWork.PostRepository.CreateAsync(entity);
        }
        [HttpPost("UpdatePost")]
        public Task<Post> UpdatePost(int? id)
        {
            return _ofWork.PostRepository.UpdateAsyncPost(id);
        }

        [HttpDelete("Delete")]
        public Task<bool> DeletePost(Post post)
        {
            return _ofWork.PostRepository.DeleteAsync(post);
        }


    }
}
