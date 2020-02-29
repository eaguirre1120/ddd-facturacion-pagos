using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Facpag.Domain.Entities;
using Facpag.Domain.Interfaces;
using Facpag.Domain.Interfaces.Services.Product;

namespace Facpag.Service.Services
{
    public class ProductService : IProductService
    {
        private IRepository<ProductEntity> _respository;
        public ProductService(IRepository<ProductEntity> repository)
        {
            _respository = repository;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _respository.DeleteAsync(id);
        }

        public async Task<ProductEntity> Get(Guid id)
        {
            return await _respository.SelectAsync(id);
        }

        public async Task<IEnumerable<ProductEntity>> GetAll()
        {
            return await _respository.SelectAsync();
        }

        public async Task<ProductEntity> Post(ProductEntity product)
        {
            return await _respository.InsertAsync(product);
        }

        public async Task<ProductEntity> Put(ProductEntity product)
        {
            return await _respository.UpdateAsync(product);
        }
    }
}
