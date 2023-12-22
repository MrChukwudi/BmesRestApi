using System;
namespace BmesRestApi.Messages.Requests.Product
{
	public class FetchProductRequest
    {
        //For my project's Purpose, these are the Parameters that I will need when performing a Fetch Brands request:
        public int PageNumber { get; set; }
        public int ProductsPerPage { get; set; }
        public string? CategorySlug { get; set; }
        public string? BrandSlug { get; set; }
    }
}

