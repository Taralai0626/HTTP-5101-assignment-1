using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Return the squared input numner
        /// </summary>
        /// <param name="id">the input number</param>
        /// <returns>the input number mutiples input numbere</returns>
        public int Get(int id)
        {
            return id * id;
        }
    }
}
