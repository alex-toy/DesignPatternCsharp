using BridgeWrong;

Console.WriteLine("Bridge wrong");

Machine machine = new Machine_A_A_A() { BasePrice = 5000, Name = "Fiscal A - Environment A - Insurance fee A" };
machine.ToString();
CanDrive(machine);

machine = new Machine_A_B_A() { BasePrice = 5000, Name = "Fiscal A - Environment B - Insurance fee A" };
machine.ToString();
CanDrive(machine);

machine = new Machine_B_D_C() { BasePrice = 5000, Name = "Fiscal B - Environment D - Insurance fee C" };
machine.ToString();
CanDrive(machine);





void CanDrive(Machine machine)
{
    string[] allowedCategories = {"A", "B", "C"};
    if (allowedCategories.Contains(machine.GetEnvironmentalCategory()))
    {
        Console.WriteLine($"Machine {machine.Name} can drive on the street");
    }
    else
    {
        Console.WriteLine($"Machine {machine.Name} cannot drive on the street");
    }
}