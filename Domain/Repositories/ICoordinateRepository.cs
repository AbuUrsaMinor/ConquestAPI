using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface ICoordinateRepository
    {
        Task<IReadOnlyCollection<Coordinate>> GetAllAsync();
        Task<Coordinate> GetByIdAsync(Guid id);
        void Add(Coordinate coordinate);
    }
}
