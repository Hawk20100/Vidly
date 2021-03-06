﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name ="Released Date")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Added Date")]
        public DateTime? DateAdded { get; set; }

        [Required]
        [Display(Name ="Number In Stock")]
        [Range(1,20)]
        public int NumberInStock { get; set; }

        public Genre Genre { get; set; }

        [Display(Name ="Genre")]
        public int GenreId { get; set; }
    }
}