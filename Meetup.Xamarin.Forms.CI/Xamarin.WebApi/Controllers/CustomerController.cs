using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Xamarin.WebApi.Controllers
{
    [RoutePrefix("customer")]
    public class CustomerController : ApiController
    {
        public IHttpActionResult GetAll()
        {
            var customers = new List<string>()
            {
                "Jorge Castro",
                "Guest 1",
                "Guest 2",
                "L. Frank",
                "Robert O. Kern"
            };
            return Ok(customers);
        }
    }
}
