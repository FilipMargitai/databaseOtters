﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace databaseOtters.Model
{
    public class Place
    {
        [Key]
        public string Name { get; set; }
    }
}