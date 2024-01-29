using CommandOk;
using CommandOk.Commands;

Console.WriteLine("Command Ok");

var store = new Store();
var article = new Article() { Id = 2, Name = "pants" };

var buyCommand = new ByeArticle() { Store = store, Article = article, Quantity = 22 };
var supplyCommand = new SupplyArticle() { Store = store, Article = article, Quantity = 100 };

store.GetRemainingArticleCount(article);
CommandManager.Execute(buyCommand);
store.GetRemainingArticleCount(article);
CommandManager.Execute(buyCommand);
store.GetRemainingArticleCount(article);
CommandManager.Execute(supplyCommand);
store.GetRemainingArticleCount(article);