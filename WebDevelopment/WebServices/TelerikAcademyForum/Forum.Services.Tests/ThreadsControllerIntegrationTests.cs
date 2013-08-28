using System;
using System.Transactions;
using Forum.Services.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Web.Http;
using Forum.Services.Models;
using System.Net;
using Newtonsoft.Json;

namespace Forum.Services.Tests
{
    [TestClass]
    public class ThreadsControllerIntegrationTests
    {
        static TransactionScope tran;
        private InMemoryHttpServer httpServer;

        [TestInitialize]
        public void TestInit()
        {
            var type = typeof(UsersController);
            tran = new TransactionScope();

            var routes = new List<Route>
            {
                new Route(
                    "ThreadApi",
                    "api/thread/{threadId}/posts",
                    defaults: new
                    {
                        controller = "threads",
                        action = "posts"
                    }
                ),
                new Route(
                    "UserApi",
                   "api/users/{action}",
                    defaults: new 
                    {
                        controller = "users"
                    }
                ),
                new Route(
                    "DefaultApi",
                    "api/{controller}/{id}",
                    defaults: new 
                    { 
                        id = RouteParameter.Optional 
                    }
                ),
            };

            this.httpServer = new InMemoryHttpServer("http://localhost/", routes);
        }

        [TestCleanup]
        public void TearDown()
        {
            tran.Dispose();
        }


        [TestMethod]
        public void Register_WhenUserModelValid_ShouldSaveToDatabase()
        {
            var newUser = new UserRegisterModel
            {
                Username = "ValidUsername",
                Nickname = "ValidNickname",
                AuthCode = new string('b', 40)
            };

            var response = httpServer.Post("api/users/register", newUser);
            var contentString = response.Content.ReadAsStringAsync().Result;
            var userModel = JsonConvert.DeserializeObject<LoggedUserModel>(contentString);

            Assert.AreEqual(response.StatusCode, HttpStatusCode.Created);
        }

        [TestMethod]
        public void Get()
        {
            var testUser = new UserRegisterModel()
            {
                Username = "VALIDUSER",
                Nickname = "VALIDNICK",
                AuthCode = new string('b', 40)
            };

            var response = httpServer.Post("api/users/register", testUser);
            var contentString = response.Content.ReadAsStringAsync().Result;
            var userModel = JsonConvert.DeserializeObject<LoggedUserModel>(contentString);

            var headers = new Dictionary<string, string>();
            headers["X-sessionKey"] = userModel.SessionKey;

            var responseTwo = httpServer.Get("api/threads", headers);

            Assert.AreEqual(HttpStatusCode.OK, responseTwo.StatusCode);
            Assert.IsNotNull(responseTwo.Content);        
        }
    }
}
