using DecoratorPattern;
using DecoratorPatternWrong.Options;

namespace DecoratorPatternWrong.Cars
{
    public class Car
    {
        public Model Model { get; set; }
        public List<Option> Options { get; set; }

        public int GetTotalPrice()
        {
            return Model.Price + Options.Select(o => o.Price).Sum();
        }

        public string GetDescription()
        {
            string options = string.Join(", ", Options.Select(o => o.Name));
            return $"Model : {Model.Name} - Price : {GetTotalPrice()} - Options : {options}";
        }
    }
}
