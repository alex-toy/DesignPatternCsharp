using Facade.BackOffice;

public class BankAccountFacade
{
    public int AccountNumber { get; set; }
    public int SecurityKey { get; set; }
    private AccountNumberChecker AccountNumberChecker { get; set; }
    private SecurityCodeChecker SecurityCodeChecker { get; set; }
    private FundsChecker FundsChecker { get; set; }

    public BankAccountFacade()
    {
        AccountNumberChecker = new AccountNumberChecker();
        SecurityCodeChecker = new SecurityCodeChecker();
        FundsChecker = new FundsChecker();
    }

    public void GetCashAvailable()
    {
        bool isAccountNumberOk = AccountNumberChecker.IsAccountNumberOk(AccountNumber);
        if (!isAccountNumberOk)
        {
            Console.WriteLine("Account number not recognised");
            return;
        }

        bool isSecurityCodeOk = SecurityCodeChecker.IsSecurityCodeOk(SecurityKey);
        if (!isSecurityCodeOk)
        {
            Console.WriteLine("Security code not recognised");
            return;
        }

        Console.WriteLine($"Cash available : {FundsChecker.CashAvailable}");
    }

    public void Deposit(float amount)
    {
        Console.WriteLine($"Account number : {AccountNumber} - Security code : {SecurityKey}");

        bool isAccountNumberOk = AccountNumberChecker.IsAccountNumberOk(AccountNumber);
        if (!isAccountNumberOk)
        {
            Console.WriteLine("Account number not recognised");
            return;
        }

        bool isSecurityCodeOk = SecurityCodeChecker.IsSecurityCodeOk(SecurityKey);
        if (!isSecurityCodeOk)
        {
            Console.WriteLine("Security code not recognised");
            return;
        }

        FundsChecker.Deposit(amount);
    }

    public void Withdraw(float amount)
    {
        Console.WriteLine($"Account number : {AccountNumber} - Security code : {SecurityKey}");

        bool isAccountNumberOk = AccountNumberChecker.IsAccountNumberOk(AccountNumber);
        if (!isAccountNumberOk)
        {
            Console.WriteLine("Account number not recognised");
            return;
        }

        bool isSecurityCodeOk = SecurityCodeChecker.IsSecurityCodeOk(SecurityKey);
        if (!isSecurityCodeOk)
        {
            Console.WriteLine("Security code not recognised");
            return;
        }

        FundsChecker.Withdraw(amount);
    }
}