using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IntomexApi.Models.DBModel;

namespace IntomexApi.Data
{
    public class IntomexApiContext : DbContext
    {
        public IntomexApiContext (DbContextOptions<IntomexApiContext> options)
            : base(options)
        {
        }

        public DbSet<IntomexApi.Models.DBModel.Categories> Categories { get; set; }

        public DbSet<IntomexApi.Models.DBModel.Products> Products { get; set; }

        public DbSet<IntomexApi.Models.DBModel.ProductsXimage> ProductsXimage { get; set; }
    }
}
