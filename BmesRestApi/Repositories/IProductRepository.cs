using System;
using BmesRestApi.Models.Product;

namespace BmesRestApi.Repositories
{
	public interface IProductRepository
	{
		Product FindProductById(long id);
        

        IEnumerable<Product> GetAllProducts();


		IEnumerable<Product> GetAllProductsCatBrand();


		void SaveProduct(Product product);



		void UpdateProduct(Product product);



		void DeleteProduct(Product product);
    }
}

