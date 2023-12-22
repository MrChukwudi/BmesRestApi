using System;
using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Response.Category
{
	public class GetCategoryResponse : ResponseBase
	{
		public CategoryDto? Category { get; set; }
	}
}

