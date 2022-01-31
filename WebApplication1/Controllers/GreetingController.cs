using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class GreetingController : ApiController
    {
        public string Post()
        {
            return "Hello World!";
        }
        
    /// <summary>
    /// /input a nuumber and get back a number
    /// </summary>
    /// <param name="id"></param>
    /// <returns>return "message" and the same number that was input</returns>
        public string Get(int id)
        {
            int people =(int)(id);//number of people equal id, so return id directly.
            return "Greetings to " + id + " people!";
        }

    }
}
