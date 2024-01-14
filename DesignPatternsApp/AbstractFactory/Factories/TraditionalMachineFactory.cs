using AbstractFactory.Machines;
using AbstractFactory.TraditionalMachines;

namespace AbstractFactory.Factories
{
    public class TraditionalMachineFactory : IMachineFactory
    {
        public ICoffeeMachine CreateCoffeeMachine()
        {
            return new TraditionalCoffeeMachine();
        }

        public IPenMachine CreatePenMachine()
        {
            return new TraditionalPenMachine();
        }
    }
}
