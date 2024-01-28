using BuilderOk.Options;

namespace BuilderOk.CarBuilder
{
    public class BCarBuilder : CarBuilder
    {
        public List<BOption> BOptions { get; set; }

        public BCarBuilder(string model) : base(model)
        {
        }

        public override void SetAOptions()
        {
            Car.Options = new List<Option>();
        }

        public override void SetBOptions()
        {
            Car.Options.AddRange(BOptions);
        }

        public override void SetCOptions()
        {
            Car.Options = new List<Option>();
        }
    }
}
