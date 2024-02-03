namespace BridgeOk.Insurances
{
    public class InsuranceC : InsuranceCalculator
    {
        public double CalculateInsuranceFee(double basePrice)
        {
            return basePrice / 13.0;
        }
    }
}
