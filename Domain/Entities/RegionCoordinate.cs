using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class RegionCoordinate
    {
        public Guid RegionId { get; }
        public Guid CoordinateId { get; }
        private RegionCoordinate()
        {
        }
        public RegionCoordinate(Guid region, Guid coordinate)
        {
            RegionId = region;
            CoordinateId = coordinate;
        }

        public override bool Equals(object obj)
        {
            var that = obj as RegionCoordinate;

            if (ReferenceEquals(that, null))
                return false;

            if (GetType() != obj.GetType())
                return false;

            return that.RegionId == this.RegionId && that.CoordinateId == this.CoordinateId;
        }

        public override int GetHashCode()
        {
            return 31+this.RegionId.GetHashCode() * 23 + this.CoordinateId.GetHashCode();
        }

        public static bool operator ==(RegionCoordinate a, RegionCoordinate b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(RegionCoordinate a, RegionCoordinate b)
        {
            return !(a == b);
        }
    }
}
