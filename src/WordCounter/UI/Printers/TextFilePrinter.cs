using System.Collections.Generic;
using System.IO;
using WordCounter.Core;
using WordCounter.Core.Formatters;

namespace WordCounter.UI.Printers
{
    class TextFilePrinter : IPrintable
    {
        string filename;
        Dictionary<string, int> words = new Dictionary<string, int>();

        public TextFilePrinter(string filename, Dictionary<string, int> words)
        {
            this.filename = filename;
            this.words = words;
        }

        public void Print()
        {
            FileStream file = new FileStream(filename, FileMode.Create);
            StreamWriter writer = new StreamWriter(file);

            IFormattable formatter = DependencyResolver.Container.GetInstance<IFormattable>();
            writer.Write(formatter.Format(words));

            writer.Close();
            file.Close();
        }
    }
}
