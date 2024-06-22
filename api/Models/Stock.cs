using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace api.Models
{
    public class Stock
    {//Stock section propertys
        public int ID{ get; set; }
        public string? Symbol{ get; set; }
        public string CompanyName{ get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase{ get; set;}

        public decimal LastDiv{ get; set;}
        public string? Industry{ get; set; }
        public long MarketCap{ get; set; }
        public List<Comment> Comments{ get; set; } = [];
    }
}