using DecoratorOk;
using DecoratorOk.Cars;
using DecoratorOk.Decorators;

Console.WriteLine("Decorator Pattern OK");

Model clioModel = new Model() { Name = "clio", Price = 3000 };
List<Option> options = new List<Option>() {
    new Option(){ Name = "central lock", Price = 250 },
    new Option(){ Name = "turbo", Price = 250 },
};
Car car = new Car() { Model = clioModel, Options = options };
Console.WriteLine(car.GetDescription());
Console.WriteLine($"Total price : {car.GetTotalPrice()}");


List<Option> Aoptions = new List<Option>() {
    new Option(){ Name = "rear camera", Price = 100 },
    new Option(){ Name = "leather seats", Price = 100 },
};
AOptionDecorator aOptionDecorator = new AOptionDecorator() { Car = car, AOptions = Aoptions };
Console.WriteLine(aOptionDecorator.GetDescription());
Console.WriteLine($"Total price : {aOptionDecorator.GetTotalPrice()}");


List<Option> Boptions = new List<Option>() {
    new Option(){ Name = "luxury option 1", Price = 870 },
    new Option(){ Name = "luxury option 2", Price = 960 },
};
BOptionDecorator bOptionDecorator = new BOptionDecorator() { Car = aOptionDecorator, BOptions = Boptions };
Console.WriteLine(bOptionDecorator.GetDescription());
Console.WriteLine($"Total price : {bOptionDecorator.GetTotalPrice()}");