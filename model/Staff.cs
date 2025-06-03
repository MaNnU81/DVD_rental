using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_rental.model
{
    public class Staff
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address_Id { get; set; }
        public string Email { get; set; }
        public int Store_Id { get; set; }  
        
        public bool Active { get; set; } = true;   
        public string Username { get; set; }    
        public string Password { get; set; }

        public DateTime LastUpdate { get; set; } = DateTime.Now;



    }
}
