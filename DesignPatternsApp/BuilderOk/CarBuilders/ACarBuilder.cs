using BuilderOk.Options;

namespace BuilderOk.CarBuilders
{
    public class ACarBuilder : CarBuilder
    {
        public List<AOption> AOptions { get; set; } = new List<AOption>();

        public ACarBuilder(string model) : base(model)
        {
        }

        public override void SetAOptions()
        {
            if (AOptions.Count > 10)
            {
                throw new ArgumentException("A options should not exceed 10");
            }

            if (AOptions.Select(o => o.Price).Any(p => p > 100))
            {
                throw new ArgumentException("A options price should not exceed 100");
            }

            Car.Options.AddRange(AOptions);
        }
    }
}
