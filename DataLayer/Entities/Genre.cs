using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entities
{
    public class Genre
    {
        [Key]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Artist> Artists { get; set; }
    }
}
