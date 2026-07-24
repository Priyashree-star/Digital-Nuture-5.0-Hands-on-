using FactoryMethodPattern.Models;

namespace FactoryMethodPattern.Factories
{
    public class ExcelFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new ExcelDocument();
        }
    }
}