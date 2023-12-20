using System;
using BmesRestApi.Models.Product;

namespace BmesRestApi.Messages.DataTransferObjects.Product
{
	public class CategoryDto
	{
        public long Id { get; set; }

        public string? Name { get; set; } = "";

        public string? Slug { get; set; } = "";

        public string? Description { get; set; } = String.Empty;

        public string? MetaDescription { get; set; } = "";

        public string? MetaKeywords { get; set; } = "";

        public CategoryStatus CategoryStatus { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset ModifiedDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}

