using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Back.Models
{
   public  class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }
    }
}
