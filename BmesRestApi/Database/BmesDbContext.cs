using BmesRestApi.Models.Product;
using Microsoft.EntityFrameworkCore;

namespace BmesRestApi.Database
{
	public class BmesDbContext : DbContext
	{
        
        //Using the Constructor to allow us create a New NotelyDbContext Model: 
        public BmesDbContext(DbContextOptions<BmesDbContext> options) : base(options) { }


        //Setting Up The DbSet Action to Map my Models to my DataBase Tables:  public virtual DbSet<ModelName> DBTableName {get; set;}
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
        public object Product { get; internal set; }
    }
}

