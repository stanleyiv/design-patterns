using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer.Models
{
    public class StockTracker : IObservable<Stock>
    {
        private Stock _stock;
        private List<IObserver<Stock>> _observers;

        public StockTracker(Stock stock)
        {
            _stock = stock;
            _observers = new List<IObserver<Stock>>();
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Stock>> _observers;
            private IObserver<Stock> _observer;

            public Unsubscriber(List<IObserver<Stock>> observers, IObserver<Stock> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null) _observers.Remove(_observer);
            }
        }

        public IDisposable Subscribe(IObserver<Stock> observer)
        {
            if (!_observers.Contains(observer)) _observers.Add(observer);

            return new Unsubscriber(_observers, observer);
        }

        public void GetStock(float value)
        {
            _stock.Value = value;
            foreach (var observer in _observers)
            {
                observer.OnNext(_stock);
            }
        }
    }
}
