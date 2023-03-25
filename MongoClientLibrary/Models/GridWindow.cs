using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoClientLibrary.Models;

public class GridWindow : IWindow
{
    public GridWindow(string title, (int, int) position, List<string> columnHeaders, List<string> rowHeaders)
    {
        Title = title;
        Position = position;
        ColumnHeaders = columnHeaders;
        RowHeaders = rowHeaders;
        Id = ObjectId.GenerateNewId().ToString();
    }

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; }
    
    public string Title { get; }
    
    public (int, int) Position { get; set; }
    
    public List<string> ColumnHeaders { get; }
    
    
    public List<string> RowHeaders { get; }
}
