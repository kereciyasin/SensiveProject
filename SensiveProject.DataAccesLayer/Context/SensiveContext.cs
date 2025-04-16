using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.DataAccesLayer.Context
{
    public class SensiveContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KERECI\\SQLEXPRESS;Initial Catalog=SensiveBlogDb;Integrated Security=true;TrustServerCertificate=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Artikel> Artikels { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }

    }
}
