using System;
using Domain;

namespace Persistence
{
    public class ConquestDbContext: DbContext
    {
	    public ConquestDbContext(DbContextOptions<ConquestDbContext> options): base( options )
	    {
	    }

        public DbSet<Region> Regions { get; set; }
    }
}
