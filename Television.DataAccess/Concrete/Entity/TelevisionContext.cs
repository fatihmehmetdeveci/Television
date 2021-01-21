using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Television.DataAccess.Concrete.Entity
{
    public class TelevisionContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder
            optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TelevisionDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public DbSet<Entities.Concrete.Television> Televisions { get; set; }
        public DbSet<Entities.Concrete.post> posts { get; set; }
    }
}
