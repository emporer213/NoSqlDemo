namespace MongoClientLibrary.Models;

public class MongoDbConfiguration : IMongoDbConfiguration
{
    public MongoDbConfiguration(string connectionString, string databaseName, string collectionName)
    {
        ConnectionString = connectionString;
        DatabaseName = databaseName;
        CollectionName = collectionName;
    }

    public string ConnectionString { get; }
    public string DatabaseName { get; }
    public string CollectionName { get; }
}
