namespace CommandOk
{
    public class Store
    {
        private List<Article> _store;

        public Store()
        {
            _store = new ()
            {
                new Article(){ Id = 1, Name = "shoes", Quantity = 23 },
                new Article(){ Id = 2, Name = "pants", Quantity = 43 },
                new Article(){ Id = 3, Name = "shirt", Quantity = 12 },
                new Article(){ Id = 4, Name = "dress", Quantity = 86 },
            };
        }

        public bool ContainsSufficient(Article article, int quantity)
        {
                return _store.Find(a => a.Id.Equals(article.Id))?.Quantity > quantity;
        }

        public void Buy(Article article, int quantity)
        {
            Article? articleInStore = _store.Find(a => a.Id.Equals(article.Id));
            if (articleInStore is null) return;
            articleInStore.Quantity -= quantity;
        }

        public void Supply(Article article, int quantity)
        {
            Article? articleInStore = _store.Find(a => a.Id.Equals(article.Id));
            if (articleInStore is null) return;
            articleInStore.Quantity += quantity;
        }

        public void GetRemainingArticleCount(Article article)
        {
            Article? articleInStore = _store.Find(a => a.Id.Equals(article.Id));
            Console.WriteLine($"It remains {articleInStore.Quantity} {articleInStore.Name} in store.");
        }
    }
}
