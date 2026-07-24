using DecoratorPatternExample.Models;

Console.Write("Enter notification message: ");
string message = Console.ReadLine()!;

INotifier notifier = new EmailNotifier();

// Add decorators
notifier = new SMSNotifierDecorator(notifier);
notifier = new SlackNotifierDecorator(notifier);

Console.WriteLine("\nSending Notifications...\n");

notifier.Send(message);