namespace RefactoringDemo
{
    public class _2_DuplicatedCode
    {
        public void PrintOrderDetails(int orderId)
        {
            if (orderId > 0)
            {
                var orderDetails = GetOrderDetails(orderId);
                
                HelperMethods.Print(orderDetails);
            }
        }

        public void PrintProductDetails(int productId)
        {
            if(productId > 0)
            {
                var productDetails = GetProductDetails(productId);

                Print(productDetails);
            }
        }

        private void Print(string text)
        {
            if (text != "")
            {
                Console.WriteLine(text);
            }
        }

        #region

        private string GetOrderDetails(int orderId)
        {
            return "Massa grejer i denna order";
        }

        private string GetProductDetails(int productId)
        {
            return "Åh vilken cool produkt";
        }

        #endregion
    }
}
