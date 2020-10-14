using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent
{
    public class StreamingContentBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public Genre Genre { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public bool IsFamilyFriendly {
            get
            {
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.PG_13:
                        return true;
                    case MaturityRating.R:
                    case MaturityRating.NC_17:
                        return false;
                    default:
                        throw new InvalidEnumArgumentException("Not a valid category");
                }
            }
        }

        public StreamingContentBase() { }

        public StreamingContentBase(string title, string description, double starRating, Genre genre, MaturityRating maturityRating)
        {
            Title = title;
            Description = description;
            StarRating = starRating;
            Genre = genre;
            MaturityRating = maturityRating;
        }
    }

    public enum Genre
    {
        Horror,
        RomCom,
        SciFi,
        Action,
        Documentary,
        Musical,
        Drama,
        Mystery
    }

    public enum MaturityRating
    {
        G,
        PG,
        PG_13,
        R,
        NC_17
    }
}
