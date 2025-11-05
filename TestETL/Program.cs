using TestETL.Core;
namespace TestETL;

public class Program
{
    static void Main(string[] args)
    {
        IExtractorPort extractor = new DummyExtractorAdapter();
        ITransformerPort transformer = new DummyTransformerAdapter();
        ILoaderPort loader = new DummyLoaderAdapter();
        
        ETLOrchestrator etl = new ETLOrchestrator(extractor, transformer, loader);

        etl.Run();
    }
}