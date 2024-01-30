using Microsoft.Extensions.Logging;
using MISA.UT.WS.AppConsole.Exceptions;
using MISA.UT.WS.AppConsole.Orders;
using MISA.UT.WS.AppConsole.Payment;
using MISA.UT.WS.AppConsole.Products;
using MISA.UT.WS.AppConsole.Sessions;
using NSubstitute;

namespace MISA.UT.WS.AppConsole.UnitTest
{
    public class OrderServiceTest
    {
        private  IOrderRepository _orderRepository;
        private  IOrderService _orderService;
        private  IProductService _productService;
        private  IPaymentService _paymentService;
        private  ISessionService _sessionService;
        private  ILogger<OrderService> _logger;

        [SetUp]
        public void Setup()
        {
            _productService = Substitute.For<IProductService>();
            _orderService = new OrderService(
            _orderRepository,
            _productService,
            _paymentService,
            _sessionService,
            _logger);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void Create_OrderDetailtInvalid_ThowException()
        {
            //Arrange
            _productService.IsValid(Arg.Any<Order.Detail>()).Returns(false);

            var order = new Order()
            {


                Details = new List<Order.Detail>()
            {
                new Order.Detail
                {
                    ProductID = Guid.NewGuid()
                }
            }
                };

            //Act + Assert
            var ts = Assert.Throws<BussinessException>(() => _orderService.Create(order));

            Assert.That(ts.Errors.Where(s => s.ErrorCode == "Err001").Count() == 1);
        }
    }
}