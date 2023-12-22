using System;
using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Response.Category
{
	public class FetchCategoryResponse : ResponseBase
	{
		public int CategoriesPerPage { get; set; }
		public bool HasPreviousPage { get; set; }
		public bool HasNextPage { get; set; }
		public int CurrentPage { get; set; }
		public int[]? Pages { get; set; }
		public IEnumerable<CategoryDto>? Categories { get; set; }
    }
}

