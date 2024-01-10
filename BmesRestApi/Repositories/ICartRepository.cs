using System;
using BmesRestApi.Models.Cart;

namespace BmesRestApi.Repositories.Implementations
{
	public interface ICartRepository
	{
        Cart FindCartById(long id);
        IEnumerable<Cart> GetAllCarts();
        void SaveCart(Cart cart);
        void UpdateCart(Cart cart);
        void DeleteCart(Cart cart);
    }
}

