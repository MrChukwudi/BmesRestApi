using System;
using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Response.Brand
{
	public class DeleteBrandResponse : ResponseBase
	{
        //For our Project; We want to return the Deleted Brand to the User:
        public BrandDto? Brand { get; set; }
    }
}

