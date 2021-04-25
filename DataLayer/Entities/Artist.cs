using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class Artist : User
    {
        public List<Concert> Concerts { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
