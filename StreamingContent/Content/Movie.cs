﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent.Content
{
    public class Movie : StreamingContentBase
    {
        public double RunTime { get; set; }
        public Movie() { }

        public Movie(string title, string description, double starRating, Genre genre, MaturityRating maturityRating, double runTime)
            : base(title, description, starRating, genre, maturityRating)
        {
            RunTime = runTime;
        }
    }
}
