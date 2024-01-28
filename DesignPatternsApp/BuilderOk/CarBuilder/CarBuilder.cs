using BuilderOk.Options;

namespace BuilderOk.CarBuilder
{
    public abstract class CarBuilder
    {
        public Car Car { get; private set; }

        public CarBuilder(string model)
        {
            Car = new Car() { Model = model };
        }

        public abstract void SetAOptions();
        public abstract void SetBOptions();
        public abstract void SetCOptions();
    }
}
