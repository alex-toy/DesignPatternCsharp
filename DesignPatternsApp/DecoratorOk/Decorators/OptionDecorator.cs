using DecoratorOk.Cars;

namespace DecoratorOk.Decorators
{
    public abstract class OptionDecorator : ICar
    {
        public ICar Car { get; set; }

        public virtual string GetDescription()
        {
            return Car.GetDescription();
        }

        public virtual int GetTotalPrice()
        {
            return Car.GetTotalPrice();
        }
    }
}
