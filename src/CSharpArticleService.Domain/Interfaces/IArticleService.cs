using CSharpArticleService.Domain.Entities;

namespace CSharpArticleService.Domain.Interfaces
{
    public interface IArticleService
    {
        Task<Article> Create(string userId, string title, string html);

        Task<Article> Find(string userId, Guid id);
    }
}
