using System;
using BmesRestApi.Messages.DataTransferObjects.Cart;

namespace BmesRestApi.Messages.Response.Cart
{
	public class AddItemToCartResponse : ResponseBase
	{
        public CartItemDto CartItem { get; set; }
    }
}

