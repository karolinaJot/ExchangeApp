using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExchangeApp.Web.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExchangeApp.Web.ViewComponents
{
	public class LastItem : ViewComponent
	{
		private readonly ExchangesDbContext _dbContext;
		public LastItem(ExchangesDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IViewComponentResult Invoke()
		{
			var latestItem = _dbContext.Item.OrderByDescending(x => x.Id).First();
			return View("Index", latestItem);
		}
	}
}
