using System;

namespace DesignPatterns.Observer.Models
{
    public class StockListener : IObserver<Stock>
    {
        private IDisposable unsubscriber;

        public virtual void Subscribe(IObservable<Stock> provider)
        {
            unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }

        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(Stock value)
        {
            Console.WriteLine($"Stock updated recieved for ticker: {value.Ticker}, with new value: {value.Value}.");
        }
    }
}
