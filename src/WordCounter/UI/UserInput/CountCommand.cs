using Oakton;
using StructureMap.Pipeline;
using WordCounter.Core;
using WordCounter.Core.FileReaders;
using WordCounter.Core.Sorters;
using WordCounter.UI.Printers;

namespace WordCounter.UI.UserInput
{
    class CountCommand : OaktonCommand<CountInput>
    {
        public CountCommand() { }

        public override bool Execute(CountInput input)
        {
            string inputFileName = input.InputFileName;
            string outputFileName = input.OutputFileName;

            IReadable reader = DependencyResolver.Container.GetInstance<IReadable>(
                               new ExplicitArguments()
                               .Set(inputFileName));

            ISortable sorter = DependencyResolver.Container.GetInstance<ISortable>();

            IPrintable printer = DependencyResolver.Container.GetInstance<IPrintable>(
                                 new ExplicitArguments()
                                 .Set(outputFileName)
                                 .Set(sorter.Sort(reader.Read())));

            printer.Print();

            return true;
        }
    }
}
