using MongoDB.Bson;

namespace MongoClientLibrary.Models;

public interface IWorkspace
{ 
    string Id { get; }
    string Name { get; set; }
    
    List<Window> Windows { get; }

}
