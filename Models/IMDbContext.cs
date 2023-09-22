using System;
using Microsoft.EntityFrameworkCore;

namespace IMDb.Models
{
	public class IMDbContext : DbContext
    {
        public DbSet<Film> Filmer { get; set; }
        public DbSet<ActorActris> ActorActris { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=IMDb-Manager;User Id=sa;Password=Password123;Encrypt=false;");
        }

    }
}

