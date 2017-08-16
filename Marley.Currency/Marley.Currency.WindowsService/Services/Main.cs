using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Threading;
using Excel;
using Marley.Currency.Domain.DataEntities;
using Plataforma.Infrastructure.WindowService.Service.Services;

namespace Marley.Currency.WindowsService.Services
{
    class Main
    {
        public static void Load()
        {
            var source = ConfigurationManager.AppSettings["SourceSheet"];
            var target = ConfigurationManager.AppSettings["TargetSheet"];

            File.Copy(source, target, true);

            var stream = File.Open(target, FileMode.Open, FileAccess.Read);
            var excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            excelReader.IsFirstRowAsColumnNames = true;

            var stockList = new List<Stock>();

            while (excelReader.Read())
            {
                var name = excelReader.GetString(0);
                var value = excelReader.GetString(1);
                var oscillation = excelReader.GetString(2);

                if (name != "Ativo")
                {
                    stockList.Add(new Stock
                    {
                        Name = name,
                        Value = !value.Equals("-") && !value.Equals("#N/A") ? Convert.ToDecimal(value) : (decimal?)null,
                        Oscillation = !oscillation.Equals("-") && !oscillation.Equals("#N/A") ? Convert.ToDecimal(oscillation) : (decimal?)null,
                    });
                }
            }
            
            var service = new ServiceReference.ServiceClient();
            var log = service.UpdateStocks(stockList.ToArray());
            service.Close();

            UtilService.Log($"[{DateTime.Now.ToShortTimeString()}] {log}" + Environment.NewLine, ConfigurationManager.AppSettings["Log"]);
            
            excelReader.Close();            
            File.Delete(target);
        }
    }
}