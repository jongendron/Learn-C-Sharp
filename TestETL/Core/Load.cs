using TestETL.Core;
namespace TestETL.Core;

public interface ILoaderPort
{
    void Load(List<DataRecord> transformedData);
}

public class DummyLoaderAdapter : ILoaderPort
{
    public void Load(List<DataRecord> transformedData) { }
}

