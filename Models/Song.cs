﻿using System.ComponentModel.DataAnnotations;

namespace Assignment_5.Models
{
    public class Song
    {
        public int Id { get; set; }

        public string Title { get; set; }
      
        public string Performer { get; set; }
        
        public string Genre { get; set; }
      
        public decimal Price { get; set; }
    }
}
