using System;
using System.Collections.Generic;
using System.Text;

namespace Magazzino.Data.Infraestructure
{
    class DataResult
    {
        public Boolean Successfull { get; set; } = true;
        public dynamic Data { get; set; }

        public void LogError(Exception ex)
        {
            this.Successfull = false;
            this.Data = ex.Message;
        }
    }
}
