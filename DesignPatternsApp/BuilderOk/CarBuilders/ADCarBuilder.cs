using BuilderOk.Options;

namespace BuilderOk.CarBuilders
{
    public class ADCarBuilder : CarBuilder
    {
        public List<AOption> AOptions { get; set; } = new List<AOption>();
        public List<DOption> DOptions { get; set; } = new List<DOption>();

        public ADCarBuilder(string model) : base(model)
        {
        }

        public override void SetAOptions()
        {
            Car.Options.AddRange(AOptions);
        }

        public override void SetDOptions()
        {
            Car.Options.AddRange(DOptions);
        }
    }
}
