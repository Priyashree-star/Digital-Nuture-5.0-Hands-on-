namespace AdapterPatternExample.Models
{
    public class PayPalAdapter : IPaymentProcessor
    {
        private readonly PayPalGateway payPalGateway;

        public PayPalAdapter()
        {
            payPalGateway = new PayPalGateway();
        }

        public void ProcessPayment(decimal amount)
        {
            payPalGateway.SendPayment(amount);
        }
    }
}