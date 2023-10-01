using RefactoringDemo.Models;

namespace RefactoringDemo
{
    public class _4_MagicValues
    {
        public void UpdateOrderStatus(int orderId, string newOrderStatus)
        {
            //newOrderStatus = "Confirmed";

            var orderStatus = GetOrderById(orderId);

            if (newOrderStatus == "confirmed")
            {
                orderStatus.OrderStatus = newOrderStatus;
                UpdateOrder(orderStatus);
            }
        }

        public List<int> GetBestSellers()
        {
            var numberOfProducts = 10;

            var bestSellers = QueryDBForBestSellers(numberOfProducts);

            return bestSellers;
        }

        #region
        public Order GetOrderById(int orderId)
        {
            var order = new Order
            {
                CreateDateUtc = DateTime.Now,
                OrderId = orderId,
                OrderItems = new List<int> { 1000, 1001, 1002 },
                OrderStatus = "Created"
            };

            return order;
        }

        public void UpdateOrder(Order order)
        {
            return true;
        }

        public List<int> QueryDBForBestSellers(int items)
        {
            return new List<int>();
        }
        #endregion
    }
}
