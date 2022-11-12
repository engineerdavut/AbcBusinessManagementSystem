using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Contexts
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder
            dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BusinessManagementSystemDb;"+
                "integrated security = true; ");
        }
        public DbSet<Account> accounts { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Team> teams { get; set; }
        public DbSet<UserOperation> userOperations { get; set; }

        public DbSet<UserOperationClaim> userOperationClaims { get; set; }
        public DbSet<TeamOfAccount> teamOfAccounts { get; set; }
    }
}
