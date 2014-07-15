using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stuff.RavenNoSql
{
    public class DailyPrice
    {
        public string id { get; set; }
        public DateTime transactionDate { get; set; }
        public string code { get; set; }
        public double priceHigh { get; set; }
        public double priceLow { get; set; }
        public double priceOpen { get; set; }
        public double priceClose { get; set; }
    }
}
