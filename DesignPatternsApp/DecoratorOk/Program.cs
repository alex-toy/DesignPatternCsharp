using DecoratorOk;
using DecoratorOk.Cars;
using DecoratorOk.Decorators;
using DecoratorOk.Options;

Console.WriteLine("Decorator Pattern OK");

Model clioModel = new Model() { Name = "clio", Price = 3000 };
Car car = new Car() { Model = clioModel };
Console.WriteLine(car.GetDescription());
Console.WriteLine($"Total price : {car.GetTotalPrice()}");


List<OptionA> Aoptions = new List<OptionA>() {
    new OptionA(){ Name = "rear camera", Price = 100 },
    new OptionA(){ Name = "leather seats", Price = 100 },
};
AOptionDecorator aOptionDecorator = new AOptionDecorator() { Car = car, AOptions = Aoptions };
Console.WriteLine(aOptionDecorator.GetDescription());
Console.WriteLine($"Total price : {aOptionDecorator.GetTotalPrice()}");


List<OptionB> Boptions = new List<OptionB>() {
    new OptionB(){ Name = "luxury option 1", Price = 870 },
    new OptionB(){ Name = "luxury option 2", Price = 960 },
};
BOptionDecorator bOptionDecorator = new BOptionDecorator() { Car = aOptionDecorator, BOptions = Boptions };
Console.WriteLine(bOptionDecorator.GetDescription());
Console.WriteLine($"Total price : {bOptionDecorator.GetTotalPrice()}");


List<OptionC> Coptions = new List<OptionC>() {
    new OptionC(){ Name = "sport option 1", Price = 12 },
    new OptionC(){ Name = "sport option 2", Price = 23 },
};
COptionDecorator cOptionDecorator = new COptionDecorator() { Car = bOptionDecorator, COptions = Coptions };
Console.WriteLine(cOptionDecorator.GetDescription());
Console.WriteLine($"Total price : {cOptionDecorator.GetTotalPrice()}");