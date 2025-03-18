using System.Threading.Tasks;
using CryptoTicker.Domain;
using Bybit.Net.Objects;
using Domain.Dto;
using Service;
using Bybit.Net.Clients;

namespace CryptoTicker.Domain
{
    public class BybitService : IExchangeService<string, TickerDto>
    {
        private readonly BybitClient _client;

        public BybitService()
        {
            _client = new BybitClient(); 
        }

        public async Task<TickerDto> GetTickerAsync(string tradingPair)
        {
            var result = await _client.SpotApiV3.ExchangeData.GetPriceAsync(tradingPair);  
            if (!result.Success)
                return new TickerDto("Bybit", tradingPair, 0);

            return new TickerDto("Bybit", tradingPair, result.Data.Price);
        }
    }
}
