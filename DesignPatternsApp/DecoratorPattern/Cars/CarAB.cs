using DecoratorPattern;

namespace DecoratorPatternWrong.Cars
{
    public class CarAB : Car
    {
        public List<Option> AOptions { get; set; }
        public List<Option> BOptions { get; set; }

        public string GetDescription()
        {
            string options = string.Join(", ", Options.Concat(AOptions).Concat(BOptions).Select(o => o.Name));
            return $"Model : {Model.Name} - Price : {GetTotalPrice()} - Options : {options}";
        }

        public int GetTotalPrice()
        {
            return Model.Price + Options.Select(o => o.Price).Sum() + AOptions.Select(o => o.Price).Sum() + BOptions.Select(o => o.Price).Sum();
        }
    }
}
