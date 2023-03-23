namespace MongoClientLibrary.Models;

public interface IMongoDbConfiguration
{
    string ConnectionString { get; }
    string DatabaseName { get; }
    string CollectionName { get; }
}
