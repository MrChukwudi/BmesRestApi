using System;
using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Response.Category
{
	public class CreateCategoryResponse : ResponseBase
	{
		public CategoryDto? Category { get; set; }
	}
}

