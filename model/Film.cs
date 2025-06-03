using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_rental.model
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }

        public int Language_Id    { get; set; } // Foreign key to the language table
        public int? ReleaseYear { get; set; }
        public int RentalDuration { get; set; }

        public int RentalRate { get; set; } 
        public int? Length { get; set; }

        public int ReplacementCost { get; set; }

        public string? Rating { get; set; }

       public string? SpecialFeatures { get; set; } 
       
        public string Fulltext { get; set; }



        
        public Language Language { get; set; } = new Language();
        public List<Actor> Actors { get; set; }  // Molti-a-molti con Actor
        public List<Category> Categories { get; set; }  // Molti-a-molti con Category
        public List<Inventory> Inventories { get; set; }


    }
}
