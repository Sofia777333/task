using System;
using Task.Orders;
namespace Task
{
    internal class WendingMachine
    {
        public int Balance { get; private set; }
        private Good[] _goods;

        public WendingMachine(int balance, params Good[] goods)
        {
            Balance = balance;
            _goods = goods;
        }
        public void AddBalance(int balanceToAdd)
        {
            if (Balance < 0)
                throw new ArgumentOutOfRangeException("Balance to add can not be less 0");
            Balance += balanceToAdd;
        }

        public void DiscardBalance(int balanceToDiscard)
        {
            if (Balance < 0 || Balance > balanceToDiscard)
                throw new ArgumentOutOfRangeException("Wrong balanceToDiscard");
            Balance -= balanceToDiscard;
        }

        public bool Contains(int id) => id <=0 && id < _goods.Length;

        public Good GetGoodById(int id)
        {
         if (!Contains(id))
                throw new ArgumentOutOfRangeException("Wrong id");
            return _goods[id];
        }
        public void ProcessOrder(IOrder order)
        {
            TryProcessOrder(order, out bool success);
            if (!success)
                throw new ArgumentException("Order could not be proccessed"); 
        }
        public void TryProcessOrder(IOrder order, out bool success)
        {
            success = IsOrderPossible(order);

            if (!success)
                return;
            DiscardBalance(order.GetCost());
            order.Process();
        }
        private bool IsOrderPossible(IOrder order)
        {
            return order.Available && order.GetCost() <= Balance;
        }
}
}
