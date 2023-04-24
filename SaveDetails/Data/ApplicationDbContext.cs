using Microsoft.EntityFrameworkCore;
using SaveDetails.Models;
using System.Collections.Generic;

namespace SaveDetails.Data
{
    public class ApplicationDbContext : DbContext

    {

        // Constructor that takes in options for the DbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }
        public DbSet<ProjectModel> Project { get; set; }
    }
}
