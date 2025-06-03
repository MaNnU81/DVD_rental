using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_rental.model
{
    internal class Rental
    {
        public int Id { get; set; } // Unique identifier for the rental
        public int Customer_Id { get; set; } 
        public int Staff_Id { get; set; } 
        public int Inventory_Id { get; set; } 
        public DateTime Rental_Date { get; set; } 
        public DateTime Return_Date { get; set; } 
      
        public DateTime Last_Update { get; set; } = DateTime.Now;




        public Inventory Inventory { get; set; }
        public Customer Customer { get; set; }
        public Staff Staff { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
