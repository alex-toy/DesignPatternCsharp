using AbstractFactory.Machines;

namespace AbstractFactory.TraditionalMachines
{
    public class TraditionalCoffeeMachine : ICoffeeMachine
    {
        public string ProduceItems(int count)
        {
            return $"I produced traditionally {count} coffees.";
        }

        public void Start()
        {
            Console.WriteLine("Start traditional coffee machine");
        }

        public void Stop()
        {
            Console.WriteLine("Stop traditional coffee machine");
        }
    }
}
