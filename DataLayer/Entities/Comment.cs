using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Content { get; set; }
        [Required]
        public DateTime PublishTime { get; set; }
        public List<UserComment> Likes { get; set; }
        //public List<Person> Persons { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
