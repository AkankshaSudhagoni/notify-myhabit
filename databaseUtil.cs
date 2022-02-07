using MongoDB.Bson;
using MongoDB.Driver;
using System.Runtime.InteropServices;


[assembly: ComVisible(false)]


[assembly: Guid("f9b2f329-de05-444f-8168-5b1bd101f4fa")]


namespace HabitApp 
{

    public class DatabaseUtil 
    {
        
        private static string dbPassword = "habitapp123";



        private string dbUrl = "mongodb+srv://habitapp:"+ dbPassword + "@cluster0.vnra6.mongodb.net/myFirstDatabase?retryWrites=true&w=majority";

        private bool isConnected = false;

        private MongoClient client;

        private IMongoDatabase database;
        private const string DATABASE_NAME = "habbitDB"; 
        public bool getConnectionStatus() 
        {
            return isConnected;
        }

        //returns the collection object for the given collection name
        public IMongoCollection<BsonDocument> getCollection(string collectionName) 
        {
            getDatabase();
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>(collectionName);

            return collection;
        }


        public void getDatabase() 
        {
            getDbClient();
             database = client.GetDatabase(DATABASE_NAME);

            
        }

        public void getDbClient() 
        {
             client = new MongoClient(dbUrl);

        }


    }

}