using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Mappings
{
    public class RegionCoordinateMap : IEntityTypeConfiguration<RegionCoordinate>
    {
        public void Configure(EntityTypeBuilder<RegionCoordinate> builder)
        {
            builder.ToTable("RegionCoordinates");

            builder.HasKey(key => new {key.RegionId, key.CoordinateId});

            builder.HasOne<Region>()
                .WithMany(x => x.Coordinates)
                .HasForeignKey(c => c.RegionId)
                .HasPrincipalKey(x => x.Id);

            builder.HasOne<Coordinate>()
                .WithMany()
                .HasForeignKey(c => c.CoordinateId)
                .HasPrincipalKey(x => x.Id);

            builder.HasData(GetDefaults()
                .Select(
                    x => new
                    {
                        x.RegionId,
                        x.CoordinateId
                    }).Cast<object>().ToArray());
        }

        private static IEnumerable<RegionCoordinate> GetDefaults()
        {
            return new List<RegionCoordinate>
            {
                new RegionCoordinate(SeedConstants.stockholm.Id, SeedConstants.stockholm1.Id),
                new RegionCoordinate(SeedConstants.stockholm.Id, SeedConstants.stockholm2.Id),
                new RegionCoordinate(SeedConstants.stockholm.Id, SeedConstants.stockholm3.Id),
                new RegionCoordinate(SeedConstants.stockholm.Id, SeedConstants.stockholm4.Id),

                new RegionCoordinate(SeedConstants.solna.Id, SeedConstants.solna1.Id),
                new RegionCoordinate(SeedConstants.solna.Id, SeedConstants.solna2.Id),
                new RegionCoordinate(SeedConstants.solna.Id, SeedConstants.solna3.Id),
                new RegionCoordinate(SeedConstants.solna.Id, SeedConstants.solna4.Id),

                new RegionCoordinate(SeedConstants.sodermalm.Id, SeedConstants.sodermalm1.Id),
                new RegionCoordinate(SeedConstants.sodermalm.Id, SeedConstants.sodermalm2.Id),
                new RegionCoordinate(SeedConstants.sodermalm.Id, SeedConstants.sodermalm3.Id),
                new RegionCoordinate(SeedConstants.sodermalm.Id, SeedConstants.sodermalm4.Id),

                new RegionCoordinate(SeedConstants.kista.Id, SeedConstants.kista1.Id),
                new RegionCoordinate(SeedConstants.kista.Id, SeedConstants.kista2.Id),
                new RegionCoordinate(SeedConstants.kista.Id, SeedConstants.kista3.Id),
                new RegionCoordinate(SeedConstants.kista.Id, SeedConstants.kista4.Id),
            };
        }
    }
}