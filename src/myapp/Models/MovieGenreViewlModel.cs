using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace myapp.Models
{
    public class MovieGenreViewlModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
        
    }
}