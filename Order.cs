using System;


namespace Task.Orders
{
    abstract class Order : IOrder
    {
        protected readonly Good Good;
        protected readonly int Count;


        public Order(Good good, int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("Count can not be less then 0");

            Good = good;
            Count = count;
        }
        public bool Available => Count <= Good.Count;

        public abstract int GetCost();

        public void Process() => Good.Count -= Count;
    }
}
