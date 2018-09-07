using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordCounter.Core.Formatters
{
    class PlainTextFormatter : IFormattable
    {
        public PlainTextFormatter() { }

        public string Format(Dictionary<string, int> words)
        {
            StringBuilder formatted = new StringBuilder();

            var result = words.GroupBy(x => x.Key[0])
                              .OrderBy(x => x.Key);

            foreach (var group in result)
            {
                formatted.AppendLine(group.Key.ToString());
                foreach (var item in group) 
                {
                    formatted.AppendLine(item.Key + " " + item.Value);
                }
            }

            return formatted.ToString();
        }
    }
}
