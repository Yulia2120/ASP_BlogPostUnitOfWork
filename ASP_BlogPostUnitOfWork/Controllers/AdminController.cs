﻿using Logic.Domain;
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
        public Task<List<Post>> GetAllPosts()
        {
            return _ofWork.PostRepository.GetAllAsync();
        }

        [HttpGet("id")]
        public Task<Post> GetPostId(int? id)
        {
           return _ofWork.PostRepository.GetByIdAsync(id);

        }

        [HttpPost]
        public Task<Post> AddPost([FromForm]Post post)
        {
            return _ofWork.PostRepository.CreateAsync(post);
        }
        [HttpPost("UpdatePost")]
        public Task<Post> UpdatePost(Post post)
        {
            return _ofWork.PostRepository.UpdateAsyncPost(post);
        }

        [HttpDelete("Delete")]
        public Task<bool> DeletePost(Post post)
        {
            return _ofWork.PostRepository.DeleteAsync(post);
        }


    }
}
//http://teddi2518-001-site1.gtempurl.com/api/Admin/