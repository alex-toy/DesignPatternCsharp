using MachineHelper.Machine;

namespace MachineHelper.MachineFactory
{
    public class MachineFactory : IMachineFactory
    {
        public IMachine GetMachine(int selectedMachine)
        {
            IMachine newMachine;
            switch (selectedMachine)
            {
                case 0:
                    newMachine = new CoffeeMachine();
                    break;
                case 1:
                    newMachine = new PrinterMachine();
                    break;
                default:
                    throw new ApplicationException(string.Format(" Unknown Machine cannot be instantiated"));
            }

            return newMachine;
        }
    }
}
