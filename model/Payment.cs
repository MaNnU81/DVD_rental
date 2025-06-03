using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_rental.model
{
    internal class Payment
    {

        public int Id { get; set; }
        public int Customer_Id { get; set; } // Foreign key to Customer
        public int Staff_Id { get; set; } // Foreign key to Staff
        public int Rental_Id { get; set; } // Foreign key to Rental

        public decimal Amount { get; set; } // Payment amount

        public DateTime Payment_Date { get; set; } // Date of payment
    }
}
