using System;
using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Response.Brand
{
	public class FetchBrandResponse : ResponseBase
	{
		public int BrandsPerPage { get; set; }
		public bool HasPreviousPage { get; set; }
		public bool HasNextPage { get; set; }
		public int CurrentPage { get; set; }
		public int[]? Pages { get; set; }
		public IEnumerable<BrandDto>? Brands { get; set; }
    }
}

