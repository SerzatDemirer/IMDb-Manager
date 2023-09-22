using System;
namespace IMDb.Models
{
	public class Film
	{
        public int Id { get; set; }
        public string? Titel { get; set; }
        public string? Handling { get; set; }
        public string? Genre { get; set; }
        public string? Regissör { get; set; }
        public DateTime Premiär { get; set; }

    }
}

