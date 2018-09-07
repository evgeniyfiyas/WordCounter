using System.Collections.Generic;

namespace WordCounter.Core.FileReaders
{
    interface IReadable
    {
        List<string> Read();
    }
}
