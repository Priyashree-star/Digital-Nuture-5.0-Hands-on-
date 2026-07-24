namespace DecoratorPatternExample.Models
{
    public class EmailNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine("Email Sent: " + message);
        }
    }
}