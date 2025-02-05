using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksAnalyzer.Shared.Entities
{
    public class AnalysisResult
    {
        public string Symbol { get; set; }
        public decimal EntryProbability { get; set; }
        public decimal BestEntry { get; set; }
        public decimal StopLoss { get; set; }
        public decimal TakeProfit { get; set; }
        public string SupportResistance { get; set; }
    }
}
