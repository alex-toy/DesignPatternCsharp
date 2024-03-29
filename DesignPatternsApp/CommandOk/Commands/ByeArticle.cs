﻿namespace CommandOk.Commands
{
    public class ByeArticle : ICommand
    {
        public Article Article { get; set; }
        public Store Store { get; set; }
        public int Quantity { get; set; }

        public bool CanExecute()
        {
            return Store.ContainsSufficient(Article, Quantity);
        }

        public void Execute()
        {
            Store.Buy(Article, Quantity);
        }
    }
}
