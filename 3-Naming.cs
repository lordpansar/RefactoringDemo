using RefactoringDemo.Models;

namespace RefactoringDemo
{
    public class _3_Naming
    {
        public bool UpdateOrderStatus(int id, string os)
        {
            var o = GetOrderById(id);

            if(o.OrderStatus != os)
            {
                o.OrderStatus = os;
            }

            var x = UpdateOrder(o);

            return x;
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

        public bool UpdateOrder(Order order)
        {
            return true;
        }
        #endregion
    }
}
