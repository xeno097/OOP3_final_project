using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace Magazzino.Data.Entities
{
    [Table("Sales", Schema = "dbo")]
    public class Sales : BaseEntity
    {
    }
}
