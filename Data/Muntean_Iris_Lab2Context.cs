using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Muntean_Iris_Lab2.Models;

namespace Muntean_Iris_Lab2.Data
{
    public class Muntean_Iris_Lab2Context : DbContext
    {
        public Muntean_Iris_Lab2Context (DbContextOptions<Muntean_Iris_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Muntean_Iris_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Muntean_Iris_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
