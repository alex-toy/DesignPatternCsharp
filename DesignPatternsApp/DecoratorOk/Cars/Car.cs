namespace DecoratorOk.Cars
{
    public class Car : ICar
    {
        public Model Model { get; set; }

        public int GetTotalPrice()
        {
            return Model.Price;
        }

        public string GetDescription()
        {
            return $"Model : {Model.Name} - Base Price : {GetTotalPrice()}";
        }
    }
}
