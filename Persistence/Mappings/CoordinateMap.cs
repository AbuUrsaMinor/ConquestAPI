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
    public class CoordinateMap: IEntityTypeConfiguration<Coordinate>
    {
        public void Configure(EntityTypeBuilder<Coordinate> builder)
        {
            builder.ToTable("Coordinates");
            builder.HasKey(x => x.Id);

            builder.HasData(GetDefaults()
                .Select(
                    x => new
                    {
                        x.Id,
                        x.Latitude,
                        x.Longitude
                    }).Cast<object>().ToArray());
        }

        private static IEnumerable<Coordinate> GetDefaults()
        {

            return new List<Coordinate>
            {
                SeedConstants.kista1,
                SeedConstants.kista2,
                SeedConstants.kista3,
                SeedConstants.kista4,
                SeedConstants.stockholm1,
                SeedConstants.stockholm2,
                SeedConstants.stockholm3,
                SeedConstants.stockholm4,
                SeedConstants.solna1,
                SeedConstants.solna2,
                SeedConstants.solna3,
                SeedConstants.solna4,
                SeedConstants.sodermalm1,
                SeedConstants.sodermalm2,
                SeedConstants.sodermalm3,
                SeedConstants.sodermalm4,
            };
        }
    }
}
