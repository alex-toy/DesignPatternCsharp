using AbstractFactory.Machines;
using AbstractFactory.ManualMachines;

namespace AbstractFactory.Factories
{
    public class ManualMachineFactory : IMachineFactory
    {
        public ICoffeeMachine CreateCoffeeMachine()
        {
            return new ManualCoffeeMachine();
        }

        public IPenMachine CreatePenMachine()
        {
            return new ManualPenMachine();
        }
    }
}
