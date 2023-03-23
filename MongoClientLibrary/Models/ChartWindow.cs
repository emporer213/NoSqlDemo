using MongoDB.Bson;

namespace MongoClientLibrary.Models;

public class ChartWindow : IWindow
{
    public ChartWindow(string title, (int, int) position, ChartType chartType)
    {
        Title = title;
        Position = position;
        ChartType = chartType;
        Id = ObjectId.GenerateNewId();
    }

    public ObjectId Id { get; }
    public string Title { get; }
    public (int, int) Position { get; set; }
    public ChartType ChartType { get; set; }
}
