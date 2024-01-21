namespace Facade.BackOffice
{
    public class FundsChecker
    {
        public float CashAvailable { get; private set; } = 1000;

        public void Withdraw(float amount)
        {
            if (amount > CashAvailable)
            {
                Console.WriteLine("Not enough money");
                return;
            }
            CashAvailable -= amount;
            Console.WriteLine($"Remaining amount : {CashAvailable}");
        }

        public void Deposit(float amount)
        {
            CashAvailable += amount;
            Console.WriteLine($"Remaining amount : {CashAvailable}");
        }
    }
}
