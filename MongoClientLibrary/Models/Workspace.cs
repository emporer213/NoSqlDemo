﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoClientLibrary.Models;

public class Workspace : IWorkspace
{
    public Workspace(string name)
    {
        Id = ObjectId.GenerateNewId();
        Name = name;
    }
    
    [BsonId]
    public ObjectId Id { get; }
    
    [BsonElement]
    public string Name { get; set; }
    
    [BsonElement]
    public List<IWindow> Windows { get; } = new();
}
