using Marraia.Application.AppItem.Input;
using Marraia.Application.AppItem.Interfaces;
using Marraia.Dominio;
using Marraia.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marraia.Application.AppItem
{
    public class ItemAppService : IItemAppService
    {
        private readonly IItemRepositorio _itemRepository;
        private readonly IStockRepository _stockRepository;

        public ItemAppService(
            IItemRepositorio itemRepository,
            IStockRepository stockRepository
        )
        {
            _itemRepository = itemRepository;
            _stockRepository = stockRepository;
        }

        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            return await _itemRepository
                            .GetAllAsync()
                            .ConfigureAwait(false);
        }

        public async Task<Item> InsertAsync(ItemInput input)
        {
            if (string.IsNullOrEmpty(input.Description))
                throw new ArgumentNullException("Descrição do produto é obrigatório!!");

            if (input.Ammount <= 0)
                throw new ArgumentNullException("Quantidade de estoque necessita ser maior que zero");

            var item = new Item(input.Description, input.Price);

            await _itemRepository
                    .InsertAsync(item)
                    .ConfigureAwait(false);

            var stock = new Stock(item.Id, input.Ammount);

            await _stockRepository
                    .InsertAsync(stock)
                    .ConfigureAwait(false);

            return item;
        }
    }
}
