using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoClientLibrary.Models;

public class ChartWindow : IWindow
{
    public ChartWindow(string title, (int, int) position, ChartType chartType)
    {
        Title = title;
        Position = position;
        ChartType = chartType;
        Id = ObjectId.GenerateNewId().ToString();
    }
    
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    public string Title { get; set; }
    public (int, int) Position { get; set; }
    public ChartType ChartType { get; set; }
}
