using MongoClientLibrary.Models;
using MongoDB.Bson;

namespace MongoClientLibrary;

public interface IMongoService
{
    Task<List<Workspace>> GetAsync();
    Task<Workspace?> GetAsync(string id);
    Task CreateAsync(Workspace newWorkspace);
    Task UpdateAsync(string id, Workspace updatedWorkspace);
    Task RemoveAsync(string id);
}
