using TestETL.Core;

namespace TestETL.Core;

public class ETLOrchestrator
{

    private readonly IExtractorPort _extractor;
    private readonly ITransformerPort _transformer;
    private readonly ILoaderPort _loader;
    public ETLOrchestrator(IExtractorPort extractor, ITransformerPort transformer, ILoaderPort loader)
    {
        _extractor = extractor;
        _transformer = transformer;
        _loader = loader;
    }

    public void Run()
    {
        List<DataRecord> rawData = _extractor.Extract();
        List<DataRecord> transformedData = _transformer.Transform(rawData);
        _loader.Load(transformedData);
    }
}