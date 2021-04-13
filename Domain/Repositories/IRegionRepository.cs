using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Dto;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface IRegionRepository
    {
        Task<IReadOnlyCollection<RegionWithCoordinatesDto>> GetAllAsync();
        Task<RegionWithCoordinatesDto> GetByIdAsync(Guid id);
    }
}
