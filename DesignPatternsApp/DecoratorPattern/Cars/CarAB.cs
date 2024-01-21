using DecoratorPattern;

namespace DecoratorPatternWrong.Cars
{
    public class CarAB : Car
    {
        public List<Option> ABOptions { get; set; }

        public int GetTotalPrice()
        {
            return Model.Price + Options.Select(o => o.Price).Sum() + ABOptions.Select(o => o.Price).Sum();
        }
    }
}
