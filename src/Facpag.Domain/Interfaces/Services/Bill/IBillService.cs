using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Facpag.Domain.Entities;

namespace Facpag.Domain.Interfaces.Services.Bill
{
    public interface IBillService
    {
        Task<BillEntity> Get(Guid id);
        Task<IEnumerable<BillEntity>> GetAll();
        Task<BillEntity> Post(BillEntity bill);
        Task<BillEntity> Put(BillEntity bill);
        Task<bool> Delete(Guid id);
    }
}
