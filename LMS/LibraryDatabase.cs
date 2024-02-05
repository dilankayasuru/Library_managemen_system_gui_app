using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

static class LibraryDatabase
{
    static IMongoDatabase database = new MongoClient().GetDatabase("libraryDatabase");

    // Insert One docuement
    static public void insertRecord<Type>(string table, Type record)
    {
        var collection = database.GetCollection<Type>(table);
        collection.InsertOne(record);
    }

    // Read documents
    public static List<Type> getRecords<Type>(string table)
    {
        //var collection = new MongoClient("mongodb://localhost:27017").GetDatabase("Library").GetCollection<Type>(table);
        var collection = database.GetCollection<Type>(table);
        return collection.Find(new BsonDocument()).ToList();
    }

    // Read document by id
    public static classType getRecordBy<classType>(string table, string id)
    {
        var collection = database.GetCollection<classType>(table);
        var filter = Builders<classType>.Filter.Eq("Id", id);

        return collection.Find(filter).First();
    }

    public static classType getRecordBy<classType>(string filterKey, string keyword, string table)
    {
        var collection = database.GetCollection<classType>(table);
        var filter = Builders<classType>.Filter.Eq(filterKey, keyword);

        return collection.Find(filter).First();
    }

    // Update or Insert
    public static void updateRecord<classType>(string table, string id, classType record)
    {
        var collection = database.GetCollection<classType>(table);

        var filter = Builders<classType>.Filter.Eq("Id", id);

        ReplaceOptions options = new ReplaceOptions()
        {
            IsUpsert = true
        };

        var result = collection.ReplaceOne(filter, record, options);
    }

    //// Delete a record
    public static void deleteRecord<classType>(string table, string id)
    {
        var collection = database.GetCollection<classType>(table);
        var filter = Builders<classType>.Filter.Eq("Id", id);
        collection.DeleteOne(filter);
    }
}
