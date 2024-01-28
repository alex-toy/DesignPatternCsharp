using BuilderOk.CarBuilders;

namespace BuilderOk
{
    public static class CarMaker
    {
        public static Car MakeCar(CarBuilder carBuilder)
        {
            carBuilder.SetAOptions();
            carBuilder.SetBOptions();
            carBuilder.SetCOptions();
            carBuilder.SetDOptions();
            return carBuilder.Car;
        }
    }
}
