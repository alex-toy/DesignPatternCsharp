using BridgeOk.Environments;
using BridgeOk.Insurances;
using BridgeOk.Taxes;

namespace BridgeOk
{
    public class Machine
    {
        public string Name { get; set; }
        public double BasePrice { get; set; }
        public TaxCalculator TaxCalculator { get; set; }
        public EnvironmentalHandler EnvironmentalHandler { get; set; }
        public InsuranceCalculator InsuranceCalculator { get; set; }

        public double GetPrice()
        {
            return BasePrice + CalculateTaxes();
        }

        public double CalculateTaxes()
        {
            return TaxCalculator.CalculateTaxes();
        }

        public string GetEnvironmentalCategory()
        {
            return EnvironmentalHandler.GetEnvironmentalCategory();
        }

        public double CalculateInsuranceFee()
        {
            return InsuranceCalculator.CalculateInsuranceFee(BasePrice);
        }

        public void ToString()
        {
            Console.WriteLine($"Machine {Name} - Price : {GetPrice()} - Insurance Fee : {CalculateInsuranceFee()}");
        }
    }
}
