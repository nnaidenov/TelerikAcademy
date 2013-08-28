using BlogSystem.Data;
using BlogSystem.Models;
using BlogSystem.Repositories;
using BlogSystem.Services.Attributes;
using BlogSystem.Services.Models;
using BlogSystem.Services.Persisters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ValueProviders;

namespace BlogSystem.Services.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly IRepository<User> userRepository;

        public UsersController()
        {
            var dbContext = new BlogSystemContext();
            this.userRepository = new DbUserRepository(dbContext);
        }

        public UsersController(IRepository<User> repository)
        {
            this.userRepository = repository;
        }

        [HttpPost]
        [ActionName("register")]
        public HttpResponseMessage RegisterUser(UserRegisterModel model)
        {
            var responseMsg = this.ExceptionHandler(
                 () =>
                 {
                     UserDataPersister.ValidateUsername(model.Username);
                     UserDataPersister.ValidateNickname(model.DisplayName);
                     UserDataPersister.ValidateAuthCode(model.AuthCode);

                     var usernameToLower = model.Username.ToLower();
                     var displayNameToLower = model.DisplayName.ToLower();

                     var users = this.userRepository.All();
                     var user = users.FirstOrDefault(
                           usr => usr.Username == usernameToLower || usr.DisplayName.ToLower() == displayNameToLower);

                     if (user != null)
                     {
                         throw new InvalidOperationException("Invalid Username or Password");
                     }

                     var newUser = new User
                     {
                         Username = usernameToLower,
                         DisplayName = model.DisplayName,
                         AuthCode = model.AuthCode
                     };

                     var userInDb = this.userRepository.Add(newUser);
                     this.userRepository.Update(userInDb, userInDb.Id, true);

                     var loggedModel = new UserLoggedModel
                     {
                         DisplayName = userInDb.DisplayName,
                         SessionKey = userInDb.SessionKey
                     };

                     var response = this.Request.CreateResponse(HttpStatusCode.Created, loggedModel);
                     response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = userInDb.Id }));

                     return response;
                 });

            return responseMsg;
        }

        [HttpPost]
        [ActionName("login")]
        public HttpResponseMessage LoginUser(UserLoginModel model)
        {
            var responseMsg = this.ExceptionHandler(
                 () =>
                 {
                     UserDataPersister.ValidateUsername(model.Username);
                     UserDataPersister.ValidateAuthCode(model.AuthCode);

                     var usernameToLower = model.Username.ToLower();

                     var users = this.userRepository.All();
                     var user = users.FirstOrDefault(
                           usr => usr.Username == usernameToLower && usr.AuthCode == model.AuthCode);

                     if (user == null)
                     {
                         throw new InvalidOperationException("Invalid Username or Password");
                     }

                     this.userRepository.Update(user, user.Id, true);

                     var loggedModel = new UserLoggedModel
                     {
                         DisplayName = user.DisplayName,
                         SessionKey = user.SessionKey
                     };

                     var response = this.Request.CreateResponse(HttpStatusCode.Created, loggedModel);
                     response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = user.Id }));

                     return response;
                 });

            return responseMsg;
        }

        [HttpPut]
        [ActionName("logout")]
        public HttpResponseMessage LogoutUser(
            [ValueProvider(typeof(HeaderValueProviderFactory<string>))] string sessionKey)
        {
            var responseMsg = this.ExceptionHandler(
                 () =>
                 {
                     var users = this.userRepository.All();
                     var user = users.FirstOrDefault(
                           usr => usr.SessionKey == sessionKey);

                     if (user == null)
                     {
                         throw new InvalidOperationException("Invalid Username or Password");
                     }

                     this.userRepository.Update(user, user.Id, false);

                     var response = this.Request.CreateResponse(HttpStatusCode.OK);

                     return response;
                 });

            return responseMsg;
        }
    }
}
