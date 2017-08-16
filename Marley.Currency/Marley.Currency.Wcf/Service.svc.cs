using System.Collections.Generic;
using Marley.Currency.Data.Repositories;
using Marley.Currency.Domain.DataEntities;

namespace Marley.Currency.Wcf
{
    public class Service : IService
    {
        StockRepository _stockRepository = new StockRepository();

        public IEnumerable<Stock> GetList()
        {
            return _stockRepository.GetList();
        }

        public string UpdateStocks(IEnumerable<Stock> stockList)
        {
            return _stockRepository.UpdateStocks(stockList);
        }
    }
}