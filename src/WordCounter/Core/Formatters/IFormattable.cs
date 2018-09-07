using System.Collections.Generic;

namespace WordCounter.Core.Formatters
{
    interface IFormattable
    {
        string Format(Dictionary<string, int> words);
    }
}
