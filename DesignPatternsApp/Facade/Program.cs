using Facade.BackOffice;

Console.WriteLine("Facade ok");

var bankAccountFacade = new BankAccountFacade() { 
    AccountNumber = 12345678, 
    SecurityKey = 1234,
};

bankAccountFacade.GetCashAvailable();
bankAccountFacade.Deposit(100);
bankAccountFacade.Withdraw(800);
bankAccountFacade.Withdraw(600);


