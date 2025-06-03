using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_rental.model
{
    internal class Language
    {
        public int id { get; set; } 
        public string name { get; set; }
        public DateTime last_update { get; set; } = DateTime.Now; 
    }
}
