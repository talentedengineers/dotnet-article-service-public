using DotNetArticleService.Domain.Entities;
using DotNetArticleService.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotNetArticleService.Controllers
{
    [Route("api/articles")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet]
        public async Task<Article> Get(Guid id)
        {
            var userId = string.Empty; // TODO

            return await _articleService.Find(userId, id);
        }
    }
}
