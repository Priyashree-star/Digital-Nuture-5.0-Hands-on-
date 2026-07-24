using StrategyPatternExample.Models;

Console.Write("Enter amount: ");
decimal amount = decimal.Parse(Console.ReadLine()!);

Console.WriteLine("\nChoose Payment Method");
Console.WriteLine("1. Credit Card");
Console.WriteLine("2. PayPal");

Console.Write("Enter choice: ");
int choice = int.Parse(Console.ReadLine()!);

PaymentContext context;

if (choice == 1)
{
    context = new PaymentContext(new CreditCardPayment());
}
else
{
    context = new PaymentContext(new PayPalPayment());
}

Console.WriteLine();
context.MakePayment(amount);