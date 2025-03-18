using CryptoTicker.Domain;
using Domain.Dto;
using Domain.Queries;
using Service;

namespace CryptoTicker
{
    public partial class Form1 : Form
    {
        private IExchangeService<string, TickerDto> _binanceService;
        private IExchangeService<string, TickerDto> _bybitService;
        private IExchangeService<string, TickerDto> _kucoinService;
        private IExchangeService<string, TickerDto> _bitgetService;
        public Form1()
        {
            InitializeComponent();
            _binanceService = new BinanceService();
            _bybitService = new BybitService();
            _kucoinService = new KucoinService();
            _bitgetService = new BitgetService();

            timer1.Interval = 5000;  // 5 секунд
            timer1.Tick += async (sender, e) => await UpdatePricesAsync();
            timer1.Start();

        }

        private async Task UpdatePricesAsync()
        {
            string tradingPair = txtTradingPair.Text.ToUpper();

            if (string.IsNullOrWhiteSpace(tradingPair)) return;

            var binancePrice = await _binanceService.GetTickerAsync(tradingPair);
            var bybitPrice = await _bybitService.GetTickerAsync(tradingPair);
            var kucoinPrice = await _kucoinService.GetTickerAsync(tradingPair);
            var bitgetPrice = await _bitgetService.GetTickerAsync(tradingPair);

            lblPrice.Text = $"Binance: {binancePrice.Price}\n" +
                           $"Bybit: {bybitPrice.Price}\n" +
                           $"Kucoin: {kucoinPrice.Price}\n" +
                           $"Bitget: {bitgetPrice.Price}";
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await UpdatePricesAsync();
        }
    }
}
