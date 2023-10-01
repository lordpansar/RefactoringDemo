using RefactoringDemo.Models;

namespace RefactoringDemo
{
    public class _5_Reusability
    {
        public void UpdateOrderStatusAndDeliveryTime(int orderId, OrderStatus newOrderStatus)
        {
            var order = GetOrderById(orderId);

            if (order.OrderStatus != newOrderStatus)
            {
                order.OrderStatus = newOrderStatus;
                UpdateOrder(order);
            }

            if (newOrderStatus == OrderStatus.Packed)
            {
                var estimatedDeliveryDate = DateTime.Now.AddDays(3);

                UpdateDeliveryDate(orderId, estimatedDeliveryDate);
            }
        }

        #region
        public Order GetOrderById(int orderId)
        {
            var order = new Order
            {
                CreateDateUtc = DateTime.Now,
                OrderId = orderId,
                OrderItems = new List<int> { 1000, 1001, 1002 },
                OrderStatus = OrderStatus.Created
            };

            return order;
        }

        public void UpdateOrder(Order order)
        {

        }

        public void UpdateDeliveryDate(int orderId, DateTime date)
        {

        }

        public class Order
        {
            public int OrderId { get; set; }
            public DateTime CreateDateUtc { get; set; }
            public List<int>? OrderItems { get; set; }
            public OrderStatus OrderStatus { get; set; }
        }
        #endregion
    }
}
