using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class RegionVm
    {
        public Guid Id { get; }
        public string Name { get; }
        public bool Coastal { get; }
        public CoordinateVm[] Coordinates { get; }

        public RegionVm(Guid id, string name, bool coastal, IEnumerable<CoordinateVm> coordinates )
        {
            Id = id;
            Name = name;
            Coastal = coastal;
            Coordinates = coordinates.ToArray();
        }
    }
}
