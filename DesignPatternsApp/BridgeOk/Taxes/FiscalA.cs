namespace BridgeOk.Taxes
{
    public class FiscalA : TaxCalculator
    {
        public Machine Machine { get; set; }

        public double CalculateTaxes()
        {
            if (Machine.EnvironmentalHandler.GetEnvironmentalCategory() == "A")
            {
                return Machine.BasePrice * 0.1;
            }
            else
            {
                return Machine.BasePrice * 0.2;
            }
        }
    }
}
