﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vid_App.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}