using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            var orderService = new OrderService();

            //Act

            var result = orderService.PlaceOrder(customerId, shoppingCart);


            //Assert

            Assert.AreEqual(expectedOrderId, result);

        }
    }
}
