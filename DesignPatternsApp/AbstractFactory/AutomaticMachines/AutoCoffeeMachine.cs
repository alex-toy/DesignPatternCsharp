using AbstractFactory.Machines;

namespace AbstractFactory.AutomaticMachines
{
    public class AutoCoffeeMachine : ICoffeeMachine
    {
        public string ProduceItems(int count)
        {
            return $"I produced automatically {count} coffees.";
        }

        public void Start()
        {
            Console.WriteLine("Start automatic coffee machine");
        }

        public void Stop()
        {
            Console.WriteLine("Stop automatic coffee machine");
        }
    }
}
