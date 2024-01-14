namespace MachineHelper.MachineFactory
{
    public interface IMachineFactory
    {
        public abstract IMachine Create(int selectedMachine);
    }
}
