namespace MachineFactoryHelper
{
    public abstract class Machine
    {
        public abstract void Start();
        public abstract string ProduceItems(int count);
        public abstract void Stop();
    }
}