
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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<UpdateList>().HasData(
                new UpdateList
                {
                    Category = "Family",
                    Title = "The Secret Life of Walter Mitty",
                    Year = 2013,
                    Director = "Ben Stiller",
                    Rating = "PG",
                    //Edited = false,
                    LentTo = "No one",
                    Notes = "Best movie ever made"

                },
                new UpdateList
                {
                    Category = "Family",
                    Title = "The Lego Movie",
                    Year = 2014,
                    Director = "Phil Lord, Chris Miller",
                    Rating = "PG",
                    //Edited = false,
                    LentTo = "No one",
                    Notes = "Another wonderful film"
                },
                new UpdateList
                {
                    Category = "Action/Adventure",
                    Title = "Captain America: Civil War",
                    Year = 2016,
                    Director = "Joe Russo, Anthony Russo",
                    Rating = "PG-13",
                    //Edited = false,
                    LentTo = "Bucky",
                    Notes = "Best Cap'n America movie"
                }
            );
        }
    }
}