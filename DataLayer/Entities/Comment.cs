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
        public List<PersonComment> Likes { get; set; }
        //public List<Person> Persons { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
