namespace MachineFactoryHelper.Machines
{
    public class PhoneMachine : Machine
    {
        public override string ProduceItems(int count)
        {
            return $"I produced {count} phones.";
        }

        public override void Start()
        {
            Console.WriteLine("Start phone machine");
        }

        public override void Stop()
        {
            Console.WriteLine("Stop phone machine");
        }
    }
}
