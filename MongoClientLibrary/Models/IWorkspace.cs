using MongoDB.Bson;

namespace MongoClientLibrary.Models;

public interface IWorkspace
{ 
    string Id { get; }
    string Name { get; set; }
    
    List<IWindow> Windows { get; }

}
