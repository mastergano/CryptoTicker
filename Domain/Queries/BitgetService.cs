using BitGet.Net.Clients;
using BitGet.Net.Interfaces.Clients;
using Domain.Dto;
using Service;
using System.Threading.Tasks;

namespace Domain.Queries
{
    public class BitgetService : IExchangeService<string, TickerDto>
    {
        private readonly BitGetClient _client;

        public BitgetService()
        {
            _client = new BitGetClient();  
        }

        public async Task<TickerDto> GetTickerAsync(string tradingPair)
        {
            var result = await _client.SpotApi.ExchangeData.GetPriceAsync(tradingPair);  
            if (!result.Success)
                return new TickerDto("Bitget", tradingPair, 0);

            return new TickerDto("Bitget", tradingPair, result.Data.RequestTime); 
        }
    }
}
