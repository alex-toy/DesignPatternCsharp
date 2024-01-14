using MachineFactoryHelper;

namespace FactoryDesignPattern
{
    public class Order : IOrder
    {
        public int Reference { get; set; }

        public int GetOrderReference()
        {
            return Reference;
        }
    }
}
