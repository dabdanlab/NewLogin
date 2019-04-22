using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Driver.Core;
using System.Configuration;
using Animals.App_Start;
using Animals.Models;
using MongoDB.Driver;
using System.Web.UI.WebControls;

namespace Animals.Controllers
{
    public class CreateUserController : Controller
    {
        private IMongoCollection<CreateUserModel> createUserCollection;
        private CreateUserConfig createUserConfig;
        public CreateUserController()
        {
            createUserConfig = new CreateUserConfig();
            createUserCollection = createUserConfig.database.GetCollection<CreateUserModel>("Craete");
        }
        // GET: CreateUser
        public ActionResult Index()
        {
            List<CreateUserModel> animals = createUserCollection.AsQueryable<CreateUserModel>().ToList();
            return View(animals);
        }

        // GET: CreateUser/Details/5
        public ActionResult Details(string id)
        {
            var UserId = new ObjectId(id);
            var User = createUserCollection.AsQueryable<CreateUserModel>().SingleOrDefault(x => x.id == UserId);
            return View(User);
        }

        // GET: CreateUser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CreateUser/Create
        [HttpPost]
        public ActionResult Create(CreateUserModel createUser)
        {
            try
            {
                // TODO: Add insert logic here

                createUserCollection.InsertOne(createUser);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CreateUser/Edit/5
        public ActionResult Edit(string id)
        {
            var UserId = new ObjectId(id);
            var User = createUserCollection.AsQueryable<CreateUserModel>().SingleOrDefault(x => x.id == UserId);
            return View(User);
        }

        // POST: CreateUser/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, CreateUserModel createUser)
        {
            try
            {
                // TODO: Add update logic here
                var filter = Builders<CreateUserModel>.Filter.Eq("_id", ObjectId.Parse(id));
                var update = Builders<CreateUserModel>.Update
                    .Set("UserName", createUser.UserName)
                    .Set("PassWord", createUser.PassWord)
                    .Set("Email", createUser.Email)
                    .Set("Phone", createUser.Phone)
                    .Set("Address", createUser.Address);
                var result = createUserCollection.UpdateOne(filter, update);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: CreateUser/Delete/5
        public ActionResult Delete(string id)
        {
            var UserId = new ObjectId(id);
            var User = createUserCollection.AsQueryable<CreateUserModel>().SingleOrDefault(x => x.id == UserId);
            return View(User);
        }

        // POST: Animals/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, CreateUserModel createUser)
        {
            try
            {
                // TODO: Add delete logic here
                createUserCollection.DeleteOne(Builders<CreateUserModel>.Filter.Eq("_id", ObjectId.Parse(id)));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
