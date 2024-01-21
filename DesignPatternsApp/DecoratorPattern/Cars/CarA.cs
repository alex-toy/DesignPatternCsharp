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

        public string GetDescription()
        {
            string options = string.Join(", ", Options.Concat(AOptions).Select(o => o.Name));
            return $"Model : {Model.Name} - Price : {GetTotalPrice()} - Options : {options}";
        }
    }
}
