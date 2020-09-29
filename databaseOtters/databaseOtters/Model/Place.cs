using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace databaseOtters.Model
{
    public class Place
    {
        public string Name { get; set; }
        public ICollection<Otter> Otters { get; set; } 
        [Required]
        public Location location { get; set; }

        [ForeignKey("location")] //mapuje se na vlastnost public Location location
        public int LocationId { get; set; }
    }
}
