using System;
using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Requests.Product
{
	public class UpdateProductRequest
    {
        //For my project's Purpose, this is the Parameter that I will need when performing a Update a Brand request:
        public ProductDto? Product { get; set; }
    }
}

