using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Core.Sorters
{
    class DescendingFrequencySorter : ISortable
    {
        public Dictionary<string, int> Sort(List<string> words)
        {
            var dictionary = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!dictionary.ContainsKey(word)) dictionary.Add(word, 1);
                else dictionary[word]++;
            }

            return dictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
