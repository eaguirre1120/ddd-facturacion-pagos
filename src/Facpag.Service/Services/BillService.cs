using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Facpag.Domain.Entities;
using Facpag.Domain.Interfaces;
using Facpag.Domain.Interfaces.Services.Bill;

namespace Facpag.Service.Services
{
    public class BillService : IBillService
    {
        private IRepository<BillEntity> _repository;

        public BillService(IRepository<BillEntity> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<BillEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<BillEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<BillEntity> Post(BillEntity bill)
        {
            return await _repository.InsertAsync(bill);
        }

        public async Task<BillEntity> Put(BillEntity bill)
        {
            return await _repository.UpdateAsync(bill);
        }
    }
}
