using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Region
    {

        private readonly List<RegionCoordinate> _coordinates = new List<RegionCoordinate>();
        public Region()
        {
        }

        public Region(Guid id, string name): this(id, name, null, false, new Coordinate[]{})
        {
        }

        public Region(Guid id, string name, Region parent, bool coastal, IReadOnlyCollection<Coordinate> coordinates)
        {
            Id = id;
            Name = name;
            Parent = parent;
            Coastal = coastal;
            foreach (var c in coordinates)
            {
                _coordinates.Add(new RegionCoordinate(this.Id,c.Id));
            }
        }
        public IReadOnlyCollection<RegionCoordinate> Coordinates => _coordinates;
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public Region Parent { get; set; }
        public string Name { get; set; }
        public bool Coastal { get; set; }
        
    }
}
