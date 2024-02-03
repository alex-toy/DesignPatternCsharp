using BridgeOk;
using BridgeOk.Environments;
using BridgeOk.Insurances;
using BridgeOk.Taxes;

Console.WriteLine("Bridge Ok");

Machine machineA_A_A = new Machine()
{
    BasePrice = 5000,
    Name = "Fiscal A - Environment A - Insurance fee A",
    EnvironmentalHandler = new EnvironmentA(),
    InsuranceCalculator = new InsuranceA(),
};
machineA_A_A.TaxCalculator = new FiscalA() { Machine = machineA_A_A };
machineA_A_A.ToString();
CanDrive(machineA_A_A);


Machine machineA_B_A = new Machine()
{
    BasePrice = 5000,
    Name = "Fiscal A - Environment B - Insurance fee A",
    EnvironmentalHandler = new EnvironmentB(),
    InsuranceCalculator = new InsuranceA(),
};
machineA_B_A.TaxCalculator = new FiscalA() { Machine = machineA_B_A };
machineA_B_A.ToString();
CanDrive(machineA_B_A);


Machine machineB_D_C = new Machine()
{
    BasePrice = 5000,
    Name = "Fiscal B - Environment D - Insurance fee C",
    EnvironmentalHandler = new EnvironmentD(),
    InsuranceCalculator = new InsuranceC(),
};
machineB_D_C.TaxCalculator = new FiscalB() { Machine = machineB_D_C, TaxCoefficient = 0.12 };
machineB_D_C.ToString();
CanDrive(machineB_D_C);


Machine machineB_D_A = new Machine()
{
    BasePrice = 5000,
    Name = "Fiscal B - Environment D - Insurance fee A",
    EnvironmentalHandler = new EnvironmentD(),
    InsuranceCalculator = new InsuranceA(),
};
machineB_D_A.TaxCalculator = new FiscalB() { Machine = machineB_D_A, TaxCoefficient = 0.12 };
machineB_D_A.ToString();
CanDrive(machineB_D_A);


Machine machineC_D_B = new Machine()
{
    BasePrice = 5000,
    Name = "Fiscal C - Environment D - Insurance fee B",
    EnvironmentalHandler = new EnvironmentD(),
    InsuranceCalculator = new InsuranceB() { InsuranceCoefficient = 14 },
};
machineC_D_B.TaxCalculator = new FiscalC() { Machine = machineC_D_B, TaxCoefficient1 = 0.12, TaxCoefficient2 = 0.02 };
machineC_D_B.ToString();
CanDrive(machineC_D_B);





void CanDrive(Machine machine)
{
    string[] allowedCategories = { "A", "B", "C" };
    if (allowedCategories.Contains(machine.GetEnvironmentalCategory()))
    {
        Console.WriteLine($"Machine {machine.Name} can drive on the street");
    }
    else
    {
        Console.WriteLine($"Machine {machine.Name} cannot drive on the street");
    }
}
