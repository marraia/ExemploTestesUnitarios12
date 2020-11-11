using Marraia.Dominio;
using Marraia.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marraia.Repositorio
{
    public class ItemRepositorio : IItemRepositorio
    {
        public Task<IEnumerable<Item>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Item> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
