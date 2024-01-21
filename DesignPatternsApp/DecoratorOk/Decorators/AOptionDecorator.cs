using DecoratorOk.Cars;

namespace DecoratorOk.Decorators
{
    public class AOptionDecorator : OptionDecorator
    {
        public List<Option> AOptions { get; set; }

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
