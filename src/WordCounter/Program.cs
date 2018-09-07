using Oakton;
using WordCounter.UI.UserInput;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandExecutor.ExecuteCommand<CountCommand>(args);
        }
    }
}
