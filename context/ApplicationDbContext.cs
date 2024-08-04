using EF__task.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF__task.context
{
    internal class ApplicationDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer("Server=localhost;Database=ASP9_EF;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<product> Products { get; set; }
    }
}
