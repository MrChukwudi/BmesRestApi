using System;
namespace BmesRestApi.Messages.Requests.Category
{
	public class FetchCategoryRequest
	{
        //For my project's Purpose, these are the Parameters that I will need when performing a Fetch Brands request:
        public int PageNumber { get; set; }
        public int CategoriesPerPage { get; set; }
    }
}

