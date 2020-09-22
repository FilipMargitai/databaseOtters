using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace databaseOtters.Model
{
    public class Otter
    {
        public string Name { get; set; }
        public string Color { get; set; }
        [Key]
        public int? tattooID { get; set; } 
    }
}
