using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace myapi.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRequired]
        public string Name { get; set; }

        public string LastName { get; set; }

        [BsonRequired]
        public string Username { get; set; }

        [BsonRequired]
        public string Email { get; set; }

        public BsonDateTime Birthday { get; set; }
        
    }
}