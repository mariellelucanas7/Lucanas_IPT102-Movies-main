using System;
using Microsoft.AspNetCore.Mvc.TagHelpers;
namespace BSIT3L_Movies.Models
{
    
	public class MovieViewModel
    {
        public string WatchMovie { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }  
    }
}

