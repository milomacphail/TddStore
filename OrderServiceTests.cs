using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Telerik.JustMock;
using TddStore.Core;

namespace TddStore
{
    [TestClass]
    public class OrderServiceTests
    {
        [TestMethod]
        public void WhenUserPlacesACorrectOrderThenAnOrderNumberShouldBeReturned()
        {
            //Arrange

            var shoppingCart = new ShoppingCart();

            shoppingCart.Items.Add(new ShoppingCartItem { ItemId = Guid.NewGuid(), Quantity = 1 });

            var customerId = Guid.NewGuid();
            var expectedOrderId = Guid.NewGuid();

            var orderDataService = Mock.Create<IOrderService>();
            Mock.Arrange(() => orderDataService.Save(Arg.IsAny<Order>()))
                .Returns(expectedOrderId)
            .OccursOnce();

            OrderService orderService = new OrderService(orderDataService);

            //Act

            var result = orderService.PlaceOrder(customerId, shoppingCart);

            //Assert

            Assert.AreEqual(expectedOrderId, result);

        }
    }
}
