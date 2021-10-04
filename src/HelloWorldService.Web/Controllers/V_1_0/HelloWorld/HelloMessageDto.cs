using EasyDesk.CleanArchitecture.Application.Mapping;
using EasyDesk.Tools;
using EasyDesk.Tools.PrimitiveTypes.DateAndTime;
using HelloWorldService.Domain.Aggregates.HelloWorldAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldService.Web.Controllers.V_1_0.HelloWorld
{
    public record HelloMessageDto(
        string Message,
        Timestamp Timestamp);

    public class HelloMessageMapping : DirectMapping<HelloMessage, HelloMessageDto>
    {
        public HelloMessageMapping() : base(src => new(
            src.Message,
            src.Timestamp))
        {
        }
    }
}
