namespace CommandOk.Commands
{
    public class SupplyArticle : ICommand
    {
        public Article Article { get; set; }
        public Store Store { get; set; }
        public int Quantity { get; set; }

        public bool CanExecute()
        {
            return true;
        }

        public void Execute()
        {
            Store.Supply(Article, Quantity);
        }

    }
}
