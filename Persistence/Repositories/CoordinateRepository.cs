using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Persistence.Db;

namespace Persistence.Repositories
{
    public class CoordinateRepository : ICoordinateRepository
    {
        private readonly DbContext _db;

        public CoordinateRepository(ConquestDbContext db)
        {
            _db = db;
        }

        public async Task<IReadOnlyCollection<Coordinate>> GetAllAsync()
        {
            return await _db.Set<Coordinate>()
                .OrderBy(x => x.Latitude)
                .ToListAsync();
        }

        public async Task<Coordinate> GetByIdAsync(Guid id)
        {
            return await _db.Set<Coordinate>()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public void Add(Coordinate c)
        {
            _db.Add(c);
        }
    }
}