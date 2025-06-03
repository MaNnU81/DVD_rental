using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_rental.model
{
    internal class country
    {
        public int Id { get; set; } 
        public string Country_Name { get; set; } 
        public DateTime Last_Update { get; set; } = DateTime.Now; 

    }
}
