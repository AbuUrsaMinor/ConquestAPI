using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.ViewModels;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services
{
    public class CoordinateService
    {
        private readonly ICoordinateRepository _repo;

        public CoordinateService(ICoordinateRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<CoordinateVm>> GetAll()
        {
            IReadOnlyCollection<Coordinate> coordinates = await _repo.GetAllAsync();
            List<CoordinateVm> vms = new List<CoordinateVm>();
            foreach (Coordinate c in coordinates)
            {
                vms.Add(new CoordinateVm(c.Id,c.Latitude,c.Longitude));
            }

            return vms;
        } 
    }
}
