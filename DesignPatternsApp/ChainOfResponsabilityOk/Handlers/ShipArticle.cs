namespace ChainOfResponsabilityOk.Handlers
{
    public class ShipArticle : BaseHandler<BuyArticle>
    {
        public override Task HandleAsync(BuyArticle request)
        {
            Console.WriteLine($"Ship article to address {request.Address}");

            if (_successor is not null)
            {
                return _successor.HandleAsync(request);
            }

            return Task.CompletedTask;
        }
    }
}
