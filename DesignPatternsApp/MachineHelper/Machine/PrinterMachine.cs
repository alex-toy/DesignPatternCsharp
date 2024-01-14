using MachineHelper.MachineFactory;

namespace MachineHelper.Machine
{
    internal class PrinterMachine : IMachine
    {
        public void Action()
        {
            Console.WriteLine("Print...");
        }

        public void Start()
        {
            Console.WriteLine("Start printer");
        }

        public void Stop()
        {
            Console.WriteLine("Stop printer");
        }
    }
}
