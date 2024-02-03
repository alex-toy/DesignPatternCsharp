namespace BridgeOk.Insurances
{
    public class InsuranceA : InsuranceCalculator
    {
        public double CalculateInsuranceFee(double basePrice)
        {
            return basePrice / 12.0;
        }
    }
}
