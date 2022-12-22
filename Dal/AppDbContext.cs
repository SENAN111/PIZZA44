using Microsoft.EntityFrameworkCore;
using Pizzamizzadark.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Size = Pizzamizzadark.Models.Size;

namespace Pizzamizzadark.Dal
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-V540I6U\\SQLEXPRESS ; database= PizzaMizza ; integrated security= true ; trusted_connection=true; ww");


        }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Ingerdient> Ingerdients { get; set;}
        
    }
}
