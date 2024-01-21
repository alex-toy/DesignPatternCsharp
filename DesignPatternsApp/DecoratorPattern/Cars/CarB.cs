using DecoratorPattern;

namespace DecoratorPatternWrong.Cars
{
    public class CarB : Car
    {
        public List<Option> BOptions { get; set; }

        public int GetTotalPrice()
        {
            return Model.Price + Options.Select(o => o.Price).Sum() + BOptions.Select(o => o.Price).Sum();
        }
    }
}
