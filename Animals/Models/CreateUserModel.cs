using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Animals.Models
{
    public class CreateUserModel
    {
        [BsonId]
        public ObjectId id { get; set; }
        [BsonElement("UserName")]
        public string UserName { get; set; }
        [BsonElement("PassWord")]
        public string PassWord { get; set; }
        [BsonElement("Email")]
        public string Email { get; set; }
        [BsonElement("Phone")]
        public string Phone { get; set; }
        [BsonElement("Address")]
        public string Address { get; set; }
    }
}