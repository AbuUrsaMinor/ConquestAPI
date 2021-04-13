using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class CoordinateVm
    {
        public Guid Id { get; }
        public double Longitude { get; }
        public double Latitude { get; }

        public CoordinateVm(Guid id, double longitude, double latitude)
        {
            Id = id;
            Longitude = longitude;
            Latitude = latitude;
        }
    }
}
