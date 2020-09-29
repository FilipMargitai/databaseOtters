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
        public Location Location { get; set; }

        [ForeignKey("Location")]
        public int LocationId { get; set; }
    }
}
