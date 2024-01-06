using BmesRestApi.Database;
using BmesRestApi.Models.Product;
using Microsoft.EntityFrameworkCore;

namespace BmesRestApi.Repositories.Implementations
{
	public class ProductRepository : IProductRepository
    {
        //Initialize the DbContext for accessing the Database:
        public BmesDbContext _context;




        public ProductRepository(BmesDbContext context)
        {
            _context = context;
        }


        //Get Single Product
        public Product FindProductById(long id)
        {
            var product = _context.Products.Find(id);
            return product;

            //throw new Exception($"Failed to get Product with Id {id}");

        }


        //Get All Products
        public IEnumerable<Product> GetAllProducts()
        {
            IEnumerable<Product> products = _context.Products;
            if (products != null) //This might be a redundant check:
            {
                return products;
            }
            throw new Exception($"Failed to get Product with Id");
        }


        //Get All Products: AOnly Return the ones that have Category and Brand on Them.
        public IEnumerable<Product> GetAllProductsCatBrand()
        {
            IEnumerable<Product> products = _context.Products.Include(p => p.Category).Include(p => p.Brand);
            return products;

        }


        //Save a Product Record to the DB:
        public void SaveProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }



        //Update a Product Record:
        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }



        //Delete a Product Record:
        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

    }
}

