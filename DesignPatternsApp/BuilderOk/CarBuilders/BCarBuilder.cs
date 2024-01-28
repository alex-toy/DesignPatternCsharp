using BuilderOk.Options;

namespace BuilderOk.CarBuilders
{
    public class BCarBuilder : CarBuilder
    {
        public List<BOption> BOptions { get; set; } = new List<BOption>();

        public BCarBuilder(string model) : base(model)
        {
        }

        public override void SetBOptions()
        {
            Car.Options.AddRange(BOptions);
        }
    }
}
