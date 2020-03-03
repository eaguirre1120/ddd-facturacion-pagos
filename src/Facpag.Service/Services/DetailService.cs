using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Facpag.Domain.Entities;
using Facpag.Domain.Interfaces;
using Facpag.Domain.Interfaces.Services.Detail;

namespace Facpag.Service.Services
{
    public class DetailService : IDetailService
    {
        private IRepository<DetailEntity> _repository;
        public DetailService(IRepository<DetailEntity> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<DetailEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<DetailEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<DetailEntity> Post(DetailEntity detail)
        {
            return await _repository.InsertAsync(detail);
        }

        public async Task<DetailEntity> Put(DetailEntity detail)
        {
            return await _repository.UpdateAsync(detail);
        }
    }
}
