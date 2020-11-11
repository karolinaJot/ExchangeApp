
using ExchangeApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;





namespace ExchangeApp.Web.Controllers
{
	[ApiController]
	[Route("api/exchanges")]
	public class MyApiController : ControllerBase
	{
		public IActionResult Post(ItemModel itemModel)
		{

			try
			{

				ItemAddedModel response = new ItemAddedModel
				{
					NumberOfCharsInName = itemModel.Name.Length,
					NumberofCharsInDescription = itemModel.Description.Length,
					IsHidden = !itemModel.IsVisible
				};

				return Ok(response);
			}
			catch(Exception exception) 
			{
				return NotFound(exception);
			}
		}
	}
}
