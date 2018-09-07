using System.Collections.Generic;

namespace WordCounter.Core.Sorters
{
    interface ISortable
    {
        Dictionary<string, int> Sort(List<string> words);
    }
}
