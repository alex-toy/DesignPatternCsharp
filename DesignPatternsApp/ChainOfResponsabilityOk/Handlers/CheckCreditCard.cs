namespace ChainOfResponsabilityOk.Handlers
{
    public class CheckCreditCard : BaseHandler<BuyArticle>
    {
        public Predicate<string> _isCardNumOk { get; set; }

        public override Task HandleAsync(BuyArticle request)
        {
            if (!_isCardNumOk(request.CardNumber))
            {
                throw new Exception("Wrong card number");
            }

            if (_successor is not null)
            {
                return _successor.HandleAsync(request);
            }

            Console.WriteLine($"Article {request.ArticleId} could be successfully purchased {request.Quantity} times");

            return Task.CompletedTask;
        }
    }
}
