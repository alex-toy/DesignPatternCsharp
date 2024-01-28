using BuilderOk.Options;

namespace BuilderOk.CarBuilders
{
    public class BCCarBuilder : CarBuilder
    {
        public List<BOption> BOptions { get; set; } = new List<BOption>();
        public List<COption> COptions { get; set; } = new List<COption>();

        public BCCarBuilder(string model) : base(model)
        {
        }

        public override void SetBOptions()
        {
            if (BOptions.Count < 2)
            {
                throw new ArgumentException("B options should be at least 3");
            }

            Car.Options.AddRange(BOptions);
        }

        public override void SetCOptions()
        {
            Car.Options.AddRange(COptions);
        }
    }
}
