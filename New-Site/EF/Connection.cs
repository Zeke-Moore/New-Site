using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Site.EF;
using Site.Models.Entities;

namespace Site.EF
{
    public class Connection : DbContext
    {
        public Connection()
        {

        }
        public Connection(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                     // @"Server=csc435.database.windows.net;Database=NotesAPI;Trusted_Connection=True;MultipleActiveResultSets=true;",
                     @"Server = tcp:csc435.database.windows.net; " +
                    "Database=NotesAPI;Uid=dmoore@csc435.database.windows.net;Pwd=*GOLDEN_fire12*;Encrypt=yes;",
                options => options.ExecutionStrategy(c => new MyExecutionStrategy(c)));
            }
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Category> Notes { get; set; }
        public DbSet<Category> User { get; set; }
    }
}
