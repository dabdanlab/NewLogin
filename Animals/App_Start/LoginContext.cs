using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using System.Configuration;

namespace Animals.App_Start
{
    public class LoginContext
    {
        public IMongoDatabase database;

        public LoginContext()
        {
            var mongoClient = new MongoClient(ConfigurationManager.AppSettings["MongoDBHost"]);
            database = mongoClient.GetDatabase(ConfigurationManager.AppSettings["MongoDBName"]);
        }
    }
}