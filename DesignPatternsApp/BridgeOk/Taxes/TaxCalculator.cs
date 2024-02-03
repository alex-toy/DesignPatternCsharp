namespace BridgeOk.Taxes
{
    public interface TaxCalculator
    {
        public Machine Machine { get; set; }

        double CalculateTaxes();
    }
}
