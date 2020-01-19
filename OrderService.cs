using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddStore
{
    public class OrderService
    {

        private IOrderDataService _orderDataService;

        public OrderService(IOrderDataService orderDataService)
        {
            _orderDataService = orderDataService;
        }
        public Guid PlaceOrder(Guid customerId, ShoppingCart shoppingCart)
        {
            var order = new Order();

            //return _orderDataService.Save(order);

            return Guid.NewGuid();
        }
    }
}
