using DecoratorPattern;
using DecoratorPatternWrong.Cars;

Console.WriteLine("Decorator Pattern Wrong");

Model clioModel = new Model() { Name = "clio", Price = 3000 };
List<Option> options = new List<Option>() {
    new Option(){ Name = "central lock", Price = 150 },
    new Option(){ Name = "turbo", Price = 250 },
    new Option(){ Name = "rear camera", Price = 250 },
    new Option(){ Name = "leather seats", Price = 250 },
};
Car car = new Car() { Model = clioModel, Options = options };
Console.WriteLine(car.GetDescription());


List<Option> Aoptions = new List<Option>() {
    new Option(){ Name = "rear camera", Price = 250 },
    new Option(){ Name = "leather seats", Price = 250 },
};
CarA carA = new CarA() { Model = clioModel, Options = options, AOptions = Aoptions };
Console.WriteLine(carA.GetDescription());


List<Option> Boptions = new List<Option>() {
    new Option(){ Name = "rear camera", Price = 250 },
    new Option(){ Name = "leather seats", Price = 250 },
};
CarAB carAB = new CarAB() { Model = clioModel, Options = options, AOptions = Aoptions, BOptions = Boptions };
Console.WriteLine(carAB.GetDescription());