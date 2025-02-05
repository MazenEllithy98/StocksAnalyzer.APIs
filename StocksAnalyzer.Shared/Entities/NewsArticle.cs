using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksAnalyzer.Shared.Entities
{
    public class NewsArticle
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Source { get; set; }
        public List<string> Keywords { get; set; }
    }
}
