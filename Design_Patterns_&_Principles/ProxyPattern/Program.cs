using ProxyPatternExample.Models;

Console.Write("Enter image name: ");
string fileName = Console.ReadLine()!;

Image image = new ProxyImage(fileName);

Console.WriteLine("\nFirst Display:");
image.Display();

Console.WriteLine("\nSecond Display:");
image.Display();