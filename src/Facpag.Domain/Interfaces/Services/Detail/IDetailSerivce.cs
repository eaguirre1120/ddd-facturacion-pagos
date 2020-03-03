using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Facpag.Domain.Entities;

namespace Facpag.Domain.Interfaces.Services.Detail
{
    public interface IDetailService
    {
        Task<DetailEntity> Get(Guid id);
        Task<IEnumerable<DetailEntity>> GetAll();
        Task<DetailEntity> Post(DetailEntity detail);
        Task<DetailEntity> Put(DetailEntity detail);
        Task<bool> Delete(Guid id);
    }
}
