using Microsoft.Extensions.Options;
using MongoClientLibrary.Models;
using MongoDB.Driver;

namespace MongoClientLibrary;

public class MongoService : IMongoService
{
    private readonly IMongoCollection<Workspace> _workspaceCollection;

    public MongoService(IOptions<MongoDbConfiguration> optionsConfiguration)
    {
        var mongoDbConfiguration = optionsConfiguration.Value;
        var mongoClient = new MongoClient(mongoDbConfiguration.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(mongoDbConfiguration.DatabaseName);

        _workspaceCollection = mongoDatabase.GetCollection<Workspace>(mongoDbConfiguration.CollectionName);
    }

    public async Task<List<Workspace>> GetAsync() => await _workspaceCollection.Find(_ => true).ToListAsync();

    public async Task<Workspace?> GetAsync(string id) =>
        await _workspaceCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(Workspace newWorkspace) => await _workspaceCollection.InsertOneAsync(newWorkspace);

    public async Task UpdateAsync(string id, Workspace updatedWorkspace) =>
        await _workspaceCollection.ReplaceOneAsync(x => x.Id == id, updatedWorkspace);

    public async Task RemoveAsync(string id) => await _workspaceCollection.DeleteOneAsync(x => x.Id == id);
}
