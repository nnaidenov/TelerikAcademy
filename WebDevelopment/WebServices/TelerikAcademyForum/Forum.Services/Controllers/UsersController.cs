using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Web.Http;
using Forum.Services.Models;
using Forum.Data;
using Forum.Models;
using Forum.Services.Persisters;
using System.Web.Http.ValueProviders;
using Forum.Services.Attributes;

namespace Forum.Services.Controllers
{
    public class UsersController : BaseController
    {
        /*
           {"username": "DonchoMinkov",
           "nickname": "Doncho Minkov",
           "authCode":   "bfff2dd4f1b310eb0dbf593bd83f94dd8d34077e"}
        */
        [HttpPost]
        [ActionName("register")]
        public HttpResponseMessage RegisterUser(UserRegisterModel model)
        {
            var responseMsg = this.ExceptionHandler(
                () =>
                {
                    var context = new ForumContext();

                    using (context)
                    {
                        UserDataPersister.ValidateUsername(model.Username);
                        UserDataPersister.ValidateNickname(model.Nickname);
                        UserDataPersister.ValidateAuthCode(model.AuthCode);

                        var usernameToLower = model.Username.ToLower();
                        var nicknameToLower = model.Nickname.ToLower();

                        var user = context.Users.FirstOrDefault(
                            usr => usr.Username == usernameToLower || usr.Nickname.ToLower() == nicknameToLower);

                        if (user != null)
                        {
                            throw new InvalidOperationException("Invalid Username or Password");
                        }

                        var newUser = new User
                        {
                            Username = usernameToLower,
                            Nickname = model.Nickname,
                            AuthCode = model.AuthCode
                        };

                        context.Users.Add(newUser);
                        context.SaveChanges();

                        newUser.SessionKey = UserDataPersister.GenerateSessionKey(newUser.Id);
                        context.SaveChanges();


                        var loggedModel = new LoggedUserModel
                        {
                            Nickname = newUser.Nickname,
                            SessionKey = newUser.SessionKey
                        };

                        var response = this.Request.CreateResponse(HttpStatusCode.Created, loggedModel);
                        response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = newUser.Id }));

                        return response;
                    }
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
                    var context = new ForumContext();

                    using (context)
                    {
                        UserDataPersister.ValidateUsername(model.Username);
                        UserDataPersister.ValidateAuthCode(model.AuthCode);

                        var usernameToLower = model.Username.ToLower();

                        var user = context.Users.FirstOrDefault(
                            usr => usr.Username == usernameToLower && usr.AuthCode == model.AuthCode);

                        if (user == null)
                        {
                            throw new InvalidOperationException("Invalid Username or Password");
                        }

                        user.SessionKey = UserDataPersister.GenerateSessionKey(user.Id);
                        context.SaveChanges();

                        var loggedModel = new LoggedUserModel
                        {
                            Nickname = user.Nickname,
                            SessionKey = user.SessionKey
                        };

                        var response = this.Request.CreateResponse(HttpStatusCode.Created, loggedModel);

                        return response;
                    }
                });

            return responseMsg;
        }

        [HttpPut]
        [ActionName("logout")]
        public void LogoutUser(
             [ValueProvider(typeof(HeaderValueProviderFactory<string>))] string sessionKey)
        {
            this.ExceptionHandler(
            () =>
            {
                var context = new ForumContext();

                using (context)
                {
                    var user = context.Users.FirstOrDefault(
                        usr => usr.SessionKey == sessionKey);

                    if (user == null)
                    {
                        throw new InvalidOperationException("Invalid Username or Password");
                    }

                    user.SessionKey = null;
                    context.SaveChanges();

                    var loggedModel = new LoggedUserModel
                    {
                        Nickname = user.Nickname,
                        SessionKey = user.SessionKey
                    };

                    var response = this.Request.CreateResponse(HttpStatusCode.Created, loggedModel);

                    return response;
                }
            });
        }
    }
}