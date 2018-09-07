using Oakton;

namespace WordCounter.UI.UserInput
{
    class CountInput
    {
        [Description("Source filename (e.g. input.txt)")]
        public string InputFileName { get; set; }

        [Description("Result filename (e.g. output.txt)")]
        public string OutputFileName { get; set; }
    }
}
