using DesignPatterns.Observer.Models;
using System.Threading;

namespace DesignPatterns.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock
            {
                Ticker = "TSLA",
                Value = 999
            };
            var provider = new StockTracker(stock);
            var observer1 = new StockListener();
            var observer2 = new StockListener();

            observer1.Subscribe(provider);
            observer2.Subscribe(provider);

            provider.GetStock(123);
            Thread.Sleep(500);
            provider.GetStock(556);
        }
    }
}
