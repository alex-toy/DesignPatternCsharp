namespace BridgeOk.Taxes
{
    public class FiscalC : TaxCalculator
    {
        public double TaxCoefficient1 { get; set; }
        public double TaxCoefficient2 { get; set; }
        public Machine Machine { get; set; }

        public double CalculateTaxes()
        {
            return Machine.BasePrice * TaxCoefficient1 + Machine.BasePrice * TaxCoefficient2;
        }
    }
}
