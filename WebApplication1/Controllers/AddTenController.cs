using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Returns the input number plus 10
        /// </summary>
        /// <param name="id">the input number</param>
        /// <returns>The input number with 10 added</returns>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
