using System;
using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Response.Product
{
	public class CreateProductResponse : ResponseBase
	{
		public ProductDto? Product { get; set; }
	}
}

