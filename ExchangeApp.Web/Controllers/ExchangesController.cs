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
		[HttpGet]
		public IActionResult Show()
		{
			return View();
		}
	

		[HttpPost]
		public IActionResult Show(ItemModel item)
		{
			var viewModel = new ItemAddedModel
			{
				//NumberOfCharsInName = item.Name.Length,
				//NumberofCharsInDescription = item.Description.Length,
				//IsHidden = !item.IsVisible

				Id = 1,
				Name = item.Name,
			};

			//return View("ItemAdded", viewModel);
			return RedirectToAction("ItemAddedConfirmation");
		}

		[HttpGet]
		public IActionResult ItemAddedConfirmation()
		{
			return View();
		}
	}
}
