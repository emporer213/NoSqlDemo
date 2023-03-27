using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoClientLibrary.Models;

public class Window
{
    public Window(string title)
    {
        Title = title;
        // Position = position;
        Id = ObjectId.GenerateNewId().ToString();
    }
    
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Title { get; set; }
    // public (int, int) Position { get; set; }
}
