using MongoDB.Bson;

namespace MongoClientLibrary.Models;

public interface IWorkspace
{ 
    ObjectId Id { get; }
    string Name { get; set; }
    
    List<IWindow> Windows { get; }

}
