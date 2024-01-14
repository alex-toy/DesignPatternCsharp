using AbstractFactory.Factories;
using AbstractFactory.Machines;

Console.WriteLine("Abstract Factory");

string message;

IMachineFactory machineFactory;
ICoffeeMachine coffeeMachine;
IPenMachine penMachine;

Console.WriteLine("******************************************************");
Console.WriteLine("Automatic");
machineFactory = new AutoMachineFactory();

coffeeMachine = machineFactory.CreateCoffeeMachine();
coffeeMachine.Start();
message = coffeeMachine.ProduceItems(4);
Console.WriteLine(message);
coffeeMachine.Stop();

penMachine = machineFactory.CreatePenMachine();
penMachine.Start();
message = penMachine.ProduceItems(4);
Console.WriteLine(message);
penMachine.Stop();


Console.WriteLine("******************************************************");
Console.WriteLine("Manual");
machineFactory = new ManualMachineFactory();

coffeeMachine = machineFactory.CreateCoffeeMachine();
coffeeMachine.Start();
message = coffeeMachine.ProduceItems(4);
Console.WriteLine(message);
coffeeMachine.Stop();

penMachine = machineFactory.CreatePenMachine();
penMachine.Start();
message = penMachine.ProduceItems(4);
Console.WriteLine(message);
penMachine.Stop();


Console.WriteLine("******************************************************");
Console.WriteLine("Traditional");
machineFactory = new TraditionalMachineFactory();

coffeeMachine = machineFactory.CreateCoffeeMachine();
coffeeMachine.Start();
message = coffeeMachine.ProduceItems(4);
Console.WriteLine(message);
coffeeMachine.Stop();

penMachine = machineFactory.CreatePenMachine();
penMachine.Start();
message = penMachine.ProduceItems(4);
Console.WriteLine(message);
penMachine.Stop();
