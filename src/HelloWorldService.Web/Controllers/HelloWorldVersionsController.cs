using EasyDesk.CleanArchitecture.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldService.Web.Controllers
{
    public class HelloWorldVersionsController : VersionsController
    {
        public HelloWorldVersionsController() : base(typeof(Startup))
        {
        }
    }
}
