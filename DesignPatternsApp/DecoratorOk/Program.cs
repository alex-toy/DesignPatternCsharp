using DecoratorOk;
using DecoratorOk.Cars;
using DecoratorOk.Decorators;
using DecoratorOk.Options;

Console.WriteLine("Decorator Pattern OK");

Model clioModel = new Model() { Name = "Modele de base", Price = 3000 };
Car car = new Car() { Model = clioModel };
Console.WriteLine(car.GetDescription());
Console.WriteLine($"Total price : {car.GetTotalPrice()}");


List<OptionA> Aoptions = new List<OptionA>() {
    new OptionA(){ Name = "A option 1", Price = 100 },
    new OptionA(){ Name = "A option 2", Price = 100 },
};
var aOptionDecorator = new OptionDecorator<OptionA>() { Car = car, Options = Aoptions };
Console.WriteLine(aOptionDecorator.GetDescription());
Console.WriteLine($"Total price : {aOptionDecorator.GetTotalPrice()}");


List<OptionB> Boptions = new List<OptionB>() {
    new OptionB(){ Name = "B option 1", Price = 870 },
    new OptionB(){ Name = "B option 2", Price = 960 },
};
var bOptionDecorator = new OptionDecorator<OptionB>() { Car = aOptionDecorator, Options = Boptions };
Console.WriteLine(bOptionDecorator.GetDescription());
Console.WriteLine($"Total price : {bOptionDecorator.GetTotalPrice()}");


List<OptionC> Coptions = new List<OptionC>() {
    new OptionC(){ Name = "C option 1", Price = 12 },
    new OptionC(){ Name = "C option 2", Price = 23 },
};
var cOptionDecorator = new OptionDecorator<OptionC>() { Car = bOptionDecorator, Options = Coptions };
Console.WriteLine(cOptionDecorator.GetDescription());
Console.WriteLine($"Total price : {cOptionDecorator.GetTotalPrice()}");
