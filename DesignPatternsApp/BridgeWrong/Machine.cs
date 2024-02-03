namespace BridgeWrong
{
    public abstract class Machine
    {
        public string Name { get; set; }
        public double BasePrice { get; set; }

        public virtual double GetPrice()
        {
            return BasePrice + CalculateTaxes();
        }

        public virtual double CalculateTaxes()
        {
            return 0;
        }

        public virtual string GetEnvironmentalCategory()
        {
            return "";
        }

        public virtual double CalculateInsuranceFee()
        {
            return 0;
        }

        public virtual void ToString()
        {
            Console.WriteLine($"Machine {Name} - Price : {GetPrice()} - Insurance Fee : {CalculateInsuranceFee()}");
        }
    }
}
