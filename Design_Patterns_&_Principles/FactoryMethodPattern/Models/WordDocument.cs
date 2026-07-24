using System;

namespace FactoryMethodPattern.Models
{
    public class WordDocument : IDocument
    {
        public string GetName() => "Word Document";

        public void Print()
        {
            Console.WriteLine("Printing a Word document...");
        }
    }
}