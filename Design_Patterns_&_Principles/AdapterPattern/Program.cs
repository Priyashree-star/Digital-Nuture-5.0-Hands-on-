using AdapterPatternExample.Models;

Console.Write("Enter payment amount: ");

if (decimal.TryParse(Console.ReadLine(), out decimal amount))
{
    IPaymentProcessor paymentProcessor = new PayPalAdapter();
    paymentProcessor.ProcessPayment(amount);
}
else
{
    Console.WriteLine("Invalid amount entered.");
}