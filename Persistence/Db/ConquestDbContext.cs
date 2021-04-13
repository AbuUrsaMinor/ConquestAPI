using System;
using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Db
{
    public class ConquestDbContext: DbContext
    {
	    public ConquestDbContext(DbContextOptions<ConquestDbContext> options): base( options )
	    {
	    }

        public DbSet<Region> Regions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(builder);
        }
    }
}
