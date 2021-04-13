using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.ViewModels;
using Domain.Dto;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services
{
    public class RegionService
    {
        private readonly ICoordinateRepository _coordinateRepo;
        private readonly IRegionRepository _repo;

        public RegionService(ICoordinateRepository coordinateRepo, IRegionRepository repo)
        {
            _coordinateRepo = coordinateRepo;
            _repo = repo;
        }

        public async Task<ICollection<RegionVm>> GetAll()
        {
            IReadOnlyCollection<RegionWithCoordinatesDto> regions = await _repo.GetAllAsync();
            ICollection<RegionVm> vms = new List<RegionVm>();
            foreach (RegionWithCoordinatesDto r in regions)
            {
                var coordinates = new List<CoordinateVm>();
                foreach (Coordinate c in r.Coordinates)
                {
                    coordinates.Add(new CoordinateVm(c.Id, c.Longitude, c.Latitude));
                }
                
               vms.Add(new RegionVm(r.Region.Id,r.Region.Name,r.Region.Coastal,coordinates));
            }

            return vms;
        } 
    }
}
