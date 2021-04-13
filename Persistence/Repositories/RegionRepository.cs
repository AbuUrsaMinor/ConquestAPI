using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Dto;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Persistence.Db;


namespace Persistence.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly DbContext _db;

        public RegionRepository(ConquestDbContext db)
        {
            _db = db;
        }

        public async Task<IReadOnlyCollection<RegionWithCoordinatesDto>> GetAllAsync()
        {
                return await GetCoordinatesDtos()                
                .OrderBy(x => x.Region.Name)
                .ToListAsync();
        }

        private IQueryable<RegionWithCoordinatesDto> GetCoordinatesDtos()
        {
            return _db.Set<Region>()
                .Include(r => r.Coordinates)
                .Select(r => new RegionWithCoordinatesDto
                {
                    Region = r,
                    Coordinates = _db.Set<RegionCoordinate>().Where(rc => rc.RegionId == r.Id)
                        .Join(_db.Set<Coordinate>(), rc => rc.CoordinateId, c => c.Id,
                            (rc, c) => c
                        )
                        .ToArray()
                });
        }

        public async Task<RegionWithCoordinatesDto> GetByIdAsync(Guid id)
        {
            return await GetCoordinatesDtos()
                .FirstOrDefaultAsync(x => x.Region.Id == id);
        }

        public void Add(Region c)
        {
            _db.Add(c);
        }
    }
}