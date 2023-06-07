using ShoppingCard.Models;

namespace ShoppingCard.Repositories
{
    public interface ICartRepository
    {
        Task<int> AddItem(int bookId, int qty);
        Task<int> RemoveItem(int bookId);
        Task<shoppingCard> GetUserCart();
        Task<int> GetCartItemCount(string userId = "");
        Task<shoppingCard> GetCart(string userId);
        Task<bool> DoCheckout();
    }
}
