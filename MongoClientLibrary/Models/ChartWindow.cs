using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoClientLibrary.Models;

public class ChartWindow : Window
{
    public ChartWindow(string title, ChartType chartType) : base(title)
    {
        ChartType = chartType;
    }
    
    public ChartType ChartType { get; set; }
}
