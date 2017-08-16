using System.Collections.Generic;
using Marley.Currency.Domain.DataEntities;

namespace Marley.Currency.Domain.Interfaces.Repositories
{
    public interface IStockRepository : IRepositoryBase<Stock>
    {
        IEnumerable<Stock> GetList();
        string UpdateStocks (IEnumerable<Stock> stockList);
    }
}