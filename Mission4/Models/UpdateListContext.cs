
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class UpdateListContext : DbContext
    {
        public UpdateListContext(DbContextOptions<UpdateListContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<UpdateList> Responses { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Family"},
                new Category { CategoryId = 2, CategoryName = "Action/Adventure"},
                new Category { CategoryId = 3, CategoryName = "Drama"},
                new Category { CategoryId = 4, CategoryName = "Horror/Suspense"},
                new Category { CategoryId = 5, CategoryName = "Misc"},
                new Category { CategoryId = 6, CategoryName = "TV"},
                new Category { CategoryId = 7, CategoryName = "VHS"}


                );
            mb.Entity<UpdateList>().HasData(
                new UpdateList
                {
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "The Secret Life of Walter Mitty",
                    Year = 2013,
                    Director = "Ben Stiller",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "No one",
                    Notes = "Best movie ever made"

                },
                new UpdateList
                {
                    MovieId = 2,
                    CategoryId = 1,
                    Title = "The Lego Movie",
                    Year = 2014,
                    Director = "Phil Lord, Chris Miller",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "No one",
                    Notes = "Another wonderful film"
                },
                new UpdateList
                {
                    MovieId = 3,
                    CategoryId = 2,
                    Title = "Captain America: Civil War",
                    Year = 2016,
                    Director = "Joe Russo, Anthony Russo",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "Bucky",
                    Notes = "Best Cap'n America movie"
                }
            );
        }
    }
}