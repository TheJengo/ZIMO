using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZIMO.DAL.Abstractions;
using ZIMO.DAL.Concretes;
using ZIMO.Entities.Abstractions;
using ZIMO.Entities.Concretes;

namespace ZIMO.BLL.General_Operations
{
    internal class StockController
    {
        public static IList<Stock> GetAllStocks()
        {
            IStockRepository stockRepository = new StockRepository();
            return stockRepository.GetAll().Select(x=>x = stockRepository.GetSingle(y=>y.Id.Equals(x.Id),y=>y.Borrows,y=>y.Garbages)).ToList();
        }

        public static IList<Stock> GetStocksByItemId(int id)
        {
            IStockRepository stockRepository = new StockRepository();
            return stockRepository.GetList(x => x.Id.Equals(id));
        }

        public static void ManageStock(Stock stock, EntityState entityState)
        {
            IStockRepository stockRepository = new StockRepository();
            stock.EntityState = entityState;
            stockRepository.Update(stock);
        }
    }
}
