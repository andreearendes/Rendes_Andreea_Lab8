using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rendes_Andreea_Lab8.Models;

namespace Rendes_Andreea_Lab8.Data
{
    public class Rendes_Andreea_Lab8Context : DbContext
    {
        public Rendes_Andreea_Lab8Context (DbContextOptions<Rendes_Andreea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Rendes_Andreea_Lab8.Models.Book> Book { get; set; }

        public DbSet<Rendes_Andreea_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Rendes_Andreea_Lab8.Models.Category> Category { get; set; }
    }
}
