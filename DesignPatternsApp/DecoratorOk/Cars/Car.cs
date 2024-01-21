namespace DecoratorOk.Cars
{
    public class Car : ICar
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
            return $"Model : {Model.Name} - Base Price : {GetTotalPrice()} - Options : {options}";
        }
    }
}
