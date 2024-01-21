using DecoratorPattern;
using DecoratorPatternWrong.Options;

namespace DecoratorPatternWrong.Cars
{
    public class CarAB : Car
    {
        public List<OptionA> AOptions { get; set; }
        public List<OptionB> BOptions { get; set; }

        public string GetDescription()
        {


            string options = string.Join(", ", Options.Select(o => o.Name));
            string A_options = string.Join(", ", AOptions.Select(o => o.Name));
            string B_options = string.Join(", ", BOptions.Select(o => o.Name));
            return $"Model : {Model.Name} - Price : {GetTotalPrice()} - Options : {options + A_options + B_options}";
        }

        public int GetTotalPrice()
        {
            return Model.Price + Options.Select(o => o.Price).Sum() + AOptions.Select(o => o.Price).Sum() + BOptions.Select(o => o.Price).Sum();
        }
    }
}
