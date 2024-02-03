namespace BridgeOk.Insurances
{
    public class InsuranceB : InsuranceCalculator
    {
        public double InsuranceCoefficient { get; set; }

        public double CalculateInsuranceFee(double basePrice)
        {
            return basePrice / InsuranceCoefficient;
        }
    }
}
