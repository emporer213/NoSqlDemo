using MongoClientLibrary.Models;
using MongoDB.Bson;

namespace MongoClientLibrary;

public interface IMongoService
{
    Task<List<Workspace>> GetAsync();
    Task<Workspace?> GetAsync(ObjectId id);
    Task CreateAsync(Workspace newWorkspace);
    Task UpdateAsync(ObjectId id, Workspace updatedWorkspace);
    Task RemoveAsync(ObjectId id);
}