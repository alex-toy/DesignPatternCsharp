using DecoratorPattern;
using DecoratorPatternWrong.Options;

namespace DecoratorPatternWrong.Cars
{
    public class CarB : Car
    {
        public List<OptionB> BOptions { get; set; }

        public int GetTotalPrice()
        {
            return Model.Price + Options.Select(o => o.Price).Sum() + BOptions.Select(o => o.Price).Sum();
        }

        public string GetDescription()
        {
            string options = string.Join(", ", Options.Select(o => o.Name));
            string B_options = string.Join(", ", BOptions.Select(o => o.Name));
            return $"Model : {Model.Name} - Price : {GetTotalPrice()} - Options : {options + B_options}";
        }
    }
}
