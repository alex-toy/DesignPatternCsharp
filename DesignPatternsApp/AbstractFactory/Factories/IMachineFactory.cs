using AbstractFactory.Machines;

namespace AbstractFactory.Factories
{
    public interface IMachineFactory
    {
        ICoffeeMachine CreateCoffeeMachine();
        IPenMachine CreatePenMachine();
    }
}
