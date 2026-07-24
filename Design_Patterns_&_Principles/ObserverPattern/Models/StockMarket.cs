namespace ObserverPatternExample.Models
{
    public class StockMarket : IStock
    {
        private List<IObserver> observers = new();

        private string stockName = "";
        private double price;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetStock(string name, double price)
        {
            stockName = name;
            this.price = price;
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(stockName, price);
            }
        }
    }
}