using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent.Content
{
    public class Show : StreamingContentBase
    {
        public List<Episode> Episodes { get; set; } = new List<Episode>();

        public int EpisodeCount
        {
            get { return Episodes.Count; }
        }

        public double AverageRunTime { get; set; }

        public Show(string title, string description, double starRating, Genre genre, MaturityRating maturityRating, double runTime )
        : base(title, description, starRating, genre, maturityRating)
        {
            AverageRunTime = runTime;
        }
    }

    public class Episode
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                if(value[0].ToString().ToLower() == value[0].ToString())
                {
                    string capitalizedTitle = "";
                    capitalizedTitle += value[0].ToString().ToUpper();
                    capitalizedTitle += value.Substring(1);
                    _title = capitalizedTitle;
                } else
                {
                    _title = value;
                }
            }
        }
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }

        public Episode() { }

        public Episode(string title, double runTime, int season)
        {
            Title = title;
            RunTime = runTime;
            SeasonNumber = season;
        }
    }
}
