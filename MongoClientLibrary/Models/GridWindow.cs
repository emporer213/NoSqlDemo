using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoClientLibrary.Models;

public class GridWindow : Window
{
    public GridWindow(string title, List<string> columnHeaders, List<string> rowHeaders) : base(title)
    {
        
        ColumnHeaders = columnHeaders;
        RowHeaders = rowHeaders;
    }
    public List<string> ColumnHeaders { get; }
    public List<string> RowHeaders { get; }
}
