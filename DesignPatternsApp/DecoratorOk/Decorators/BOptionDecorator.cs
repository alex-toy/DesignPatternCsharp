using DecoratorOk.Cars;

namespace DecoratorOk.Decorators
{
    public class BOptionDecorator : OptionDecorator
    {
        public List<Option> BOptions { get; set; }

        public override string GetDescription()
        {
            string options = string.Join(", ", BOptions.Select(o => o.Name));
            return Car.GetDescription() + ", " + options;
        }

        public override int GetTotalPrice()
        {
            var priceAOptions = BOptions.Select(o => o.Price).Sum();
            return Car.GetTotalPrice() + priceAOptions;
        }
    }
}
