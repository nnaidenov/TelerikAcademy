﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Forum.Services.Controllers
{
    public class BaseController : ApiController
    {
        protected T ExceptionHandler<T>(Func<T> operation)
        {
            try
            {
                return operation();
            }
            catch (Exception ex)
            {
                var errResponse = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);

                throw new HttpResponseException(errResponse);
            }
        }
    }
}
