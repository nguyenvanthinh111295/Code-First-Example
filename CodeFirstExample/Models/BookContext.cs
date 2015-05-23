using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstExample.Models
{
    public class BookContext : DbContext
    {
        public BookContext()
            :base("name=BookContext")
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // khai báo Id sẽ là khóa chính
            modelBuilder.Entity<Book>().HasKey(b => b.Id);

            // khai báo Id sẽ tự động tăng
            modelBuilder.Entity<Book>().Property(b => b.Id)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            base.OnModelCreating(modelBuilder);
        }
    }
}