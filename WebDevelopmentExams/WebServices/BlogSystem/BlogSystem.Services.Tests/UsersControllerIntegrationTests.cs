using System;
using System.Transactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlogSystem.Services.Controllers;
using System.Collections.Generic;
using System.Web.Http;
using BlogSystem.Services.Models;
using Newtonsoft.Json;
using Telerik.JustMock;
using System.Net;
using BlogSystem.Models;
using BlogSystem.Repositories;

namespace BlogSystem.Services.Tests
{
    [TestClass]
    public class UsersControllerIntegrationTests
    {
        [TestMethod]
        public void RegisteUser_WhenIsValid_ShouldAddToDb()
        {
            var mockRepository = Mock.Create<IRepository<UserRegisterModel>>();
            UserRegisterModel model = new UserRegisterModel()
            {
                Username = "TestUser",
                DisplayName = "DIsplayName",
                AuthCode = new string('b', 40)
            };

            var server = new InMemoryHttpServer<UserRegisterModel>("http://localhost/", mockRepository);

            var response = server.CreateGetRequest("api/users/register");

            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
            Assert.IsNotNull(response.Content);
        }
    }
}