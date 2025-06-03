using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_rental.model
{
    internal class Customer
    {
        public int Id { get; set; } 
        public int Store_Id { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Address_Id { get; set; } 
        public string Email { get; set; } 
        public bool Active { get; set; } = true;
        public DateTime Create_Date { get; set; } = DateTime.Now;
        public DateTime LastUpdate { get; set; } = DateTime.Now; 

    }
}
