using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Giurgiu_Adrian_Lab8.Models;

namespace Giurgiu_Adrian_Lab8.Data
{
    public class Giurgiu_Adrian_Lab8Context : DbContext
    {
        public Giurgiu_Adrian_Lab8Context (DbContextOptions<Giurgiu_Adrian_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Giurgiu_Adrian_Lab8.Models.Book> Book { get; set; }

        public DbSet<Giurgiu_Adrian_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Giurgiu_Adrian_Lab8.Models.Category> Category { get; set; }
    }
}
