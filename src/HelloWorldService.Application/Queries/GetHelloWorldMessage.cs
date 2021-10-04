using EasyDesk.CleanArchitecture.Application.Mediator;
using EasyDesk.CleanArchitecture.Application.Responses;
using EasyDesk.CleanArchitecture.Domain.Time;
using EasyDesk.Tools.Options;
using HelloWorldService.Domain.Aggregates.HelloWorldAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EasyDesk.CleanArchitecture.Application.Responses.ResponseImports;

namespace HelloWorldService.Application.Queries
{
    public static class GetHelloWorldMessage
    {
        public record Query(Option<string> Subject) : QueryBase<HelloMessage>;

        public class Handler : RequestHandlerBase<Query, HelloMessage>
        {
            private readonly ITimestampProvider _timestampProvider;

            public Handler(ITimestampProvider timestampProvider)
            {
                _timestampProvider = timestampProvider;
            }

            protected override Task<Response<HelloMessage>> Handle(Query request) => Task.FromResult(Success(HelloMessage.From(Subject.From(request.Subject | "World"), _timestampProvider.Now)));
        }
    }
}
