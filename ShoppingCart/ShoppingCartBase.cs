namespace ShoppingCartModels
{
    public class ShoppingCartBase
    {

        public void AddShoppingItem(ShoppingCartItem item)

        {
            _items.Add(item);
        }
    }
}