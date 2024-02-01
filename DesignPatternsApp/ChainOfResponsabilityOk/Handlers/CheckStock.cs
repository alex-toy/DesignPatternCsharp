using ChainOfResponsabilityOk.Models;

namespace ChainOfResponsabilityOk.Handlers
{
    public class CheckStock : BaseHandler<BuyArticle>
    {
        public List<Article> Articles { get; set; } = new List<Article>()
        {
            new Article(){ ArticleId = 1, Quantity = 10 },
            new Article(){ ArticleId = 2, Quantity = 3 },
            new Article(){ ArticleId = 3, Quantity = 3 },
        };

        public override Task HandleAsync(BuyArticle request)
        {
            var article = Articles.Find(a => a.ArticleId == request.ArticleId);

            if (article is null)
            {
                throw new Exception("unknown article");
            }

            if (article.Quantity < request.Quantity)
            {
                throw new Exception($"Not enough in stock. There only remains {article.Quantity} articles");
            }

            article.Quantity -= request.Quantity;
            Console.WriteLine($"Remaining quantity for article {article.ArticleId} : {article.Quantity}");

            if (_successor is not null)
            {
                return _successor.HandleAsync(request);
            }

            return Task.CompletedTask;
        }
    }
}
