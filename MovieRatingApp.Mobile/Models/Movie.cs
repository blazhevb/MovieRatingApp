using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingApp.Mobile.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Rating 
        { 
            get; 
            set; 
        }
    }
}
