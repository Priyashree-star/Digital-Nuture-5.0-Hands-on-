using ObserverPatternExample.Models;

StockMarket stockMarket = new StockMarket();

IObserver mobile = new MobileApp();
IObserver web = new WebApp();

stockMarket.RegisterObserver(mobile);
stockMarket.RegisterObserver(web);

Console.Write("Enter Stock Name: ");
string stock = Console.ReadLine()!;

Console.Write("Enter Stock Price: ");
double price = double.Parse(Console.ReadLine()!);

Console.WriteLine();

stockMarket.SetStock(stock, price);