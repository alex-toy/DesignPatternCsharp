using MachineHelper.MachineFactory;

namespace MachineHelper.Machine
{
    internal class CoffeeMachine : IMachine
    {
        public void Action()
        {
            Console.WriteLine("Do some coffee");
        }

        public void Start()
        {
            Console.WriteLine("Start coffee machine");
        }

        public void Stop()
        {
            Console.WriteLine("Stop coffee machine");
        }
    }
}
