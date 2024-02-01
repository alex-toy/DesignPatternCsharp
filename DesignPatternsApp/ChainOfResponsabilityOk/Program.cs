using ChainOfResponsabilityOk;
using ChainOfResponsabilityOk.Handlers;

Console.WriteLine("Chain of responsability Ok");

var commandOk = new BuyArticle(1, 2, "12345", "12 rue victor hugo");
var commandWrong = new BuyArticle(2, 2, "3221", "12 rue victor hugo");

Predicate<string> isCardNumberOk = x => x == "12345";

var stockChecker = new CheckStock();
var creditCardChecker = new CheckCreditCard() { _isCardNumOk = isCardNumberOk };
var shipper = new ShipArticle();
stockChecker
    .SetNext(creditCardChecker)
    .SetNext(shipper);

try
{
    stockChecker.HandleAsync(commandOk);
    stockChecker.HandleAsync(commandOk);
    stockChecker.HandleAsync(commandOk);
    stockChecker.HandleAsync(commandOk);
    //stockChecker.HandleAsync(commandWrong);
}
catch (Exception)
{
	throw;
}