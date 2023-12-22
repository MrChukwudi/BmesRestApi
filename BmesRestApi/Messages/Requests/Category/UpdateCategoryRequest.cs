using System;
using BmesRestApi.Messages.DataTransferObjects.Product;

namespace BmesRestApi.Messages.Requests.Category
{
	public class UpdateCategoryRequest
	{
        //For my project's Purpose, this is the Parameter that I will need when performing a Update a Brand request:
        public CategoryDto? Category { get; set; }
    }
}

