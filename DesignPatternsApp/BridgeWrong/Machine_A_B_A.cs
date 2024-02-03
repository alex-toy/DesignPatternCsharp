namespace BridgeWrong
{
    public class Machine_A_B_A : Machine
    {
        public override double CalculateTaxes()
        {
            return BasePrice * 0.1;
        }

        public override string GetEnvironmentalCategory()
        {
            return "B";
        }

        public override double CalculateInsuranceFee()
        {
            return BasePrice / 12.0;
        }
    }
}
