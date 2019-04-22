using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace Animals.Models
{
    public class LoginModels
    {
        [BsonElement("Username")]
        public string Username { get; set; }
        [BsonElement("Password")]
        public string Password { get; set; }
    }
}