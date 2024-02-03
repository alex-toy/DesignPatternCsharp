namespace BridgeWrong
{
    public class Machine_B_D_C : Machine
    {
        public override double CalculateTaxes()
        {
            return BasePrice * 0.2;
        }

        public override string GetEnvironmentalCategory()
        {
            return "D";
        }

        public override double CalculateInsuranceFee()
        {
            return BasePrice / 13.0;
        }
    }
}
