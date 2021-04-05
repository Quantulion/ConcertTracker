using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entities
{
    public class Concert
    {
        public int Id { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int ConcertHallId { get; set; }
        public ConcertHall ConcertHall { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Artist> Artists { get; set; }
    }
}
