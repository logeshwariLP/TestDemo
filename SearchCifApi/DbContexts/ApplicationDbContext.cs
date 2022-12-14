using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using SearchCifApi.Models;

namespace SearchCifApi.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<CifUser> CifUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CifUser>().HasData(new CifUser
            {
                emailId = "aaa@test.com",
                CifId = 00001
            });
            modelBuilder.Entity<CifUser>().HasData(new CifUser
            {
                emailId = "bbb@test.com",
                CifId = 00002
            });
            modelBuilder.Entity<CifUser>().HasData(new CifUser
            {
                emailId = "ccc@test.com",
                CifId = 00003
            });
            modelBuilder.Entity<CifUser>().HasData(new CifUser
            {
                emailId = "ddd@test.com",
                CifId = 00004
            });
            modelBuilder.Entity<CifUser>().HasData(new CifUser
            {
                emailId = "eee@test.com",
                CifId = 00005
            });
            modelBuilder.Entity<CifUser>().HasData(new CifUser
            {
                emailId = "fff@test.com",
                CifId = 00006
            });
            modelBuilder.Entity<CifUser>().HasData(new CifUser
            {
                emailId = "ggg@test.com",
                CifId = 00007
            });
        }
    }
}
