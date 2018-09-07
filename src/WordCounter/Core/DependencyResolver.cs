using StructureMap;
using WordCounter.Core.FileReaders;
using WordCounter.Core.Formatters;
using WordCounter.Core.Sorters;
using WordCounter.UI.Printers;

namespace WordCounter.Core
{
    static class DependencyResolver
    {
        public static Container Container { get => container; set => container = value; }

        private static Container container = new Container(_ =>
        {
            _.For<IFormattable>().Use<PlainTextFormatter>();
            _.For<ISortable>().Use<DescendingFrequencySorter>();
            _.For<IReadable>().Use<PlainTextReader>();
            _.For<IPrintable>().Use<TextFilePrinter>();
        });
    }
}
