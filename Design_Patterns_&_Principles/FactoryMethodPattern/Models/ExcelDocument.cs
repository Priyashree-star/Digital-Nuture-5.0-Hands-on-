using System;

namespace FactoryMethodPattern.Models
{
    public class ExcelDocument : IDocument
    {
        public string GetName() => "Excel Document";

        public void Print()
        {
            Console.WriteLine("Printing an Excel document...");
        }
    }
}