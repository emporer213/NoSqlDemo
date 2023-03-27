using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoClientLibrary.Models;

public class Workspace : IWorkspace
{
    public Workspace(string name)
    {
        Id = ObjectId.GenerateNewId().ToString();
        Name = name;
    }
    
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    
    [BsonElement]
    public string Name { get; set; }
    
    [BsonElement]
    public List<Window> Windows { get; set; } = new();
}
