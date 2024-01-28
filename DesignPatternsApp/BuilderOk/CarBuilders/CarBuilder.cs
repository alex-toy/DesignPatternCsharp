using BuilderOk.Options;

namespace BuilderOk.CarBuilders
{
    public abstract class CarBuilder
    {
        public Car Car { get; private set; }

        public CarBuilder(string model)
        {
            Car = new Car() { Model = model };
        }

        public virtual void SetAOptions()
        {
            Car.Options = Car.Options ?? new List<Option>() { };
        }

        public virtual void SetBOptions()
        {
            Car.Options = Car.Options ?? new List<Option>() { };
        }

        public virtual void SetCOptions()
        {
            Car.Options = Car.Options ?? new List<Option>() { };
        }

        public virtual void SetDOptions()
        {
            Car.Options = Car.Options ?? new List<Option>() { };
        }
    }
}
