using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marraia.Dominio.Interfaces
{
    public interface IStockRepositorio
    {
        Task InsertAsync(Stock stock);
        Task UpdateAsync(Stock stock);
        Task<Stock> GetByIdAsync(Guid id);
    }
}
