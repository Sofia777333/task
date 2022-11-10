using System;


namespace Task.Orders
{
    internal interface IOrder
    {
        
        
            bool Available { get; }
            int GetCost();
            void Process();
        }
}
