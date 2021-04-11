using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entities
{
    public class Person
    {
        public int Id { get; set; }
        [Required][MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Pass { get; set; }
        public string Description { get; set; }
        public string MailAddress { get; set; }
        public List<Comment> Comments { get; set; }
        //public List<Comment> LikedComments { get; set; }
        public List<PersonComment> Likes { get; set; }
    }
}
