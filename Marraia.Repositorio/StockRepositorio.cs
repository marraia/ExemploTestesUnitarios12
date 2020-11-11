using Marraia.Dominio;
using Marraia.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marraia.Repositorio
{
    public class StockRepositorio : IStockRepositorio
    {
        public Task<Stock> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(Stock stock)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Stock stock)
        {
            throw new NotImplementedException();
        }
    }
}
