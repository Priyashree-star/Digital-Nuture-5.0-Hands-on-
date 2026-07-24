namespace AdapterPatternExample.Models
{
    public class PayPalGateway
    {
        public void SendPayment(decimal amount)
        {
            Console.WriteLine($"Payment of ₹{amount} processed through PayPal.");
        }
    }
}