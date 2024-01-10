using System;
using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.DataTransferObjects.Cart
{
	public class CartItemDto
	{
        public long Id { get; set; }
        public long CartId { get; set; }
        public ProductDto Product { get; set; }
        public int Quantity { get; set; }
    }
}

