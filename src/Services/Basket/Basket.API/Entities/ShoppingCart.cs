namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
        }

        public ShoppingCart(string userName)
        {
            UserName = userName;
        }
        public string UserName { get; set; }

        public List<ShoppingCartItems> Items { get; set; } = new List<ShoppingCartItems>();

        public decimal TotalPrice 
        {
            get { 
                decimal totalprice = 0;
                foreach (var item in Items)
                {
                    totalprice += item.Price * item.Quantity;
                }

                return totalprice;
            } 
        }

    }
}
