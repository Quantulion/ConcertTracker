using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public class User : IdentityUser
    {
        public int Age { get; set; }
        public string Description { get; set; }
        public List<Comment> Comments { get; set; }
        public List<UserComment> Likes { get; set; }
    }
}
