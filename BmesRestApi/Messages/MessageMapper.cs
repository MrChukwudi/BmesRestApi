using System;
using BmesRestApi.Messages.DataTransferObjects.Product;
using BmesRestApi.Models.Product;

namespace BmesRestApi.Messages
{
	public class MessageMapper
	{
		public Brand MapToBrand(BrandDto brandDto)
		{
			var brand = new Brand
			{
				Id = brandDto.Id,
				Name = brandDto.Name,
				Slug = brandDto.Slug,
				Description = brandDto.Description,
				MetaDescription = brandDto.MetaDescription,
				MetaKeywords = brandDto.MetaKeywords,
				BrandStatus = (BrandStatus)brandDto.BrandStatus,
				ModifiedDate = brandDto.ModifiedDate,
				IsDeleted = brandDto.IsDeleted
			};

			return brand;
		}





		public BrandDto MapToBrandDto(Brand brand)
		{
			var brandDto = new BrandDto();

			if(brand != null)
			{

				brandDto.Id = brand.Id;
				brandDto.Name = brand.Name;
				brandDto.Slug = brand.Slug;
				brandDto.Description = brand.MetaDescription;
				brandDto.MetaKeywords = brand.MetaKeywords;
				brandDto.BrandStatus = (int)brand.BrandStatus;
				brandDto.ModifiedDate = brand.ModifiedDate;
                brandDto.IsDeleted = brand.IsDeleted;
            }

            return brandDto;

        }





		public Category MapToCategory(CategoryDto categoryDto)
		{
			var category = new Category
			{
				Id = categoryDto.Id,
				Name = categoryDto.Name,
				Slug = categoryDto.Slug,
				Description = categoryDto.Description,
				MetaDescription = categoryDto.MetaDescription,
				MetaKeywords = categoryDto.MetaKeywords,
				CategoryStatus = (CategoryStatus)categoryDto.CategoryStatus,
				ModifiedDate = categoryDto.ModifiedDate,
				IsDeleted = categoryDto.IsDeleted

			};

			return category;
		}



		public CategoryDto MapToCategoryDto(Category category)
		{
			var categoryDto = new CategoryDto();

			if(category != null)
			{
				categoryDto.Id = category.Id;
				categoryDto.Name = category.Name;
				categoryDto.Description = category.Description;
				categoryDto.MetaDescription = category.MetaDescription;
				categoryDto.MetaKeywords = category.MetaKeywords;
				categoryDto.CategoryStatus = (int)category.CategoryStatus;
				categoryDto.ModifiedDate = category.ModifiedDate;
				categoryDto.IsDeleted = category.IsDeleted;
			 }

			return categoryDto;
		}





		public Product MapToProduct(ProductDto productDto)
		{
			var product = new Product();
		}
















	}
}

