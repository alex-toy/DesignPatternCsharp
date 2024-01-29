namespace CommandOk
{
    public class Store
    {
        private List<Article> _store;

        public Store()
        {
            _store = new ()
            {
                new Article(){Name = "shoes", Quantity = 23 },
                new Article(){Name = "pants", Quantity = 43 },
                new Article(){Name = "shirt", Quantity = 12 },
                new Article(){Name = "dress", Quantity = 86 },
            };
        }

        public bool IsInStore(Article article)
        {
                return _store.Find(s => s.Equals(article))?.Quantity > 0;
        }

        public void Bye(Article article)
        {
            Article? articleInStore = _store.Find(s => s.Equals(article));
            if (articleInStore is null) return;
            articleInStore.Quantity--;
        }
    }
}
