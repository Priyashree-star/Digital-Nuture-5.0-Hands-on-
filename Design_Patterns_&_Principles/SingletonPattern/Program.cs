using SingletonPatternExample.Models;

Logger logger1 = Logger.GetInstance();
logger1.Log("Application Started");

Logger logger2 = Logger.GetInstance();
logger2.Log("User Logged In");

Console.WriteLine();

Console.WriteLine(logger1 == logger2);