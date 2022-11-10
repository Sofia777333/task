using Task.Orders;

namespace Task.Commands
{
    class BuyGood : ICommand
    {
        private readonly WendingMachine _machine;
        private readonly IOrder _order;

        public BuyGood(WendingMachine machine, IOrder order)
        {
            _machine = machine;
            _order = order;
        }
        public void Execute() => _machine.ProcessOrder(_order);
    }
}