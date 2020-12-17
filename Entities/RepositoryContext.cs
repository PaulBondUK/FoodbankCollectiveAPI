using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Foodbank> Foodbanks { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}