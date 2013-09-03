using AutoMorgue.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMorgue.Services.Models;

namespace AutoMorgue.Services.Controllers
{
    public class CategoriesController : BaseApiController
    {
        [HttpGet]
        public HttpResponseMessage All()
        {
            var responseMsg = this.ExceptionHandler(
                 () =>
                 {
                     var context = new AutoMorgueContext();

                     var categories = context.Categories;
                     var models = (
                         from c in categories
                         select new CategoryModel
                         {
                             Id = c.Id,
                             Name = c.Name
                         }).ToList();

                     var response = this.Request.CreateResponse(HttpStatusCode.OK, models);

                     return response;
                 });

            return responseMsg;
        }
    }
}
