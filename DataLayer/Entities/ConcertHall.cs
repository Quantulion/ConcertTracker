using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entities
{
    public class ConcertHall
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [MaxLength(50)]
        public string Address { get; set; }
        public string Photo { get; set; }
        public List<Concert> Concerts { get; set; }
        public override string ToString()
        {
            return $"Concert Hall: {Name}, Address: {Address}, About: {Description}";
        }
    }
}
