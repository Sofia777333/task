using System;
using Task.Orders;

namespace Task.Routing.States
{
     class CustomerState : RouterState
    {
        public CustomerState(Router router):base(router) { }

        public override IOrder MakeOrder(Request request)
        {
            Good good = Router.Machine.GetGoodById(request.Parameters[0]); 
            return new PaidOrder(good, count: request.Parameters[1]);
        }
    }
}
