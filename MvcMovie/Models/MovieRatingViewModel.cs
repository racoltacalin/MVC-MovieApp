using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieRatingViewModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList RatingCriteria { get; set; }
        public string MovieRating { get; set; }
        public string SearchRatingString { get; set; }
    }
}
