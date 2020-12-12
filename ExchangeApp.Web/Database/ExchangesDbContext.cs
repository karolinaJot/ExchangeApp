using ExchangeApp.Web.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeApp.Web.Database
{
	public class ExchangesDbContext : DbContext
	{
		public ExchangesDbContext(DbContextOptions options)
			: base(options)
		{ 
		}

		public DbSet<ItemEntity> Item { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<ItemEntity>().ToTable("Item");
		}



	}
}
