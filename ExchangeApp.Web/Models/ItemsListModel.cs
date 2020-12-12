using ExchangeApp.Web.Database;
using ExchangeApp.Web.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeApp.Web.Models
{
	public class ItemsListModel
	{
		private readonly ExchangesDbContext _dbContext;
		public ItemsListModel(ExchangesDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IEnumerable<ItemEntity> Item { get; set; }

		public async Task OnGet()
		{
			Item = await _dbContext.Item.ToListAsync();
		}



	}
}
