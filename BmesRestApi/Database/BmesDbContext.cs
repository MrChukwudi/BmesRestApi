﻿using BmesRestApi.Models.Address;
using BmesRestApi.Models.Cart;
using BmesRestApi.Models.Customer;
using BmesRestApi.Models.Order;
using BmesRestApi.Models.Product;
using BmesRestApi.Models.Shared;
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



        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }


        public DbSet<Address> Addresses { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Customer> Customers { get; set; }



        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }





        
    }
}

