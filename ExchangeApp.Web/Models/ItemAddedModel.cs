using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeApp.Web.Models
{
	public class ItemAddedModel
	{
		public int NumberOfCharsInName { get; set; }
		public int NumberofCharsInDescription { get; set; }
		public bool IsHidden { get; set; }
	}
}
