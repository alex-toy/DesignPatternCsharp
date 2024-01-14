using AbstractFactory.Machines;

namespace AbstractFactory.ManualMachines
{
    public class ManualCoffeeMachine : ICoffeeMachine
    {
        public string ProduceItems(int count)
        {
            return $"I produced manually {count} coffees.";
        }

        public void Start()
        {
            Console.WriteLine("Start manual coffee machine");
        }

        public void Stop()
        {
            Console.WriteLine("Stop manual coffee machine");
        }
    }
}
