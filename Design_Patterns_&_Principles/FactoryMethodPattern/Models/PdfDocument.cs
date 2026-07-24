using System;

namespace FactoryMethodPattern.Models
{
    public class PdfDocument : IDocument
    {
        public string GetName() => "PDF Document";

        public void Print()
        {
            Console.WriteLine("Printing a PDF document...");
        }
    }
}