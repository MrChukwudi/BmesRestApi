using System;
using System.Data.SqlTypes;
using BmesRestApi.Database;
using BmesRestApi.Models.Cart;



namespace BmesRestApi.Repositories.Implementations
{
	public class CartRepository : ICartRepository
	{
		private BmesDbContext _context;



		public CartRepository(BmesDbContext context)
		{
			_context = context;
		}


		//To Find One Cart by Id from DB:
		public Cart FindCartById(long id)
		{
			var cart = _context.Carts.Find(id);

            if (cart != null)
            {
                return cart;
            }
            else
            {
                throw new Exception("The Carts list is null here:");
            }
            
		}

		//To Get All Carts from DB:
		public IEnumerable<Cart> GetAllCarts()
		{
			var carts = _context.Carts.Find();

			if(carts != null)
			{
				return (IEnumerable<Cart>)carts;
			}
			else
			{
				throw new Exception("The Carts list is null here:");
			}
		}



		//to Save Cart Record to DB:
		public void SaveCart(Cart cart)
		{
			_context.Carts.Add(cart);
			_context.SaveChanges();
		}


		//To Update Cart Record in the DB:
		public void UpdateCart(Cart cart)
		{
			_context.Carts.Update(cart);
			_context.SaveChanges();
		}


		//To Delete a Cart record in the DB:
        public void DeleteCart(Cart cart)
        {
            _context.Carts.Remove(cart);
            _context.SaveChanges();
        }

    }
}

