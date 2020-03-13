using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_pmarshall_ProgrammingChallenge1.Models
{
    public class ContactContext : DbContext
    {
        // Constructor that accepts Dbcontext object, inherits from the DbContext base class
        public ContactContext(DbContextOptions<ContactContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding Category Data
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Work" },
                new Category { CategoryId = 2, Name = "Friend" },
                new Category { CategoryId = 3, Name = "Family" },
                new Category { CategoryId = 4, Name = "Other" }
                );

            // Seeding Contact Info
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    FirstName = "James",
                    LastName = "Marshall",
                    Phone = "720-965-1963",
                    Email = "james_marshall48@aol.com",
                    Organization = "Student",
                    ContactId = 1,
                    DateAdded = DateTime.Now,
                    CategoryId = 3
                },
                new Contact
                {
                    FirstName = "Philip",
                    LastName = "Marshall",
                    Phone = "720-965-5459",
                    Email = "philip.marshall123456789@gmail.com",
                    Organization = "Student",
                    ContactId = 2,
                    DateAdded = DateTime.Now,
                    CategoryId = 3
                },
                new Contact
                {
                    FirstName = "Keith",
                    LastName = "Howard",
                    Phone = "777-777-7777",
                    Email = "keith.howard@whatever.com",
                    Organization = "Teacher",
                    ContactId = 3,
                    DateAdded = DateTime.Now,
                    CategoryId = 1
                });
        }
    }
}
