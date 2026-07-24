using FactoryMethodPattern.Factories;
using FactoryMethodPattern.Models;

DocumentFactory wordFactory = new WordFactory();
IDocument word = wordFactory.CreateDocument();

Console.WriteLine(word.GetName());
word.Print();

Console.WriteLine();

DocumentFactory pdfFactory = new PdfFactory();
IDocument pdf = pdfFactory.CreateDocument();

Console.WriteLine(pdf.GetName());
pdf.Print();

Console.WriteLine();

DocumentFactory excelFactory = new ExcelFactory();
IDocument excel = excelFactory.CreateDocument();

Console.WriteLine(excel.GetName());
excel.Print();