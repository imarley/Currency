using System.Collections.Generic;
using System.Linq;
using Marley.Currency.Domain.DataEntities;
using Marley.Currency.Domain.Interfaces.Repositories;

namespace Marley.Currency.Data.Repositories
{
    public class StockRepository : RepositoryBase<Stock>, IStockRepository
    {
        public IEnumerable<Stock> GetList()
        {
            return _context.Stock.ToList();
        }

        public string UpdateStocks(IEnumerable<Stock> stockList)
        {
            _context.Database.ExecuteSqlCommand("TRUNCATE TABLE Stock");
            _context.Stock.AddRange(stockList);
            _context.SaveChanges();
            return "Updated successfully";
        }
    }
}