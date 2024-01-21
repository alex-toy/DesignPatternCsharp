using DecoratorOk.Options;

namespace DecoratorOk.Decorators
{
    public class COptionDecorator : OptionDecorator
    {
        public List<OptionC> COptions { get; set; }

        public override string GetDescription()
        {
            string options = string.Join(", ", COptions.Select(o => o.Name));
            return Car.GetDescription() + ", " + options;
        }

        public override int GetTotalPrice()
        {
            var priceAOptions = COptions.Select(o => o.Price).Sum();
            return Car.GetTotalPrice() + priceAOptions;
        }
    }
}
