using System;
using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Response.Product
{
	public class FetchProductResponse : ResponseBase
	{
		public int ProductsPerPage { get; set; }
		public bool HasPreviousPage { get; set; }
		public bool HasNextPage { get; set; }
		public int CurrentPage { get; set; }
		public int[]? Pages { get; set; }
		public IEnumerable<ProductDto>? Products { get; set; }
    }
}

