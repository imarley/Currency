using System.Collections.Generic;
using System.ServiceModel;
using Marley.Currency.Domain.DataEntities;

namespace Marley.Currency.Wcf
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        IEnumerable<Stock> GetList();

        [OperationContract]
        string UpdateStocks(IEnumerable<Stock> stockList);
    }
}