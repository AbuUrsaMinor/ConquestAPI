using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Dto
{
    public class RegionWithCoordinatesDto
    {
        public Region Region { get; set; }
        public IReadOnlyCollection<Coordinate> Coordinates { get; set; }

        public RegionWithCoordinatesDto()
        {

        }
        public RegionWithCoordinatesDto( Region region, Coordinate[] coordinates)
        {
            this.Region = region;
            this.Coordinates = coordinates;
        }
    }
}
