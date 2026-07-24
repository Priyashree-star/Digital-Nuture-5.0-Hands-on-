using FactoryMethodPattern.Models;

namespace FactoryMethodPattern.Factories
{
    public abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument();
    }
}