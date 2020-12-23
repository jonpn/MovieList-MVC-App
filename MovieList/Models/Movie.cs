﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieList.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required(ErrorMessage ="Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1889,2999,ErrorMessage ="Year must be after 1889.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage = "Rating must be 1 and 5.")]
        public int? Rating { get; set; }

        [Required(ErrorMessage = "Please enter a genre.")]
        public string GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
