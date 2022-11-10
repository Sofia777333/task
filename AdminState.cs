using System;
using Task.Orders;

namespace Task.Routing.States
{
     class AdminState : RouterState
    {
        public AdminState(Router router) : base(router)
        {
        } 
        public override IOrder MakeOrder (Request request)
        {
            Good good = Router.Machine.GetGoodById(request.Parameters[0]);
            return new FreeOrder(good, count: request.Parameters[1]);
        }
    }
}
