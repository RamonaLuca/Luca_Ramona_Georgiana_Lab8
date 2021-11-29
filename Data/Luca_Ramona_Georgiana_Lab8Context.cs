using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Luca_Ramona_Georgiana_Lab8.Models;

namespace Luca_Ramona_Georgiana_Lab8.Data
{
    public class Luca_Ramona_Georgiana_Lab8Context : DbContext
    {
        public Luca_Ramona_Georgiana_Lab8Context (DbContextOptions<Luca_Ramona_Georgiana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Luca_Ramona_Georgiana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Luca_Ramona_Georgiana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Luca_Ramona_Georgiana_Lab8.Models.Category> Category { get; set; }
    }
}
