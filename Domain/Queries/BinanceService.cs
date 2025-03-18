using Binance.Net.Clients;
using Domain.Dto;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Queries
{
    public class BinanceService : IExchangeService<string, TickerDto>
    {
        private readonly BinanceClient _client;

        public BinanceService()
        {
            _client = new BinanceClient();
        }

        public async Task<TickerDto> GetTickerAsync(string tradingPair)
        {
            var result = await _client.SpotApi.ExchangeData.GetPriceAsync(tradingPair);
            if (!result.Success)
                return new TickerDto("Binance", tradingPair, 0);

            return new TickerDto("Binance", tradingPair, result.Data.Price);
        }
    }
}
