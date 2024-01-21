using DecoratorOk.Options;

namespace DecoratorOk.Decorators
{
    public class AOptionDecorator : OptionDecorator
    {
        public List<OptionA> AOptions { get; set; }

        public override string GetDescription()
        {
            string options = string.Join(", ", AOptions.Select(o => o.Name));
            return Car.GetDescription() + ", " + options;
        }

        public override int GetTotalPrice()
        {
            var priceAOptions = AOptions.Select(o => o.Price).Sum();
            return Car.GetTotalPrice() + priceAOptions;
        }
    }
}
