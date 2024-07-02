namespace DotNetArticleService.Domain.Entities
{
    public class Article
    {
        public string? Html { get; set; }

        public Guid Id { get; set; }

        public string? Title { get; set; }
    }
}
