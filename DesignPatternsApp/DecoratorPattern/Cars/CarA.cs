using DecoratorPattern;
using DecoratorPatternWrong.Options;

namespace DecoratorPatternWrong.Cars
{
    public class CarA : Car
    {
        public List<OptionA> AOptions { get; set; }

        public int GetTotalPrice()
        {
            return Model.Price + Options.Select(o => o.Price).Sum() + AOptions.Select(o => o.Price).Sum();
        }

        public string GetDescription()
        {
            string options = string.Join(", ", Options.Select(o => o.Name));
            string A_options = string.Join(", ", AOptions.Select(o => o.Name));
            return $"Model : {Model.Name} - Price : {GetTotalPrice()} - Options : {options + A_options}";
        }
    }
}
