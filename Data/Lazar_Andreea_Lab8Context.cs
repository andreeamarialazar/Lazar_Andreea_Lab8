using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lazar_Andreea_Lab8.Models;

namespace Lazar_Andreea_Lab8.Data
{
    public class Lazar_Andreea_Lab8Context : DbContext
    {
        public Lazar_Andreea_Lab8Context (DbContextOptions<Lazar_Andreea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Lazar_Andreea_Lab8.Models.Book> Book { get; set; }

        public DbSet<Lazar_Andreea_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Lazar_Andreea_Lab8.Models.Category> Category { get; set; }
    }
}
