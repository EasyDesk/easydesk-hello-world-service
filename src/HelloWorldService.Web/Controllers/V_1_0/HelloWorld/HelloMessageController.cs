using EasyDesk.CleanArchitecture.Web.Controllers;
using EasyDesk.Tools.Options;
using HelloWorldService.Application.Queries;
using HelloWorldService.Domain.Aggregates.HelloWorldAggregate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldService.Web.Controllers.V_1_0.HelloWorld
{
    public class HelloMessageController : AbstractMediatrController
    {
        [HttpGet(Routes.HelloWorld.GetHelloWorld)]
        public async Task<IActionResult> GetHelloWorld([FromRoute] string subject)
        {
            var query = new GetHelloWorldMessage.Query(subject.AsOption());
            return await Send(query)
                .ReturnOk()
                .MapTo<HelloMessage, HelloMessageDto>();
        }
    }
}
