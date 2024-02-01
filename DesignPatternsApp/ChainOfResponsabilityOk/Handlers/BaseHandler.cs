namespace ChainOfResponsabilityOk.Handlers
{
    public abstract class BaseHandler<Req> : IHandler<Req> where Req : class
    {
        protected IHandler<Req>? _successor;

        public abstract Task HandleAsync(Req request);

        public IHandler<Req> SetNext(IHandler<Req> handler)
        {
            _successor = handler;
            return _successor;
        }
    }
}
