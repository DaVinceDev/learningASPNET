using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Comment
    {//Comment section propertys
        public int Id { get; set;}
        public string? Title { get; set;} = string.Empty;
        public string? Content { get; set;} = string.Empty;
        public DateTime CreatedOn{ get; set;} = DateTime.Now;
        public int? StockID{ get; set; } //Navigation property: navigate within the models
        public Stock? Stock{ get; set; }
    }
}