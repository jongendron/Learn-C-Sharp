using TestETL.Core;
namespace TestETL.Core;

public interface ITransformerPort
{
    List<DataRecord> Transform(List<DataRecord> rawData);
}

public class DummyTransformerAdapter : ITransformerPort
{
    public List<DataRecord> Transform(List<DataRecord> rawData)
    {
        List<DataRecord> data = rawData;
        // Do Stuff to data
        return data;
    }
}

