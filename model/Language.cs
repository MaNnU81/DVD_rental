using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_rental.model
{
    public class Language
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public DateTime Last_update { get; set; } = DateTime.Now; 
    }
}
