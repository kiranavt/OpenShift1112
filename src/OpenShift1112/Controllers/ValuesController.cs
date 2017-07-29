using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OpenShift1112.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [Route("Myproject")]
        [HttpPost]
        public string Post(string name)
        {
            string a = "  Bangalore,Karnataka";
            return name + a;
        }

        [Route("Addtion")]
        [HttpPost]
        public int Post(int  a,int b)
        {
            int c = a + b;
            return c;
        }
    }
}
