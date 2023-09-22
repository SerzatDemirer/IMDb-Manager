using System;
using System.ComponentModel.DataAnnotations;

namespace IMDb.Models
{
    public class ActorActris
    {
        public int Id { get; set; }
        public string? Förnamn { get; set; }
        public string? Efternamn { get; set; }
        public DateTime Födelsedatum { get; set; }
    }
}


