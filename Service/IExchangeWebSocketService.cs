using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    //интерфейс для работы с вебсокетом
    public interface IExchangeWebSocketService
    {
        event Action<string, decimal> onPriceUpdate;
        Task ConnectAsync(string tradingPair);
        Task DisconnectAsync();
    }
}
