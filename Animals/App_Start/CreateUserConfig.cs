using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using System.Configuration;
using Animals.Models;

namespace Animals.App_Start
{
    public class CreateUserConfig
    {
        public IMongoDatabase database;

        public CreateUserConfig()
        {
            var mongoClient = new MongoClient(ConfigurationManager.AppSettings["MongoDBHost"]);
            database = mongoClient.GetDatabase(ConfigurationManager.AppSettings["MongoDBName"]);
        }

        internal void InsertOne(CreateUserModel createUser)
        {
            throw new NotImplementedException();
        }
    }
}