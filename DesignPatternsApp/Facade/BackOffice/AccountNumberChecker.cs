namespace Facade.BackOffice
{
    public class AccountNumberChecker
    {
        public int AccountNumber { get; } = 12345678;

        public bool IsAccountNumberOk(int accountNumber)
        {
            return accountNumber == AccountNumber;
        }
    }
}
