using MachineHelper.MachineFactory;

Console.WriteLine("Simple Factory Pattern");

IMachine machine;
IMachineFactory simpleFactory = new MachineFactory();

machine = simpleFactory.GetMachine(0);
machine.Start();
machine.Action();
machine.Stop();

machine = simpleFactory.GetMachine(1);
machine.Start();
machine.Action();
machine.Stop();
