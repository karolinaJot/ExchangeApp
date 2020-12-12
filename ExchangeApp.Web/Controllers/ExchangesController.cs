using ExchangeApp.Web.Database;
using ExchangeApp.Web.Entities;
using ExchangeApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeApp.Web.Controllers
{
	public class ExchangesController : Controller
	{

		private readonly ExchangesDbContext _dbContext;
		public ExchangesController(ExchangesDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		[HttpGet]
		public IActionResult Show()
		{
			return View();
		}
	

		[HttpPost]
		public IActionResult Show(ItemModel item)
		{
			var entity = new ItemEntity
			{
				Name = item.Name,
				Description = item.Description,
				IsVisible = item.IsVisible
			};

			_dbContext.Item.Add(entity);
			_dbContext.SaveChanges();

			return RedirectToAction("DisplayItemsList");
		}

		[HttpGet]
		public IActionResult DisplayItemsList()
		{
			ViewBag.Item = _dbContext.Item;
			return View();
		}
	}
}
