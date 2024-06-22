using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    class AplicationDBContext : DbContext
    {
        public AplicationDBContext(DbContextOptions dbContexOptions) : base (dbContexOptions)
        {}

        public DbSet<Models.Stock> Stocks { get; set; }
        public DbSet<Models.Comment> Comments{ get; set; }
    }

}