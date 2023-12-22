using System;
using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Response.Category
{
	public class DeleteCategoryResponse : ResponseBase
	{
        //For our Project; We want to return the Deleted Category to the User:
        public CategoryDto? Category { get; set; }
        
    }
}

