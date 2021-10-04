using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldService.Web.Controllers.V_1_0
{
    public static class Routes
    {
        public static class HelloWorld
        {
            public const string GetHelloWorld = "{subject?}";
        }
    }
}
