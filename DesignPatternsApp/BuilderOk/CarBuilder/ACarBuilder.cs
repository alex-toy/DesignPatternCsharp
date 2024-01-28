using BuilderOk.Options;

namespace BuilderOk.CarBuilder
{
    public class ACarBuilder : CarBuilder
    {
        public List<AOption> AOptions { get; set; }

        public ACarBuilder(string model) : base(model)
        {
        }

        public override void SetAOptions()
        {
            Car.Options.AddRange(AOptions);
        }

        public override void SetBOptions()
        {
            Car.Options = new List<Option>();
        }

        public override void SetCOptions()
        {
            Car.Options = new List<Option>();
        }
    }
}
