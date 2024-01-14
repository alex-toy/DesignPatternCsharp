using MachineFactoryHelper.Machines;

namespace MachineFactoryHelper
{
    public class MachineFactory
    {
        public Machine GetMachine(IOrder order) {

            if (order.GetOrderReference() == 1) return new PenMachine();

            if (order.GetOrderReference() == 2) return new PhoneMachine();

            return new PenMachine();
        }
    }
}
