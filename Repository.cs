using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MdiLoginSystem
{
    public class Repository : DbContext
    {
        private static readonly String _connectionsParams = @"server=127.0.0.1;port=3307;uid=root;pwd=;database=sistemaprotob";

        public DbSet<User> Users { get; set; }
        public DbSet<Credential> Credentials { get; set; }

        public Repository() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(_connectionsParams);
        }
    }
}
