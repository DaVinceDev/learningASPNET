using System;
using api.DTOs.Stock;
using static api.DTOs.Stock.StockDTO;

namespace api.Mappers
{
    public static class StockMappers
    {
        public static StockDTO ToStockDTO(this StockDTO stockmodel)
        {
            return new StockDTO
            {
                ID = stockmodel.ID,
                Symbol = stockmodel.Symbol,
                CompanyName = stockmodel.CompanyName,
                Purchase = stockmodel.Purchase,
                LastDiv = stockmodel.LastDiv,
                Industry = stockmodel.Industry,
                MarketCap = stockmodel.MarketCap
            };
        }
    }
}