using System;
using Microsoft.EntityFrameworkCore;

namespace dotnet_ef_core.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Database=ef_db;Uid=root;Pwd=112345;");
        }

        public DbSet<CategoryEntity> categories 
        { 
            get; 
            set; 
        }
    }
}
