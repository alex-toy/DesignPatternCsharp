using AbstractFactory.AutomaticMachines;
using AbstractFactory.Machines;

namespace AbstractFactory.Factories
{
    internal class AutoMachineFactory : IMachineFactory
    {
        public ICoffeeMachine CreateCoffeeMachine()
        {
            return new AutoCoffeeMachine();
        }

        public IPenMachine CreatePenMachine()
        {
            return new AutoPenMachine();
        }
    }
}
