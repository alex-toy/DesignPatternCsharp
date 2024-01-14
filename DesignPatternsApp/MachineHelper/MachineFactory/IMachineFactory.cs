namespace MachineHelper.MachineFactory
{
    public interface IMachineFactory
    {
        public abstract IMachine GetMachine(int selectedMachine);
    }
}
