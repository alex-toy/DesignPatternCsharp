namespace ChainOfResponsabilityOk
{
    public interface IHandler<Req> where Req : class
    {
        IHandler<Req> SetNext(IHandler<Req> handler);
        Task HandleAsync(Req request);

    }
}
