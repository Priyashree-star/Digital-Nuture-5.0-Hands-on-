namespace AdapterPatternExample.Models
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}