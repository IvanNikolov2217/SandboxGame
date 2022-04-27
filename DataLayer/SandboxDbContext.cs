using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class SandboxDbContext : DbContext
    {
        public SandboxDbContext()
        {

        }

        public SandboxDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"Server=127.0.0.1;Port=3306;Database=AirportDB;Uid=root;Pwd=ivan221718;");

            //base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Battle> Battles { get; set; }

        public DbSet<Users> Users { get; set; }

        public DbSet<Heroes> Heroes { get; set; }

        public DbSet<Roles> Roles { get; set; }

        public DbSet<Rounds> Rounds { get; set; }

    }
}
