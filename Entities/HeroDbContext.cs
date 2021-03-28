using System;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using api.Entities;
namespace api.Entities
{
    public class HeroDbContext: DbContext
    {
        public DbSet<Hero> Heroes { get; set; }
        public HeroDbContext()
        {

        }

        public HeroDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}