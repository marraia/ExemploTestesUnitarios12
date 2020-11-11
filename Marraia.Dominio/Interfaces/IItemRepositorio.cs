using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marraia.Dominio.Interfaces
{
    public interface IItemRepositorio
    {
        Task InsertAsync(Item item);
        Task<Item> GetByIdAsync(Guid id);
        Task<IEnumerable<Item>> GetAllAsync();
    }
}
