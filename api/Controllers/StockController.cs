using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api.DTOs.Stock;
using api.Mappers;

namespace api.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly Data.AplicationDBContext _context;
        
        public StockController(Data.AplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var stocks = _context.Stocks.ToList()
            .Select(s => StockMappers.ToStockDTO(new StockDTO
            {
                ID = s.ID,
                Symbol = s.Symbol,
                CompanyName = s.CompanyName,
                Purchase = s.Purchase,
                LastDiv = s.LastDiv,
                Industry = s.Industry,
                MarketCap = s.MarketCap

            }));

            return Ok(stocks);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID([FromRoute] int id)
        {
            var stock = _context.Stocks.Find();

            if(stock==null)
            {
                return NotFound();
            }

           var converted = StockMappers.ToStockDTO(new StockDTO
            {
                ID = stock.ID,
                Symbol = stock.Symbol,
                CompanyName = stock.CompanyName,
                Purchase = stock.Purchase,
                LastDiv = stock.LastDiv,
                Industry = stock.Industry,
                MarketCap = stock.MarketCap
            });
            return Ok(converted);
        }
    }
}