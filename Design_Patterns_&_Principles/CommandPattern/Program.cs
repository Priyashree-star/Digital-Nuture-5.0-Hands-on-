using CommandPatternExample.Models;

Light light = new Light();
RemoteControl remote = new RemoteControl();

Console.WriteLine("1. Turn ON");
Console.WriteLine("2. Turn OFF");

Console.Write("Enter choice: ");
int choice = int.Parse(Console.ReadLine()!);

if (choice == 1)
{
    remote.SetCommand(new LightOnCommand(light));
}
else
{
    remote.SetCommand(new LightOffCommand(light));
}

Console.WriteLine();
remote.PressButton();