namespace MachineFactoryHelper.Machines
{
    public class PenMachine : Machine
    {
        public override string ProduceItems(int count)
        {
            return $"I produced {count} pens.";
        }

        public override void Start()
        {
            Console.WriteLine("Start pen machine");
        }

        public override void Stop()
        {
            Console.WriteLine("Stop pen machine");
        }
    }
}
