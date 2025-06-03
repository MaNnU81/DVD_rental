using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_rental.model
{
    internal class Store
    {

        public int Id { get; set; }
        public int Manager__Staff_Id { get; set; } // Foreign key to the manager
        public int Address_Id { get; set; } // Address of the store

        public DateTime LastUpdate { get; set; } = DateTime.Now; 
    }
}
