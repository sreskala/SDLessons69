﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPI.Models
{
    public class Species
    {

        public string name { get; set; }
        public string classification { get; set; }
        public string designation { get; set; }
        public string average_height { get; set; }
        public string skin_colors { get; set; }
        public string hair_colors { get; set; }
        public string eye_colors { get; set; }
        public string average_lifespan { get; set; }
        public object homeworld { get; set; }
        public string language { get; set; }
        public List<string> people { get; set; }
        public List<string> films { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string url { get; set; }


    }
}
