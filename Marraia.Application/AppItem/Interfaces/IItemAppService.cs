using Marraia.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marraia.Application.AppItem.Interfaces
{
    public interface IItemAppService
    {
        Task InsertAsync(Item item);
        Task<Item> GetByIdAsync(Guid id);
        Task<IEnumerable<Item>> GetAllAsync();
    }
}
