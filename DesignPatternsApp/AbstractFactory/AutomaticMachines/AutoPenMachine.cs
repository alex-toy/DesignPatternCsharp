using AbstractFactory.Machines;

namespace AbstractFactory.AutomaticMachines
{
    internal class AutoPenMachine : IPenMachine
    {
        public string ProduceItems(int count)
        {
            return $"I produced automatically {count} pen.";
        }

        public void Start()
        {
            Console.WriteLine("Start automatic pen machine");
        }

        public void Stop()
        {
            Console.WriteLine("Stop automatic pen machine");
        }
    }
}
