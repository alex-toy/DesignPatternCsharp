using DecoratorPattern;

namespace DecoratorPatternWrong.Cars
{
    public class CarA : Car
    {
        public List<Option> AOptions { get; set; }

        public int GetTotalPrice()
        {
            return Model.Price + Options.Select(o => o.Price).Sum() + AOptions.Select(o => o.Price).Sum();
        }
    }
}
