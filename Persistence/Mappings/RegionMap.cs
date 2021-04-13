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
    public class RegionMap: IEntityTypeConfiguration<Region>
    {
       
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.ToTable("Regions");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Parent)
                .WithMany()
                .HasForeignKey(x => x.ParentId)
                .HasPrincipalKey(parent => parent.Id)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder.Metadata.FindNavigation(nameof(Region.Coordinates))
                .SetPropertyAccessMode(PropertyAccessMode.Field);
            
            builder.HasData(GetDefaults()
                .Select(
                    x => new
                    {
                        x.Id,
                        x.Name,
                        ParentId = (Guid?) (x.Parent == null?null:x.Parent.Id),
                        x.Coastal
                    }).Cast<object>().ToArray());
        }

        private static IEnumerable<Region> GetDefaults()
        {
            return new List<Region>
            {
                SeedConstants.stockholm,
                SeedConstants.solna,
                SeedConstants.sodermalm,
                SeedConstants.kista
            };
        }
    }
}
