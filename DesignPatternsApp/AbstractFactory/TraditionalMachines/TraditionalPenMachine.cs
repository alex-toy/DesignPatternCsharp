using AbstractFactory.Machines;

namespace AbstractFactory.TraditionalMachines
{
    internal class TraditionalPenMachine : IPenMachine
    {
        public string ProduceItems(int count)
        {
            return $"I produced traditionally {count} pen.";
        }

        public void Start()
        {
            Console.WriteLine("Start traditional pen machine");
        }

        public void Stop()
        {
            Console.WriteLine("Stop traditional pen machine");
        }
    }
}
