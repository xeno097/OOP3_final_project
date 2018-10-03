using System;
using System.Collections.Generic;
using System.Text;
using Magazzino.Models.Infraestruture;
using System.ComponentModel.DataAnnotations;

namespace Magazzino.Models
{
    public class UserViewModel : BaseViewModel
    {
		public int IdUser { get; set; }
		[MaxLength(50)]
		public string UserName { get; set; }
        [MaxLength(50)]
        public string Passoword { get; set; }
		[MaxLength(50)]
		public string Type { get; set; }
	}
}
