using System;


namespace Task.Orders
{
    class PaidOrder : Order

    {
        public PaidOrder(Good good, int count):base(good, count) { }

        public override int GetCost() => Count * Good.Price;
    }
}
