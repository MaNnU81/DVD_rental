using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_rental.model
{
    public class Address
    {
        public int Id { get; set; } 
        public string Address_1 { get; set; } 
        public string Address_2 { get; set; } 
        public int City_Id { get; set; } 
        public string State { get; set; } 
        public string Postal_Code { get; set; } 

        public int Phone { get; set; }

        public DateTime Last_Update { get; set; } = DateTime.Now; 




    }
}
