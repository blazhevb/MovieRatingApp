using MovieRatingApp.Mobile.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingApp.Mobile.Models
{
    public class MovieApiResponse
    {
        [JsonProperty("results")]
        public List<MovieApiData> Results { get; set; }
    }
}
