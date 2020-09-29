using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace databaseOtters.Model
{
    public class Otter
    {
        public string Name { get; set; }
        public string Color { get; set; }
        [Key]
        public int tattooID { get; set; } 
        public Otter Mother { get; set; }

        [ForeignKey("Mother")] // MotherId se váže na Mother
        public int MotherId { get; set; }
        [Required]
        public Place place { get; set; }
        public string PlaceName { get; set; }
        public int LocationId { get; set; }
        public ICollection<Otter> children { get; set; }
    }
}
