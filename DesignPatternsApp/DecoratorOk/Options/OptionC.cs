namespace DecoratorOk.Options
{
    public class OptionC : IOption
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int GetPrice()
        {
            return Price;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
