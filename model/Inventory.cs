using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_rental.model
{
    internal class Inventory
    {

        public int Id { get; set; } 
        public int Film_Id { get; set; } // Foreign key to Film
        public int Store_Id { get; set; } // Foreign key to Store
        public DateTime Last_Update { get; set; } = DateTime.Now;



        public Film Film { get; set; }
        public Store Store { get; set; }
        public ICollection<Rental> Rentals { get; set; }

    }
}
