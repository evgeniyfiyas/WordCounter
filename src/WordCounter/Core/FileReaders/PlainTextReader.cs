using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCounter.Core.FileReaders
{
    class PlainTextReader : IReadable
    {
        string filename;

        public PlainTextReader(string filename)
        {
            this.filename = filename;
        }

        public List<string> Read()
        {
            FileStream input = new FileStream("input.txt", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(input);
            Regex regex = new Regex("[a-zA-Z\\-]+");

            return regex.Matches(reader.ReadToEnd().ToLower()).Cast<Match>().Select(match => match.Value).ToList();
        }
    }
}
