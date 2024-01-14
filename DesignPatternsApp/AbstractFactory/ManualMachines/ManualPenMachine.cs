using AbstractFactory.Machines;

namespace AbstractFactory.ManualMachines
{
    internal class ManualPenMachine : IPenMachine
    {
        public string ProduceItems(int count)
        {
            return $"I produced manually {count} pen.";
        }

        public void Start()
        {
            Console.WriteLine("Start manual pen machine");
        }

        public void Stop()
        {
            Console.WriteLine("Stop manual pen machine");
        }
    }
}
