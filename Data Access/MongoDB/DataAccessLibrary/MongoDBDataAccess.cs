using System.Data.Common;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DataAccessLibrary;

public class MongoDBDataAccess 
{
    private IMongoDatabase _db;

    public MongoDBDataAccess(string dbName, string connectionString)
    {
        var client = new MongoClient(connectionString);
        _db = client.GetDatabase(dbName);
    }

    public void InsertRecord<T>(string table, T record)
    {
        var collection = _db.GetCollection<T>(table);
        collection.InsertOne(record);
    }

    public List<T> LoadRecords<T>(string table)
    {
        var collection = _db.GetCollection<T>(table);
        return collection.Find(new BsonDocument()).ToList();
    }

    public T LoadRecordById<T>(string table, Guid id)
    {
        var collection = _db.GetCollection<T>(table);
        var filter = Builders<T>.Filter.Eq("Id", id);

        return collection.Find(filter).First();
    }

    public void UpsertRecord<T>(string table, Guid id, T record)
    {
        var collection = _db.GetCollection<T>(table);
        var filter = Builders<T>.Filter.Eq("Id", id);
        var result = collection.ReplaceOne(
            filter,
            record,
            new ReplaceOptions { IsUpsert = true }
        );
    }

    public void DeleteRecord<T>(string table, Guid id)
    {
        var collection = _db.GetCollection<T>(table);
        var filter = Builders<T>.Filter.Eq("Id", id);
        collection.DeleteOne(filter);
    }
}