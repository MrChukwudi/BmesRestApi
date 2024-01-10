using System;
using System.Data.Entity;
using BmesRestApi.Database;
using BmesRestApi.Models.Cart;

namespace BmesRestApi.Repositories.Implementations
{
	public class CartItemRepository : ICartItemRepository
	{
        private BmesDbContext _context;

        public CartItemRepository(BmesDbContext context)
        {
            _context = context;
        }


        //Get A sSingle CartItem BY iD from DB:
        public CartItem FindCartItemById(long id)
        {
            var cartItem = _context.CartItems.Find(id);

            if(cartItem != null)
            {
                return cartItem;
            }
            else
            {
                throw new Exception("The CartItem does not exist here");
            }
        }

        //Get all CartItems WITHIN a particular CART from the DB:
        public IEnumerable<CartItem> FindCartItemsByCartId(long cartId)
        {
            var cartItems = _context.CartItems.Where(cartItem => cartItem.CartId == cartId).Include(c => c.Product);
            return cartItems;
        }



        public void SaveCartItem(CartItem cartItem)
        {
            _context.CartItems.Add(cartItem);
            _context.SaveChanges();
        }

        public void UpdateCartItem(CartItem cartItem)
        {
            _context.CartItems.Update(cartItem);
            _context.SaveChanges();
        }

        public void DeleteCartItem(CartItem cartItem)
        {
            _context.CartItems.Remove(cartItem);
            _context.SaveChanges();
        }
    }
}

