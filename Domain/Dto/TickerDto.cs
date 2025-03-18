using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto
{
    public class TickerDto
    {
        public string Exchange { get; set; }
        public string TradingPair { get; set; }
        public decimal Price { get; set; }

        public TickerDto(string exchange, string tradingPair, decimal price)
        {
            Exchange = exchange;
            TradingPair = tradingPair;
            Price = price;
        }
    }
}
