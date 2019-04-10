namespace SDML.NET
{
    public interface ISdmlImporter
    {
        string Read(string path, ImportOptions options);
    }
}
