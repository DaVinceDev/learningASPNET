using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.DTOs.Stock
{
    public class StockDTO
    {
        public int ID{ get; set; }
        public string? Symbol{ get; set; }
        public string CompanyName{ get; set; } = string.Empty;
        public decimal Purchase{ get; set;}
        public decimal LastDiv{ get; set;}
        public string? Industry{ get; set; }
        public long MarketCap{ get; set; }
        //comments
    }
}