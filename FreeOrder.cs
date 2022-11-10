using System;


namespace Task.Orders
{
    class FreeOrder : Order
    {
        public FreeOrder(Good good, int count) : base(good, count) { }

        public override int GetCost() => 0;

           
    }
}
