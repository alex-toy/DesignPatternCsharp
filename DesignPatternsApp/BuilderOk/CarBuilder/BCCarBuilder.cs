using BuilderOk.Options;

namespace BuilderOk.CarBuilder
{
    public class BCCarBuilder : CarBuilder
    {
        public List<BOption> BOptions { get; set; }
        public List<BOption> COptions { get; set; }

        public BCCarBuilder(string model) : base(model)
        {
        }

        public override void SetAOptions()
        {
            throw new NotImplementedException();
        }

        public override void SetBOptions()
        {
            Car.Options.AddRange(BOptions);
        }

        public override void SetCOptions()
        {
            Car.Options.AddRange(COptions);
        }
    }
}
