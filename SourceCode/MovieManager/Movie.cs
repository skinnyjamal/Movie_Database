﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace MovieManager
{
    public class Movie
    {
        public string Genre { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Synopsis { get; set; }

    }
}
