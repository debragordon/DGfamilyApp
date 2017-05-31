using FamilyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DGfamilyApp.Controllers
{
    public class FamilyController : ApiController
    {
        // POST api/family
        [HttpPost]
        public void Post([FromBody]Family family)
        {

        }
        // get all
        // get one
        // update one
        // delete one
    }
}
