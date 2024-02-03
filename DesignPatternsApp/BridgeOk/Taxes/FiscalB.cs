namespace BridgeOk.Taxes
{
    public class FiscalB : TaxCalculator
    {
        public double TaxCoefficient { get; set; }
        public Machine Machine { get; set; }

        public double CalculateTaxes()
        {
            return Machine.BasePrice * TaxCoefficient;
        }
    }
}
