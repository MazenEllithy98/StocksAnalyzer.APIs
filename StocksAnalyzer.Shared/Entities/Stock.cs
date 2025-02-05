using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksAnalyzer.Shared.Entities
{
    public class Stock
    {
        public string Symbol { get; set; }
        public decimal Price { get; set; }
        public long Volume { get; set; }
        public decimal ChangePercent { get; set; }
        public string Sector { get; set; }
    }
}
