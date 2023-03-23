using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoClientLibrary.Models;

public class GridWindow : IWindow
{
    public GridWindow(string title, (int, int) position, List<string> columnHeader, List<string> rowHeader)
    {
        Title = title;
        Position = position;
        ColumnHeader = columnHeader;
        RowHeader = rowHeader;
        Id = ObjectId.GenerateNewId();
    }

    [BsonId]
    public ObjectId Id { get; }
    
    [BsonElement]
    public string Title { get; }
    
    [BsonElement]
    public (int, int) Position { get; set; }
    
    [BsonElement]
    public List<string> ColumnHeader { get; }
    
    [BsonElement]
    public List<string> RowHeader { get; }
}
