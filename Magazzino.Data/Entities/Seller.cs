using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Magazzino.Data.Entities
{
    [Table("Seller", Schema = "dbo")]
    public  class Seller : BaseEntity
    {
        public int IdSeller { get; set; }
        [MaxLength(50)]
        public string Company { get; set; }
        [MaxLength(50)]
        public string Tel { get; set; }
        [MaxLength(150)]
        public string Location { get; set; }

        [MaxLength(50)]
        public string Mail { get; set; }
        [MaxLength(250)]
        public string Cal { get; set; }
        [MaxLength(150)]
        public string Post { get; set; }
        [MaxLength(250)]
        public string Policy { get; set; }
    }
}
