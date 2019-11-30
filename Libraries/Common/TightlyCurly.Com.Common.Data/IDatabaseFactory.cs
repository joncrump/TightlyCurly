namespace TightlyCurly.Com.Common.Data
{
    public interface IDatabaseFactory
    {
        IDatabaseWrapper GetDatabase(string databaseName);
    }
}
