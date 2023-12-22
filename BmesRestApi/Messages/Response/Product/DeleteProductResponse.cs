using System;
using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Response.Product
{
	public class DeleteProductResponse : ResponseBase
	{
        //For our Project; We want to return the Deleted Brand to the User:
        public ProductDto? Product { get; set; }
    }
}

