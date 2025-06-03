using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_rental.model
{
    public class City
    {
        public int Id { get; set; } // Unique identifier for the city
        public string City_Name { get; set; } // Name of the city

        public int Country_Id { get; set; } // Foreign key to the country

        public DateTime Last_Update { get; set; } = DateTime.Now; // Last update timestamp
    }
}
