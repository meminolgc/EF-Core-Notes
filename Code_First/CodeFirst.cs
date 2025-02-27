﻿using Microsoft.EntityFrameworkCore;

namespace Code_First
{
	public class ECommerceDbContext : DbContext
	{
		public DbSet<Product> Products { get; set; }
		public DbSet<Customer> Customers { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=EMIN\\SQLEXPRESS; initial Catalog=EFCoreDb; integrated Security=true; TrustServerCertificate=True;");
		}
	}

	//Entity
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Quantity { get; set; }
		public float Price { get; set; }
	}
	//Entity
	public class Customer
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}
