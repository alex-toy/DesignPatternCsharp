namespace DecoratorOk.Options
{
    public class OptionB : IOption
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
