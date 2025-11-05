using TestETL.Core;
namespace TestETL.Core;

public interface IExtractorPort
{
    List<DataRecord> Extract();
}

public class DummyExtractorAdapter : IExtractorPort
{
    // Placeholder logic for extracting data form source
    public List<DataRecord> Extract()
    {
        return new List<DataRecord>
        {
            new DataRecord(),
            new DataRecord(),
            new DataRecord()
        };
    }
}