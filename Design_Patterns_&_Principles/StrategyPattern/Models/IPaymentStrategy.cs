namespace StrategyPatternExample.Models
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}