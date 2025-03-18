using System.Threading.Tasks;
using Kucoin.Net.Clients;  // Подключаем KucoinClient
using CryptoTicker.Domain;
using Domain.Dto;
using Service;

namespace Domain.Queries
{
    public class KucoinService : IExchangeService<string, TickerDto>
    {
        private readonly KucoinRestClient _client;  

        public KucoinService()
        {
            _client = new KucoinRestClient(); 
        }

        public async Task<TickerDto> GetTickerAsync(string tradingPair)
        {
            var result = await _client.SpotApi.ExchangeData.GetTickerAsync(tradingPair);
            if (!result.Success)
                return new TickerDto("Kucoin", tradingPair, 0);

            return new TickerDto("Kucoin", tradingPair, (decimal)result.Data.LastPrice);
        }
    }
}
