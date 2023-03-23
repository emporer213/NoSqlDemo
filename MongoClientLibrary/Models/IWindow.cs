using MongoDB.Bson;

namespace MongoClientLibrary.Models;

public interface IWindow
{
    ObjectId Id { get; }
    string Title { get; }
    (int, int) Position { get; set; }
}
