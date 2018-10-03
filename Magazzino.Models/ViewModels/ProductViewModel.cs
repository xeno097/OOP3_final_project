using System;
using System.Collections.Generic;
using Magazzino.Models.Infraestruture;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Magazzino.Models
{
    public class ProductViewModel : BaseViewModel
    {
		public int IdProductM { get; set; }
		[MaxLength(50)]
		public string ProductNameM { get; set; }
		[MaxLength(50)]
		public string DetailsM { get; set; }
		
		public int MoneyM { get; set; }

        public int IdSellersM { get; set; }

        [MaxLength(50)]
		public string CalM { get; set; }

        public string ImagenM { get; set; }

        [MaxLength(50)]
		public string CategoryM { get; set; }
			
	}
}
