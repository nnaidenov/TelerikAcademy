//using System;
//using System.Transactions;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using BlogSystem.Services.Controllers;
//using System.Collections.Generic;
//using System.Web.Http;
//using BlogSystem.Services.Models;
//using Newtonsoft.Json;
//using System.Net;
//using BlogSystem.Models;
//using BlogSystem.Repositories;

//namespace BlogSystem.Services.Tests
//{
//    [TestClass]
//    public class PostsControllerTests
//    {
//        static TransactionScope tran;
//        private InMemoryHttpServer httpServer;
//         private readonly IRepository<User> userRepository;

//        [TestInitialize]
//        public void TestInit()
//        {
//            var type = typeof(PostsController);
//            tran = new TransactionScope();

//            var routes = new List<Route>
//            {
//            new Route(
//                "DefaultApi",
//                "api/{controller}/{id}",
//                defaults: new { id = RouteParameter.Optional }
//            )
//            };

//            this.httpServer = new InMemoryHttpServer("http://localhost/", routes);
//        }

//        [TestCleanup]
//        public void TearDown()
//        {
//            tran.Dispose();
//        }

//        [TestMethod]
//        public void CreatePost_WhenPostModelValid_ShouldSaveToDatabase()
//        {
//            var newPost = new PostModel
//            {
//                Title = "Test Post",
//                Text = "Some some text",
//                Tags = new List<string> { "test-tag" },
//                PostedBy = "Display Name",
//                PostDate = DateTime.Now,
//            };

//            var response = httpServer.Post("api/posts", newPost);
//            var contentString = response.Content.ReadAsStringAsync().Result;
//            var postModel = JsonConvert.DeserializeObject<CreatedPostModel>(contentString);

//        }
//    }
//}
