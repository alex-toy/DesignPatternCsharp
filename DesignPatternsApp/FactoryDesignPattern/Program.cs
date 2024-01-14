using FactoryDesignPattern;
using MachineFactoryHelper;

Console.WriteLine("Factory Design Pattern");

var factory = new MachineFactory();

Order order = new Order() { Reference = 1 };
Machine machine = factory.GetMachine(order);
machine.Start();
string message = machine.ProduceItems(6);
Console.WriteLine(message);
machine.Stop();


order = new Order() { Reference = 2 };
machine = factory.GetMachine(order);
machine.Start();
message = machine.ProduceItems(6);
Console.WriteLine(message);
machine.Stop();
