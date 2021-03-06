using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using projectProgra2020.Models;


namespace projectProgra2020.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        public DbSet<projectProgra2020.Models.Registro> Registro { get; set; }
        public DbSet<projectProgra2020.Models.Producto> producto { get; set; }
        public DbSet<projectProgra2020.Models.Productom> productom { get; set; }
        public DbSet<projectProgra2020.Models.Producton> producton { get; set; }

    }
}