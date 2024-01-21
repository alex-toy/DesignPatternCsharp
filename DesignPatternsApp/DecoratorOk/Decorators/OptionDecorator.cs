using DecoratorOk.Cars;
using DecoratorOk.Options;

namespace DecoratorOk.Decorators
{
    public class OptionDecorator<TOption> : ICar where TOption : IOption
    {
        public ICar Car { get; set; }
        public List<TOption> Options { get; set; }

        public string GetDescription()
        {
            string options = string.Join(", ", Options.Select(o => o.GetName()));
            return Car.GetDescription() + ", " + options;
        }

        public int GetTotalPrice()
        {
            var priceOptions = Options.Select(o => o.GetPrice()).Sum();
            return Car.GetTotalPrice() + priceOptions;
        }
    }
}
