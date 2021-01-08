using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public partial class Movie
    {
        public int Id { get; set; }
        [Required] 
        public string MovieName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public string ReleaseDate { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public string Duration { get; set; }
    }
}
