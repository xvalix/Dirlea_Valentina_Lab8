using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dirlea_Valentina_Lab8.Models;

namespace Dirlea_Valentina_Lab8.Data
{
    public class Dirlea_Valentina_Lab8Context : DbContext
    {
        public Dirlea_Valentina_Lab8Context (DbContextOptions<Dirlea_Valentina_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Dirlea_Valentina_Lab8.Models.Book> Book { get; set; }

        public DbSet<Dirlea_Valentina_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
